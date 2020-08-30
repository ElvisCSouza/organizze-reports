using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using OrganizzeReports.MVC.Core.Notificacoes;
using System.Linq;

namespace OrganizzeReports.MVC.Controllers
{
    [Authorize]
    public class MainController : Controller
    {
        private readonly INotificador _notificador;
        protected MainController(INotificador notificador)
        {
            _notificador = notificador;
        }

        protected bool OperacaoValida()
        {
            return !_notificador.TemNotificacao();
        }

        protected IActionResult CustomResponse(object result = null)
        {
            if (OperacaoValida())
            {
                return Ok(result);
            }

            return BadRequest(new
            {
                erros = _notificador.ObterNotificacoes(),
                result
            });
        }

        protected void NotificarErro(string chave, string mensagem)
        {
            _notificador.Handle(new Notificacao(chave, mensagem));
        }

        protected IActionResult CustomResponse(ModelStateDictionary modelState, object result = null)
        {
            if (!modelState.IsValid) NotificarErroModelInvalida(modelState);
            return CustomResponse(result);
        }

        protected void NotificarErroModelInvalida(ModelStateDictionary modelState)
        {
            foreach (var erro in modelState)
            {
                erro.Value.Errors
                        .ToList()
                        .ForEach(x => NotificarErro(erro.Key, x.ErrorMessage ?? x.Exception.Message));
            }
        }
    }
}

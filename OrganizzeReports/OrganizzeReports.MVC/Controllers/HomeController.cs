using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OrganizzeReports.MVC.Integration;
using OrganizzeReports.MVC.Integration.Dtos;
using OrganizzeReports.MVC.Services;
using OrganizzeReports.MVC.ViewModels.Home;

namespace OrganizzeReports.MVC.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly IOrganizzeApi _organizzeApi;
        private readonly IUser _user;

        public HomeController(
            IOrganizzeApi organizzeApi,
            IUser user)
        {
            _organizzeApi = organizzeApi;
            _user = user;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Categorias()
        {
            var viewModel = await ObterCategoriaViewModel();
            return PartialView("_Categorias", viewModel);
        }

        public async Task<IActionResult> ComparativoMeses()
        {
            var viewModel = await ObterTransacoesViewModel();
            return PartialView("_ComparativoMeses", viewModel);
        }

        #region Métodos privados
        #region Comparativo entre meses
        private async Task<ComparativoMesesViewModel> ObterTransacoesViewModel()
        {
            var viewModel = new ComparativoMesesViewModel();
            var transacoesViewModel = await MontarListaTransacaoNoDiaViewModel(DateTime.Now);
            viewModel.TransacoesPorMes.Add(DateTime.Now.Date, transacoesViewModel);
            transacoesViewModel = await MontarListaTransacaoNoDiaViewModel(DateTime.Now.AddMonths(-1));
            viewModel.TransacoesPorMes.Add(DateTime.Now.AddMonths(-1).Date, transacoesViewModel);

            return viewModel;
        }
        private async Task<List<Transaction>> ObterTransacoesDeDebitoOrganizze(DateTime dtInicio, DateTime dtFim)
        {
            var transacoes = await _organizzeApi.Transacoes(dtInicio.ToString("yyyy-MM-dd"), dtFim.ToString("yyyy-MM-dd"));
            return transacoes.Where(TransacaoEhDebito).ToList();
        }
        private async Task<List<TransacaoNoDiaViewModel>> MontarListaTransacaoNoDiaViewModel(DateTime dataBusca)
        {
            var transacoes = await ObterTransacoesDeDebitoOrganizze(
               ObterPrimeiroDiaMes(dataBusca),
               ObterUltimoDiaMes(dataBusca));
            var transacoesViewModel = new List<TransacaoNoDiaViewModel>();
            for (int i = 1; i <= 31 && i <= transacoes.Max(x => x.created_at.Day); i++)
            {
                transacoesViewModel.Add(new TransacaoNoDiaViewModel()
                {
                    DiaDoMes = i,
                    ValorTotal = (transacoes
                                    .Where(x => x.created_at.Day == i)
                                    .Sum(x => x.amount_cents * -1)) / 100
                });
            }
            return transacoesViewModel;
        }
        private DateTime ObterPrimeiroDiaMes(DateTime dataMes)
        {
            return new DateTime(dataMes.Year, dataMes.Month, 1);
        }
        private DateTime ObterUltimoDiaMes(DateTime dataMes)
        {
            return new DateTime(dataMes.Year, dataMes.Month, DateTime.DaysInMonth(dataMes.Year, dataMes.Month));
        }
        private Func<Transaction, bool> TransacaoEhDebito = x => x.amount_cents < 0 &&
                                                                 x.oposite_account_id == null &&
                                                                 x.paid_credit_card_id == null;
        #endregion
        #region Categorias
        private async Task<List<CategoriaViewModel>> ObterCategoriaViewModel()
        {
            var categorias = await _organizzeApi.Categorias();
            var viewModel = new List<CategoriaViewModel>();
            foreach (var parent_id in categorias
                                        .Where(x => x.parent_id.HasValue)
                                        .GroupBy(x => x.parent_id)
                                        .Select(x => x.Key.Value))
            {
                var categoriaPai = categorias.First(x => x.id == parent_id);
                var itemViewModel =new CategoriaViewModel()
                {
                    CategoriaPai = new CategoriaItemViewModel()
                    {
                        Id = parent_id,
                        Nome = categoriaPai.name,
                        Cor = categoriaPai.color
                    },
                };
                foreach(var categoria in categorias.Where(x => x.parent_id == parent_id))
                {
                    itemViewModel.Categorias.Add(new CategoriaItemViewModel()
                    {
                        Id = categoria.id,
                        Nome = categoria.name
                    });
                }
                viewModel.Add(itemViewModel);
            }

            return viewModel;
        }
        #endregion
        #endregion
    }
}

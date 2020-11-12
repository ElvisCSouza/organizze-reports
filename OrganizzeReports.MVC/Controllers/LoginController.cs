using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OrganizzeReports.MVC.Core.Notificacoes;
using OrganizzeReports.MVC.Integration;
using OrganizzeReports.MVC.Models;
using OrganizzeReports.MVC.Statics;

namespace OrganizzeReports.MVC.Controllers
{
    [AllowAnonymous]
    public class LoginController : MainController
    {
        private readonly IOrganizzeApi _organizzeApi;

        public LoginController(
            IOrganizzeApi organizzeApi,
            INotificador notificador) : base(notificador)
        {
            _organizzeApi = organizzeApi;
        }

        [Route("login")]
        public IActionResult Index(string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            return View();
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login(UsuarioLogin usuarioLogin, string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            if (!ModelState.IsValid) return CustomResponse(ModelState);

            var resposta = await Autenticar(usuarioLogin);
            if (!resposta)
            {
                NotificarErro("", "Falha na autenticação com o Organizze");
                return CustomResponse();
            }

            await RealizarLogin(usuarioLogin);

            if (string.IsNullOrEmpty(returnUrl)) return CustomResponse(Url.Action("Index", "Home"));

            return CustomResponse(new {
                url = Url.Action("Index", "Home")
            });
        }

        private async Task<bool> Autenticar(UsuarioLogin usuarioLogin)
        {
            try
            {
                var auth = GerarAuthenticationHeader(usuarioLogin);
                var categorias = await _organizzeApi.Categorias(auth);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        private async Task RealizarLogin(UsuarioLogin usuarioLogin)
        {
            var auth = GerarAuthenticationHeader(usuarioLogin);

            var claims = new List<Claim>
            {
                new Claim(ClaimsTypes.ORGANIZZE_AUTH_HEADER, auth),
                new Claim(ClaimsTypes.EMAIL, usuarioLogin.Email)
            };

            var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

            var authProperties = new AuthenticationProperties
            {
                ExpiresUtc = DateTimeOffset.UtcNow.AddMinutes(60),
                IsPersistent = true
            };

            await HttpContext.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme,
                new ClaimsPrincipal(claimsIdentity),
                authProperties);

            //await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
        }
        private string GerarAuthenticationHeader(UsuarioLogin usuarioLogin)
        {
            return "Basic " + Convert.ToBase64String(
                Encoding.ASCII.GetBytes($"{usuarioLogin.Email}:{usuarioLogin.ApiKey}")); ;
        }

    }
}

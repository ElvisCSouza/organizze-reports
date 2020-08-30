using Microsoft.AspNetCore.Http;
using OrganizzeReports.MVC.Statics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace OrganizzeReports.MVC.Services
{
    public interface IUser
    {
        string ObterEmail();

        string ObterAuthHeader();

        bool EstaAutenticado();
    }

    public class OrganizzeUser : IUser
    {
        private readonly IHttpContextAccessor _accessor;

        public OrganizzeUser(IHttpContextAccessor accessor)
        {
            _accessor = accessor;
        }

        public bool EstaAutenticado()
        {
            return _accessor.HttpContext.User.Identity.IsAuthenticated;
        }

        public string ObterAuthHeader()
        {
            return _accessor.HttpContext.User.Claims.First(x => x.Type == ClaimsTypes.ORGANIZZE_AUTH_HEADER).Value;
        }

            public string ObterEmail()
            {
                return _accessor.HttpContext.User.Claims.First(x => x.Type == ClaimsTypes.EMAIL).Value;
            }
    }
}

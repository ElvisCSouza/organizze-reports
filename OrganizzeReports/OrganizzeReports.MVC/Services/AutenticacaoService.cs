using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrganizzeReports.MVC.Services
{
    public interface IAutenticacaoService
    {
        bool EstaAutenticado();
    }
    public class AutenticacaoService : IAutenticacaoService
    {
        public bool EstaAutenticado()
        {
            return false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OrganizzeReports.MVC.Models
{
    public class UsuarioLogin
    {
        [Required(ErrorMessage = "Informe o e-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Informe a API Key")]
        public string ApiKey { get; set; }
    }
}

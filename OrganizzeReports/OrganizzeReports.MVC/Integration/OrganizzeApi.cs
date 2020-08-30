using OrganizzeReports.MVC.Integration.Dtos;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrganizzeReports.MVC.Integration
{
    public interface IOrganizzeApi
    {
        [Get("/accounts")]
        public Task<List<Account>> ContasBancarias();
        [Get("/categories")]
        public Task<List<Category>> Categorias([Header("Authorization")] string authorization = null);
        [Get("/transactions")]
        public Task<List<Transaction>> Transacoes();
        [Get("/transactions?start_date={data_inicial}&end_date={data_final}")]
        public Task<List<Transaction>> Transacoes([Query]string data_inicial, [Query]string data_final);
    }
}

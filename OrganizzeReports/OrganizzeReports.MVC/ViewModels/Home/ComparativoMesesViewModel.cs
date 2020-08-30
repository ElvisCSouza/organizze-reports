using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrganizzeReports.MVC.ViewModels.Home
{
    public class ComparativoMesesViewModel
    {
        public Dictionary<DateTime, List<TransacaoNoDiaViewModel>> TransacoesPorMes { get; set; } = new Dictionary<DateTime, List<TransacaoNoDiaViewModel>>();
    }

    public class TransacaoNoDiaViewModel
    {
        public int DiaDoMes { get; set; }
        public decimal ValorTotal { get; set; }
    }
}

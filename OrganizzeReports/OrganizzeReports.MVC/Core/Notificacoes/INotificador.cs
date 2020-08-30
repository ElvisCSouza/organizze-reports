using System;
using System.Collections.Generic;
using System.Text;

namespace OrganizzeReports.MVC.Core.Notificacoes
{
    public interface INotificador
    {
        bool TemNotificacao();
        List<Notificacao> ObterNotificacoes();
        void Handle(Notificacao notificacao);
    }
}

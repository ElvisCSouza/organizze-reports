using OrganizzeReports.MVC.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace OrganizzeReports.MVC.Integration
{
    public class OrganizzeAuthHttpClientDelegatingHandler : DelegatingHandler
    {
        private readonly IUser _user;
        public OrganizzeAuthHttpClientDelegatingHandler(
            IUser user)
        {
            _user = user;
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            if(!request.Headers.Any(h => h.Key.Equals("Authorization")))
                request.Headers.Add("Authorization", _user.ObterAuthHeader());
            return await base.SendAsync(request, cancellationToken);
        }
    }
}

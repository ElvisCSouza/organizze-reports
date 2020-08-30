﻿// <auto-generated />
using System;
using System.Net.Http;
using System.Collections.Generic;
using OrganizzeReports.BlazorWebAssembly.RefitInternalGenerated;

/* ******** Hey You! *********
 *
 * This is a generated file, and gets rewritten every time you build the
 * project. If you want to edit it, you need to edit the mustache template
 * in the Refit package */

#pragma warning disable
namespace OrganizzeReports.BlazorWebAssembly.RefitInternalGenerated
{
    [global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    [AttributeUsage (AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Delegate)]
    sealed class PreserveAttribute : Attribute
    {

        //
        // Fields
        //
        public bool AllMembers;

        public bool Conditional;
    }
}
#pragma warning restore

#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
#pragma warning disable CS8669 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context. Auto-generated code requires an explicit '#nullable' directive in source.
namespace OrganizzeReports.BlazorWebAssembly.Integration
{
    using global::OrganizzeReports.Integration.Dtos;
    using global::Refit;
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;

    /// <inheritdoc />
    [global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    [global::System.Diagnostics.DebuggerNonUserCode]
    [Preserve]
    [global::System.Reflection.Obfuscation(Exclude=true)]
    partial class AutoGeneratedIOrganizzeApi : IOrganizzeApi
    {
        /// <inheritdoc />
        public HttpClient Client { get; protected set; }
        readonly IRequestBuilder requestBuilder;

        /// <inheritdoc />
        public AutoGeneratedIOrganizzeApi(HttpClient client, IRequestBuilder requestBuilder)
        {
            Client = client;
            this.requestBuilder = requestBuilder;
        }

        /// <inheritdoc />
        Task<List<Account>> IOrganizzeApi.ContasBancarias()
        {
            var arguments = new object[] {  };
            var func = requestBuilder.BuildRestResultFuncForMethod("ContasBancarias", new Type[] {  });
            return (Task<List<Account>>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<List<Category>> IOrganizzeApi.Categorias()
        {
            var arguments = new object[] {  };
            var func = requestBuilder.BuildRestResultFuncForMethod("Categorias", new Type[] {  });
            return (Task<List<Category>>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<List<Transaction>> IOrganizzeApi.Transacoes()
        {
            var arguments = new object[] {  };
            var func = requestBuilder.BuildRestResultFuncForMethod("Transacoes", new Type[] {  });
            return (Task<List<Transaction>>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<List<Transaction>> IOrganizzeApi.Transacoes(string data_inicial, string data_final)
        {
            var arguments = new object[] { data_inicial, data_final };
            var func = requestBuilder.BuildRestResultFuncForMethod("Transacoes", new Type[] { typeof(string), typeof(string) });
            return (Task<List<Transaction>>)func(Client, arguments);
        }
    }
}

#pragma warning restore CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
#pragma warning restore CS8669 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context. Auto-generated code requires an explicit '#nullable' directive in source.
#pragma checksum "C:\Projetos\OrganizzeReports\OrganizzeReports\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3da58d115aad7f79ede69dc9121445a504b878fa"
// <auto-generated/>
#pragma warning disable 1591
namespace OrganizzeReports.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Projetos\OrganizzeReports\OrganizzeReports\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Projetos\OrganizzeReports\OrganizzeReports\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Projetos\OrganizzeReports\OrganizzeReports\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Projetos\OrganizzeReports\OrganizzeReports\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Projetos\OrganizzeReports\OrganizzeReports\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Projetos\OrganizzeReports\OrganizzeReports\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Projetos\OrganizzeReports\OrganizzeReports\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Projetos\OrganizzeReports\OrganizzeReports\_Imports.razor"
using OrganizzeReports;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Projetos\OrganizzeReports\OrganizzeReports\_Imports.razor"
using OrganizzeReports.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Projetos\OrganizzeReports\OrganizzeReports\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Projetos\OrganizzeReports\OrganizzeReports\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Projetos\OrganizzeReports\OrganizzeReports\Pages\Index.razor"
using OrganizzeReports.Integration.Dtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Projetos\OrganizzeReports\OrganizzeReports\Pages\Index.razor"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col-md-6");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.AddMarkupContent(6, "<h3>Remover categorias</h3>\r\n        ");
            __builder.OpenComponent<Radzen.Blazor.RadzenCard>(7);
            __builder.AddAttribute(8, "style", "overflow: auto;height:500px;");
            __builder.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(10, "\r\n");
#nullable restore
#line 13 "C:\Projetos\OrganizzeReports\OrganizzeReports\Pages\Index.razor"
             foreach (var categoria in Categorias.OrderBy(x => x.NomeCategoriaPai).ThenBy(x => x.NomeCategoria))
            {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(11, "                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenCheckBox<bool>>(12);
                __builder2.AddAttribute(13, "Change", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<bool>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<bool>(this, 
#nullable restore
#line 15 "C:\Projetos\OrganizzeReports\OrganizzeReports\Pages\Index.razor"
                                          args => RemoverCategoria(args, categoria.Id)

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(14, "Style", "margin-bottom: 20px");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\r\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(16);
                __builder2.AddAttribute(17, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 16 "C:\Projetos\OrganizzeReports\OrganizzeReports\Pages\Index.razor"
                                     categoria.NomeCategoriaPai + " -> " +  categoria.NomeCategoria

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "Style", "margin-left: 5px;margin-bottom: 20px;");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\r\n                <br>\r\n");
#nullable restore
#line 18 "C:\Projetos\OrganizzeReports\OrganizzeReports\Pages\Index.razor"
            }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(20, "        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(21, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n    ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "col-md-6");
            __builder.AddMarkupContent(25, "\r\n        ");
            __builder.AddMarkupContent(26, "<h3>Remover contas</h3>\r\n        ");
            __builder.OpenComponent<Radzen.Blazor.RadzenCard>(27);
            __builder.AddAttribute(28, "style", "overflow: auto;height:500px;");
            __builder.AddAttribute(29, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(30, "\r\n");
#nullable restore
#line 24 "C:\Projetos\OrganizzeReports\OrganizzeReports\Pages\Index.razor"
             foreach (var categoria in organizzeApi.ContasBancarias(AuthorizationHeader).Result.OrderBy(x => x.name))
            {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(31, "                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenCheckBox<bool>>(32);
                __builder2.AddAttribute(33, "Change", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<bool>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<bool>(this, 
#nullable restore
#line 26 "C:\Projetos\OrganizzeReports\OrganizzeReports\Pages\Index.razor"
                                          args => RemoverContas(args, categoria.id)

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(34, "Style", "margin-bottom: 20px");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(35, "\r\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenLabel>(36);
                __builder2.AddAttribute(37, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 27 "C:\Projetos\OrganizzeReports\OrganizzeReports\Pages\Index.razor"
                                    categoria.name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(38, "Style", "margin-left: 5px;margin-bottom: 20px");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(39, "\r\n                <br>\r\n");
#nullable restore
#line 29 "C:\Projetos\OrganizzeReports\OrganizzeReports\Pages\Index.razor"
            }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(40, "        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(41, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n\r\n\r\n");
            __builder.AddMarkupContent(44, "<h1>Gastos nos últimos 3 meses</h1>\r\n");
            __builder.OpenElement(45, "div");
            __builder.AddAttribute(46, "class", "row");
            __builder.AddMarkupContent(47, "\r\n    ");
            __builder.OpenElement(48, "div");
            __builder.AddAttribute(49, "class", "col-md-12 col-sm-12 p-4");
            __builder.AddMarkupContent(50, "\r\n        ");
            __builder.OpenComponent<Radzen.Blazor.RadzenChart>(51);
            __builder.AddAttribute(52, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(53, "\r\n            ");
                __Blazor.OrganizzeReports.Pages.Index.TypeInference.CreateRadzenLineSeries_0(__builder2, 54, 55, 
#nullable restore
#line 39 "C:\Projetos\OrganizzeReports\OrganizzeReports\Pages\Index.razor"
                                      false

#line default
#line hidden
#nullable disable
                , 56, 
#nullable restore
#line 39 "C:\Projetos\OrganizzeReports\OrganizzeReports\Pages\Index.razor"
                                                    debitosMesCorrente

#line default
#line hidden
#nullable disable
                , 57, "Dia", 58, "Mês atual", 59, 
#nullable restore
#line 39 "C:\Projetos\OrganizzeReports\OrganizzeReports\Pages\Index.razor"
                                                                                                                           LineType.Dashed

#line default
#line hidden
#nullable disable
                , 60, "DebitoAcumulado", 61, (__builder3) => {
                    __builder3.AddMarkupContent(62, "\r\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenMarkers>(63);
                    __builder3.AddAttribute(64, "MarkerType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.Blazor.MarkerType>(
#nullable restore
#line 40 "C:\Projetos\OrganizzeReports\OrganizzeReports\Pages\Index.razor"
                                           MarkerType.Square

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(65, "\r\n            ");
                }
                );
                __builder2.AddMarkupContent(66, "\r\n            ");
                __Blazor.OrganizzeReports.Pages.Index.TypeInference.CreateRadzenLineSeries_1(__builder2, 67, 68, 
#nullable restore
#line 42 "C:\Projetos\OrganizzeReports\OrganizzeReports\Pages\Index.razor"
                                      false

#line default
#line hidden
#nullable disable
                , 69, 
#nullable restore
#line 42 "C:\Projetos\OrganizzeReports\OrganizzeReports\Pages\Index.razor"
                                                    debitosMesAnterior

#line default
#line hidden
#nullable disable
                , 70, "Dia", 71, "Mês passado", 72, "DebitoAcumulado", 73, (__builder3) => {
                    __builder3.AddMarkupContent(74, "\r\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenMarkers>(75);
                    __builder3.AddAttribute(76, "MarkerType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.Blazor.MarkerType>(
#nullable restore
#line 43 "C:\Projetos\OrganizzeReports\OrganizzeReports\Pages\Index.razor"
                                           MarkerType.Circle

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(77, "\r\n            ");
                }
                );
                __builder2.AddMarkupContent(78, "\r\n            ");
                __Blazor.OrganizzeReports.Pages.Index.TypeInference.CreateRadzenLineSeries_2(__builder2, 79, 80, 
#nullable restore
#line 45 "C:\Projetos\OrganizzeReports\OrganizzeReports\Pages\Index.razor"
                                      false

#line default
#line hidden
#nullable disable
                , 81, 
#nullable restore
#line 45 "C:\Projetos\OrganizzeReports\OrganizzeReports\Pages\Index.razor"
                                                    debitos2MesesAtras

#line default
#line hidden
#nullable disable
                , 82, "Dia", 83, "2 meses anterior", 84, "DebitoAcumulado", 85, (__builder3) => {
                    __builder3.AddMarkupContent(86, "\r\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenMarkers>(87);
                    __builder3.AddAttribute(88, "MarkerType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.Blazor.MarkerType>(
#nullable restore
#line 46 "C:\Projetos\OrganizzeReports\OrganizzeReports\Pages\Index.razor"
                                           MarkerType.Circle

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(89, "\r\n            ");
                }
                );
                __builder2.AddMarkupContent(90, "\r\n            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenCategoryAxis>(91);
                __builder2.AddAttribute(92, "Padding", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 48 "C:\Projetos\OrganizzeReports\OrganizzeReports\Pages\Index.razor"
                                         20

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(93, "\r\n            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenValueAxis>(94);
                __builder2.AddAttribute(95, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(96, "\r\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridLines>(97);
                    __builder3.AddAttribute(98, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 50 "C:\Projetos\OrganizzeReports\OrganizzeReports\Pages\Index.razor"
                                          true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(99, "\r\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenAxisTitle>(100);
                    __builder3.AddAttribute(101, "Text", "Total de Débito");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(102, "\r\n            ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(103, "\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(104, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(105, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 57 "C:\Projetos\OrganizzeReports\OrganizzeReports\Pages\Index.razor"
       

    string AuthorizationHeader;

    List<int> CategoriasRemovidas;
    List<int> ContasRemovidas;
    List<DataItem> debitosMesCorrente;
    List<DataItem> debitosMesAnterior;
    List<DataItem> debitos2MesesAtras;
    List<Categoria> Categorias;

    List<Transaction> transacoesMesCorrente;
    List<Transaction> transacoesMesAnterior;
    List<Transaction> transacoes2mesesAtras;
    class DataItem
    {
        public int Dia { get; set; }
        public decimal DebitoAcumulado { get; set; }
    }
    class Categoria
    {
        public int Id { get; set; }
        public string NomeCategoriaPai { get; set; }
        public string NomeCategoria { get; set; }
        public string Cor { get; set; }
    }

    void CarregarCategoria()
    {
        Categorias = new List<Categoria>();
        var categoriasResult = organizzeApi.Categorias(AuthorizationHeader).Result;

        foreach (var categoriaResult in categoriasResult.Where(x => x.parent_id.GetValueOrDefault() > 0))
        {
            Categorias.Add(new Categoria()
            {
                Cor = "#" + categoriaResult.color,
                Id = categoriaResult.id,
                NomeCategoria = categoriaResult.name,
                NomeCategoriaPai = categoriasResult.First(x => x.id == categoriaResult.parent_id.Value).name
            }); ;

        }
    }

    void RemoverCategoria(bool remover, int categoria_id)
    {
        if (!remover)
            CategoriasRemovidas.Remove(categoria_id);
        else
            CategoriasRemovidas.Add(categoria_id);

        CarregarGrafico();
    }

    void RemoverContas(bool remover, int categoria_id)
    {
        if (!remover)
            ContasRemovidas.Remove(categoria_id);
        else
            ContasRemovidas.Add(categoria_id);

        CarregarGrafico();
    }

    void CarregarGrafico()
    {
        debitosMesCorrente = new List<DataItem>();
        debitosMesAnterior = new List<DataItem>();
        debitos2MesesAtras = new List<DataItem>();

        for (int i = 1; i <= 31 && i <= DateTime.Now.Day; i++)
        {
            debitosMesCorrente.Add(new DataItem()
            {
                Dia = i,
                DebitoAcumulado = (decimal)((transacoesMesCorrente
                                                .Where(x => x.amount_cents < 0
                                                         && x.created_at.Day <= i
                                                         && x.oposite_account_id == null
                                                         && x.paid_credit_card_id == null
                                                         && !CategoriasRemovidas.Any(c => c == x.category_id)
                                                         && !ContasRemovidas.Any(c => c == x.account_id)
                                                         && !x.tags.Any(t => t.name == "Reforma 2020")
                                                         )

                                                .Sum(x => x.amount_cents) * -1)
                                                / 100)
            });
        }

        for (int i = 1; i <= 31; i++)
        {
            debitosMesAnterior.Add(new DataItem()
            {
                Dia = i,
                DebitoAcumulado = (decimal)((transacoesMesAnterior
                                                .Where(x => x.amount_cents < 0
                                                         && x.created_at.Day <= i
                                                         && !CategoriasRemovidas.Any(c => c == x.category_id)
                                                         && !ContasRemovidas.Any(c => c == x.account_id)
                                                         && x.oposite_account_id == null
                                                         && x.paid_credit_card_id == null)
                                                .Sum(x => x.amount_cents) * -1)
                                                / 100)
            });

            debitos2MesesAtras.Add(new DataItem()
            {
                Dia = i,
                DebitoAcumulado = (decimal)((transacoes2mesesAtras
                                                .Where(x => x.amount_cents < 0
                                                         && x.created_at.Day <= i
                                                         && !CategoriasRemovidas.Any(c => c == x.category_id)
                                                         && !ContasRemovidas.Any(c => c == x.account_id)
                                                         && x.oposite_account_id == null
                                                         && x.paid_credit_card_id == null)
                                                .Sum(x => x.amount_cents) * -1)
                                                / 100)
            });
        }
    }

    protected override void OnInitialized()
    {
        AuthorizationHeader = ObterAuthorizationHeader();

        CategoriasRemovidas = new List<int>();
        ContasRemovidas = new List<int>();

        transacoesMesCorrente = organizzeApi.Transacoes(AuthorizationHeader).Result;

        var anoMesPassado = DateTime.Now.AddMonths(-1).Year;
        var mesMesPassado = DateTime.Now.AddMonths(-1).Month;
        transacoesMesAnterior = organizzeApi.Transacoes(
            AuthorizationHeader,
            new DateTime(anoMesPassado, mesMesPassado, 1).ToString("yyyy-MM-dd"),
            new DateTime(anoMesPassado, mesMesPassado, DateTime.DaysInMonth(anoMesPassado, mesMesPassado)).ToString("yyyy-MM-dd")
                                ).Result;

        var ano2MesesAtras = DateTime.Now.AddMonths(-2).Year;
        var mes2MesesAtras = DateTime.Now.AddMonths(-2).Month;
        transacoes2mesesAtras = organizzeApi.Transacoes(
            AuthorizationHeader,
        new DateTime(ano2MesesAtras, mes2MesesAtras, 1).ToString("yyyy-MM-dd"),
        new DateTime(ano2MesesAtras, mes2MesesAtras, DateTime.DaysInMonth(ano2MesesAtras, mes2MesesAtras)).ToString("yyyy-MM-dd")
                            ).Result;

        CarregarCategoria();
        CarregarGrafico();
    }

    string ObterAuthorizationHeader()
    {
        if (!hca.HttpContext.Request.Cookies.ContainsKey("organizze-auth"))
            NavigationManager.NavigateTo("Login", false);
        return "";
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private OrganizzeReports.Integration.IOrganizzeApi organizzeApi { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpContextAccessor hca { get; set; }
    }
}
namespace __Blazor.OrganizzeReports.Pages.Index
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateRadzenLineSeries_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Boolean __arg0, int __seq1, global::System.Collections.Generic.IEnumerable<TItem> __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.String __arg3, int __seq4, global::Radzen.Blazor.LineType __arg4, int __seq5, global::System.String __arg5, int __seq6, global::Microsoft.AspNetCore.Components.RenderFragment __arg6)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenLineSeries<TItem>>(seq);
        __builder.AddAttribute(__seq0, "Smooth", __arg0);
        __builder.AddAttribute(__seq1, "Data", __arg1);
        __builder.AddAttribute(__seq2, "CategoryProperty", __arg2);
        __builder.AddAttribute(__seq3, "Title", __arg3);
        __builder.AddAttribute(__seq4, "LineType", __arg4);
        __builder.AddAttribute(__seq5, "ValueProperty", __arg5);
        __builder.AddAttribute(__seq6, "ChildContent", __arg6);
        __builder.CloseComponent();
        }
        public static void CreateRadzenLineSeries_1<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Boolean __arg0, int __seq1, global::System.Collections.Generic.IEnumerable<TItem> __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.String __arg3, int __seq4, global::System.String __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenLineSeries<TItem>>(seq);
        __builder.AddAttribute(__seq0, "Smooth", __arg0);
        __builder.AddAttribute(__seq1, "Data", __arg1);
        __builder.AddAttribute(__seq2, "CategoryProperty", __arg2);
        __builder.AddAttribute(__seq3, "Title", __arg3);
        __builder.AddAttribute(__seq4, "ValueProperty", __arg4);
        __builder.AddAttribute(__seq5, "ChildContent", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateRadzenLineSeries_2<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Boolean __arg0, int __seq1, global::System.Collections.Generic.IEnumerable<TItem> __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.String __arg3, int __seq4, global::System.String __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenLineSeries<TItem>>(seq);
        __builder.AddAttribute(__seq0, "Smooth", __arg0);
        __builder.AddAttribute(__seq1, "Data", __arg1);
        __builder.AddAttribute(__seq2, "CategoryProperty", __arg2);
        __builder.AddAttribute(__seq3, "Title", __arg3);
        __builder.AddAttribute(__seq4, "ValueProperty", __arg4);
        __builder.AddAttribute(__seq5, "ChildContent", __arg5);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591

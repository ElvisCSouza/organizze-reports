#pragma checksum "C:\Projetos\OrganizzeReports\OrganizzeReports.MVC\Views\Home\_ComparativoMeses.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b7543868fb669a02edf6031b17282bfabe13b085"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__ComparativoMeses), @"mvc.1.0.view", @"/Views/Home/_ComparativoMeses.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Projetos\OrganizzeReports\OrganizzeReports.MVC\Views\_ViewImports.cshtml"
using OrganizzeReports.MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Projetos\OrganizzeReports\OrganizzeReports.MVC\Views\_ViewImports.cshtml"
using OrganizzeReports.MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7543868fb669a02edf6031b17282bfabe13b085", @"/Views/Home/_ComparativoMeses.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60594ded4d12fb0039f756ef507710efc6e64dda", @"/Views/_ViewImports.cshtml")]
    public class Views_Home__ComparativoMeses : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OrganizzeReports.MVC.ViewModels.Home.ComparativoMesesViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div id=\"grafico-comparativo-meses\"></div>\r\n\r\n<script>\r\n    var series = [];\r\n</script>\r\n\r\n");
#nullable restore
#line 8 "C:\Projetos\OrganizzeReports\OrganizzeReports.MVC\Views\Home\_ComparativoMeses.cshtml"
 foreach (var mes in Model.TransacoesPorMes)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <script>\r\n        var soma = 0;\r\n        series.push({\r\n            name: \'");
#nullable restore
#line 13 "C:\Projetos\OrganizzeReports\OrganizzeReports.MVC\Views\Home\_ComparativoMeses.cshtml"
              Write(mes.Key.ToString("MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\',\r\n            data: []\r\n        });\r\n    </script>\r\n");
#nullable restore
#line 17 "C:\Projetos\OrganizzeReports\OrganizzeReports.MVC\Views\Home\_ComparativoMeses.cshtml"
     for (int i = 1; i <= 31; i++)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Projetos\OrganizzeReports\OrganizzeReports.MVC\Views\Home\_ComparativoMeses.cshtml"
         if (i <= mes.Value.Count)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <script>\r\n                soma += ");
#nullable restore
#line 22 "C:\Projetos\OrganizzeReports\OrganizzeReports.MVC\Views\Home\_ComparativoMeses.cshtml"
                    Write(mes.Value.First(x => x.DiaDoMes == i).ValorTotal);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n                series.filter(function (value) { return value.name == \'");
#nullable restore
#line 23 "C:\Projetos\OrganizzeReports\OrganizzeReports.MVC\Views\Home\_ComparativoMeses.cshtml"
                                                                  Write(mes.Key.ToString("MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\'; })[0].data.push(soma);\r\n            </script>\r\n");
#nullable restore
#line 25 "C:\Projetos\OrganizzeReports\OrganizzeReports.MVC\Views\Home\_ComparativoMeses.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <script>\r\n                series.filter(function (value) { return value.name == \'");
#nullable restore
#line 29 "C:\Projetos\OrganizzeReports\OrganizzeReports.MVC\Views\Home\_ComparativoMeses.cshtml"
                                                                  Write(mes.Key.ToString("MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\'; })[0].data.push(null);\r\n            </script>\r\n");
#nullable restore
#line 31 "C:\Projetos\OrganizzeReports\OrganizzeReports.MVC\Views\Home\_ComparativoMeses.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Projetos\OrganizzeReports\OrganizzeReports.MVC\Views\Home\_ComparativoMeses.cshtml"
         
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Projetos\OrganizzeReports\OrganizzeReports.MVC\Views\Home\_ComparativoMeses.cshtml"
     
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<script>

    $(document).ready(function () {

        $(""#loader-comparativo-mes"").hide();

        var options = {
            chart: {
                height: 300,
                type: 'area',
                zoom: {
                    enabled: false
                },
                dropShadow: {
                    enabled: true,
                    opacity: 0.2,
                },
                toolbar: {
                    show: false
                },
                events: {
                    mounted: function (ctx, config) {
                        const highest1 = ctx.getHighestValueInSeries(0);
                        const highest2 = ctx.getHighestValueInSeries(1);
                        ctx.addPointAnnotation({
                            x: new Date(ctx.w.globals.seriesX[0][ctx.w.globals.series[0].indexOf(highest1)]).getTime(),
                            y: highest1,
                            label: {
                                style: {
        ");
            WriteLiteral(@"                            cssClass: 'd-none'
                                }
                            },
                            customSVG: {
                                SVG: '<svg xmlns=""http://www.w3.org/2000/svg"" width=""15"" height=""15"" viewBox=""0 0 24 24"" fill=""#661fd6"" stroke=""#fff"" stroke-width=""3"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""feather feather-circle""><circle cx=""12"" cy=""12"" r=""10""></circle></svg>',
                                cssClass: undefined,
                                offsetX: -8,
                                offsetY: 5
                            }
                        })
                        ctx.addPointAnnotation({
                            x: new Date(ctx.w.globals.seriesX[1][ctx.w.globals.series[1].indexOf(highest2)]).getTime(),
                            y: highest2,
                            label: {
                                style: {
                                    cssClass: 'd-none'
                    ");
            WriteLiteral(@"            }
                            },
                            customSVG: {
                                SVG: '<svg xmlns=""http://www.w3.org/2000/svg"" width=""15"" height=""15"" viewBox=""0 0 24 24"" fill=""#f7b731"" stroke=""#fff"" stroke-width=""3"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""feather feather-circle""><circle cx=""12"" cy=""12"" r=""10""></circle></svg>',
                                cssClass: undefined,
                                offsetX: -8,
                                offsetY: 5
                            }
                        })
                    },
                }
            },
            colors: ['#525ce5', '#fd5261'],
            dataLabels: {
                enabled: false
            },
            stroke: {
                show: true,
                curve: 'smooth',
                width: 2,
                lineCap: 'square'
            },
            series: series,
            labels: [
                '01', '02', '03', '04', '0");
            WriteLiteral(@"5', '06', '07', '08',
                '09', '10', '11', '12', '13', '14', '15', '16',
                '17', '18', '19', '20', '21', '22', '23', '24',
                '25', '26', '27', '28', '29', '30', '31'
            ],
            xaxis: {
                axisBorder: {
                    show: false
                },
                axisTicks: {
                    show: false
                },
                crosshairs: {
                    show: true
                },
                labels: {
                    offsetX: 0,
                    offsetY: 5,
                }
            },
            yaxis: {
                labels: {
                    offsetX: -2,
                    offsetY: 0,
                }
            },
            grid: {
                borderColor: 'rgba(112, 131, 171, .1)',
                xaxis: {
                    lines: {
                        show: true
                    }
                },
                yaxis: {
       ");
            WriteLiteral(@"             lines: {
                        show: false,
                    }
                },
                padding: {
                    top: 0,
                    right: 0,
                    bottom: 0,
                    left: 0
                },
            },
            legend: {
                position: 'top',
            },
            tooltip: {
                theme: 'dark',
                marker: {
                    show: true,
                },
                x: {
                    show: false,
                }
            },
            fill: {
                type: ""gradient"",
                gradient: {
                    type: ""vertical"",
                    shadeIntensity: 1,
                    inverseColors: !1,
                    opacityFrom: .28,
                    opacityTo: .05,
                    stops: [45, 100]
                }
            },
        }
        var grafico = new ApexCharts(document.querySelector(""#grafico-c");
            WriteLiteral("omparativo-meses\"), options);\r\n        grafico.render();\r\n    });\r\n</script>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OrganizzeReports.MVC.ViewModels.Home.ComparativoMesesViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

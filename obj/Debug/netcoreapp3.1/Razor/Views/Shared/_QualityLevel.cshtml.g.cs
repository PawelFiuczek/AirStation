#pragma checksum "C:\Users\zelo9\Desktop\AirStation\Views\Shared\_QualityLevel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "800ec64de13e0878abbffe9ba7de02362f56a12d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__QualityLevel), @"mvc.1.0.view", @"/Views/Shared/_QualityLevel.cshtml")]
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
#line 1 "C:\Users\zelo9\Desktop\AirStation\Views\_ViewImports.cshtml"
using AirStation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\zelo9\Desktop\AirStation\Views\_ViewImports.cshtml"
using AirStation.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"800ec64de13e0878abbffe9ba7de02362f56a12d", @"/Views/Shared/_QualityLevel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b86c9e1ec256a829eb8c45bbd058c6c061ca4d0", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__QualityLevel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MeasuringStation>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 5 "C:\Users\zelo9\Desktop\AirStation\Views\Shared\_QualityLevel.cshtml"
 if (Model.AirQualityIndex.So2IndexLevel != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n        <td>Dwutlenek siarki</td>\r\n        <td>SO2</td>\r\n        <td");
            BeginWriteAttribute("style", " style=\"", 163, "\"", 369, 2);
            WriteAttributeValue("", 171, "background-color:", 171, 17, true);
#nullable restore
#line 10 "C:\Users\zelo9\Desktop\AirStation\Views\Shared\_QualityLevel.cshtml"
WriteAttributeValue(" ", 188, Model.AirQualityIndex.So2IndexLevel.Id > 2 ? "Tomato" :
                                            ((Model.AirQualityIndex.So2IndexLevel.Id) < 2 ? "LightGreen" : "DarkOrange"), 189, 180, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            ");
#nullable restore
#line 12 "C:\Users\zelo9\Desktop\AirStation\Views\Shared\_QualityLevel.cshtml"
       Write(Model.AirQualityIndex.So2IndexLevel.IndexLevelName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n    </tr>\r\n");
#nullable restore
#line 15 "C:\Users\zelo9\Desktop\AirStation\Views\Shared\_QualityLevel.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\zelo9\Desktop\AirStation\Views\Shared\_QualityLevel.cshtml"
 if (Model.AirQualityIndex.No2IndexLevel != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n        <td>Dwutlenek azotu</td>\r\n        <td>NO2</td>\r\n        <td");
            BeginWriteAttribute("style", " style=\"", 598, "\"", 804, 2);
            WriteAttributeValue("", 606, "background-color:", 606, 17, true);
#nullable restore
#line 21 "C:\Users\zelo9\Desktop\AirStation\Views\Shared\_QualityLevel.cshtml"
WriteAttributeValue(" ", 623, Model.AirQualityIndex.No2IndexLevel.Id > 2 ? "Tomato" :
                                            ((Model.AirQualityIndex.No2IndexLevel.Id) < 2 ? "LightGreen" : "DarkOrange"), 624, 180, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            ");
#nullable restore
#line 23 "C:\Users\zelo9\Desktop\AirStation\Views\Shared\_QualityLevel.cshtml"
       Write(Model.AirQualityIndex.No2IndexLevel.IndexLevelName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n    </tr>\r\n");
#nullable restore
#line 26 "C:\Users\zelo9\Desktop\AirStation\Views\Shared\_QualityLevel.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\zelo9\Desktop\AirStation\Views\Shared\_QualityLevel.cshtml"
 if (Model.AirQualityIndex.CoIndexLevel != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n        <td>Tlenek węgla</td>\r\n        <td>CO</td>\r\n        <td");
            BeginWriteAttribute("style", " style=\"", 1028, "\"", 1232, 2);
            WriteAttributeValue("", 1036, "background-color:", 1036, 17, true);
#nullable restore
#line 32 "C:\Users\zelo9\Desktop\AirStation\Views\Shared\_QualityLevel.cshtml"
WriteAttributeValue(" ", 1053, Model.AirQualityIndex.CoIndexLevel.Id > 2 ? "Tomato" :
                                            ((Model.AirQualityIndex.CoIndexLevel.Id) < 2 ? "LightGreen" : "DarkOrange"), 1054, 178, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            ");
#nullable restore
#line 34 "C:\Users\zelo9\Desktop\AirStation\Views\Shared\_QualityLevel.cshtml"
       Write(Model.AirQualityIndex.CoIndexLevel.IndexLevelName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n    </tr>\r\n");
#nullable restore
#line 37 "C:\Users\zelo9\Desktop\AirStation\Views\Shared\_QualityLevel.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\zelo9\Desktop\AirStation\Views\Shared\_QualityLevel.cshtml"
 if (Model.AirQualityIndex.Pm10IndexLevel != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n        <td>Pył zawieszony PM10</td>\r\n        <td>PM10</td>\r\n        <td");
            BeginWriteAttribute("style", " style=\"", 1466, "\"", 1674, 2);
            WriteAttributeValue("", 1474, "background-color:", 1474, 17, true);
#nullable restore
#line 43 "C:\Users\zelo9\Desktop\AirStation\Views\Shared\_QualityLevel.cshtml"
WriteAttributeValue(" ", 1491, Model.AirQualityIndex.Pm10IndexLevel.Id > 2 ? "Tomato" :
                                            ((Model.AirQualityIndex.Pm10IndexLevel.Id) < 2 ? "LightGreen" : "DarkOrange"), 1492, 182, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            ");
#nullable restore
#line 45 "C:\Users\zelo9\Desktop\AirStation\Views\Shared\_QualityLevel.cshtml"
       Write(Model.AirQualityIndex.Pm10IndexLevel.IndexLevelName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n    </tr>\r\n");
#nullable restore
#line 48 "C:\Users\zelo9\Desktop\AirStation\Views\Shared\_QualityLevel.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "C:\Users\zelo9\Desktop\AirStation\Views\Shared\_QualityLevel.cshtml"
 if (Model.AirQualityIndex.Pm25IndexLevel != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n        <td>Pył zawieszony PM2.5</td>\r\n        <td>PM2.5</td>\r\n        <td");
            BeginWriteAttribute("style", " style=\"", 1912, "\"", 2120, 2);
            WriteAttributeValue("", 1920, "background-color:", 1920, 17, true);
#nullable restore
#line 54 "C:\Users\zelo9\Desktop\AirStation\Views\Shared\_QualityLevel.cshtml"
WriteAttributeValue(" ", 1937, Model.AirQualityIndex.Pm25IndexLevel.Id > 2 ? "Tomato" :
                                            ((Model.AirQualityIndex.Pm25IndexLevel.Id) < 2 ? "LightGreen" : "DarkOrange"), 1938, 182, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            ");
#nullable restore
#line 56 "C:\Users\zelo9\Desktop\AirStation\Views\Shared\_QualityLevel.cshtml"
       Write(Model.AirQualityIndex.Pm25IndexLevel.IndexLevelName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n    </tr>\r\n");
#nullable restore
#line 59 "C:\Users\zelo9\Desktop\AirStation\Views\Shared\_QualityLevel.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "C:\Users\zelo9\Desktop\AirStation\Views\Shared\_QualityLevel.cshtml"
 if (Model.AirQualityIndex.O3IndexLevel != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n        <td>Ozon</td>\r\n        <td>O3</td>\r\n        <td");
            BeginWriteAttribute("style", " style=\"", 2337, "\"", 2541, 2);
            WriteAttributeValue("", 2345, "background-color:", 2345, 17, true);
#nullable restore
#line 65 "C:\Users\zelo9\Desktop\AirStation\Views\Shared\_QualityLevel.cshtml"
WriteAttributeValue(" ", 2362, Model.AirQualityIndex.O3IndexLevel.Id > 2 ? "Tomato" :
                                            ((Model.AirQualityIndex.O3IndexLevel.Id) < 2 ? "LightGreen" : "DarkOrange"), 2363, 178, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            ");
#nullable restore
#line 67 "C:\Users\zelo9\Desktop\AirStation\Views\Shared\_QualityLevel.cshtml"
       Write(Model.AirQualityIndex.O3IndexLevel.IndexLevelName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n    </tr>\r\n");
#nullable restore
#line 70 "C:\Users\zelo9\Desktop\AirStation\Views\Shared\_QualityLevel.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 71 "C:\Users\zelo9\Desktop\AirStation\Views\Shared\_QualityLevel.cshtml"
 if (Model.AirQualityIndex.C6H6IndexLevel != null)
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n        <td>Benzen</td>\r\n        <td>C6H6</td>\r\n        <td");
            BeginWriteAttribute("style", " style=\"", 2764, "\"", 2972, 2);
            WriteAttributeValue("", 2772, "background-color:", 2772, 17, true);
#nullable restore
#line 77 "C:\Users\zelo9\Desktop\AirStation\Views\Shared\_QualityLevel.cshtml"
WriteAttributeValue(" ", 2789, Model.AirQualityIndex.C6H6IndexLevel.Id > 2 ? "Tomato" :
                                            ((Model.AirQualityIndex.C6H6IndexLevel.Id) < 2 ? "LightGreen" : "DarkOrange"), 2790, 182, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            ");
#nullable restore
#line 79 "C:\Users\zelo9\Desktop\AirStation\Views\Shared\_QualityLevel.cshtml"
       Write(Model.AirQualityIndex.C6H6IndexLevel.IndexLevelName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n    </tr>\r\n");
#nullable restore
#line 82 "C:\Users\zelo9\Desktop\AirStation\Views\Shared\_QualityLevel.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MeasuringStation> Html { get; private set; }
    }
}
#pragma warning restore 1591

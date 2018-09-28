#pragma checksum "C:\BlazorProjects\Chap2\BlazorDemo\Pages\EventHandeling.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "307260852fa0fdd4330811f673885f5d0679215b"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorDemo.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Blazor;
    using Microsoft.AspNetCore.Blazor.Components;
    using System.Net.Http;
    using Microsoft.AspNetCore.Blazor.Layouts;
    using Microsoft.AspNetCore.Blazor.Routing;
    using Microsoft.JSInterop;
    using BlazorDemo;
    using BlazorDemo.Shared;
    [Microsoft.AspNetCore.Blazor.Layouts.LayoutAttribute(typeof(MainLayout))]

    [Microsoft.AspNetCore.Blazor.Components.RouteAttribute("/eventhandeling")]
    public class EventHandeling : Microsoft.AspNetCore.Blazor.Components.BlazorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
            builder.OpenElement(0, "h1");
            builder.AddContent(1, "Event Handeling example");
            builder.CloseElement();
            builder.AddContent(2, "\n");
            builder.OpenElement(3, "hr");
            builder.CloseElement();
            builder.AddContent(4, "\n\n");
            builder.OpenElement(5, "div");
            builder.AddContent(6, "\n    ");
            builder.OpenElement(7, "button");
            builder.AddAttribute(8, "class", "btn");
            builder.AddAttribute(9, "onclick", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetEventHandlerValue<Microsoft.AspNetCore.Blazor.UIMouseEventArgs>(ButtonClicked));
            builder.AddContent(10, "\n        Click me\n    ");
            builder.CloseElement();
            builder.AddContent(11, "\n");
            builder.CloseElement();
            builder.AddContent(12, "\n");
            builder.OpenElement(13, "br");
            builder.CloseElement();
            builder.AddContent(14, "\n");
            builder.OpenElement(15, "select");
            builder.AddAttribute(16, "class", "form-control col-md-4");
            builder.AddAttribute(17, "onchange", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetEventHandlerValue<Microsoft.AspNetCore.Blazor.UIChangeEventArgs>(SelectGender));
            builder.AddContent(18, "\n    ");
            builder.OpenElement(19, "option");
            builder.AddAttribute(20, "value", "");
            builder.AddContent(21, "-- Select Gender --");
            builder.CloseElement();
            builder.AddContent(22, "\n    ");
            builder.OpenElement(23, "option");
            builder.AddAttribute(24, "value", "Male");
            builder.AddContent(25, "Male");
            builder.CloseElement();
            builder.AddContent(26, "\n    ");
            builder.OpenElement(27, "option");
            builder.AddAttribute(28, "value", "Female");
            builder.AddContent(29, "Female");
            builder.CloseElement();
            builder.AddContent(30, "\n");
            builder.CloseElement();
            builder.AddContent(31, "\n");
            builder.OpenElement(32, "br");
            builder.CloseElement();
            builder.AddContent(33, "\n");
            builder.OpenElement(34, "p");
            builder.AddContent(35, "Selected Gender : ");
            builder.AddContent(36, Gender);
            builder.AddContent(37, " ");
            builder.CloseElement();
        }
        #pragma warning restore 1998
#line 20 "C:\BlazorProjects\Chap2\BlazorDemo\Pages\EventHandeling.cshtml"
           

    string Gender { get; set; }

    void ButtonClicked(UIMouseEventArgs e)
    {
        Console.WriteLine("button clicked");
    }

    void SelectGender(UIChangeEventArgs e)
    {
        Gender = e.Value.ToString();
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591
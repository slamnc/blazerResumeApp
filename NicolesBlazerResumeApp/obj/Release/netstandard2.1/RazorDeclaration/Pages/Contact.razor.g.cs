#pragma checksum "C:\2020 Apps\NicolesBlazerResumeApp\NicolesBlazerResumeApp\Pages\Contact.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7de41827fdcb8786fbaf714981b2ccbb36a50a73"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace NicolesBlazerResumeApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\2020 Apps\NicolesBlazerResumeApp\NicolesBlazerResumeApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\2020 Apps\NicolesBlazerResumeApp\NicolesBlazerResumeApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\2020 Apps\NicolesBlazerResumeApp\NicolesBlazerResumeApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\2020 Apps\NicolesBlazerResumeApp\NicolesBlazerResumeApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\2020 Apps\NicolesBlazerResumeApp\NicolesBlazerResumeApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\2020 Apps\NicolesBlazerResumeApp\NicolesBlazerResumeApp\_Imports.razor"
using NicolesBlazerResumeApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\2020 Apps\NicolesBlazerResumeApp\NicolesBlazerResumeApp\_Imports.razor"
using NicolesBlazerResumeApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\2020 Apps\NicolesBlazerResumeApp\NicolesBlazerResumeApp\Pages\Contact.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/contact")]
    public partial class Contact : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "C:\2020 Apps\NicolesBlazerResumeApp\NicolesBlazerResumeApp\Pages\Contact.razor"
      



    private ExampleModel _exampleModel = new ExampleModel();

    private void HandleValidSubmit()
    {
        Console.WriteLine("Sent Email");
    }

    public class ExampleModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

    }


    


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace StockApp.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\PAWEL\Desktop\PROJEKT2\StockApp\StockApp\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\PAWEL\Desktop\PROJEKT2\StockApp\StockApp\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\PAWEL\Desktop\PROJEKT2\StockApp\StockApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\PAWEL\Desktop\PROJEKT2\StockApp\StockApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\PAWEL\Desktop\PROJEKT2\StockApp\StockApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\PAWEL\Desktop\PROJEKT2\StockApp\StockApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\PAWEL\Desktop\PROJEKT2\StockApp\StockApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\PAWEL\Desktop\PROJEKT2\StockApp\StockApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\PAWEL\Desktop\PROJEKT2\StockApp\StockApp\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\PAWEL\Desktop\PROJEKT2\StockApp\StockApp\Client\_Imports.razor"
using StockApp.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\PAWEL\Desktop\PROJEKT2\StockApp\StockApp\Client\_Imports.razor"
using StockApp.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\PAWEL\Desktop\PROJEKT2\StockApp\StockApp\Client\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\PAWEL\Desktop\PROJEKT2\StockApp\StockApp\Client\_Imports.razor"
using Syncfusion.Blazor.Calendars;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\PAWEL\Desktop\PROJEKT2\StockApp\StockApp\Client\Pages\LookingForCompany.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\PAWEL\Desktop\PROJEKT2\StockApp\StockApp\Client\Pages\LookingForCompany.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\PAWEL\Desktop\PROJEKT2\StockApp\StockApp\Client\Pages\LookingForCompany.razor"
using StockApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\PAWEL\Desktop\PROJEKT2\StockApp\StockApp\Client\Pages\LookingForCompany.razor"
using Syncfusion.Blazor.DropDowns;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\PAWEL\Desktop\PROJEKT2\StockApp\StockApp\Client\Pages\LookingForCompany.razor"
using Syncfusion.Blazor.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\PAWEL\Desktop\PROJEKT2\StockApp\StockApp\Client\Pages\LookingForCompany.razor"
using Syncfusion.Blazor.Layouts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\PAWEL\Desktop\PROJEKT2\StockApp\StockApp\Client\Pages\LookingForCompany.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/LookingForCompany")]
    public partial class LookingForCompany : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 44 "C:\Users\PAWEL\Desktop\PROJEKT2\StockApp\StockApp\Client\Pages\LookingForCompany.razor"
       
    Type models = typeof(EmployeeData);
    public class EmployeeData
    {
        public string FirstName { get; set; }
        public string Designation { get; set; }
        public string Eimg { get; set; }
    }
    List<EmployeeData> Data = new List<EmployeeData>
    {
        new EmployeeData() { FirstName = "Andrew Fuller",  Designation = "Team Lead", Eimg= "7" },
        new EmployeeData() { FirstName = "Anne Dodsworth", Designation = "Developer", Eimg= "1" },
        new EmployeeData() { FirstName = "Janet Leverling", Designation = "HR", Eimg= "3" },
        new EmployeeData() { FirstName = "Laura Callahan", Designation = "Product Manager", Eimg= "2" },
        new EmployeeData() { FirstName = "Margaret Peacock", Designation = "Developer", Eimg= "6" },
        new EmployeeData() { FirstName = "Michael Suyama", Designation = "Team Lead", Eimg= "9" },
        new EmployeeData() { FirstName = "Nancy Davolio", Designation = "Product Manager", Eimg= "4" },
        new EmployeeData() { FirstName = "Robert King", Designation = "Developer", Eimg= "8" },
        new EmployeeData() { FirstName = "Steven Buchanan", Designation = "CEO", Eimg= "10" }
    };
     void onAction()
    {
        navigationManager.NavigateTo($"/students");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591

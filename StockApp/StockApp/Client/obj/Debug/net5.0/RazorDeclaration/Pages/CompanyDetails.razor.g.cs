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
    using Microsoft.AspNetCore.Components;
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
#line 13 "C:\Users\PAWEL\Desktop\PROJEKT2\StockApp\StockApp\Client\_Imports.razor"
using Syncfusion.Blazor.Calendars;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\PAWEL\Desktop\PROJEKT2\StockApp\StockApp\Client\Pages\CompanyDetails.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\PAWEL\Desktop\PROJEKT2\StockApp\StockApp\Client\Pages\CompanyDetails.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\PAWEL\Desktop\PROJEKT2\StockApp\StockApp\Client\Pages\CompanyDetails.razor"
using System.Threading.Tasks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\PAWEL\Desktop\PROJEKT2\StockApp\StockApp\Client\Pages\CompanyDetails.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\PAWEL\Desktop\PROJEKT2\StockApp\StockApp\Client\Pages\CompanyDetails.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\PAWEL\Desktop\PROJEKT2\StockApp\StockApp\Client\Pages\CompanyDetails.razor"
using Microsoft.VisualBasic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\PAWEL\Desktop\PROJEKT2\StockApp\StockApp\Client\Pages\CompanyDetails.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\PAWEL\Desktop\PROJEKT2\StockApp\StockApp\Client\Pages\CompanyDetails.razor"
using StockApp.Server.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\PAWEL\Desktop\PROJEKT2\StockApp\StockApp\Client\Pages\CompanyDetails.razor"
using StockApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\PAWEL\Desktop\PROJEKT2\StockApp\StockApp\Client\Pages\CompanyDetails.razor"
using StockApp.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\PAWEL\Desktop\PROJEKT2\StockApp\StockApp\Client\Pages\CompanyDetails.razor"
using Syncfusion.Blazor.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\PAWEL\Desktop\PROJEKT2\StockApp\StockApp\Client\Pages\CompanyDetails.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\PAWEL\Desktop\PROJEKT2\StockApp\StockApp\Client\Pages\CompanyDetails.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\PAWEL\Desktop\PROJEKT2\StockApp\StockApp\Client\Pages\CompanyDetails.razor"
using System.Text;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\PAWEL\Desktop\PROJEKT2\StockApp\StockApp\Client\Pages\CompanyDetails.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/LookingForCompany/{sName}")]
    public partial class CompanyDetails : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 77 "C:\Users\PAWEL\Desktop\PROJEKT2\StockApp\StockApp\Client\Pages\CompanyDetails.razor"
       
    [Parameter]
    public string sName { get; set; }
    // [Parameter]
    //public string KeyAdded { get; set; }
    [Parameter]
    public TickerDet tickerDet { get; set; }
    List<ChartData> Data = new List<ChartData>();
    string chartName;
    Theme theme = Theme.Bootstrap4;

    protected override async Task OnInitializedAsync()
    {
        try
        {
            string ss = (string) sName;
            tickerDet = await Http.GetFromJsonAsync<TickerDet>("WeatherForecast/info/" + ss);
            tickerDet.logo_url = tickerDet.logo_url + "?apiKey=ZqJe9jQrip7ulI2Pa6fkICLddpneFoqK";
            Data = await Http.GetFromJsonAsync<List<ChartData>>("WeatherForecast/chart/" + ss);
            chartName = sName + " Stock Price";
            //Console.WriteLine(Data.Count + "    " + Data[0].x + "     " + Data[1].x);
            //Console.WriteLine("OTO POJERZANA O BLAD DATA: " + DateAndTime.DateAdd(DateInterval.Day, -1, DateTime.Today).ToString("yyyy - MM - dd"));

            var json = JsonConvert.SerializeObject(tickerDet);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await Http.PostAsync("WeatherForecast/WatchedList", data);
        }
        catch (AccessTokenNotAvailableException exception)
        {
            exception.Redirect();
        }
    }
    string loadClass = "stockchartloader";
    string loadDiv = "stockchartdiv";
    void ChartLoaded(StockChartEventArgs args)
    {
        loadClass = "";
        loadDiv = "";
        StateHasChanged();
    }

    async void AddToMyList()
    {
        if (await js.InvokeAsync<bool>("confirm", "Do you want to add this company to your List? (If your company is already in Your List nothing will happen)"))
        {
            var json = JsonConvert.SerializeObject(tickerDet);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await Http.PostAsync("WeatherForecast/MyList", data);

            //var result = await response.Content.ReadAsStringAsync();
        }
    }

    void GoBack()
    {
        navigationManager.NavigateTo($"/LookingForCompany");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
    }
}
#pragma warning restore 1591
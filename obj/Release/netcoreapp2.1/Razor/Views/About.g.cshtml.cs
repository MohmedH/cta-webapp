#pragma checksum "/Users/Hira/Desktop/project07/cta-web/Views/About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a28bf89bd78704e3568340dc18d81450e386ec5c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(program.Pages.Views_About), @"mvc.1.0.razor-page", @"/Views/About.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Views/About.cshtml", typeof(program.Pages.Views_About), null)]
namespace program.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "/Users/Hira/Desktop/project07/cta-web/Views/_ViewImports.cshtml"
using program;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a28bf89bd78704e3568340dc18d81450e386ec5c", @"/Views/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65a87352ab55936b7625448d2e9155e1658af919", @"/Views/_ViewImports.cshtml")]
    public class Views_About : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "/Users/Hira/Desktop/project07/cta-web/Views/About.cshtml"
  
    ViewData["Title"] = "About";

#line default
#line hidden
            BeginContext(62, 4, true);
            WriteLiteral("<h3>");
            EndContext();
            BeginContext(67, 13, false);
#line 6 "/Users/Hira/Desktop/project07/cta-web/Views/About.cshtml"
Write(Model.Message);

#line default
#line hidden
            EndContext();
            BeginContext(80, 4141, true);
            WriteLiteral(@"</h3>

<p>This is a web application developed in ASP.NET, using C# and ADO.NET serverside with SQL Database. 
<br/> 
<br/>
This project was developed by <b>Mohmed Hira</b> at <i> The University of Illinois Chicago </i> CS341
</p>
<br/>
<p>The SQL Database contains data collected from CTA (Chicago Transit Authority)</p>

<br/>

<h4>Connection: </h4>
<p> The connection page will let you know what the current status of the connection is</p>

<br/>

<h4>Station Info: </h4>
<p> Enterning in a station name here. Can be the full name e.g. <i>Clark/Lake</i> <b>OR</b> partial e.g. <i>lake</i> <b>**Not Case sensitive**</b> </p>
<p> When you enter a partial name, you will get all the stations that have the keyword that you entered, so entering lake will include Clark/Lake </p>
<p> 
    <b>ID:</b> The ID field will be the ID given to that station by CTA. 
    <br/>
    <b>Name:</b> This field will be the full name of the station found based on your input.
    <br/> 
    <b>Average Daily Ridership:</b> This field will con");
            WriteLiteral(@"tain the Average # of Daily riders at that specific station.
    <br/>
    <b># of stops:</b> This field provides the number of stops at the station.
    Handicap Accedible Stops: In this field you will find, <b>All</b>, <b>Some</b>, or <b>None</b>. 
    <br/>
        <b>All</b> means that if the # of stops at a staion were 4, then all 4 stops are Handicap accessible.
    <br/>
        <b>Some</b> means that if the # of stops at a station were 4, then 1, 2 or 3 of the stops are Handicap accessible.
    <br/>
        <b>None</b> means that if the # of stops at a station were 4 no stops at the station are Handicap accessible.
</p>

<br/>

<h4>Stops Info: </h4>
<p> On this page you will need to enter the station number in order to search for the stops </p>
<p> Upon entering a valid station number, you will see a table with information regarding each stop </p>
<p>
    <b>StopID:</b> The StopID field will be the StopID given to that specific stop by CTA. 
    <br/>
    <b>Name:</b> This is the name of the station.");
            WriteLiteral(@"
    <br/> 
    <b>Direction:</b> This is the direction the train will go from this stop. Gets tricky because not all lines travel North/South.
    <br/>
    <b>ADA:</b> ADA means Handicap Accedible.
    <br/> 
    <b>Latitude:</b> Latitude Location of the stop.
    <br/>
    <b>Longitude:</b> Longitude Location of the stop.
    <br/> 
    <b>Color:</b> This field is the color of the train line, as CTA train lines are represented by Colors, Brown, Red, Blue, Green, Orange, etc..
    
</p>

<br/>

<h4>Ridership By Month</h4>
<p> This section will break down and graph the total # of CTA riders per <b>Month</b> </p>


<br/>

<h4>Ridership By Year</h4>
<p> This section will break down and graph the total # of CTA riders per <b>Year</b> </p>

<br/>

<h4>Live Train Times</h4>
<p> This section will allow you to track live trains coming to a certain station </p>
<br/>
<p> With integration of the CTA API, using C# and some extensions, you are able to get live train run information </p>
<br/>
<p> You will enter in a st");
            WriteLiteral(@"ation number, just like in the StopsInfo Section. Based on this, you will get in return all the trains that are going in either directions and the times they will arrive at that station</p>
<br/>
<p>

    <b>StaionID:</b> The StaionID field will be the StaionID eentered. 
    <br/>
    <b>Currently Here:</b> This will be the name of the station you are currently at, or are trying to look at train times for.
    <br/> 
    <b>Direction:</b> This is the direction the train will go from this stop. e.g. If we entered 40710, we would get the Chicago station. At this station there are two directions, One goes towards The Loop, the other goes towards Kimball.
    <br/>
    <b>Line Color:</b> The line color, important because some stops multiple lines will stop.
    <br/> 
    <b>Eta Arrival:</b> This is the time that is estimated for this train to arrive to the station which was searched.
    <br/>
    <b>Arriving in Mintues:</b> This will be how many minutes from when you search for the train to arrive at the stati");
            WriteLiteral("on which was searched.\n    <br/> \n\n</p>\n\n\n\n\n\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AboutModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AboutModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AboutModel>)PageContext?.ViewData;
        public AboutModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
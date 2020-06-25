#pragma checksum "C:\Users\andre\source\repos\ExploreCalifornia\Views\Home\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d7357330e0e903d5541ec21165344288917898b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_index), @"mvc.1.0.view", @"/Views/Home/index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d7357330e0e903d5541ec21165344288917898b", @"/Views/Home/index.cshtml")]
    public class Views_Home_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("home"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("no-js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE HTML>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d7357330e0e903d5541ec21165344288917898b3395", async() => {
                WriteLiteral(@"
<meta charset=""utf-8"">
<title>Welcome to Explore California</title>
<meta name=""description"" content=""A lynda.com example of HTML5 and CSS3"">
<meta name=""keywords"" content=""html5, css3, lynda, local storage, canvas, forms, semantics, web apps"">
<!--make sure mobile devices display the page at the proper scale	-->
<meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
<!--[if lt IE 9]>
<script src=""http://html5shiv.googlecode.com/svn/trunk/html5.js""></script>
<![endif]-->
<link href=""/css/main.css"" rel=""stylesheet"" type=""text/css"" media=""screen, projection"">
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d7357330e0e903d5541ec21165344288917898b4974", async() => {
                WriteLiteral(@"
<div id=""wrapper"">
  <header id=""mainHeader""> <a href=""/"" title=""home"" class=""logo"">
   <!-- I need this div because IE is an affront to mankind-->
    <div>
    <h1>Explore California</h1>
    </div>
    </a>
    <nav id=""siteNav"">
      <h1>Where do you want to go?</h1>
      <ul>
       <li><a href=""/tours.htm"" title=""Our tours"">Tours <br /><span class=""tagline"">follow our bliss</span></a>
          <ul>
            <li><a href=""/tours.htm"" title=""Our tours"">All Tours</a></li>
            <li><a href=""/tours.htm"" title=""find tours"">Tours by Activity</a></li>
            <li><a href=""/tours.htm"" title=""find tours"">Tours by Region</a></li>
            <li><a href=""/tours.htm"" title=""find tours"">Tour Finder</a></li>
          </ul>
        </li>
        <li><a href=""mission.htm"" title=""What we believe"">Mission <br /><span class=""tagline"">what makes us different?</span></a></li>
        <li><a href=""resources.htm"" title=""planning resources"">Resources <br /><span class=""tagline"">plan your t");
                WriteLiteral(@"rip</span></a>
          <ul>
            <li><a href=""resources/faq.htm"" title=""Got questions?"">Tour FAQs</a></li>
            <li><a href=""resources/additional_resources.htm"" title=""additional resources"">Tour Information</a></li>
            <li><a href=""resources/terms.htm"" title=""terms and conditions"">Site Terms</a></li>
          </ul>
        </li>
        <li><a href=""explorers.htm"" title=""Our community"">Explorers <br /><span class=""tagline"">join our community</span></a>
          <ul>
            <li><a href=""explorers/join.htm"" title=""join our community"">Join the Explorers</a></li>
            <li><a href=""/blog"" title=""read our blog!"">Read our Blog</a></li>
            <li><a href=""explorers/gallery.htm"" title=""contributor photos"">Tour Photos</a></li>
            <li><a href=""_video/EC_podcast_full version.mov"" title=""check out our podcast"">Video podcast</a></li>
          </ul>
        </li>
        <li><a href=""contact.htm"" title=""contact us"" class=""last"">Contact <br /><span class=""");
                WriteLiteral(@"tagline"">we're listening</span></a>
          <ul>
            <li><a href=""support.htm"" title=""need help?"">Support</a></li>
          </ul>
        </li>
      </ul>
    </nav>
  </header>
  <section id=""actionCall"">
  <h1>Explore our world your way</h1>
  <a href=""/tours.htm"" title=""Find your tour!""><h2>Find your tour</h2></a>
  </section>
  <div id=""contentWrapper"">
  <section id=""mainContent"">
 <article id=""mainArticle""> 
 <h1>Tour Spotlight</h1>
  <p class=""spotlight"">This month's spotlight package is Cycle California. Whether you are looking for some serious downhill thrills to a relaxing ride along the coast, you'll find something to love in Cycle California.<br /> <span class=""accent""><a href=""/tours_cycle.htm"" title=""Cycle California"">tour details</a></span></p>
  <h1>Explorer's Podcast</h1>
<video controls poster=""/images/podcast_poster.jpg"" width=""512"" height=""288"" preload=""none"">
	<source src=""_video/podcast_teaser.mp4"" type=""video/mp4"" />
	<source src=""_video/podcast_teaser.we");
                WriteLiteral(@"bm"" type=""video/webm"" />
	<source src=""_video/podcast_teaser.theora.ogv""type=""video/ogg"" />
</video>
  <p class=""videoText"">Join us each month as we publish a new Explore California video podcast, with featured tours, customer photos, and some exctiing new features!<span class=""accent""><a href=""explorers/video.htm"" title=""Video Podcast"">Watch the full video</a></span></p>
  </article>
  </section>
    <aside id=""secondaryContent"">
        <div id=""specials"" class=""callOut"">
            <h1>Monthly Specials</h1>
            <h2 class=""top""><img src=""/images/calm_bug.gif"" alt=""California Calm"" width=""75"" height=""75"">California Calm</h2>
            <p>
                Day Spa Package <br>
                <a href=""/tours/tour_detail_cycle.htm"">$250</a>
            </p>
            <h2><img src=""/images/desert_bug.gif"" alt=""From desert to sea"" width=""75"" height=""75"">From Desert to Sea</h2>
            <p>
                2 Day Salton Sea <br>
                <a href=""/tours/tour_detail_cycle.htm""");
                WriteLiteral(@">$350</a>
            </p>
            <h2><img src=""/images/backpack_bug.gif"" alt=""Backpack Cali"" width=""75"" height=""41"">Backpack Cali</h2>
            <p>
                Big Sur Retreat <br>
                <a href=""/tours/tour_detail_cycle.htm"">$620</a>
            </p>
            <h2><img src=""/images/taste_bug.gif"" alt=""Taste of California"" width=""75"" height=""75"">Taste of California</h2>
            <p>
                Tapas &amp; Groves <br>
                <a href=""/tours/tour_detail_taste.htm"">$150</a>
            </p>
        </div>
        <div id=""trivia"" class=""callOut"">
            <h1>Did You Know?</h1>
            <p>California produces over 17 million gallons of wine each year!</p>
        </div>
    </aside>
  </div>
  <footer id=""pageFooter"">
  <section id=""quickLinks"">
  <h1>Quick Nav</h1>
    <ul id=""quickNav"">
      <li><a href=""/"" title=""Our home page"">Home</a></li>
      <li><a href=""/tours.htm"" title=""Explore our tours"">Tours</a></li>
      <li><a href=""missi");
                WriteLiteral(@"on.htm"" title=""What we think"">Mission</a></li>
      <li><a href=""resources.htm"" title=""Guidance and planning"">Resources</a></li>
      <li><a href=""explorers.htm"" title=""Join our community"">Explorers</a></li>
      <li><a href=""contact.htm"" title=""Contact and support"">Contact</a></li>
    </ul>
  </section>
  <section id=""footerResources"">
  <h1>Resources</h1>
    <ul id=""quickNav"">
      <li><a href=""resources/faq.htm"" title=""Our home page"">FAQ</a></li>
      <li><a href=""support.htm"" title=""Need help?"">Support</a></li>
      <li><a href=""resources/legal.htm"" title=""The fine print"">Legal</a></li><li><a href=""login.htm"">Login</a></li>
    </ul>
  </section>
  <section id=""companyInfo"">
  <h1>Contact</h1>
  <h2>Explore California</h2>
      <p>5605 Nota Street<br />
        Ventura, CA 93003</p>
      <p>866.555.4310<br />866.555.4315 <em>(24 hour support)</em></p>
  </section>
  </footer>
</div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
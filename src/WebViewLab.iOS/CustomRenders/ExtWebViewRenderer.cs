using WebViewLab.CustomRenders;
using WebViewLab.iOS.CustomRenders;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(ExtWebView), typeof(ExtWebViewRenderer))]
namespace WebViewLab.iOS.CustomRenders
{
    class ExtWebViewRenderer: WebViewRenderer
    {
        public ExtWebViewRenderer() : base()
        {
        }
    }
}
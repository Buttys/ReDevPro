using CefSharp.WinForms;
using System.Windows.Forms;

namespace ReDevPro.Components
{
    public class WebTab : TabPage
    {
        ChromiumWebBrowser browser;
        public string URL { get; private set; }

        public WebTab(string url)
        {
            URL = url;
            InitBrowser();
        }

        public void InitBrowser()
        {
            browser = new ChromiumWebBrowser(URL);
            Controls.Add(browser);
            browser.Dock = DockStyle.Fill;
        }

        //public void LoadPage(string url)
        //{

        //}
    }
}

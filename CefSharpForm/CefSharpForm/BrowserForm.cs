using CefSharp;
using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CefSharpForm
{
    public partial class BrowserForm : Form
    {
        public BrowserForm()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            Cef.Initialize(new CefSettings());
            string url = ConfigurationManager.AppSettings["Home"];
            ChromiumWebBrowser browser = new ChromiumWebBrowser(url)
            {
                Dock = DockStyle.Fill
            };
            this.Controls.Add(browser);
            browser.DownloadHandler = new DownloadHandler();
            browser.MenuHandler = new MenuHandler();
        }
    }
}

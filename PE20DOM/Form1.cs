using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PE20DOM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            try
            {
                Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(
                    @"SOFTWARE\\WOW6432Node\\Microsoft\\Internet Explorer\\MAIN\\FeatureControl\\FEATURE_BROWSER_EMULATION",
                    true);
                key.SetValue(Application.ExecutablePath.Replace(Application.StartupPath + "\\", ""), 12001, Microsoft.Win32.RegistryValueKind.DWord);
                key.Close();
            }
            catch
            {

            }

            // add the delegate method to be called after the webpage loads, set this up before Navigate()
            this.webBrowser1.DocumentCompleted += new
            WebBrowserDocumentCompletedEventHandler(this.WebBrowser1__DocumentCompleted);

            // if you want to use example.html from a local folder (saved in c:\temp for example):
            //this.webBrowser1.Navigate("c:\\temp\\example.html");

            // or if you want to use the URL (only use one of these Navigate() statements)
            this.webBrowser1.Navigate("people.rit.edu/dxsigm/example.html");

        }

        private void WebBrowser1__DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            WebBrowser webBrowser = (WebBrowser)sender;
            HtmlElementCollection htmlElementCollection;
            HtmlElement htmlElement;

            HtmlDocument htmlDocument = webBrowser1.Document;

            HtmlElement line1 = htmlDocument.GetElementsByTagName("h1")[0];
            line1.InnerText = "My UFO Page";

            HtmlElementCollection h2s = htmlDocument.GetElementsByTagName("h2");
            h2s[0].InnerText = "My UFO Info";
            h2s[1].InnerText = "My UFO Pictures";
            h2s[2].InnerText = "";

            HtmlElement body = htmlDocument.GetElementsByTagName("body")[0];
            body.Style = "font-family: sans-serif; color: rgb(170, 68, 68)";

            HtmlElement paragraph1 = htmlDocument.GetElementsByTagName("p")[0];
            paragraph1.InnerText = "Report your UFO sightings here: ";

            HtmlElement link = htmlDocument.CreateElement("a");
            link.SetAttribute("href", "http://www.nuforc.org/");
            link.InnerText = "http://www.nuforc.org/";
            paragraph1.AppendChild(link);
            paragraph1.Style = "color: green; font-weight: bold; font-size: 2em; text-transform: uppercase; text-shadow: 3px 2px #A44";
        
            HtmlElement paragraph2 = htmlDocument.GetElementsByTagName("p")[1];
            paragraph2.InnerText = "";

            HtmlElement paragraph3 = htmlDocument.GetElementsByTagName("p")[2];
            HtmlElement image = htmlDocument.CreateElement("img");
            image.SetAttribute("src", "https://cdn.britannica.com/99/200099-004-17A60207/UFO-farm-McMinnville-Oregon-1950.jpg?s=300x300");
            image.SetAttribute("alt", "UFO");

            paragraph3.InsertAdjacentElement(HtmlElementInsertionOrientation.AfterBegin, image);

            HtmlElement footer = htmlDocument.CreateElement("footer");
            footer.InnerText = "©2023 Sarah Schneider";
            body.AppendChild(footer);
        }
    }
}

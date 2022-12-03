using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PE20Dom
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
            this.webBrowser1.Navigate("c:\\temp\\example.html");

            // or if you want to use the URL  (only use one of these Navigate() statements)
            this.webBrowser1.Navigate("people.rit.edu/dxsigm/example.html");

        }

        private void WebBrowser1__DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            WebBrowser webBrowser = (WebBrowser)sender;
            HtmlElementCollection htmlElementCollection;
            HtmlElement htmlElement;

            // change the .InnerText of the first <h1> to "My UFO Page"
            htmlElementCollection = webBrowser.Document.GetElementsByTagName("h1");

            htmlElement = htmlElementCollection[0];

            htmlElement.InnerText = "My UFO Page";

            // change the .InnerText of the first <h2> to "My UFO Info"
            htmlElementCollection = webBrowser.Document.GetElementsByTagName("h2");

            htmlElement = htmlElementCollection[0];

            htmlElement.InnerText = "My UFO Info";

            // change the .InnerText of the 2nd <h2> to "My UFO Pictures"
            htmlElement = htmlElementCollection[1];

            htmlElement.InnerText = "My UFO Pictures";

            // change the .InnerText of the 3rd <h2> to and empty string - ""
            htmlElement = htmlElementCollection[2];

            htmlElement.InnerText = "";

            // select the <body> element and make 2 style changes:
            // font-family: "sans-serif"; font color: "#a8423b";
            htmlElement = webBrowser.Document.Body;
            htmlElement.Style += "font-family: sans-serif; color: #a8423b";

            // select the first paragraph. The innerHTML will contain the text "Report your UFO sightings here: "
            // and a working link to "http://www.nuforc.org"
            htmlElementCollection = webBrowser.Document.GetElementsByTagName("p");
            htmlElement = htmlElementCollection[0];

            htmlElement.InnerHtml = "Report your UFO sightings here: ";
            htmlElement.InnerHtml += "<a href='http://www.nuforc.org'>http://www.nuforc.org</a>";

            // make some style changes to the first paragraph
            // font color is "green"
            htmlElement.Style += "color: green";

            // font-weight is "bold"
            htmlElement.Style += "font-weight: bold";

            // font size is "2em"
            htmlElement.Style += "font-size: 2em";

            // text-transform is "uppercase"
            htmlElement.Style += "text-transform: uppercase";

            // text-shadow is "3px 2px #A44"
            htmlElement.Style += "text-shadow: 3px 2px #A44";

            // change the .innerText of the 2nd paragraph to an empty string - ""
            htmlElement = htmlElementCollection[1];
            htmlElement.InnerText = "";

            // insert an <img> element in the beginning of the 3rd paragraph to show an image of a UFO
            HtmlElement htmlElement1 = webBrowser.Document.CreateElement("img");
            htmlElement1.SetAttribute("src", "https://www.pennlive.com/resizer/L1dJbYvtRa3FAA_wIpFWDjMJ6RY=/1280x0/smart/cloudfront-us-east-1.images.arcpublishing.com/advancelocal/RROSP6BKUJF2FNSHHP2A4IKOHY.jpeg");
            htmlElement1.SetAttribute("title", "ufo pic from web");

            htmlElement = htmlElementCollection[2];
            htmlElement.InsertAdjacentElement(HtmlElementInsertionOrientation.BeforeBegin, htmlElement1);

            // add a <footer> element to the end of the page which has a copyright (&copy;) notice
            // the current year and name
            htmlElement1 = webBrowser.Document.CreateElement("footer");
            htmlElement1.InnerHtml = "&copy;2022 Judy Derrick";

            webBrowser.Document.Body.AppendChild(htmlElement1);
        }
    }
}

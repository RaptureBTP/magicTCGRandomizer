using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
using ScrapySharp.Extensions;
using ScrapySharp.Network;
using ScrapySharp.Html.Forms;

namespace magicTCGRandomizer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            try {
                //ScrapingBrowser Browser = new ScrapingBrowser();
                //Browser.AutoDownloadPagesResources = true;
                //Browser.AllowAutoRedirect = true; // Browser has settings you can access in setup
                //Browser.AllowMetaRedirect = true;
                var getHtmlWeb = new HtmlWeb();
                //var document = getHtmlWeb.Load("http://gatherer.wizards.com/Pages/Card/Details.aspx?action=random");
                //http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=132069
                var document = getHtmlWeb.Load("http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=132069");
                /*var nodes = document.DocumentNode.SelectNodes("//div[@id='ctl00_ctl00_ctl00_MainContent_SubContent_SubContent_cmcRow']");
                if (nodes != null)
                {
                    foreach (HtmlAgilityPack.HtmlNode node in nodes)
                    {
                        MessageBox.Show(node.InnerText);
                    }
                }*/
                var CMCNode = document.GetElementbyId("ctl00_ctl00_ctl00_MainContent_SubContent_SubContent_cmcRow");
                if(CMCNode != null)
                {
                    string temp = CMCNode.InnerText;
                    //now use regular expressions to strip string and get important info
                }

                //WebPage home = Browser.NavigateToPage(new Uri("http://www.ietf.org"));
                //WebPage PageResult = Browser.NavigateToPage(new Uri("http://gatherer.wizards.com/Pages/Default.aspx"));
                //WebPage PageResult = Browser.NavigateToPage(new Uri("http://gatherer.wizards.com/Pages/Advanced.aspx"));
                //http://gatherer.wizards.com/Pages/Card/Details.aspx?action=random
                //webBrowser1.Navigate(new Uri("http://gatherer.wizards.com/Pages/Card/Details.aspx?action=random"));
                //WebPage PageResult = Browser.NavigateToPage(new Uri("http://gatherer.wizards.com/Pages/Card/Details.aspx?action=random"));
                //PageWebForm form = PageResult.FindFormById("dataForm");
                //HtmlNode ColorNode = PageResult.Html.CssSelect("#ctl00_ctl00_ctl00_MainContent_SubContent_SubContent_manaRow > div:nth-child(2) > img:nth-child(1)").First();
                //string temp = ColorNode.InnerText;
                //HtmlNode TitleNode = PageResult.Html.CssSelect("#ctl00_ctl00_ctl00_MainContent_SubContent_SubContent_cardImage").First();
                //TitleNode.
            }
            catch(Exception exp)
            {
                Console.WriteLine(exp);
            }
        }
    }
}

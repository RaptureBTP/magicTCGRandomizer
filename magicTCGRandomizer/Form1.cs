﻿using System;
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
using System.Text.RegularExpressions;

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
                //var document = getHtmlWeb.Load("http://gatherer.wizards.com/Pages/Card/Details.aspx?action=random");
                //WebPage home = Browser.NavigateToPage(new Uri("http://www.ietf.org"));
                //WebPage PageResult = Browser.NavigateToPage(new Uri("http://gatherer.wizards.com/Pages/Default.aspx"));
                //WebPage PageResult = Browser.NavigateToPage(new Uri("http://gatherer.wizards.com/Pages/Advanced.aspx"));
                //webBrowser1.Navigate(new Uri("http://gatherer.wizards.com/Pages/Card/Details.aspx?action=random"));
                //WebPage PageResult = Browser.NavigateToPage(new Uri("http://gatherer.wizards.com/Pages/Card/Details.aspx?action=random"));
                //HtmlNode ColorNode = PageResult.Html.CssSelect("#ctl00_ctl00_ctl00_MainContent_SubContent_SubContent_manaRow > div:nth-child(2) > img:nth-child(1)").First();
                //HtmlNode TitleNode = PageResult.Html.CssSelect("#ctl00_ctl00_ctl00_MainContent_SubContent_SubContent_cardImage").First();

                bool cardFound = false;
                bool colorMismatch = false;

                var getHtmlWeb = new HtmlWeb(); //create new HtmlWeb object
                while(cardFound == false) //loop until card meeting criteria is matched
                {
                    var document = getHtmlWeb.Load("http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=132069"); //load a specific page for now. Will eventually be the random card page on gatherer
                    //http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=368483 = blightning
                    //http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=132069 = cloud sprite
                    if (checkBoxCMCRandom.Checked != true) //if RandomCMC checkbox is not checked
                    {
                        if (checkCMC(document, numericUpDownCMC.Value.ToString()) == false) //check cards CMC against specified CMC
                        {
                            continue; //CMC didn't match, keep looping
                        }
                    }
                    if (checkBoxColorRandom.Checked != true) //if RandomColor box is not checked
                    {
                        var checkedColors = ColorListCheckBox.CheckedItems; //obtain collection of checked items
                        for(int i = 0; i < checkedColors.Count; i++) //loop over each index (each checked item)
                        {
                            if(checkMana(document, checkedColors[i].ToString()) == false) //TODO: need to include 'Exclusive Colors' logic
                            {
                                colorMismatch = true; //at least one of the colors didnt match
                                break;
                            }
                        }
                        if (colorMismatch == true)
                            continue; //loop to a new random card
                    }
                }


                /*var nodes = document.DocumentNode.SelectNodes("//div[@id='ctl00_ctl00_ctl00_MainContent_SubContent_SubContent_cmcRow']");
                if (nodes != null)
                {
                    foreach (HtmlAgilityPack.HtmlNode node in nodes)
                    {
                        MessageBox.Show(node.InnerText);
                    }
                }*/
            }
            catch(Exception exp)
            {
                Console.WriteLine(exp);
            }
        }

        public bool checkCMC(HtmlAgilityPack.HtmlDocument document, string cmc)
        {
            string result = "";
            var CMCNode = document.GetElementbyId("ctl00_ctl00_ctl00_MainContent_SubContent_SubContent_cmcRow"); //find the CMC element via ID
            if (CMCNode != null)
            {
                string temp = CMCNode.InnerText;
                result = Regex.Match(temp, "\\d").ToString(); //regex match to find only the digit //check to make sure double digits work correctly
            }
            else
            {
                Console.WriteLine("Something went wrong. We didn't find the correct CMC id on the page.");
                return false;
            }
            if(result.Equals(cmc))
                return true;
            else
                return false;
        }
        
        public bool checkMana(HtmlAgilityPack.HtmlDocument document, string color)
        {
            var manaRow = document.GetElementbyId("ctl00_ctl00_ctl00_MainContent_SubContent_SubContent_manaRow");
            if (manaRow != null)
            {
                var colorChildren = manaRow.ChildNodes;
                var colorList = colorChildren[3].InnerHtml.ToString();
                if(colorList.Contains(color))
                    return true;
                else
                    return false;
            }
            else
            {
                Console.WriteLine("Something went wrong. We didn't find the correct mana symbol id on the page.");
                return false;
            }
        } 
    }
}

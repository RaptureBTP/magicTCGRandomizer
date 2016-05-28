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
            try
            {
                var getHtmlWeb = new HtmlWeb(); //create new HtmlWeb object

                string baseURL = "http://gatherer.wizards.com/Pages/Search/Default.aspx?";
                string searchURL= "";

                if (checkBoxColorRandom.Checked != true) //if RandomCMC checkbox is not checked
                {
                    var checkedColors = ColorListCheckBox.CheckedItems; //obtain collection of checked items
                    searchURL = baseURL + "color=|";
                    //List<string> manaSymbolColors = new List<string>(); //list of strings
                    for (int i = 0; i < checkedColors.Count; i++)
                    {
                        if (checkedColors[i].ToString() == "Red")
                            searchURL += "[R]";
                    }
                    
                }

                var document = getHtmlWeb.Load(searchURL);
            }
            catch(Exception exp)
            {

            }
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
                bool colorMatch = false;
                bool tooManyColors = false;
                int colorCount = 0;

                var getHtmlWeb = new HtmlWeb(); //create new HtmlWeb object
                while(cardFound == false) //loop until card meeting criteria is matched
                {
                    var document = getHtmlWeb.Load("http://gatherer.wizards.com/Pages/Card/Details.aspx?action=random"); //load a specific page for now. Will eventually be the random card page on gatherer
                    //http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=368483 = blightning sorcery common
                    //http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=132069 = cloud sprite creature common
                    //http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=260991 = nicol bolas planeswalker mythic rare
                    //http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=389600 = Moss diamond artifact
                    //http://gatherer.wizards.com/Pages/Card/Details.aspx?action=random random
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
                        List<string> manaSymbolColors = new List<string>(); //list of strings

                        if (radioButtonAND.Checked == true) //check for AND stipulation
                        {
                            for (int i = 0; i < checkedColors.Count; i++) //loop over each index (each checked item)
                            {
                                if (checkMana(document, checkedColors[i].ToString()) == false)
                                {
                                    colorMismatch = true; //at least one of the colors didnt match
                                    break;
                                }
                                else
                                {
                                    colorCount++;
                                    manaSymbolColors.Add(checkedColors[i].ToString());
                                }
                            }
                            
                            if (colorMismatch == true || countCMCColors(document, manaSymbolColors) != colorCount) 
                            { 
                                colorMismatch = false;
                                colorCount = 0;
                                continue; //loop to a new random card
                            }
                            colorCount = 0;
                        }
                        else if(radioButtonOR.Checked == true) 
                        {
                            if (countCMCColors(document) > 1) //if card is not mono-colored, skip it //need to add list here I think?
                                continue;

                            for (int i = 0; i < checkedColors.Count; i++) //loop over each index (each checked item)
                            {
                                if (checkMana(document, checkedColors[i].ToString()) == true)
                                {
                                    if(colorMatch == false)
                                    {
                                        colorMatch = true;
                                    }
                                    else
                                    {
                                        colorMatch = false;
                                        tooManyColors = true;
                                    }
                                }
                            }
                            if (tooManyColors == true || colorMatch == false)
                            {
                                tooManyColors = false;
                                continue;
                            }
                        }
                        else if(radioButtonANY.Checked == true) //problem here
                        {
                            for (int i = 0; i < checkedColors.Count; i++) //loop over each index (each checked item)
                            {
                                if (checkMana(document, checkedColors[i].ToString()) == true)
                                {
                                    colorMatch = true; //at least one of the colors matched 
                                    break;
                                }
                            }
                            
                            if (colorMatch == false)
                            {
                                colorMatch = false; //?
                                continue;
                            }
                        }
                    }
                    if(comboBoxCardType.Text != "Random") 
                    {
                        if (checkType(document, comboBoxCardType.Text) == false)
                            continue;
                    }
                    if(comboBoxRarity.Text != "Random")
                    {if (checkRarity(document, comboBoxRarity.Text) == false)
                            continue;

                    }
                    if(comboBoxSet.Text != "Random")
                    {
                        if (checkSets(document, comboBoxSet.Text) == false)
                            continue;
                    }

                    //card met all requirements 
                    //get card url
                    var picture = document.GetElementbyId("ctl00_ctl00_ctl00_MainContent_SubContent_SubContent_cardImage");
                    string picHTML = picture.OuterHtml;
                    string imgMatch = Regex.Match(picHTML, "\".+&").ToString(); //use regex to obtain only the image source portion of the HTML
                    imgMatch = imgMatch.Substring(6); //cut off the useless chars - can maybe incorporate this into above line

                    string totalImgURL = "http://gatherer.wizards.com" + imgMatch + "type=card"; //create full URL
                    
                    pictureBoxCard.Load(totalImgURL);
                    cardFound = true;
                    return;
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
                //Console.WriteLine("Something went wrong. We didn't find the correct CMC id on the page.");
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
                //Console.WriteLine("Something went wrong. We didn't find the correct mana symbol id on the page.");
                return false;
            }
        }
        
        public int countCMCColors(HtmlAgilityPack.HtmlDocument document, List<string> passedColors = null) //TODO: CURRENTLY DOES NOT CHECK/ACCOUNT FOR MULTIPLE OF SAME MANA SYMBOL - FIX THIS
        {
            var manaRow = document.GetElementbyId("ctl00_ctl00_ctl00_MainContent_SubContent_SubContent_manaRow");
            if (manaRow != null)
            {
                var colorChildren = manaRow.ChildNodes;
                var colorList = colorChildren[3].InnerHtml.ToString();
                int webColorCount = Regex.Matches(colorList, "src=").Count; //use regex to count number of mana symbol images
                for(int j = 0; j <= 15; j++)//check for generic mana symbol
                {
                    string altWithDigit = "alt=\"" + j + "\"";
                    if (colorList.Contains(altWithDigit))
                    {
                        webColorCount -= 1;
                        break;
                    }
                }

                if(passedColors != null) // if passedColors contains colors
                {
                    foreach (string col in passedColors)
                    {
                        int numSelectedColor = Regex.Matches(colorList, col).Count; //count number of occurances of each mana symbol of the same type (ex. two swamps, 3 islands)
                        webColorCount = (webColorCount - numSelectedColor) + 1; //subtract the extras from the count, but leave one count of this color
                    }
                }
                return webColorCount;
            }
            else
            {
                //Console.WriteLine("Something went wrong. We didn't find the correct mana symbol id on the page.");
                return 0;
            }
        }

        public bool checkType(HtmlAgilityPack.HtmlDocument document, string type)
        {
            var typeRow = document.GetElementbyId("ctl00_ctl00_ctl00_MainContent_SubContent_SubContent_typeRow");
            if(typeRow != null)
            {
                string cardTypes = typeRow.InnerText.ToString();
                if (Regex.IsMatch(cardTypes, type) == true)
                    return true;
                else
                    return false;
            }
            else
            {
                //Console.WriteLine("Something went wrong. We didn't find the correct card type element on the page.");
                return false;
            }
        }
        public bool checkRarity(HtmlAgilityPack.HtmlDocument document, string rarity)
        {
            var rarityRow = document.GetElementbyId("ctl00_ctl00_ctl00_MainContent_SubContent_SubContent_rarityRow");
            if(rarityRow != null)
            {
                if (Regex.IsMatch(rarityRow.InnerText.ToString(), rarity))
                    return true;
                else
                    return false;
            }
            else
            {
                //Console.WriteLine("Something went wrong. We didn't find the correct card rarity element on the page.");
                return false;
            }
        }
        public bool checkSets(HtmlAgilityPack.HtmlDocument document, string set)
        {
            var setsRow = document.GetElementbyId("ctl00_ctl00_ctl00_MainContent_SubContent_SubContent_otherSetsValue");
            if(setsRow != null)
            {
                if (Regex.IsMatch(setsRow.InnerHtml, set))
                    return true;
                else
                    return false;
            }
            else
            {
                //Console.WriteLine("Something went wrong. We didn't find the correct card sets element on the page.");
                return false;
            }
        }
    }
}

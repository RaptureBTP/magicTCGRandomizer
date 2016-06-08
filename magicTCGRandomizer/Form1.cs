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
using System.Threading;

namespace magicTCGRandomizer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool cardFound = false;

        public void updateTextBox(string msg)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string>(textBoxOutput.AppendText), msg);
            }
            else
            {
                textBoxOutput.AppendText(msg);
            }
            //textBoxOutput.Text += msg;
        }

        public string getTextFromForm(string location)
        {
            if(location == "format")
            {
                if (InvokeRequired)
                {
                    return (string)Invoke((Func<string>)delegate
                    {
                        return comboBoxFormat.Text;
                    });
                }
                else
                    return comboBoxFormat.Text;
            }
            else if(location == "set")
            {
                if (InvokeRequired)
                {
                    return (string)Invoke((Func<string>)delegate
                    {
                        return comboBoxSet.Text;
                    });
                }
                else
                    return comboBoxSet.Text;
            }
            else if(location == "type")
            {
                if (InvokeRequired)
                {
                    return (string)Invoke((Func<string>)delegate
                    {
                        return comboBoxCardType.Text;
                    });
                }
                else
                    return comboBoxCardType.Text;
            }
            else if(location == "subtype")
                if (InvokeRequired)
                {
                    return (string)Invoke((Func<string>)delegate
                    {
                        return textBoxSubtype.Text;
                    });
                }
                else
                    return textBoxSubtype.Text;
            return "error";
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {

            Thread searchThread = new Thread(cardSearch);
            searchThread.Start();

            /*while(cardFound == false)
            {
                //loop and wait for thread to finish
            }*/ 
            
        }

        public void cardSearch()
        {
            try
            {
                var getHtmlWeb = new HtmlWeb(); //create new HtmlWeb object

                string baseURL = "http://gatherer.wizards.com/Pages/Search/Default.aspx?";
                string searchURL = baseURL;
                bool prefixed = false;

                //name
                if (textBoxName.Text != "")
                {
                    //split on word in textbox
                    string[] nameWords = textBoxName.Text.Split();

                    searchURL += "name=";

                    foreach (string name in nameWords)
                    {
                        searchURL += "+[" + name + "]";
                    }
                    prefixed = true;
                }

                //color
                if (checkBoxColorRandom.Checked != true) //if RandomCMC checkbox is not checked
                {
                    if (radioButtonAND.Checked == true)
                    {

                    }
                    else if (radioButtonOR.Checked == true)
                    {

                    }
                    else
                    {
                        var checkedColors = ColorListCheckBox.CheckedItems; //obtain collection of checked items
                        if (prefixed == true) //if there is a preceding search term in the url, add an ampersand
                            searchURL += "&";
                        searchURL += "color=|";
                        prefixed = true;

                        if (checkedColors.Contains("White"))
                            searchURL += "[W]";
                        if (checkedColors.Contains("Blue"))
                            searchURL += "[U]";
                        if (checkedColors.Contains("Black"))
                            searchURL += "[B]";
                        if (checkedColors.Contains("Red"))
                            searchURL += "[R]";
                        if (checkedColors.Contains("Green"))
                            searchURL += "[G]";
                    }
                }

                updateTextBox("Thread Start\r\n");

                //format
                //if (comboBoxFormat.Text != "Random")
                string format = getTextFromForm("format");
                if(format != "Random")
                {
                    if (prefixed == true)
                        searchURL += "&";
                    searchURL += "format=[\"" + format + "\"]";
                    prefixed = true;
                }

                //set
                string set = getTextFromForm("set");
                if (set != "Random")
                {
                    if (prefixed == true)
                        searchURL += "&";
                    searchURL += "set=[\"" + set + "\"]";
                    prefixed = true;
                }

                //type
                string type = getTextFromForm("type");
                if (type != "Random")
                {
                    if (prefixed == true) //if there is a preceding search term in the url, add an ampersand
                        searchURL += "&";
                    searchURL += "type=+[" + type + "]";
                    prefixed = true;
                }

                //subtype
                string subtype = getTextFromForm("subtype");
                if (subtype != "Random")
                {
                    if (prefixed == true)
                        searchURL += "&";
                    searchURL += "subtype=+[" + subtype + "]";
                }

                var document = getHtmlWeb.Load(searchURL);

                while(true)

                prefixed = false;

                var searchResults = document.GetElementbyId("ctl00_ctl00_ctl00_MainContent_SubContent_SubContent_searchResultsContainer");
                var cardsTable = searchResults.ChildNodes[1].ChildNodes[7].ChildNodes[1].ChildNodes[0];  //table containing the tables (each table is a card)
                //div , table , tr, td
                //children count is (actual number of results  * 2) + 1  [+1 appears to be an additional text element at the bottom? need to test]
                //test with no results

                //temp
                updateTextBox("Thread end.\r\n");
                //cardFound = true;

                //check if there are multiple pages to look through
                /*var pageControlContainer = document.GetElementbyId("ctl00_ctl00_ctl00_MainContent_SubContent_bottomPagingControlsContainer");
                if (pageControlContainer != null)
                {

                }*/
            }
            catch (Exception exp)
            {

            }
        }

        /* public bool checkCMC(HtmlAgilityPack.HtmlDocument document, string cmc)
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
        } */

        private void checkBoxColorRandom_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxColorRandom.Checked == true)
            {
                for (int i = 0; i < ColorListCheckBox.Items.Count; i++)
                {
                    ColorListCheckBox.SetItemChecked(i, false);
                }
            }
        }

        private void ColorListCheckBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkBoxColorRandom.Checked == true)
                checkBoxColorRandom.Checked = false;
        }

        private void checkBoxCMCRandom_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCMCRandom.Checked == true)
            {
                if (numericUpDownCMC.Value != 0)
                    numericUpDownCMC.Value = 0;
                checkBoxCMCRandom.Checked = true;
            }
        }

        private void numericUpDownCMC_ValueChanged(object sender, EventArgs e)
        {
            if (checkBoxCMCRandom.Checked == true)
                checkBoxCMCRandom.Checked = false;
        }
    }
}

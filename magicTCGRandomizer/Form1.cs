/*Author: Brady Ericksen
Last Edit: 7/6/2016
Version: v0.5 Alpha
*/
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
using System.Threading;

namespace magicTCGRandomizer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<String> lastResults = new List<String>();
        int lastResultIndex = -1;

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
        }

        public string getTextFromForm(string location)
        {
            if (location == "format")
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
            else if (location == "set")
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
            else if (location == "type")
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
            else if (location == "subtype")
            {
                if (InvokeRequired)
                {
                    return (string)Invoke((Func<string>)delegate
                    {
                        return textBoxSubtype.Text;
                    });
                }
                else
                    return textBoxSubtype.Text;
            }
            else if (location == "rarity")
            {
                if (InvokeRequired)
                {
                    return (string)Invoke((Func<string>)delegate
                    {
                        return comboBoxRarity.Text;
                    });
                }
                else
                    return comboBoxRarity.Text;
            }
            else if (location == "keyword")
            {
                if (InvokeRequired)
                {
                    return (string)Invoke((Func<string>)delegate
                    {
                        return textBoxKeyword.Text.ToLower();
                    });
                }
                else
                    return textBoxKeyword.Text.ToLower();
            }
            else if (location == "cmc")
            {
                if (InvokeRequired)
                {
                    return (string)Invoke((Func<string>)delegate
                    {
                        return numericUpDownCMC.Value.ToString();
                    });
                }
                else
                    return numericUpDownCMC.Value.ToString();
            }
            return "error";
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            lastResults = new List<String>();
            buttonSearch.Enabled = false;
            buttonNext.Enabled = false;
            Thread searchThread = new Thread(cardSearch);
            searchThread.Start();

            buttonSearch.Enabled = true;
            buttonNext.Enabled = true;
            buttonRotate.Enabled = true;
        }

        public void cardSearch()
        {
            try
            {
                //updateTextBox("Thread Start\r\n");
                var getHtmlWeb = new HtmlWeb(); //create new HtmlWeb object

                string baseURL = "http://gatherer.wizards.com/Pages/Search/Default.aspx?";
                string searchURL = "";
                bool prefixed = false;

                //name
                if (textBoxName.Text != "")
                {
                    //split on word in textbox
                    string[] nameWords = textBoxName.Text.Split();

                    searchURL = "name="; //+=

                    foreach (string name in nameWords)
                    {
                        searchURL += "+[" + name + "]";
                    }
                    prefixed = true;
                    updateTextBox("Name added to URL\r\n");
                }

                //color
                if (checkBoxColorRandom.Checked != true) //if RandomCMC checkbox is not checked
                {
                    var checkedColors = ColorListCheckBox.CheckedItems; //obtain collection of checked items
                    if (prefixed == true) //if there is a preceding search term in the url, add an ampersand
                        searchURL += "&";
                    searchURL += "color=";
                    prefixed = true;
                    if (radioButtonAND.Checked == true)
                    {
                        if (checkedColors.Contains("White"))
                            searchURL += "+[W]";
                        if (checkedColors.Contains("Blue"))
                            searchURL += "+[U]";
                        if (checkedColors.Contains("Black"))
                            searchURL += "+[B]";
                        if (checkedColors.Contains("Red"))
                            searchURL += "+[R]";
                        if (checkedColors.Contains("Green"))
                            searchURL += "+[G]";
                    }
                    else if(radioButtonANY.Checked == true)
                    {
                        if (checkedColors.Contains("White"))
                            searchURL += "|[W]";
                        if (checkedColors.Contains("Blue"))
                            searchURL += "|[U]";
                        if (checkedColors.Contains("Black"))
                            searchURL += "|[B]";
                        if (checkedColors.Contains("Red"))
                            searchURL += "|[R]";
                        if (checkedColors.Contains("Green"))
                            searchURL += "|[G]";
                    }
                    else if(radioButtonExclusive.Checked == true)
                    {
                        searchURL += "+@(";
                        if (checkedColors.Contains("White"))
                            searchURL += "+[W]";
                        if (checkedColors.Contains("Blue"))
                            searchURL += "+[U]";
                        if (checkedColors.Contains("Black"))
                            searchURL += "+[B]";
                        if (checkedColors.Contains("Red"))
                            searchURL += "+[R]";
                        if (checkedColors.Contains("Green"))
                            searchURL += "+[G]";
                        searchURL += ")";
                    }
                    updateTextBox("Colors added to URL\r\n");
                }

                //format
                string format = getTextFromForm("format");
                if(format != "Random")
                {
                    if (prefixed == true)
                        searchURL += "&";
                    searchURL += "format=[\"" + format + "\"]";
                    prefixed = true;
                    updateTextBox("Format added to URL\r\n");
                }

                //set
                string set = getTextFromForm("set");
                if (set != "Random")
                {
                    if (prefixed == true)
                        searchURL += "&";
                    searchURL += "set=[\"" + set + "\"]";
                    prefixed = true;
                    updateTextBox("Set added to URL\r\n");
                }

                //type
                string type = getTextFromForm("type");
                if (type != "Random")
                {
                    if (prefixed == true) //if there is a preceding search term in the url, add an ampersand
                        searchURL += "&";
                    searchURL += "type=+[" + type + "]";
                    prefixed = true;
                    updateTextBox("Type added to URL\r\n");
                }

                //subtype
                string subtype = getTextFromForm("subtype");
                if (subtype != "Random")
                {
                    if (prefixed == true)
                        searchURL += "&";
                    searchURL += "subtype=+[" + subtype + "]";
                    updateTextBox("Subtype added to URL\r\n");
                }

                string combinedURL = baseURL + searchURL;
                var document = getHtmlWeb.Load(combinedURL); //search with completed URL

                if (document != null)
                    updateTextBox("Web page found\r\n");
                else
                    updateTextBox("Web page not found and something went very wrong.\r\n");

                prefixed = false;

                if(document.GetElementbyId("ctl00_ctl00_ctl00_MainContent_SubContent_SubContent_cardComponent0") != null) //if this ID exists, its a single card page result
                {
                    updateTextBox("Found single result.\r\n");
                    if(checkBoxCMCRandom.Checked != true) 
                    {
                        if(checkCMC(document, numericUpDownCMC.Value.ToString()) == false) //if the CMC of the card does not match the desired CMC
                        {
                            updateTextBox("No match found.\r\n");
                            return;
                        }
                    }
                    if(!(getTextFromForm("rarity").Equals("Random"))) //if Rarity is not random
                    {
                        if (checkRarity(document, getTextFromForm("rarity")) == false) //if it does not match the cards rarity
                        {
                            updateTextBox("No match found.\r\n");
                            return;
                        }
                    }
                    if(!(getTextFromForm("keyword").Equals(""))) //if user entered a keyword
                    {
                        var textDetails = document.GetElementbyId("ctl00_ctl00_ctl00_MainContent_SubContent_SubContent_textRow");
                        if(!(textDetails.InnerText.ToUpper().Contains(getTextFromForm("keyword").ToUpper())))
                        {
                            updateTextBox("No match found.\r\n");
                            return;
                        }
                    }

                    //display card
                    var cardImgNode = document.GetElementbyId("ctl00_ctl00_ctl00_MainContent_SubContent_SubContent_cardImage");
                    string imgMatch = Regex.Match(cardImgNode.OuterHtml, "\".+&").ToString(); //use regex to obtain only the image source portion of the HTML
                    imgMatch = imgMatch.Substring(6); //cut off the useless chars - can maybe incorporate this into above line
                    string totalImgURL = "http://gatherer.wizards.com" + imgMatch + "type=card"; //create full URL
                    
                    pictureBoxCard.Load(totalImgURL);
                }
                else //found multiple results or no results
                {
                    List<String> compiledCardList = new List<String>();
                    updateTextBox("Found multiple results.\r\n");
                    bool loop = true;
                    int pageNum = 1;
                    int maxPageNum = 1;
                    bool foundEverything = false;
                    bool foundTotalPages = false;

                    var pageControlContainer = document.GetElementbyId("ctl00_ctl00_ctl00_MainContent_SubContent_bottomPagingControlsContainer");

                    if (foundTotalPages == false && pageControlContainer != null) //multiple pages of results
                    {
                        foundTotalPages = true;
                        int lastPageIndex = pageControlContainer.ChildNodes[1].ChildNodes.Count;
                        string lastPageLink = pageControlContainer.ChildNodes[1].ChildNodes[lastPageIndex - 1].OuterHtml.ToString();
                        string maxPageNumString = Regex.Match(lastPageLink, "(page=\\d)").ToString();
                        maxPageNum = Int32.Parse(Regex.Match(maxPageNumString, "\\d").ToString());
                    }

                    while (loop)
                    {
                        var searchResults = document.GetElementbyId("ctl00_ctl00_ctl00_MainContent_SubContent_SubContent_searchResultsContainer");

                        var cardsTable = searchResults.ChildNodes[1].ChildNodes[7].ChildNodes[1].ChildNodes[0];
                        //table containing the tables (each table is a card)
                        //div , table , tr, td
                        //children count is (actual number of results  * 2) + 1  [+1 appears to be an additional text element at the bottom? need to test]

                        bool matched = false;

                        for (int i = 0; i < cardsTable.ChildNodes.Count; i++)
                        {
                            if (cardsTable.ChildNodes[i].Name != "#text")
                            {
                                var possibleCard = cardsTable.ChildNodes[i]; //get the entire row describing the card
                                var possibleCardDetails = possibleCard.ChildNodes[1].ChildNodes[3];  //get just the description
                                var possibleCardImage = possibleCard.ChildNodes[1].ChildNodes[1]; //get just the card art
                                var cardInfo = possibleCardDetails.InnerText.ToString().Trim(); //trim description
                                List<String> words = new List<String>();
                                cardInfo = Regex.Replace(cardInfo, @"\t|\n|\r", " "); //remove newlines, tabs, and carriage returns

                                var tempWords = cardInfo.Split();
                                foreach (string word in tempWords) //?
                                {
                                    if (word != " " && word != "")
                                        words.Add(word);
                                }

                                if (checkBoxCMCRandom.Checked == false) //if CMC is not random
                                {
                                    foreach (string theWord in words)
                                    {
                                        if (theWord.Contains("("))
                                        {
                                            string cmc = Regex.Replace(theWord, "([()])", "").ToString();
                                            if (getTextFromForm("cmc").Equals(cmc))
                                                matched = true;
                                            break;
                                        }
                                    }

                                    if (matched == false)
                                        continue;

                                    matched = false;
                                }

                                if (!(getTextFromForm("rarity").Equals("Random"))) //if rarity is not random
                                {
                                    if (!(possibleCard.ChildNodes[1].ChildNodes[5].InnerHtml.Contains(getTextFromForm("rarity")))) //get portion of table that contains rarity info, then check if it contains the specified rarity term
                                        continue; //if it doesn't, continue
                                }

                                if (!(getTextFromForm("keyword").Equals(""))) //if user enetered a keyword
                                {
                                    if (!(cardInfo.Contains(getTextFromForm("keyword"))))
                                        continue;
                                }
                                string imgStringMatch = Regex.Match(possibleCardImage.InnerHtml, "img src=\".+&").ToString(); //use regex to obtain only the image source portion of the HTML
                                imgStringMatch = imgStringMatch.Substring(14); //cut off the useless chars - can maybe incorporate this into above line
                                string totalImgURL = "http://gatherer.wizards.com" + imgStringMatch + "type=card"; //create full URL
                                if (!(compiledCardList.Contains(totalImgURL)))
                                    compiledCardList.Add(totalImgURL);
                                else if(pageNum > maxPageNum + 1)
                                {
                                    foundEverything = true;
                                    break;
                                }
                            }
                        }
                        //check if there are multiple pages to look through
                        if (pageControlContainer != null && foundEverything == false)
                        {
                            document = getHtmlWeb.Load(baseURL + "page=" + pageNum.ToString() + "&" + searchURL); //load next page
                            pageNum++;
                            updateTextBox("Please wait...\r\n");
                        }
                        else
                        {
                            foundEverything = false;
                            break;
                        }
                    }
                    lastResults = compiledCardList;
                    if(!(getTextFromForm("rarity").Equals("Random")))
                        updateTextBox("NOTE: If card results show a differing rarity, they most likely have been printed in your chosen rarity in another set.\r\n");
                    updatePictureBox();
                }

            }
            catch(ArgumentOutOfRangeException argExp)
            {
                updateTextBox("No results meeting criteria found.\r\n");
                updateTextBox("Thread end\r\n");
            }
            catch (Exception exp)
            {
                updateTextBox("Something went wrong.\r\n");
                updateTextBox(exp + "\r\n");
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            pictureBoxCard.Size = new Size(223,310);
            updatePictureBox();
        }

        private void updatePictureBox()
        {
            Random rnd = new Random();
            int j = rnd.Next(0, lastResults.Count);
            if (j != lastResultIndex && lastResults.Count != 0)
                pictureBoxCard.Load(lastResults.ElementAt(j));
            lastResultIndex = j;
        }

        private void buttonRotateRight_Click(object sender, EventArgs e)
        {
            Bitmap tempBM = new Bitmap(pictureBoxCard.Image);
            tempBM.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pictureBoxCard.Image = tempBM;

            pictureBoxCard.Size = pictureBoxCard.Image.Size;
        }

        public bool checkCMC(HtmlAgilityPack.HtmlDocument document, string cmc)
        {
            string result = "";
            var CMCNode = document.GetElementbyId("ctl00_ctl00_ctl00_MainContent_SubContent_SubContent_cmcRow"); //find the CMC element via ID
            if (CMCNode != null)
                result = Regex.Match(CMCNode.InnerText, "\\d").ToString(); //regex match to find only the digit //check to make sure double digits work correctly
            else
                return false;
            if(result.Equals(cmc))
                return true;
            else
                return false;
        }

        public bool checkRarity(HtmlAgilityPack.HtmlDocument document, string rarity)
        {
            var rarityRow = document.GetElementbyId("ctl00_ctl00_ctl00_MainContent_SubContent_SubContent_rarityRow");
            if (rarityRow != null)
            {
                if (Regex.IsMatch(rarityRow.InnerText.ToString(), rarity))
                    return true;
                else
                    return false;
            }
            else
                return false;
        }

        private void checkBoxColorRandom_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxColorRandom.Checked == true)
            {
                for (int i = 0; i < ColorListCheckBox.Items.Count; i++)
                    ColorListCheckBox.SetItemChecked(i, false);
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

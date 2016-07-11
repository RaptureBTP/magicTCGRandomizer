namespace magicTCGRandomizer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblRCG = new System.Windows.Forms.Label();
            this.ColorListCheckBox = new System.Windows.Forms.CheckedListBox();
            this.LblColor = new System.Windows.Forms.Label();
            this.LblCMC = new System.Windows.Forms.Label();
            this.numericUpDownCMC = new System.Windows.Forms.NumericUpDown();
            this.LblCardType = new System.Windows.Forms.Label();
            this.checkBoxCMCRandom = new System.Windows.Forms.CheckBox();
            this.comboBoxCardType = new System.Windows.Forms.ComboBox();
            this.LblRarity = new System.Windows.Forms.Label();
            this.comboBoxRarity = new System.Windows.Forms.ComboBox();
            this.LblSet = new System.Windows.Forms.Label();
            this.comboBoxSet = new System.Windows.Forms.ComboBox();
            this.LblFormat = new System.Windows.Forms.Label();
            this.comboBoxFormat = new System.Windows.Forms.ComboBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.checkBoxColorRandom = new System.Windows.Forms.CheckBox();
            this.radioButtonAND = new System.Windows.Forms.RadioButton();
            this.radioButtonANY = new System.Windows.Forms.RadioButton();
            this.pictureBoxCard = new System.Windows.Forms.PictureBox();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.LblOutput = new System.Windows.Forms.Label();
            this.LblSubtype = new System.Windows.Forms.Label();
            this.textBoxSubtype = new System.Windows.Forms.TextBox();
            this.LblKeyword = new System.Windows.Forms.Label();
            this.textBoxKeyword = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonRotate = new System.Windows.Forms.Button();
            this.radioButtonExclusive = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCMC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCard)).BeginInit();
            this.SuspendLayout();
            // 
            // LblRCG
            // 
            this.LblRCG.AutoSize = true;
            this.LblRCG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRCG.Location = new System.Drawing.Point(12, 9);
            this.LblRCG.Name = "LblRCG";
            this.LblRCG.Size = new System.Drawing.Size(213, 20);
            this.LblRCG.TabIndex = 1;
            this.LblRCG.Text = "Random Card Generator";
            // 
            // ColorListCheckBox
            // 
            this.ColorListCheckBox.BackColor = System.Drawing.SystemColors.Control;
            this.ColorListCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColorListCheckBox.FormattingEnabled = true;
            this.ColorListCheckBox.Items.AddRange(new object[] {
            "Blue",
            "Red",
            "Green",
            "White",
            "Black",
            "Colorless"});
            this.ColorListCheckBox.Location = new System.Drawing.Point(16, 79);
            this.ColorListCheckBox.Name = "ColorListCheckBox";
            this.ColorListCheckBox.Size = new System.Drawing.Size(133, 123);
            this.ColorListCheckBox.TabIndex = 2;
            this.ColorListCheckBox.SelectedIndexChanged += new System.EventHandler(this.ColorListCheckBox_SelectedIndexChanged);
            // 
            // LblColor
            // 
            this.LblColor.AutoSize = true;
            this.LblColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblColor.Location = new System.Drawing.Point(13, 59);
            this.LblColor.Name = "LblColor";
            this.LblColor.Size = new System.Drawing.Size(51, 17);
            this.LblColor.TabIndex = 3;
            this.LblColor.Text = "Color:";
            // 
            // LblCMC
            // 
            this.LblCMC.AutoSize = true;
            this.LblCMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCMC.Location = new System.Drawing.Point(152, 59);
            this.LblCMC.Name = "LblCMC";
            this.LblCMC.Size = new System.Drawing.Size(45, 17);
            this.LblCMC.TabIndex = 4;
            this.LblCMC.Text = "CMC:";
            // 
            // numericUpDownCMC
            // 
            this.numericUpDownCMC.Location = new System.Drawing.Point(155, 79);
            this.numericUpDownCMC.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDownCMC.Name = "numericUpDownCMC";
            this.numericUpDownCMC.Size = new System.Drawing.Size(74, 22);
            this.numericUpDownCMC.TabIndex = 5;
            this.numericUpDownCMC.ValueChanged += new System.EventHandler(this.numericUpDownCMC_ValueChanged);
            // 
            // LblCardType
            // 
            this.LblCardType.AutoSize = true;
            this.LblCardType.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCardType.Location = new System.Drawing.Point(152, 108);
            this.LblCardType.Name = "LblCardType";
            this.LblCardType.Size = new System.Drawing.Size(88, 17);
            this.LblCardType.TabIndex = 6;
            this.LblCardType.Text = "Card Type:";
            // 
            // checkBoxCMCRandom
            // 
            this.checkBoxCMCRandom.AutoSize = true;
            this.checkBoxCMCRandom.Checked = true;
            this.checkBoxCMCRandom.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCMCRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCMCRandom.Location = new System.Drawing.Point(203, 57);
            this.checkBoxCMCRandom.Name = "checkBoxCMCRandom";
            this.checkBoxCMCRandom.Size = new System.Drawing.Size(77, 19);
            this.checkBoxCMCRandom.TabIndex = 7;
            this.checkBoxCMCRandom.Text = "Random";
            this.checkBoxCMCRandom.UseVisualStyleBackColor = true;
            this.checkBoxCMCRandom.CheckedChanged += new System.EventHandler(this.checkBoxCMCRandom_CheckedChanged);
            // 
            // comboBoxCardType
            // 
            this.comboBoxCardType.FormattingEnabled = true;
            this.comboBoxCardType.Items.AddRange(new object[] {
            "Random",
            "Artifact",
            "Creature",
            "Enchantment",
            "Instant",
            "Land",
            "Legendary",
            "Planeswalker",
            "Sorcery",
            "Tribal",
            "World"});
            this.comboBoxCardType.Location = new System.Drawing.Point(152, 128);
            this.comboBoxCardType.Name = "comboBoxCardType";
            this.comboBoxCardType.Size = new System.Drawing.Size(121, 24);
            this.comboBoxCardType.TabIndex = 9;
            this.comboBoxCardType.Text = "Random";
            // 
            // LblRarity
            // 
            this.LblRarity.AutoSize = true;
            this.LblRarity.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRarity.Location = new System.Drawing.Point(155, 159);
            this.LblRarity.Name = "LblRarity";
            this.LblRarity.Size = new System.Drawing.Size(56, 17);
            this.LblRarity.TabIndex = 10;
            this.LblRarity.Text = "Rarity:";
            // 
            // comboBoxRarity
            // 
            this.comboBoxRarity.FormattingEnabled = true;
            this.comboBoxRarity.Items.AddRange(new object[] {
            "Random",
            "Common",
            "Uncommon",
            "Rare",
            "Mythic"});
            this.comboBoxRarity.Location = new System.Drawing.Point(152, 176);
            this.comboBoxRarity.Name = "comboBoxRarity";
            this.comboBoxRarity.Size = new System.Drawing.Size(121, 24);
            this.comboBoxRarity.TabIndex = 11;
            this.comboBoxRarity.Text = "Random";
            // 
            // LblSet
            // 
            this.LblSet.AutoSize = true;
            this.LblSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSet.Location = new System.Drawing.Point(286, 57);
            this.LblSet.Name = "LblSet";
            this.LblSet.Size = new System.Drawing.Size(37, 17);
            this.LblSet.TabIndex = 12;
            this.LblSet.Text = "Set:";
            // 
            // comboBoxSet
            // 
            this.comboBoxSet.FormattingEnabled = true;
            this.comboBoxSet.Items.AddRange(new object[] {
            "Random",
            "Eldritch Moon",
            "Eternal Masters",
            "Shadows Over Innistrad",
            "Duel Decks: Blessed vs. Cursed",
            "Oath of the Gatewatch",
            "Commander 2015",
            "From the Vault: Angels",
            "Battle for Zendikar",
            "Duel Decks: Zendikar vs. Eldrazi",
            "Magic Origins",
            "Modern Masters 2015 Edition",
            "Dragons of Tarkir",
            "Duel Decks: Elspeth vs. Kiora",
            "Fate Reforged",
            "Commander 2014",
            "Khans of Tarkir",
            "Duel Decks: Speed vs. Cunning",
            "From the Vault: Annihilation (2014)",
            "Magic 2015 Core Set",
            "Modern Event Deck 2014",
            "Magic: The Gathering—Conspiracy",
            "Journey Into Nyx",
            "Duel Decks: Jace vs. Vraska",
            "Born of the Gods",
            "Commander 2013 Edition",
            "Theros",
            "Duel Decks: Heroes vs. Monsters",
            "From the Vault: Twenty",
            "Magic 2014 Core Set",
            "Modern Masters",
            "Dragon\'s Maze",
            "Duel Decks: Sorin vs. Tibalt",
            "Gatecrash",
            "Commander\'s Arsenal",
            "Return to Ravnica",
            "Duel Decks: Izzet vs. Golgari",
            "From the Vault: Realms",
            "Magic 2013",
            "Planechase 2012 Edition",
            "Avacyn Restored",
            "Duel Decks: Venser vs. Koth",
            "Dark Ascension",
            "Premium Deck Series: Graveborn",
            "Innistrad",
            "Duel Decks: Ajani vs. Nicol Bolas",
            "Magic 2012",
            "From the Vault: Legends",
            "Magic: The Gathering-Commander",
            "New Phyrexia",
            "Duel Decks: Knights vs. Dragons",
            "Mirrodin Besieged",
            "Scars of Mirrodin",
            "Premium Deck Series: Fire and Lightning",
            "Duel Decks: Elspeth vs. Tezzeret",
            "From the Vault: Relics",
            "Magic 2011",
            "Archenemy",
            "Rise of the Eldrazi",
            "Duel Decks: Phyrexia vs. the Coalition",
            "Worldwake",
            "Premium Deck Series: Slivers",
            "Duel Decks: Garruk vs. Liliana",
            "Zendikar",
            "Planechase",
            "From the Vault: Exiled",
            "Magic 2010",
            "Alara Reborn",
            "Duel Decks: Divine vs. Demonic",
            "Conflux",
            "Duel Decks: Jace vs. Chandra",
            "Shards of Alara",
            "From the Vault: Dragons",
            "Eventide",
            "Shadowmoor",
            "Morningtide",
            "Duel Decks: Elves vs. Goblins",
            "Lorwyn",
            "Tenth Edition",
            "Future Sight",
            "Planar Chaos",
            "Time Spiral",
            "Coldsnap",
            "Dissension",
            "Guildpact",
            "Ravnica: City of Guilds",
            "Ninth Edition",
            "Saviors of Kamigawa",
            "Betrayers of Kamigawa",
            "Champions of Kamigawa",
            "Unhinged",
            "Fifth Dawn",
            "Darksteel",
            "Mirrodin",
            "Eighth Edition",
            "Scourge",
            "Legions",
            "Onslaught",
            "Judgment",
            "Torment",
            "Odyssey",
            "Apocalypse",
            "Seventh Edition",
            "Planeshift",
            "Invasion",
            "Beatdown Box Set",
            "Starter 2000",
            "Prophecy",
            "Nemesis",
            "Battle Royale Box Set",
            "Mercadian Masques",
            "Starter 1999",
            "Urza\'s Destiny",
            "Portal Three Kingdoms",
            "Classic Sixth Edition",
            "Urza\'s Legacy",
            "Urza\'s Saga",
            "Portal Second Age",
            "Exodus",
            "Stronghold",
            "Tempest",
            "Vanguard",
            "Portal",
            "Weatherlight",
            "Fifth Edition",
            "Visions",
            "Mirage",
            "Alliances",
            "Homelands",
            "Chronicles",
            "Ice Age",
            "Fourth Edition",
            "Fallen Empires",
            "The Dark",
            "Legends",
            "Revised Edition",
            "Antiquities",
            "Arabian Nights",
            "Unlimited",
            "Limited Edition Beta",
            "Limited Edition Alpha"});
            this.comboBoxSet.Location = new System.Drawing.Point(290, 75);
            this.comboBoxSet.Name = "comboBoxSet";
            this.comboBoxSet.Size = new System.Drawing.Size(166, 24);
            this.comboBoxSet.TabIndex = 13;
            this.comboBoxSet.Text = "Random";
            // 
            // LblFormat
            // 
            this.LblFormat.AutoSize = true;
            this.LblFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFormat.Location = new System.Drawing.Point(475, 57);
            this.LblFormat.Name = "LblFormat";
            this.LblFormat.Size = new System.Drawing.Size(63, 17);
            this.LblFormat.TabIndex = 14;
            this.LblFormat.Text = "Format:";
            // 
            // comboBoxFormat
            // 
            this.comboBoxFormat.FormattingEnabled = true;
            this.comboBoxFormat.Items.AddRange(new object[] {
            "Random",
            "Standard",
            "Modern",
            "Commander",
            "Legacy",
            "Vintage"});
            this.comboBoxFormat.Location = new System.Drawing.Point(478, 75);
            this.comboBoxFormat.Name = "comboBoxFormat";
            this.comboBoxFormat.Size = new System.Drawing.Size(121, 24);
            this.comboBoxFormat.TabIndex = 15;
            this.comboBoxFormat.Text = "Random";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(76, 323);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(135, 76);
            this.buttonSearch.TabIndex = 16;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // checkBoxColorRandom
            // 
            this.checkBoxColorRandom.AutoSize = true;
            this.checkBoxColorRandom.Checked = true;
            this.checkBoxColorRandom.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxColorRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxColorRandom.Location = new System.Drawing.Point(70, 58);
            this.checkBoxColorRandom.Name = "checkBoxColorRandom";
            this.checkBoxColorRandom.Size = new System.Drawing.Size(77, 19);
            this.checkBoxColorRandom.TabIndex = 18;
            this.checkBoxColorRandom.Text = "Random";
            this.checkBoxColorRandom.UseVisualStyleBackColor = true;
            this.checkBoxColorRandom.CheckedChanged += new System.EventHandler(this.checkBoxColorRandom_CheckedChanged);
            // 
            // radioButtonAND
            // 
            this.radioButtonAND.AutoSize = true;
            this.radioButtonAND.Location = new System.Drawing.Point(16, 218);
            this.radioButtonAND.Name = "radioButtonAND";
            this.radioButtonAND.Size = new System.Drawing.Size(325, 21);
            this.radioButtonAND.TabIndex = 19;
            this.radioButtonAND.Text = "AND (must contain at least the selected colors)";
            this.radioButtonAND.UseVisualStyleBackColor = true;
            // 
            // radioButtonANY
            // 
            this.radioButtonANY.AutoSize = true;
            this.radioButtonANY.Checked = true;
            this.radioButtonANY.Location = new System.Drawing.Point(16, 245);
            this.radioButtonANY.Name = "radioButtonANY";
            this.radioButtonANY.Size = new System.Drawing.Size(270, 21);
            this.radioButtonANY.TabIndex = 21;
            this.radioButtonANY.TabStop = true;
            this.radioButtonANY.Text = "ANY (can contain any selected colors)";
            this.radioButtonANY.UseVisualStyleBackColor = true;
            // 
            // pictureBoxCard
            // 
            this.pictureBoxCard.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBoxCard.Location = new System.Drawing.Point(682, 23);
            this.pictureBoxCard.MinimumSize = new System.Drawing.Size(223, 310);
            this.pictureBoxCard.Name = "pictureBoxCard";
            this.pictureBoxCard.Size = new System.Drawing.Size(348, 376);
            this.pictureBoxCard.TabIndex = 22;
            this.pictureBoxCard.TabStop = false;
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Location = new System.Drawing.Point(414, 265);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.Size = new System.Drawing.Size(232, 130);
            this.textBoxOutput.TabIndex = 23;
            // 
            // LblOutput
            // 
            this.LblOutput.AutoSize = true;
            this.LblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblOutput.Location = new System.Drawing.Point(411, 245);
            this.LblOutput.Name = "LblOutput";
            this.LblOutput.Size = new System.Drawing.Size(67, 17);
            this.LblOutput.TabIndex = 24;
            this.LblOutput.Text = "Results:";
            // 
            // LblSubtype
            // 
            this.LblSubtype.AutoSize = true;
            this.LblSubtype.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSubtype.Location = new System.Drawing.Point(289, 108);
            this.LblSubtype.Name = "LblSubtype";
            this.LblSubtype.Size = new System.Drawing.Size(67, 17);
            this.LblSubtype.TabIndex = 25;
            this.LblSubtype.Text = "Subtype";
            // 
            // textBoxSubtype
            // 
            this.textBoxSubtype.Location = new System.Drawing.Point(289, 128);
            this.textBoxSubtype.Name = "textBoxSubtype";
            this.textBoxSubtype.Size = new System.Drawing.Size(167, 22);
            this.textBoxSubtype.TabIndex = 26;
            this.textBoxSubtype.Text = "Random";
            // 
            // LblKeyword
            // 
            this.LblKeyword.AutoSize = true;
            this.LblKeyword.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblKeyword.Location = new System.Drawing.Point(478, 106);
            this.LblKeyword.Name = "LblKeyword";
            this.LblKeyword.Size = new System.Drawing.Size(69, 17);
            this.LblKeyword.TabIndex = 27;
            this.LblKeyword.Text = "Keyword";
            // 
            // textBoxKeyword
            // 
            this.textBoxKeyword.Location = new System.Drawing.Point(478, 130);
            this.textBoxKeyword.Name = "textBoxKeyword";
            this.textBoxKeyword.Size = new System.Drawing.Size(121, 22);
            this.textBoxKeyword.TabIndex = 28;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(292, 176);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(164, 22);
            this.textBoxName.TabIndex = 29;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(289, 157);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(54, 17);
            this.labelName.TabIndex = 30;
            this.labelName.Text = "Name:";
            // 
            // buttonNext
            // 
            this.buttonNext.Enabled = false;
            this.buttonNext.Location = new System.Drawing.Point(760, 406);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 28);
            this.buttonNext.TabIndex = 31;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonRotate
            // 
            this.buttonRotate.Enabled = false;
            this.buttonRotate.Location = new System.Drawing.Point(891, 406);
            this.buttonRotate.Name = "buttonRotate";
            this.buttonRotate.Size = new System.Drawing.Size(75, 28);
            this.buttonRotate.TabIndex = 32;
            this.buttonRotate.Text = "Rotate";
            this.buttonRotate.UseVisualStyleBackColor = true;
            this.buttonRotate.Click += new System.EventHandler(this.buttonRotateRight_Click);
            // 
            // radioButtonExclusive
            // 
            this.radioButtonExclusive.AutoSize = true;
            this.radioButtonExclusive.Location = new System.Drawing.Point(16, 272);
            this.radioButtonExclusive.Name = "radioButtonExclusive";
            this.radioButtonExclusive.Size = new System.Drawing.Size(359, 21);
            this.radioButtonExclusive.TabIndex = 33;
            this.radioButtonExclusive.TabStop = true;
            this.radioButtonExclusive.Text = "ONLY (contains only the selected colors (2+ colors))";
            this.radioButtonExclusive.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 446);
            this.Controls.Add(this.radioButtonExclusive);
            this.Controls.Add(this.buttonRotate);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxKeyword);
            this.Controls.Add(this.LblKeyword);
            this.Controls.Add(this.textBoxSubtype);
            this.Controls.Add(this.LblSubtype);
            this.Controls.Add(this.LblOutput);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.pictureBoxCard);
            this.Controls.Add(this.radioButtonANY);
            this.Controls.Add(this.radioButtonAND);
            this.Controls.Add(this.checkBoxColorRandom);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.comboBoxFormat);
            this.Controls.Add(this.LblFormat);
            this.Controls.Add(this.comboBoxSet);
            this.Controls.Add(this.LblSet);
            this.Controls.Add(this.comboBoxRarity);
            this.Controls.Add(this.LblRarity);
            this.Controls.Add(this.comboBoxCardType);
            this.Controls.Add(this.checkBoxCMCRandom);
            this.Controls.Add(this.LblCardType);
            this.Controls.Add(this.numericUpDownCMC);
            this.Controls.Add(this.LblCMC);
            this.Controls.Add(this.LblColor);
            this.Controls.Add(this.ColorListCheckBox);
            this.Controls.Add(this.LblRCG);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCMC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblRCG;
        private System.Windows.Forms.CheckedListBox ColorListCheckBox;
        private System.Windows.Forms.Label LblColor;
        private System.Windows.Forms.Label LblCMC;
        private System.Windows.Forms.NumericUpDown numericUpDownCMC;
        private System.Windows.Forms.Label LblCardType;
        private System.Windows.Forms.CheckBox checkBoxCMCRandom;
        private System.Windows.Forms.ComboBox comboBoxCardType;
        private System.Windows.Forms.Label LblRarity;
        private System.Windows.Forms.ComboBox comboBoxRarity;
        private System.Windows.Forms.Label LblSet;
        private System.Windows.Forms.ComboBox comboBoxSet;
        private System.Windows.Forms.Label LblFormat;
        private System.Windows.Forms.ComboBox comboBoxFormat;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.CheckBox checkBoxColorRandom;
        private System.Windows.Forms.RadioButton radioButtonAND;
        private System.Windows.Forms.RadioButton radioButtonANY;
        private System.Windows.Forms.PictureBox pictureBoxCard;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.Label LblOutput;
        private System.Windows.Forms.Label LblSubtype;
        private System.Windows.Forms.TextBox textBoxSubtype;
        private System.Windows.Forms.Label LblKeyword;
        private System.Windows.Forms.TextBox textBoxKeyword;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonRotate;
        private System.Windows.Forms.RadioButton radioButtonExclusive;
    }
}


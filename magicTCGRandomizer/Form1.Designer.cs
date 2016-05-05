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
            this.LblRIG = new System.Windows.Forms.Label();
            this.LblRCG = new System.Windows.Forms.Label();
            this.ColorListCheckBox = new System.Windows.Forms.CheckedListBox();
            this.LblColor = new System.Windows.Forms.Label();
            this.LblCMC = new System.Windows.Forms.Label();
            this.numericUpDownCMC = new System.Windows.Forms.NumericUpDown();
            this.LblCardType = new System.Windows.Forms.Label();
            this.checkBoxCMCRandom = new System.Windows.Forms.CheckBox();
            this.checkBoxExclusiveColors = new System.Windows.Forms.CheckBox();
            this.comboBoxCardType = new System.Windows.Forms.ComboBox();
            this.LblRarity = new System.Windows.Forms.Label();
            this.comboBoxRarity = new System.Windows.Forms.ComboBox();
            this.LblSet = new System.Windows.Forms.Label();
            this.comboBoxSet = new System.Windows.Forms.ComboBox();
            this.LblFormat = new System.Windows.Forms.Label();
            this.comboBoxFormat = new System.Windows.Forms.ComboBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCMC)).BeginInit();
            this.SuspendLayout();
            // 
            // LblRIG
            // 
            this.LblRIG.AutoSize = true;
            this.LblRIG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRIG.Location = new System.Drawing.Point(12, 336);
            this.LblRIG.Name = "LblRIG";
            this.LblRIG.Size = new System.Drawing.Size(208, 20);
            this.LblRIG.TabIndex = 0;
            this.LblRIG.Text = "Random Idea Generator";
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
            "Random",
            "Blue",
            "Red",
            "Green",
            "White",
            "Black",
            "Colorless"});
            this.ColorListCheckBox.Location = new System.Drawing.Point(16, 79);
            this.ColorListCheckBox.Name = "ColorListCheckBox";
            this.ColorListCheckBox.Size = new System.Drawing.Size(133, 140);
            this.ColorListCheckBox.TabIndex = 2;
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
            this.checkBoxCMCRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCMCRandom.Location = new System.Drawing.Point(203, 57);
            this.checkBoxCMCRandom.Name = "checkBoxCMCRandom";
            this.checkBoxCMCRandom.Size = new System.Drawing.Size(77, 19);
            this.checkBoxCMCRandom.TabIndex = 7;
            this.checkBoxCMCRandom.Text = "Random";
            this.checkBoxCMCRandom.UseVisualStyleBackColor = true;
            // 
            // checkBoxExclusiveColors
            // 
            this.checkBoxExclusiveColors.AutoSize = true;
            this.checkBoxExclusiveColors.Location = new System.Drawing.Point(16, 217);
            this.checkBoxExclusiveColors.Name = "checkBoxExclusiveColors";
            this.checkBoxExclusiveColors.Size = new System.Drawing.Size(132, 21);
            this.checkBoxExclusiveColors.TabIndex = 8;
            this.checkBoxExclusiveColors.Text = "Exclusive Colors";
            this.checkBoxExclusiveColors.UseVisualStyleBackColor = true;
            // 
            // comboBoxCardType
            // 
            this.comboBoxCardType.FormattingEnabled = true;
            this.comboBoxCardType.Items.AddRange(new object[] {
            "Random",
            "Artifact",
            "Conspiracy",
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
            "Shadows Over Innistrad",
            "Oath of the Gatewatch",
            "Battle for Zendikar",
            "Dragons of Tarkir",
            "Fate Reforged",
            "Khans of Tarkir",
            "Journey Into Nyx",
            "Born of the Gods",
            "Theros",
            "Dragon\'s Maze",
            "Gatecrash",
            "Return to Ravnica",
            "Avacyn Restored",
            "Dark Ascension",
            "Innistrad",
            "New Phyrexia",
            "Mirrodin Besieged",
            "Scars of Mirrodin",
            "Rise of the Eldrazi",
            "Worldwake",
            "Zendikar",
            "Alara Reborn",
            "Conflux",
            "Shards of Alara",
            "Eventide",
            "Shadowmoor",
            "Morningtide",
            "Lorwyn",
            "Future Sight",
            "Planar Chaos",
            "Time Spiral",
            "Dissension",
            "Guildpact",
            "Ravnica: City of Guilds",
            "Saviors of Kamigawa",
            "Betrayers of Kamigawa",
            "Champions of Kamigawa",
            "Fifth Dawn",
            "Darksteel",
            "Mirrodin"});
            this.comboBoxSet.Location = new System.Drawing.Point(290, 75);
            this.comboBoxSet.Name = "comboBoxSet";
            this.comboBoxSet.Size = new System.Drawing.Size(132, 24);
            this.comboBoxSet.TabIndex = 13;
            // 
            // LblFormat
            // 
            this.LblFormat.AutoSize = true;
            this.LblFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFormat.Location = new System.Drawing.Point(287, 108);
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
            this.comboBoxFormat.Location = new System.Drawing.Point(290, 126);
            this.comboBoxFormat.Name = "comboBoxFormat";
            this.comboBoxFormat.Size = new System.Drawing.Size(121, 24);
            this.comboBoxFormat.TabIndex = 15;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(16, 265);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 16;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(465, 12);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(250, 250);
            this.webBrowser1.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 624);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.comboBoxFormat);
            this.Controls.Add(this.LblFormat);
            this.Controls.Add(this.comboBoxSet);
            this.Controls.Add(this.LblSet);
            this.Controls.Add(this.comboBoxRarity);
            this.Controls.Add(this.LblRarity);
            this.Controls.Add(this.comboBoxCardType);
            this.Controls.Add(this.checkBoxExclusiveColors);
            this.Controls.Add(this.checkBoxCMCRandom);
            this.Controls.Add(this.LblCardType);
            this.Controls.Add(this.numericUpDownCMC);
            this.Controls.Add(this.LblCMC);
            this.Controls.Add(this.LblColor);
            this.Controls.Add(this.ColorListCheckBox);
            this.Controls.Add(this.LblRCG);
            this.Controls.Add(this.LblRIG);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCMC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblRIG;
        private System.Windows.Forms.Label LblRCG;
        private System.Windows.Forms.CheckedListBox ColorListCheckBox;
        private System.Windows.Forms.Label LblColor;
        private System.Windows.Forms.Label LblCMC;
        private System.Windows.Forms.NumericUpDown numericUpDownCMC;
        private System.Windows.Forms.Label LblCardType;
        private System.Windows.Forms.CheckBox checkBoxCMCRandom;
        private System.Windows.Forms.CheckBox checkBoxExclusiveColors;
        private System.Windows.Forms.ComboBox comboBoxCardType;
        private System.Windows.Forms.Label LblRarity;
        private System.Windows.Forms.ComboBox comboBoxRarity;
        private System.Windows.Forms.Label LblSet;
        private System.Windows.Forms.ComboBox comboBoxSet;
        private System.Windows.Forms.Label LblFormat;
        private System.Windows.Forms.ComboBox comboBoxFormat;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}


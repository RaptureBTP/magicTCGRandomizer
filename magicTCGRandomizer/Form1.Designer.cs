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
            this.radioButtonOR = new System.Windows.Forms.RadioButton();
            this.radioButtonANY = new System.Windows.Forms.RadioButton();
            this.pictureBoxCard = new System.Windows.Forms.PictureBox();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.LblOutput = new System.Windows.Forms.Label();
            this.LblSubtype = new System.Windows.Forms.Label();
            this.textBoxSubtype = new System.Windows.Forms.TextBox();
            this.LblKeyword = new System.Windows.Forms.Label();
            this.textBoxKeyword = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCMC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCard)).BeginInit();
            this.SuspendLayout();
            // 
            // LblRIG
            // 
            this.LblRIG.AutoSize = true;
            this.LblRIG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRIG.Location = new System.Drawing.Point(12, 362);
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
            "Mythic Rare"});
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
            this.comboBoxSet.Text = "Random";
            // 
            // LblFormat
            // 
            this.LblFormat.AutoSize = true;
            this.LblFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFormat.Location = new System.Drawing.Point(430, 57);
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
            this.comboBoxFormat.Location = new System.Drawing.Point(433, 75);
            this.comboBoxFormat.Name = "comboBoxFormat";
            this.comboBoxFormat.Size = new System.Drawing.Size(121, 24);
            this.comboBoxFormat.TabIndex = 15;
            this.comboBoxFormat.Text = "Random";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(12, 310);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 16;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // checkBoxColorRandom
            // 
            this.checkBoxColorRandom.AutoSize = true;
            this.checkBoxColorRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxColorRandom.Location = new System.Drawing.Point(70, 58);
            this.checkBoxColorRandom.Name = "checkBoxColorRandom";
            this.checkBoxColorRandom.Size = new System.Drawing.Size(77, 19);
            this.checkBoxColorRandom.TabIndex = 18;
            this.checkBoxColorRandom.Text = "Random";
            this.checkBoxColorRandom.UseVisualStyleBackColor = true;
            // 
            // radioButtonAND
            // 
            this.radioButtonAND.AutoSize = true;
            this.radioButtonAND.Location = new System.Drawing.Point(16, 218);
            this.radioButtonAND.Name = "radioButtonAND";
            this.radioButtonAND.Size = new System.Drawing.Size(239, 21);
            this.radioButtonAND.TabIndex = 19;
            this.radioButtonAND.TabStop = true;
            this.radioButtonAND.Text = "AND (must be all checked colors)";
            this.radioButtonAND.UseVisualStyleBackColor = true;
            // 
            // radioButtonOR
            // 
            this.radioButtonOR.AutoSize = true;
            this.radioButtonOR.Location = new System.Drawing.Point(16, 246);
            this.radioButtonOR.Name = "radioButtonOR";
            this.radioButtonOR.Size = new System.Drawing.Size(322, 21);
            this.radioButtonOR.TabIndex = 20;
            this.radioButtonOR.TabStop = true;
            this.radioButtonOR.Text = "OR (can be any one color of the above colors)";
            this.radioButtonOR.UseVisualStyleBackColor = true;
            // 
            // radioButtonANY
            // 
            this.radioButtonANY.AutoSize = true;
            this.radioButtonANY.Location = new System.Drawing.Point(16, 274);
            this.radioButtonANY.Name = "radioButtonANY";
            this.radioButtonANY.Size = new System.Drawing.Size(336, 21);
            this.radioButtonANY.TabIndex = 21;
            this.radioButtonANY.TabStop = true;
            this.radioButtonANY.Text = "ANY (can be any combination of selected colors)";
            this.radioButtonANY.UseVisualStyleBackColor = true;
            // 
            // pictureBoxCard
            // 
            this.pictureBoxCard.Location = new System.Drawing.Point(616, 23);
            this.pictureBoxCard.MaximumSize = new System.Drawing.Size(400, 400);
            this.pictureBoxCard.MinimumSize = new System.Drawing.Size(223, 310);
            this.pictureBoxCard.Name = "pictureBoxCard";
            this.pictureBoxCard.Size = new System.Drawing.Size(348, 376);
            this.pictureBoxCard.TabIndex = 22;
            this.pictureBoxCard.TabStop = false;
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Location = new System.Drawing.Point(373, 205);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.Size = new System.Drawing.Size(232, 130);
            this.textBoxOutput.TabIndex = 23;
            // 
            // LblOutput
            // 
            this.LblOutput.AutoSize = true;
            this.LblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblOutput.Location = new System.Drawing.Point(370, 185);
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
            this.textBoxSubtype.Size = new System.Drawing.Size(133, 22);
            this.textBoxSubtype.TabIndex = 26;
            this.textBoxSubtype.Text = "Random";
            // 
            // LblKeyword
            // 
            this.LblKeyword.AutoSize = true;
            this.LblKeyword.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblKeyword.Location = new System.Drawing.Point(433, 106);
            this.LblKeyword.Name = "LblKeyword";
            this.LblKeyword.Size = new System.Drawing.Size(69, 17);
            this.LblKeyword.TabIndex = 27;
            this.LblKeyword.Text = "Keyword";
            // 
            // textBoxKeyword
            // 
            this.textBoxKeyword.Location = new System.Drawing.Point(433, 130);
            this.textBoxKeyword.Name = "textBoxKeyword";
            this.textBoxKeyword.Size = new System.Drawing.Size(121, 22);
            this.textBoxKeyword.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 681);
            this.Controls.Add(this.textBoxKeyword);
            this.Controls.Add(this.LblKeyword);
            this.Controls.Add(this.textBoxSubtype);
            this.Controls.Add(this.LblSubtype);
            this.Controls.Add(this.LblOutput);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.pictureBoxCard);
            this.Controls.Add(this.radioButtonANY);
            this.Controls.Add(this.radioButtonOR);
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
            this.Controls.Add(this.LblRIG);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCMC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCard)).EndInit();
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
        private System.Windows.Forms.RadioButton radioButtonOR;
        private System.Windows.Forms.RadioButton radioButtonANY;
        private System.Windows.Forms.PictureBox pictureBoxCard;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.Label LblOutput;
        private System.Windows.Forms.Label LblSubtype;
        private System.Windows.Forms.TextBox textBoxSubtype;
        private System.Windows.Forms.Label LblKeyword;
        private System.Windows.Forms.TextBox textBoxKeyword;
    }
}


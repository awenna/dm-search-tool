namespace DMCardDBGUI
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ColorSelectionMode = new System.Windows.Forms.ComboBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.Nature = new System.Windows.Forms.CheckBox();
            this.Fire = new System.Windows.Forms.CheckBox();
            this.Darkness = new System.Windows.Forms.CheckBox();
            this.Water = new System.Windows.Forms.CheckBox();
            this.Light = new System.Windows.Forms.CheckBox();
            this.Creatures = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Evolutions = new System.Windows.Forms.CheckBox();
            this.Spells = new System.Windows.Forms.CheckBox();
            this.ManaCost = new System.Windows.Forms.GroupBox();
            this.MaxCostLabel = new System.Windows.Forms.Label();
            this.MinCostLabel = new System.Windows.Forms.Label();
            this.MaxCost = new System.Windows.Forms.TrackBar();
            this.MinCost = new System.Windows.Forms.TrackBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CardDisplay = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TipLabel = new System.Windows.Forms.Label();
            this.RuleSearchLabel = new System.Windows.Forms.Label();
            this.RuleSearch = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.FilterReminder = new System.Windows.Forms.CheckBox();
            this.FilterFlavor = new System.Windows.Forms.CheckBox();
            this.Count = new System.Windows.Forms.Label();
            this.Power = new System.Windows.Forms.GroupBox();
            this.MaxPowerLabel = new System.Windows.Forms.Label();
            this.MinPowerLabel = new System.Windows.Forms.Label();
            this.MaxPower = new System.Windows.Forms.TrackBar();
            this.MinPower = new System.Windows.Forms.TrackBar();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.ManaCost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinCost)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.Power.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxPower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinPower)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ColorSelectionMode);
            this.groupBox1.Controls.Add(this.checkBox6);
            this.groupBox1.Controls.Add(this.Nature);
            this.groupBox1.Controls.Add(this.Fire);
            this.groupBox1.Controls.Add(this.Darkness);
            this.groupBox1.Controls.Add(this.Water);
            this.groupBox1.Controls.Add(this.Light);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 139);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Color";
            // 
            // ColorSelectionMode
            // 
            this.ColorSelectionMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ColorSelectionMode.Enabled = false;
            this.ColorSelectionMode.FormattingEnabled = true;
            this.ColorSelectionMode.Items.AddRange(new object[] {
            "Including these colors",
            "At most these colors"});
            this.ColorSelectionMode.Location = new System.Drawing.Point(108, 92);
            this.ColorSelectionMode.Name = "ColorSelectionMode";
            this.ColorSelectionMode.Size = new System.Drawing.Size(121, 21);
            this.ColorSelectionMode.TabIndex = 8;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Enabled = false;
            this.checkBox6.Location = new System.Drawing.Point(108, 20);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(71, 17);
            this.checkBox6.TabIndex = 5;
            this.checkBox6.Text = "Multicolor";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // Nature
            // 
            this.Nature.AutoSize = true;
            this.Nature.Location = new System.Drawing.Point(7, 116);
            this.Nature.Name = "Nature";
            this.Nature.Size = new System.Drawing.Size(58, 17);
            this.Nature.TabIndex = 4;
            this.Nature.Text = "Nature";
            this.Nature.UseVisualStyleBackColor = true;
            this.Nature.CheckedChanged += new System.EventHandler(this.UpdateSearch);
            // 
            // Fire
            // 
            this.Fire.AutoSize = true;
            this.Fire.Location = new System.Drawing.Point(7, 92);
            this.Fire.Name = "Fire";
            this.Fire.Size = new System.Drawing.Size(43, 17);
            this.Fire.TabIndex = 3;
            this.Fire.Text = "Fire";
            this.Fire.UseVisualStyleBackColor = true;
            this.Fire.CheckedChanged += new System.EventHandler(this.UpdateSearch);
            // 
            // Darkness
            // 
            this.Darkness.AutoSize = true;
            this.Darkness.Location = new System.Drawing.Point(7, 68);
            this.Darkness.Name = "Darkness";
            this.Darkness.Size = new System.Drawing.Size(71, 17);
            this.Darkness.TabIndex = 2;
            this.Darkness.Text = "Darkness";
            this.Darkness.UseVisualStyleBackColor = true;
            this.Darkness.CheckedChanged += new System.EventHandler(this.UpdateSearch);
            // 
            // Water
            // 
            this.Water.AutoSize = true;
            this.Water.Location = new System.Drawing.Point(7, 44);
            this.Water.Name = "Water";
            this.Water.Size = new System.Drawing.Size(55, 17);
            this.Water.TabIndex = 1;
            this.Water.Text = "Water";
            this.Water.UseVisualStyleBackColor = true;
            this.Water.CheckedChanged += new System.EventHandler(this.UpdateSearch);
            // 
            // Light
            // 
            this.Light.AutoSize = true;
            this.Light.Location = new System.Drawing.Point(7, 20);
            this.Light.Name = "Light";
            this.Light.Size = new System.Drawing.Size(49, 17);
            this.Light.TabIndex = 0;
            this.Light.Text = "Light";
            this.Light.UseVisualStyleBackColor = true;
            this.Light.CheckedChanged += new System.EventHandler(this.UpdateSearch);
            // 
            // Creatures
            // 
            this.Creatures.AutoSize = true;
            this.Creatures.Checked = true;
            this.Creatures.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Creatures.Location = new System.Drawing.Point(6, 19);
            this.Creatures.Name = "Creatures";
            this.Creatures.Size = new System.Drawing.Size(71, 17);
            this.Creatures.TabIndex = 3;
            this.Creatures.Text = "Creatures";
            this.Creatures.UseVisualStyleBackColor = true;
            this.Creatures.CheckedChanged += new System.EventHandler(this.UpdateSearch);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Evolutions);
            this.groupBox2.Controls.Add(this.Spells);
            this.groupBox2.Controls.Add(this.Creatures);
            this.groupBox2.Location = new System.Drawing.Point(3, 142);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(236, 114);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Type";
            // 
            // Evolutions
            // 
            this.Evolutions.AutoSize = true;
            this.Evolutions.Checked = true;
            this.Evolutions.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Evolutions.Location = new System.Drawing.Point(7, 67);
            this.Evolutions.Name = "Evolutions";
            this.Evolutions.Size = new System.Drawing.Size(75, 17);
            this.Evolutions.TabIndex = 5;
            this.Evolutions.Text = "Evolutions";
            this.Evolutions.UseVisualStyleBackColor = true;
            this.Evolutions.CheckedChanged += new System.EventHandler(this.UpdateSearch);
            // 
            // Spells
            // 
            this.Spells.AutoSize = true;
            this.Spells.Checked = true;
            this.Spells.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Spells.Location = new System.Drawing.Point(7, 43);
            this.Spells.Name = "Spells";
            this.Spells.Size = new System.Drawing.Size(54, 17);
            this.Spells.TabIndex = 4;
            this.Spells.Text = "Spells";
            this.Spells.UseVisualStyleBackColor = true;
            this.Spells.CheckedChanged += new System.EventHandler(this.UpdateSearch);
            // 
            // ManaCost
            // 
            this.ManaCost.Controls.Add(this.MaxCostLabel);
            this.ManaCost.Controls.Add(this.MinCostLabel);
            this.ManaCost.Controls.Add(this.MaxCost);
            this.ManaCost.Controls.Add(this.MinCost);
            this.ManaCost.Location = new System.Drawing.Point(3, 262);
            this.ManaCost.Name = "ManaCost";
            this.ManaCost.Size = new System.Drawing.Size(196, 144);
            this.ManaCost.TabIndex = 5;
            this.ManaCost.TabStop = false;
            this.ManaCost.Text = "ManaCost";
            // 
            // MaxCostLabel
            // 
            this.MaxCostLabel.AutoSize = true;
            this.MaxCostLabel.Location = new System.Drawing.Point(105, 125);
            this.MaxCostLabel.Name = "MaxCostLabel";
            this.MaxCostLabel.Size = new System.Drawing.Size(74, 13);
            this.MaxCostLabel.TabIndex = 3;
            this.MaxCostLabel.Text = "MaxCostLabel";
            // 
            // MinCostLabel
            // 
            this.MinCostLabel.AutoSize = true;
            this.MinCostLabel.Location = new System.Drawing.Point(30, 125);
            this.MinCostLabel.Name = "MinCostLabel";
            this.MinCostLabel.Size = new System.Drawing.Size(71, 13);
            this.MinCostLabel.TabIndex = 2;
            this.MinCostLabel.Text = "MinCostLabel";
            // 
            // MaxCost
            // 
            this.MaxCost.Location = new System.Drawing.Point(7, 71);
            this.MaxCost.Maximum = 13;
            this.MaxCost.Minimum = 1;
            this.MaxCost.Name = "MaxCost";
            this.MaxCost.Size = new System.Drawing.Size(181, 45);
            this.MaxCost.TabIndex = 1;
            this.MaxCost.Value = 13;
            this.MaxCost.ValueChanged += new System.EventHandler(this.UpdateSearch);
            // 
            // MinCost
            // 
            this.MinCost.Location = new System.Drawing.Point(7, 20);
            this.MinCost.Maximum = 13;
            this.MinCost.Minimum = 1;
            this.MinCost.Name = "MinCost";
            this.MinCost.Size = new System.Drawing.Size(181, 45);
            this.MinCost.TabIndex = 0;
            this.MinCost.Value = 1;
            this.MinCost.ValueChanged += new System.EventHandler(this.UpdateSearch);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.CardDisplay);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(485, 661);
            this.panel1.TabIndex = 6;
            // 
            // CardDisplay
            // 
            this.CardDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CardDisplay.Location = new System.Drawing.Point(0, 0);
            this.CardDisplay.Name = "CardDisplay";
            this.CardDisplay.Size = new System.Drawing.Size(482, 661);
            this.CardDisplay.TabIndex = 0;
            this.CardDisplay.Text = "";
            // 
            // panel2
            // 
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Controls.Add(this.TipLabel);
            this.panel2.Controls.Add(this.RuleSearchLabel);
            this.panel2.Controls.Add(this.RuleSearch);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.NameLabel);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.Power);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.ManaCost);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(479, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(405, 661);
            this.panel2.TabIndex = 8;
            // 
            // TipLabel
            // 
            this.TipLabel.AutoSize = true;
            this.TipLabel.Location = new System.Drawing.Point(9, 606);
            this.TipLabel.Name = "TipLabel";
            this.TipLabel.Size = new System.Drawing.Size(391, 13);
            this.TipLabel.TabIndex = 12;
            this.TipLabel.Text = "Elements are joined by AND unless OR or NOT are used. Brackets create blocks.";
            // 
            // RuleSearchLabel
            // 
            this.RuleSearchLabel.AutoSize = true;
            this.RuleSearchLabel.Location = new System.Drawing.Point(10, 456);
            this.RuleSearchLabel.Name = "RuleSearchLabel";
            this.RuleSearchLabel.Size = new System.Drawing.Size(89, 13);
            this.RuleSearchLabel.TabIndex = 11;
            this.RuleSearchLabel.Text = "Rules text search";
            // 
            // RuleSearch
            // 
            this.RuleSearch.Location = new System.Drawing.Point(12, 472);
            this.RuleSearch.Multiline = true;
            this.RuleSearch.Name = "RuleSearch";
            this.RuleSearch.Size = new System.Drawing.Size(373, 131);
            this.RuleSearch.TabIndex = 10;
            this.RuleSearch.Text = "ex: (destroy OR (return hand)) creature";
            this.RuleSearch.TextChanged += new System.EventHandler(this.RuleSearch_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(12, 429);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(373, 20);
            this.textBox1.TabIndex = 9;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(9, 413);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(70, 13);
            this.NameLabel.TabIndex = 8;
            this.NameLabel.Text = "Name search";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.FilterReminder);
            this.panel3.Controls.Add(this.FilterFlavor);
            this.panel3.Controls.Add(this.Count);
            this.panel3.Location = new System.Drawing.Point(245, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(140, 104);
            this.panel3.TabIndex = 7;
            // 
            // FilterReminder
            // 
            this.FilterReminder.AutoSize = true;
            this.FilterReminder.Checked = true;
            this.FilterReminder.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FilterReminder.Location = new System.Drawing.Point(7, 59);
            this.FilterReminder.Name = "FilterReminder";
            this.FilterReminder.Size = new System.Drawing.Size(111, 17);
            this.FilterReminder.TabIndex = 2;
            this.FilterReminder.Text = "Filter reminder text";
            this.FilterReminder.UseVisualStyleBackColor = true;
            this.FilterReminder.CheckedChanged += new System.EventHandler(this.UpdateSearch);
            // 
            // FilterFlavor
            // 
            this.FilterFlavor.AutoSize = true;
            this.FilterFlavor.Checked = true;
            this.FilterFlavor.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FilterFlavor.Enabled = false;
            this.FilterFlavor.Location = new System.Drawing.Point(7, 35);
            this.FilterFlavor.Name = "FilterFlavor";
            this.FilterFlavor.Size = new System.Drawing.Size(97, 17);
            this.FilterFlavor.TabIndex = 1;
            this.FilterFlavor.Text = "Filter flavor text";
            this.FilterFlavor.UseVisualStyleBackColor = true;
            // 
            // Count
            // 
            this.Count.AutoSize = true;
            this.Count.Location = new System.Drawing.Point(4, 11);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(35, 13);
            this.Count.TabIndex = 0;
            this.Count.Text = "Count";
            // 
            // Power
            // 
            this.Power.Controls.Add(this.MaxPowerLabel);
            this.Power.Controls.Add(this.MinPowerLabel);
            this.Power.Controls.Add(this.MaxPower);
            this.Power.Controls.Add(this.MinPower);
            this.Power.Location = new System.Drawing.Point(205, 262);
            this.Power.Name = "Power";
            this.Power.Size = new System.Drawing.Size(197, 144);
            this.Power.TabIndex = 6;
            this.Power.TabStop = false;
            this.Power.Text = "Power";
            // 
            // MaxPowerLabel
            // 
            this.MaxPowerLabel.AutoSize = true;
            this.MaxPowerLabel.Location = new System.Drawing.Point(116, 124);
            this.MaxPowerLabel.Name = "MaxPowerLabel";
            this.MaxPowerLabel.Size = new System.Drawing.Size(83, 13);
            this.MaxPowerLabel.TabIndex = 3;
            this.MaxPowerLabel.Text = "MaxPowerLabel";
            // 
            // MinPowerLabel
            // 
            this.MinPowerLabel.AutoSize = true;
            this.MinPowerLabel.Location = new System.Drawing.Point(44, 125);
            this.MinPowerLabel.Name = "MinPowerLabel";
            this.MinPowerLabel.Size = new System.Drawing.Size(80, 13);
            this.MinPowerLabel.TabIndex = 2;
            this.MinPowerLabel.Text = "MinPowerLabel";
            // 
            // MaxPower
            // 
            this.MaxPower.Location = new System.Drawing.Point(7, 71);
            this.MaxPower.Maximum = 20;
            this.MaxPower.Minimum = 1;
            this.MaxPower.Name = "MaxPower";
            this.MaxPower.Size = new System.Drawing.Size(181, 45);
            this.MaxPower.TabIndex = 1;
            this.MaxPower.Value = 20;
            this.MaxPower.Scroll += new System.EventHandler(this.UpdateSearch);
            // 
            // MinPower
            // 
            this.MinPower.Location = new System.Drawing.Point(7, 20);
            this.MinPower.Maximum = 20;
            this.MinPower.Minimum = 1;
            this.MinPower.Name = "MinPower";
            this.MinPower.Size = new System.Drawing.Size(181, 45);
            this.MinPower.TabIndex = 0;
            this.MinPower.Value = 1;
            this.MinPower.Scroll += new System.EventHandler(this.UpdateSearch);
            // 
            // panel4
            // 
            this.panel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(884, 661);
            this.panel4.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Database Search";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ManaCost.ResumeLayout(false);
            this.ManaCost.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinCost)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.Power.ResumeLayout(false);
            this.Power.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxPower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinPower)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox ColorSelectionMode;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox Nature;
        private System.Windows.Forms.CheckBox Fire;
        private System.Windows.Forms.CheckBox Darkness;
        private System.Windows.Forms.CheckBox Water;
        private System.Windows.Forms.CheckBox Light;
        private System.Windows.Forms.CheckBox Creatures;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox Spells;
        private System.Windows.Forms.GroupBox ManaCost;
        private System.Windows.Forms.TrackBar MinCost;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TrackBar MaxCost;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox Evolutions;
        private System.Windows.Forms.GroupBox Power;
        private System.Windows.Forms.TrackBar MaxPower;
        private System.Windows.Forms.TrackBar MinPower;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label Count;
        private System.Windows.Forms.RichTextBox CardDisplay;
        private System.Windows.Forms.CheckBox FilterReminder;
        private System.Windows.Forms.CheckBox FilterFlavor;
        private System.Windows.Forms.Label MaxCostLabel;
        private System.Windows.Forms.Label MinCostLabel;
        private System.Windows.Forms.Label MaxPowerLabel;
        private System.Windows.Forms.Label MinPowerLabel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label TipLabel;
        private System.Windows.Forms.Label RuleSearchLabel;
        private System.Windows.Forms.TextBox RuleSearch;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label NameLabel;
    }
}


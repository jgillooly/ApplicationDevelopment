namespace Cool_RPG
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            StrengthLabel = new Label();
            DexterityLabel = new Label();
            ConstitutionLabel = new Label();
            IntelligenceLabel = new Label();
            WisdomLabel = new Label();
            CharismaLabel = new Label();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            numericUpDown3 = new NumericUpDown();
            numericUpDown4 = new NumericUpDown();
            numericUpDown5 = new NumericUpDown();
            numericUpDown6 = new NumericUpDown();
            ConstitutionDisplay = new Label();
            DexterityDisplay = new Label();
            StrengthDisplay = new Label();
            IntelligenceDisplay = new Label();
            WisdomDisplay = new Label();
            CharismaDisplay = new Label();
            PointsLabel = new Label();
            PointsDisplay = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown6).BeginInit();
            SuspendLayout();
            // 
            // StrengthLabel
            // 
            StrengthLabel.AutoSize = true;
            StrengthLabel.Location = new Point(419, 65);
            StrengthLabel.Name = "StrengthLabel";
            StrengthLabel.Size = new Size(91, 30);
            StrengthLabel.TabIndex = 0;
            StrengthLabel.Text = "Strength";
            // 
            // DexterityLabel
            // 
            DexterityLabel.AutoSize = true;
            DexterityLabel.Location = new Point(419, 106);
            DexterityLabel.Name = "DexterityLabel";
            DexterityLabel.Size = new Size(96, 30);
            DexterityLabel.TabIndex = 1;
            DexterityLabel.Text = "Dexterity";
            // 
            // ConstitutionLabel
            // 
            ConstitutionLabel.AutoSize = true;
            ConstitutionLabel.Location = new Point(419, 147);
            ConstitutionLabel.Name = "ConstitutionLabel";
            ConstitutionLabel.Size = new Size(126, 30);
            ConstitutionLabel.TabIndex = 2;
            ConstitutionLabel.Text = "Constitution";
            // 
            // IntelligenceLabel
            // 
            IntelligenceLabel.AutoSize = true;
            IntelligenceLabel.Location = new Point(419, 188);
            IntelligenceLabel.Name = "IntelligenceLabel";
            IntelligenceLabel.Size = new Size(120, 30);
            IntelligenceLabel.TabIndex = 3;
            IntelligenceLabel.Text = "Intelligence";
            // 
            // WisdomLabel
            // 
            WisdomLabel.AutoSize = true;
            WisdomLabel.Location = new Point(419, 229);
            WisdomLabel.Name = "WisdomLabel";
            WisdomLabel.Size = new Size(89, 30);
            WisdomLabel.TabIndex = 4;
            WisdomLabel.Text = "Wisdom";
            // 
            // CharismaLabel
            // 
            CharismaLabel.AutoSize = true;
            CharismaLabel.Location = new Point(419, 270);
            CharismaLabel.Name = "CharismaLabel";
            CharismaLabel.Size = new Size(99, 30);
            CharismaLabel.TabIndex = 5;
            CharismaLabel.Text = "Charisma";
            CharismaLabel.Click += label6_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(356, 65);
            numericUpDown1.Minimum = new decimal(new int[] { 9, 0, 0, int.MinValue });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(57, 35);
            numericUpDown1.TabIndex = 6;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(356, 106);
            numericUpDown2.Minimum = new decimal(new int[] { 9, 0, 0, int.MinValue });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(57, 35);
            numericUpDown2.TabIndex = 7;
            numericUpDown2.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(356, 147);
            numericUpDown3.Minimum = new decimal(new int[] { 9, 0, 0, int.MinValue });
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(57, 35);
            numericUpDown3.TabIndex = 8;
            numericUpDown3.ValueChanged += numericUpDown3_ValueChanged;
            // 
            // numericUpDown4
            // 
            numericUpDown4.Location = new Point(356, 188);
            numericUpDown4.Minimum = new decimal(new int[] { 9, 0, 0, int.MinValue });
            numericUpDown4.Name = "numericUpDown4";
            numericUpDown4.Size = new Size(57, 35);
            numericUpDown4.TabIndex = 9;
            numericUpDown4.ValueChanged += numericUpDown4_ValueChanged;
            // 
            // numericUpDown5
            // 
            numericUpDown5.Location = new Point(356, 229);
            numericUpDown5.Minimum = new decimal(new int[] { 9, 0, 0, int.MinValue });
            numericUpDown5.Name = "numericUpDown5";
            numericUpDown5.Size = new Size(57, 35);
            numericUpDown5.TabIndex = 10;
            numericUpDown5.ValueChanged += numericUpDown5_ValueChanged;
            // 
            // numericUpDown6
            // 
            numericUpDown6.Location = new Point(356, 270);
            numericUpDown6.Minimum = new decimal(new int[] { 9, 0, 0, int.MinValue });
            numericUpDown6.Name = "numericUpDown6";
            numericUpDown6.Size = new Size(57, 35);
            numericUpDown6.TabIndex = 11;
            numericUpDown6.ValueChanged += numericUpDown6_ValueChanged;
            // 
            // ConstitutionDisplay
            // 
            ConstitutionDisplay.AutoSize = true;
            ConstitutionDisplay.Location = new Point(580, 147);
            ConstitutionDisplay.Name = "ConstitutionDisplay";
            ConstitutionDisplay.Size = new Size(24, 30);
            ConstitutionDisplay.TabIndex = 12;
            ConstitutionDisplay.Text = "0";
            // 
            // DexterityDisplay
            // 
            DexterityDisplay.AutoSize = true;
            DexterityDisplay.Location = new Point(580, 106);
            DexterityDisplay.Name = "DexterityDisplay";
            DexterityDisplay.Size = new Size(24, 30);
            DexterityDisplay.TabIndex = 13;
            DexterityDisplay.Text = "0";
            // 
            // StrengthDisplay
            // 
            StrengthDisplay.AutoSize = true;
            StrengthDisplay.Location = new Point(580, 65);
            StrengthDisplay.Name = "StrengthDisplay";
            StrengthDisplay.Size = new Size(24, 30);
            StrengthDisplay.TabIndex = 14;
            StrengthDisplay.Text = "0";
            // 
            // IntelligenceDisplay
            // 
            IntelligenceDisplay.AutoSize = true;
            IntelligenceDisplay.Location = new Point(580, 188);
            IntelligenceDisplay.Name = "IntelligenceDisplay";
            IntelligenceDisplay.Size = new Size(24, 30);
            IntelligenceDisplay.TabIndex = 15;
            IntelligenceDisplay.Text = "0";
            // 
            // WisdomDisplay
            // 
            WisdomDisplay.AutoSize = true;
            WisdomDisplay.Location = new Point(580, 229);
            WisdomDisplay.Name = "WisdomDisplay";
            WisdomDisplay.Size = new Size(24, 30);
            WisdomDisplay.TabIndex = 16;
            WisdomDisplay.Text = "0";
            // 
            // CharismaDisplay
            // 
            CharismaDisplay.AutoSize = true;
            CharismaDisplay.Location = new Point(580, 270);
            CharismaDisplay.Name = "CharismaDisplay";
            CharismaDisplay.Size = new Size(24, 30);
            CharismaDisplay.TabIndex = 17;
            CharismaDisplay.Text = "0";
            // 
            // PointsLabel
            // 
            PointsLabel.AutoSize = true;
            PointsLabel.Location = new Point(356, 338);
            PointsLabel.Name = "PointsLabel";
            PointsLabel.Size = new Size(173, 30);
            PointsLabel.TabIndex = 18;
            PointsLabel.Text = "Points Remaining";
            PointsLabel.Click += label1_Click;
            // 
            // PointsDisplay
            // 
            PointsDisplay.AutoSize = true;
            PointsDisplay.Location = new Point(555, 338);
            PointsDisplay.Name = "PointsDisplay";
            PointsDisplay.Size = new Size(24, 30);
            PointsDisplay.TabIndex = 19;
            PointsDisplay.Text = "0";
            // 
            // button1
            // 
            button1.Location = new Point(414, 386);
            button1.Name = "button1";
            button1.Size = new Size(131, 40);
            button1.TabIndex = 20;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(PointsDisplay);
            Controls.Add(PointsLabel);
            Controls.Add(CharismaDisplay);
            Controls.Add(WisdomDisplay);
            Controls.Add(IntelligenceDisplay);
            Controls.Add(StrengthDisplay);
            Controls.Add(DexterityDisplay);
            Controls.Add(ConstitutionDisplay);
            Controls.Add(numericUpDown6);
            Controls.Add(numericUpDown5);
            Controls.Add(numericUpDown4);
            Controls.Add(numericUpDown3);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Controls.Add(CharismaLabel);
            Controls.Add(WisdomLabel);
            Controls.Add(IntelligenceLabel);
            Controls.Add(ConstitutionLabel);
            Controls.Add(DexterityLabel);
            Controls.Add(StrengthLabel);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown5).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label StrengthLabel;
        private Label DexterityLabel;
        private Label ConstitutionLabel;
        private Label IntelligenceLabel;
        private Label WisdomLabel;
        private Label CharismaLabel;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown3;
        private NumericUpDown numericUpDown4;
        private NumericUpDown numericUpDown5;
        private NumericUpDown numericUpDown6;
        private Label ConstitutionDisplay;
        private Label DexterityDisplay;
        private Label StrengthDisplay;
        private Label IntelligenceDisplay;
        private Label WisdomDisplay;
        private Label CharismaDisplay;
        private Label PointsLabel;
        private Label PointsDisplay;
        private Button button1;
    }
}
namespace Cool_RPG
{
    partial class Form2
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
            LabelDialogue = new Label();
            Option1 = new Button();
            Option2 = new Button();
            SuspendLayout();
            // 
            // LabelDialogue
            // 
            LabelDialogue.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LabelDialogue.AutoSize = true;
            LabelDialogue.Location = new Point(386, 162);
            LabelDialogue.Name = "LabelDialogue";
            LabelDialogue.Size = new Size(51, 30);
            LabelDialogue.TabIndex = 0;
            LabelDialogue.Text = "N/A";
            LabelDialogue.TextAlign = ContentAlignment.MiddleCenter;
            LabelDialogue.Click += label1_Click;
            // 
            // Option1
            // 
            Option1.Location = new Point(217, 327);
            Option1.Name = "Option1";
            Option1.Size = new Size(131, 40);
            Option1.TabIndex = 1;
            Option1.Text = "button1";
            Option1.UseCompatibleTextRendering = true;
            Option1.UseVisualStyleBackColor = true;
            Option1.Click += button1_Click;
            // 
            // Option2
            // 
            Option2.Location = new Point(468, 327);
            Option2.Name = "Option2";
            Option2.Size = new Size(131, 40);
            Option2.TabIndex = 2;
            Option2.Text = "button2";
            Option2.UseVisualStyleBackColor = true;
            Option2.Click += Option2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Option2);
            Controls.Add(Option1);
            Controls.Add(LabelDialogue);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelDialogue;
        private Button Option1;
        private Button Option2;
    }
}
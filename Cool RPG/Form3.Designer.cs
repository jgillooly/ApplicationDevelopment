namespace Cool_RPG
{
    partial class Form3
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
            EnemyPicture = new PictureBox();
            AttackButton = new Button();
            DefendButton = new Button();
            progressBar1 = new ProgressBar();
            progressBar2 = new ProgressBar();
            PlayerHealthLabel = new Label();
            EnemyHealthLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)EnemyPicture).BeginInit();
            SuspendLayout();
            // 
            // EnemyPicture
            // 
            EnemyPicture.Location = new Point(226, 95);
            EnemyPicture.Name = "EnemyPicture";
            EnemyPicture.Size = new Size(100, 100);
            EnemyPicture.TabIndex = 0;
            EnemyPicture.TabStop = false;
            // 
            // AttackButton
            // 
            AttackButton.Location = new Point(195, 294);
            AttackButton.Name = "AttackButton";
            AttackButton.Size = new Size(131, 40);
            AttackButton.TabIndex = 1;
            AttackButton.Text = "Attack";
            AttackButton.UseVisualStyleBackColor = true;
            AttackButton.Click += button1_Click;
            // 
            // DefendButton
            // 
            DefendButton.Location = new Point(418, 294);
            DefendButton.Name = "DefendButton";
            DefendButton.Size = new Size(131, 40);
            DefendButton.TabIndex = 2;
            DefendButton.Text = "Defend";
            DefendButton.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(545, 95);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(175, 40);
            progressBar1.TabIndex = 3;
            progressBar1.Value = 75;
            // 
            // progressBar2
            // 
            progressBar2.Location = new Point(566, 174);
            progressBar2.Name = "progressBar2";
            progressBar2.Size = new Size(175, 40);
            progressBar2.TabIndex = 4;
            progressBar2.Value = 25;
            // 
            // PlayerHealthLabel
            // 
            PlayerHealthLabel.AutoSize = true;
            PlayerHealthLabel.Location = new Point(418, 95);
            PlayerHealthLabel.Name = "PlayerHealthLabel";
            PlayerHealthLabel.Size = new Size(121, 30);
            PlayerHealthLabel.TabIndex = 5;
            PlayerHealthLabel.Text = "Your Health";
            // 
            // EnemyHealthLabel
            // 
            EnemyHealthLabel.AutoSize = true;
            EnemyHealthLabel.Location = new Point(418, 174);
            EnemyHealthLabel.Name = "EnemyHealthLabel";
            EnemyHealthLabel.Size = new Size(142, 30);
            EnemyHealthLabel.TabIndex = 6;
            EnemyHealthLabel.Text = "Enemy Health";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(EnemyHealthLabel);
            Controls.Add(PlayerHealthLabel);
            Controls.Add(progressBar2);
            Controls.Add(progressBar1);
            Controls.Add(DefendButton);
            Controls.Add(AttackButton);
            Controls.Add(EnemyPicture);
            Name = "Form3";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)EnemyPicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox EnemyPicture;
        private Button AttackButton;
        private Button DefendButton;
        private ProgressBar progressBar1;
        private ProgressBar progressBar2;
        private Label PlayerHealthLabel;
        private Label EnemyHealthLabel;
    }
}
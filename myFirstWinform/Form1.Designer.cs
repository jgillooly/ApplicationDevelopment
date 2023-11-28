namespace myFirstWinform;

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
        textBox1 = new TextBox();
        textBox2 = new TextBox();
        textBox3 = new TextBox();
        button1 = new Button();
        button2 = new Button();
        button3 = new Button();
        button4 = new Button();
        textBox7 = new TextBox();
        textBox8 = new TextBox();
        tableLayoutPanel1 = new TableLayoutPanel();
        textBox6 = new TextBox();
        textBox5 = new TextBox();
        textBox4 = new TextBox();
        pictureBox1 = new PictureBox();
        pictureBox2 = new PictureBox();
        pictureBox3 = new PictureBox();
        groupBox1 = new GroupBox();
        tableLayoutPanel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
        groupBox1.SuspendLayout();
        SuspendLayout();
        // 
        // textBox1
        // 
        textBox1.ImeMode = ImeMode.NoControl;
        textBox1.Location = new Point(256, 324);
        textBox1.MaxLength = 1;
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(137, 35);
        textBox1.TabIndex = 1;
        textBox1.TextAlign = HorizontalAlignment.Center;
        // 
        // textBox2
        // 
        textBox2.ImeMode = ImeMode.NoControl;
        textBox2.Location = new Point(399, 324);
        textBox2.MaxLength = 1;
        textBox2.Name = "textBox2";
        textBox2.Size = new Size(137, 35);
        textBox2.TabIndex = 2;
        textBox2.TextAlign = HorizontalAlignment.Center;
        // 
        // textBox3
        // 
        textBox3.ImeMode = ImeMode.NoControl;
        textBox3.Location = new Point(542, 324);
        textBox3.MaxLength = 1;
        textBox3.Name = "textBox3";
        textBox3.Size = new Size(137, 35);
        textBox3.TabIndex = 3;
        textBox3.TextAlign = HorizontalAlignment.Center;
        // 
        // button1
        // 
        button1.Location = new Point(256, 365);
        button1.Name = "button1";
        button1.Size = new Size(423, 40);
        button1.TabIndex = 7;
        button1.Text = "Guess";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // button2
        // 
        button2.Location = new Point(256, 411);
        button2.Name = "button2";
        button2.Size = new Size(423, 40);
        button2.TabIndex = 8;
        button2.Text = "Reset";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // button3
        // 
        button3.Location = new Point(256, 457);
        button3.Name = "button3";
        button3.Size = new Size(423, 40);
        button3.TabIndex = 12;
        button3.Text = "Start Game";
        button3.UseVisualStyleBackColor = true;
        button3.Click += button3_Click;
        // 
        // button4
        // 
        button4.Location = new Point(28, 53);
        button4.Name = "button4";
        button4.Size = new Size(131, 40);
        button4.TabIndex = 13;
        button4.Text = "Cheat :)";
        button4.UseVisualStyleBackColor = true;
        button4.Click += button4_Click;
        // 
        // textBox7
        // 
        textBox7.Location = new Point(685, 370);
        textBox7.Name = "textBox7";
        textBox7.ReadOnly = true;
        textBox7.Size = new Size(137, 35);
        textBox7.TabIndex = 14;
        // 
        // textBox8
        // 
        textBox8.Location = new Point(256, 524);
        textBox8.Name = "textBox8";
        textBox8.ReadOnly = true;
        textBox8.Size = new Size(423, 35);
        textBox8.TabIndex = 15;
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 3;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
        tableLayoutPanel1.Controls.Add(textBox6, 0, 0);
        tableLayoutPanel1.Controls.Add(textBox5, 0, 0);
        tableLayoutPanel1.Controls.Add(textBox4, 0, 0);
        tableLayoutPanel1.Location = new Point(256, 70);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 1;
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tableLayoutPanel1.Size = new Size(423, 45);
        tableLayoutPanel1.TabIndex = 17;
        tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
        // 
        // textBox6
        // 
        textBox6.Location = new Point(283, 3);
        textBox6.Name = "textBox6";
        textBox6.ReadOnly = true;
        textBox6.Size = new Size(137, 35);
        textBox6.TabIndex = 12;
        // 
        // textBox5
        // 
        textBox5.Location = new Point(143, 3);
        textBox5.Name = "textBox5";
        textBox5.ReadOnly = true;
        textBox5.Size = new Size(134, 35);
        textBox5.TabIndex = 11;
        // 
        // textBox4
        // 
        textBox4.Location = new Point(3, 3);
        textBox4.Name = "textBox4";
        textBox4.ReadOnly = true;
        textBox4.Size = new Size(134, 35);
        textBox4.TabIndex = 10;
        // 
        // pictureBox1
        // 
        pictureBox1.Location = new Point(0, 34);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(137, 137);
        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBox1.TabIndex = 7;
        pictureBox1.TabStop = false;
        // 
        // pictureBox2
        // 
        pictureBox2.Location = new Point(143, 34);
        pictureBox2.Name = "pictureBox2";
        pictureBox2.Size = new Size(137, 137);
        pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBox2.TabIndex = 8;
        pictureBox2.TabStop = false;
        // 
        // pictureBox3
        // 
        pictureBox3.Location = new Point(286, 34);
        pictureBox3.Name = "pictureBox3";
        pictureBox3.Size = new Size(137, 137);
        pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBox3.TabIndex = 9;
        pictureBox3.TabStop = false;
        // 
        // groupBox1
        // 
        groupBox1.Anchor = AnchorStyles.Bottom;
        groupBox1.Controls.Add(pictureBox3);
        groupBox1.Controls.Add(pictureBox2);
        groupBox1.Controls.Add(pictureBox1);
        groupBox1.Location = new Point(256, 144);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(423, 174);
        groupBox1.TabIndex = 16;
        groupBox1.TabStop = false;
        groupBox1.Text = "Guesses";
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(12F, 30F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(965, 586);
        Controls.Add(tableLayoutPanel1);
        Controls.Add(groupBox1);
        Controls.Add(textBox8);
        Controls.Add(textBox7);
        Controls.Add(button4);
        Controls.Add(button3);
        Controls.Add(button2);
        Controls.Add(button1);
        Controls.Add(textBox3);
        Controls.Add(textBox2);
        Controls.Add(textBox1);
        Name = "Form1";
        Text = "Form1";
        Load += Form1_Load;
        tableLayoutPanel1.ResumeLayout(false);
        tableLayoutPanel1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
        groupBox1.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private TextBox textBox1;
    private TextBox textBox2;
    private TextBox textBox3;
    private Button button1;
    private Button button2;
    private Button button3;
    private Button button4;
    private TextBox textBox7;
    private TextBox textBox8;
    private TableLayoutPanel tableLayoutPanel1;
    private TextBox textBox6;
    private TextBox textBox5;
    private TextBox textBox4;
    private PictureBox pictureBox1;
    private PictureBox pictureBox2;
    private PictureBox pictureBox3;
    private GroupBox groupBox1;
}

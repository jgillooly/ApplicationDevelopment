using System.Reflection;

namespace myFirstWinform;

public partial class Form1 : Form
{
    int num1, num2, num3;
    bool guessed1 = false, guessed2 = false, guessed3 = false;
    int guess1 = 100, guess2 = 100, guess3 = 100;
    int guesses;

    public Form1()
    {
        InitializeComponent();

    }

    private void Form1_Load(object sender, EventArgs e)
    {
        Directory.SetCurrentDirectory(@"C:\Users\Joshua\source\repos\ApplicationDevelopment\myFirstWinform\Assets");
        Random random = new Random(Guid.NewGuid().GetHashCode());
        num1 = random.Next(10);
        num2 = random.Next(10);
        num3 = random.Next(10);

        guesses = 10;

        textBox1.Visible = false;
        textBox2.Visible = false;
        textBox3.Visible = false;
        textBox7.Visible = false;
        textBox8.Visible = false;

        groupBox1.Visible = false;
        pictureBox1.Visible = false;
        pictureBox2.Visible = false;
        pictureBox3.Visible = false;

        textBox4.Visible = false;
        textBox5.Visible = false;
        textBox6.Visible = false;

        button1.Visible = false;
        button2.Visible = false;
        button4.Visible = false;
    }

    private void textBox3_TextChanged(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
        guess1 = 100;
        guess2 = 100;
        guess3 = 100;

        textBox8.Text = "";
        textBox8.BackColor = Color.White;

        try
        {
            guess1 = Int32.Parse(textBox1.Text);
            //textBox4.Text = guess1.ToString();
            guess2 = Int32.Parse(textBox2.Text);
            //textBox5.Text = guess1.ToString();
            guess3 = Int32.Parse(textBox3.Text);
            //textBox6.Text = guess1.ToString();
        }
        catch
        {
            Console.WriteLine("You broke it :')");
            textBox8.Text = "ENTER NUMBERS >:(";
            textBox8.BackColor = Color.Red;
        }
        if (guess1 != 100 && guess2 != 100 && guess3 != 100)
        {
            int dif1 = checkGuess(num1, guess1), dif2 = checkGuess(num2, guess2), dif3 = checkGuess(num3, guess3);
            guessed1 = dif1 == 0;
            guessed2 = dif2 == 0;
            guessed3 = dif3 == 0;
            displayImages(pictureBox1, dif1);
            displayImages(pictureBox2, dif2);
            displayImages(pictureBox3, dif3);
            if (guessed1 && guessed2 && guessed3)
            {
                button1.Visible = false;
                textBox8.Text = "YOU WIN :)";
            }
            else
            {
                guesses--;
                textBox7.Text = guesses.ToString();
                if (guesses <= 0)
                {
                    button1.Visible = false;
                    textBox8.Text = "YOU LOSE :(";
                    textBox4.Text = num1.ToString();
                    textBox5.Text = num2.ToString();
                    textBox6.Text = num3.ToString();
                }
            }
        }


    }

    private void displayImages(PictureBox box, int onSwitch)
    {
        switch (onSwitch)
        {
            case 0:
                box.Image = Image.FromFile("correct-icon.png");
                break;
            case 1:
            case -1:
                box.Image = Image.FromFile("help.png");
                break;
            default:
                box.Image = Image.FromFile("incorrect-icon.png");
                break;
        }
    }

    private int checkGuess(int number, int guess)
    {
        int distance = Math.Abs(number - guess);
        distance = Math.Clamp(distance, -2, 2);
        return distance;
    }

    private void button2_Click(object sender, EventArgs e)
    {
        Random random = new Random(Guid.NewGuid().GetHashCode());
        num1 = random.Next(10);
        num2 = random.Next(10);
        num3 = random.Next(10);

        guesses = 10;

        textBox1.Visible = false;
        textBox1.Text = "";
        textBox2.Visible = false;
        textBox2.Text = "";
        textBox3.Visible = false;
        textBox3.Text = "";
        textBox7.Visible = false;
        textBox8.Visible = false;

        groupBox1.Visible = false;
        pictureBox1.Visible = false;
        pictureBox2.Visible = false;
        pictureBox3.Visible = false;

        textBox4.Visible = false;
        textBox4.Text = "";
        textBox5.Visible = false;
        textBox5.Text = "";
        textBox6.Visible = false;
        textBox6.Text = "";

        button1.Visible = false;
        button2.Visible = false;
        button4.Visible = false;

        button3.Visible = true;
    }

    private void button3_Click(object sender, EventArgs e)
    {
        textBox1.Visible = true;
        textBox2.Visible = true;
        textBox3.Visible = true;
        textBox7.Visible = true;
        textBox7.Text = guesses.ToString();
        textBox8.Visible = true;
        textBox8.Text = "";

        groupBox1.Visible = true;
        pictureBox1.Visible = true;
        pictureBox1.Image = null;
        pictureBox2.Visible = true;
        pictureBox2.Image = null;
        pictureBox3.Visible = true;
        pictureBox3.Image = null;

        textBox4.Visible = true;
        textBox5.Visible = true;
        textBox6.Visible = true;

        button1.Visible = true;
        button2.Visible = true;
        button4.Visible = true;

        button3.Visible = false;
    }

    private void button4_Click(object sender, EventArgs e)
    {


        textBox4.Text = num1.ToString();
        textBox5.Text = num2.ToString();
        textBox6.Text = num3.ToString();
    }

    private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
    {

    }
}

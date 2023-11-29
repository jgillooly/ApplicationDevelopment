using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cool_RPG
{
    public partial class Form3 : Form
    {
        string currentMessage = "";
        public Form3()
        {
            InitializeComponent();
            Program.game.enemy = new Gamelogic.Character(10, 10, 10, 10, 10, 10);

            progressBar1.Maximum = Program.game.player.MaxHealth;
            progressBar2.Maximum = Program.game.enemy.MaxHealth;

            winPicture.Visible = false;

            UpdateUI();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            currentMessage = Program.game.Attack();
            UpdateUI();
        }

        private void DefendButton_Click(object sender, EventArgs e)
        {
            currentMessage = Program.game.Defend();
            UpdateUI();
        }

        private void UpdateUI()
        {
            progressBar1.Value = Program.game.player.Health;

            progressBar2.Value = Program.game.enemy.Health;

            outcome.Text = currentMessage;

            if (Program.game.combatOver)
            {
                AttackButton.Visible = false;
                DefendButton.Visible = false;
                diplomacyButton.Visible = false;
                Directory.SetCurrentDirectory(@"C:\Users\Joshua\source\repos\ApplicationDevelopment");
                winPicture.Visible = true;
                switch (Program.game.victor)
                {
                    case "Player":
                        winPicture.Image = Image.FromFile("Youwin.png");
                        break;
                    case "Enemy":
                        winPicture.Image = Image.FromFile("Youlose.png");
                        break;
                }
            }
        }

        private void diplomacyButton_Click(object sender, EventArgs e)
        {
            currentMessage = Program.game.Diplomacy();
            UpdateUI();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

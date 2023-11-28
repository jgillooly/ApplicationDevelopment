using Cool_RPG.DialogueU;
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
    public partial class Form2 : Form
    {
        Response currentResponse;
        public Form2()
        {
            InitializeComponent();

            Dialogue dialogueTree = new Dialogue();

            Response romanceStart = new Response();
            romanceStart.responseText = "I didn't know you cared so";

            Response attack = new Response();
            attack.responseText = "Attack";

            Response violenceStart = new Response();
            violenceStart.responseText = "Violence";
            violenceStart.dialogueOptions.Add("I'm Sorry", romanceStart);
            violenceStart.dialogueOptions.Add("Attack", attack);

            Response startOfDialogue = new Response();
            startOfDialogue.responseText = "General Kenobi";
            startOfDialogue.dialogueOptions.Add("How've you been", romanceStart);
            startOfDialogue.dialogueOptions.Add("Sarcasm", violenceStart);
            dialogueTree.initialResponse = startOfDialogue;

            currentResponse = dialogueTree.initialResponse;

            UpdateUI(dialogueTree.initialResponse);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var options = currentResponse.dialogueOptions.ToArray();
            if (options.Length > 0)
            {
                currentResponse = options[0].Value;
                UpdateUI(currentResponse);
            }
        }

        private void UpdateUI(Response response)
        {
            if (response != null)
            {
                if (response.responseText == "Attack")
                {
                    Form3 form = new Form3();
                    form.Show();
                    this.Close();
                }
                else
                {
                    var options = response.dialogueOptions.ToArray();
                    Option1.Text = (options.Length > 0) ? options[0].Key : "N/A";
                    Option2.Text = (options.Length > 1) ? options[1].Key : "N/A";

                    LabelDialogue.Text = response.responseText;
                }
            } else
            {
                this.Close();
            }
        }

        private void Option2_Click(object sender, EventArgs e)
        {
            var options = currentResponse.dialogueOptions.ToArray();
            if (options.Length > 0)
            {
                currentResponse = options[1].Value;
                UpdateUI(currentResponse);
            }
        }
    }
}

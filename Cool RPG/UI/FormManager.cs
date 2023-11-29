using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cool_RPG.UI
{

    internal class FormManager : ApplicationContext
    {
        private static Form1 form1;
        private static Form2 form2;
        private static Form3 form3;
        private static Form currentForm;
        private static Form prevForm;
        private static Lazy<FormManager> _current = new Lazy<FormManager>();
        public static FormManager Current => _current.Value;
        public FormManager()
        {
            Start();
        }

        private void onFormClosed(object sender, EventArgs e)
        {
            if (Application.OpenForms.Count == 0)
            {
                ExitThread();
            }
        }

        public T CreateForm<T>() where T : Form, new()
        {
            var ret = new T();
            ret.FormClosed += onFormClosed;
            return ret;
        }

        public void Start()
        {
            form1 = CreateForm<Form1>();
            form2 = CreateForm<Form2>();
            form3 = CreateForm<Form3>();

            currentForm = form1;
            currentForm.Show();
        }

        public static void SwitchWindow()
        {
            prevForm = currentForm;
            switch (Program.game.GameState)
            {
                case Gamelogic.Game.State.Creation:
                    currentForm = form1;
                    break;
                case Gamelogic.Game.State.Dialogue:
                    currentForm = form2;
                    break;
                case Gamelogic.Game.State.Combat:
                    currentForm = form3;
                    break;
            };

        }

    }
}

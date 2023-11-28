namespace Cool_RPG
{
    public partial class Form1 : Form
    {
        Character character;
        int points = 20;
        public Form1()
        {
            InitializeComponent();
            character = new Character();
            StrengthDisplay.DataBindings.Add("Text", character, "Strength", false, DataSourceUpdateMode.OnPropertyChanged);
            DexterityDisplay.DataBindings.Add("Text", character, "Dexterity", false, DataSourceUpdateMode.OnPropertyChanged);
            ConstitutionDisplay.DataBindings.Add("Text", character, "Constitution", false, DataSourceUpdateMode.OnPropertyChanged);
            IntelligenceDisplay.DataBindings.Add("Text", character, "Intelligence", false, DataSourceUpdateMode.OnPropertyChanged);
            WisdomDisplay.DataBindings.Add("Text", character, "Wisdom", false, DataSourceUpdateMode.OnPropertyChanged);
            CharismaDisplay.DataBindings.Add("Text", character, "Charisma", false, DataSourceUpdateMode.OnPropertyChanged);
            PointsDisplay.Text = points.ToString();
            character.ResetStats();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value > 10) { numericUpDown1.Value = 10; }
            UpdatePoints();
            if (points < 0) { numericUpDown1.Value -= 1; }
            decimal add = numericUpDown1.Value;
            character.Strength = ((int)add);
            UpdatePoints();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown2.Value > 10) { numericUpDown2.Value = 10; }
            UpdatePoints();
            if (points < 0) { numericUpDown2.Value -= 1; }
            decimal add = numericUpDown2.Value;
            character.Dexterity = ((int)add);
            UpdatePoints();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UpdatePoints()
        {
            decimal add = -numericUpDown1.Value - numericUpDown2.Value - numericUpDown3.Value - numericUpDown4.Value - numericUpDown5.Value - numericUpDown6.Value;
            points = 20 + (int)add;
            PointsDisplay.Text = points.ToString();
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown3.Value > 10) { numericUpDown3.Value = 10; }
            UpdatePoints();
            if (points < 0) { numericUpDown3.Value -= 1; }
            decimal add = numericUpDown3.Value;
            character.Constitution = ((int)add);
            UpdatePoints();
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown4.Value > 10) { numericUpDown4.Value = 10; }
            UpdatePoints();
            if (points < 0) { numericUpDown4.Value -= 1; }
            decimal add = numericUpDown4.Value;
            character.Intelligence = ((int)add);
            UpdatePoints();
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown5.Value > 10) { numericUpDown5.Value = 10; }
            UpdatePoints();
            if (points < 0) { numericUpDown5.Value -= 1; }
            decimal add = numericUpDown5.Value;
            character.Wisdom = ((int)add);
            UpdatePoints();
        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown6.Value > 10) { numericUpDown6.Value = 10; }
            UpdatePoints();
            if (points < 0) { numericUpDown6.Value -= 1; }
            decimal add = numericUpDown6.Value;
            character.Charisma = ((int)add);
            UpdatePoints();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            this.Close();
        }
    }
}
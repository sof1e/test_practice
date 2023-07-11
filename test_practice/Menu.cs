namespace test_practice
{
    public partial class Menu : Form
    {
        Ukraine_history form1;
        Math form2;
        Geography form3;
        Chemistry form4;
        Physics form5;
        Biology form6;

        public Menu()
        {
            InitializeComponent();
            form1 = new Ukraine_history();
            form2 = new Math();
            form3 = new Geography();
            form4 = new Chemistry();
            form5 = new Physics();
            form6 = new Biology();
        }

        private void history_Click(object sender, EventArgs e)
        {
            form1.Show();
        }
        private void math_Click(object sender, EventArgs e)
        {
            form2.Show();
        }
        private void geography_Click(object sender, EventArgs e)
        {
            form3.Show();
        }
        private void chemistry_Click(object sender, EventArgs e)
        {
            form4.Show();
        }
        private void physics_Click(object sender, EventArgs e)
        {
            form5.Show();
        }
        private void biology_Click(object sender, EventArgs e)
        {
            form6.Show();
        }

    }
}

namespace test_practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            form2 = new Menu();
            form3 = new Rating();
        }
        Menu form2;
        Rating form3;
        string login = "admin";
        string password = "admin";
        
        private void button1_Click(object sender, EventArgs e)
        {
            string log = log_tb.Text;
            string pass = parol_tb.Text;
            if (log == login && pass == password) { form2.Show(); Hide(); }
            else { MessageBox.Show("Неправильний логін або пароль. Будь-ласка, спробуйте ще раз!", "Помилка входу", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            form3.student_name = login;
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace test_practice
{
    public partial class Math : Form
    {
        public Math()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int points = 0;
            if (radioButton4.Checked == true) { points += 1; }
            if (radioButton7.Checked == true) { points += 1; }
            if (radioButton9.Checked == true) { points += 1; }
            if (radioButton19.Checked == true) { points += 1; }
            if (radioButton16.Checked == true) { points += 1; }
            if (radioButton23.Checked == true) { points += 1; }
            if (radioButton31.Checked == true) { points += 1; }
            if (textBox1.Text == "206") { points += 1; }
            if (textBox2.Text == "309") { points += 1; }
            if (textBox3.Text == "240") { points += 1; }
            if (textBox4.Text == "20") { points += 1; }
            if (textBox5.Text == "2730") { points += 1; }
            label23.Text = "Оцінка: " + Convert.ToString(points);
            Rating form3 = new Rating();
            form3.score_math = Convert.ToString(points);
            form3.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = false; radioButton2.Checked = false; radioButton3.Checked = false; radioButton4.Checked = false;
            radioButton5.Checked = false; radioButton6.Checked = false; radioButton7.Checked = false; radioButton8.Checked = false;
            radioButton9.Checked = false; radioButton10.Checked = false; radioButton11.Checked = false; radioButton12.Checked = false;
            radioButton13.Checked = false; radioButton14.Checked = false; radioButton15.Checked = false; radioButton16.Checked = false;
            radioButton17.Checked = false; radioButton18.Checked = false; radioButton19.Checked = false; radioButton20.Checked = false;
            radioButton21.Checked = false; radioButton22.Checked = false; radioButton23.Checked = false; radioButton24.Checked = false;
            radioButton25.Checked = false; radioButton26.Checked = false; radioButton27.Checked = false; radioButton28.Checked = false;
            radioButton29.Checked = false; radioButton30.Checked = false; radioButton31.Checked = false; radioButton32.Checked = false;
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox4.Text = " ";
            textBox5.Text = " ";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Chemistry next_form = new Chemistry();
            next_form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int points = 0;
            if (radioButton4.Checked == true) { points += 1; }
            if (radioButton7.Checked == true) { points += 1; }
            if (radioButton9.Checked == true) { points += 1; }
            if (radioButton19.Checked == true) { points += 1; }
            if (radioButton16.Checked == true) { points += 1; }
            if (radioButton23.Checked == true) { points += 1; }
            if (radioButton31.Checked == true) { points += 1; }
            if (textBox1.Text == "206") { points += 1; }
            if (textBox2.Text == "309") { points += 1; }
            if (textBox3.Text == "240") { points += 1; }
            if (textBox4.Text == "20") { points += 1; }
            if (textBox5.Text == "2730") { points += 1; }
            label23.Text = "Оцінка: " + Convert.ToString(points);
            Rating form3 = new Rating();
            form3.score_math = Convert.ToString(points);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Physics prev_form = new Physics();
            prev_form.Show();
        }
    }
}

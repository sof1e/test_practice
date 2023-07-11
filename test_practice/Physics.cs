using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection.Emit;

namespace test_practice
{
    public partial class Physics : Form
    {
        public Physics()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            int points = 0;
            if (radioButton1.Checked == true) { points += 1; }
            if (radioButton7.Checked == true) { points += 1; }
            if (radioButton9.Checked == true) { points += 1; }
            if (radioButton14.Checked == true) { points += 1; }
            if (radioButton20.Checked == true) { points += 1; }
            if (radioButton23.Checked == true) { points += 1; }
            if (radioButton50.Checked == true) { points += 1; }
            if (radioButton33.Checked == true) { points += 1; }
            if (radioButton29.Checked == true) { points += 1; }
            if (radioButton39.Checked == true) { points += 1; }
            if (radioButton26.Checked == true) { points += 1; }
            if (textBox1.Text == "5") { points += 1; }
            label14.Text = "Оцінка: " + Convert.ToString(points);
            Rating form3 = new Rating();
            form3.score_physics = Convert.ToString(points);
            form3.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = false; radioButton2.Checked = false; radioButton3.Checked = false; radioButton4.Checked = false;
            radioButton5.Checked = false; radioButton6.Checked = false; radioButton7.Checked = false; radioButton36.Checked = false;
            radioButton8.Checked = false; radioButton9.Checked = false; radioButton10.Checked = false; radioButton11.Checked = false;
            radioButton12.Checked = false; radioButton13.Checked = false; radioButton14.Checked = false; radioButton15.Checked = false;
            radioButton16.Checked = false; radioButton17.Checked = false; radioButton18.Checked = false; radioButton19.Checked = false;
            radioButton20.Checked = false; radioButton21.Checked = false; radioButton22.Checked = false; radioButton23.Checked = false;
            radioButton24.Checked = false; radioButton25.Checked = false; radioButton26.Checked = false; radioButton27.Checked = false;
            radioButton28.Checked = false; radioButton29.Checked = false; radioButton30.Checked = false; radioButton31.Checked = false;
            radioButton32.Checked = false; radioButton33.Checked = false; radioButton34.Checked = false; radioButton35.Checked = false;
            radioButton37.Checked = false; radioButton38.Checked = false; radioButton39.Checked = false; radioButton40.Checked = false;
            radioButton49.Checked = false; radioButton50.Checked = false; radioButton51.Checked = false; radioButton52.Checked = false;
            textBox1.Text = " ";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Math next_form = new Math();
            next_form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int points = 0;
            if (radioButton1.Checked == true) { points += 1; }
            if (radioButton7.Checked == true) { points += 1; }
            if (radioButton9.Checked == true) { points += 1; }
            if (radioButton14.Checked == true) { points += 1; }
            if (radioButton20.Checked == true) { points += 1; }
            if (radioButton23.Checked == true) { points += 1; }
            if (radioButton50.Checked == true) { points += 1; }
            if (radioButton33.Checked == true) { points += 1; }
            if (radioButton29.Checked == true) { points += 1; }
            if (radioButton39.Checked == true) { points += 1; }
            if (radioButton26.Checked == true) { points += 1; }
            if (textBox1.Text == "5") { points += 1; }
            label14.Text = "Оцінка: " + Convert.ToString(points);
            Rating form3 = new Rating();
            form3.score_physics = Convert.ToString(points);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Geography prev_form = new Geography();
            prev_form.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace test_practice
{
    public partial class Biology : Form
    {

        public Biology()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int points = 0;
            if (radioButton4.Checked == true) { points += 1; }
            if (radioButton51.Checked == true) { points += 1; }
            if (radioButton31.Checked == true) { points += 1; }
            if (radioButton19.Checked == true) { points += 1; }
            if (radioButton15.Checked == true) { points += 1; }
            if (checkBox25.Checked == true) { points += 1; }
            if (checkBox8.Checked == true) { points += 1; }
            if (checkBox23.Checked == true) { points += 1; }
            if (radioButton35.Checked == true) { points += 1; }
            if (radioButton38.Checked == true) { points += 1; }
            if (radioButton47.Checked == true) { points += 1; }
            if (radioButton11.Checked == true) { points += 1; }
            label12.Text = "Оцінка: " + Convert.ToString(points);
            Rating form3 = new Rating();
            form3.score_biology = Convert.ToString(points);
            form3.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = false; radioButton2.Checked = false; radioButton3.Checked = false; radioButton4.Checked = false;
            checkBox5.Checked = false; checkBox6.Checked = false; checkBox7.Checked = false; radioButton36.Checked = false;
            checkBox8.Checked = false; radioButton9.Checked = false; radioButton10.Checked = false; radioButton11.Checked = false;
            radioButton12.Checked = false; radioButton13.Checked = false; radioButton14.Checked = false; radioButton15.Checked = false;
            radioButton16.Checked = false; radioButton17.Checked = false; radioButton18.Checked = false; radioButton19.Checked = false;
            radioButton20.Checked = false; checkBox21.Checked = false; checkBox22.Checked = false; checkBox23.Checked = false;
            checkBox24.Checked = false; checkBox25.Checked = false; checkBox26.Checked = false; checkBox27.Checked = false;
            checkBox28.Checked = false; radioButton29.Checked = false; radioButton30.Checked = false; radioButton31.Checked = false;
            radioButton32.Checked = false; radioButton33.Checked = false; radioButton34.Checked = false; radioButton35.Checked = false;
            radioButton37.Checked = false; radioButton38.Checked = false; radioButton39.Checked = false; radioButton40.Checked = false;
            radioButton45.Checked = false; radioButton46.Checked = false; radioButton47.Checked = false; radioButton48.Checked = false;
            radioButton49.Checked = false; radioButton50.Checked = false; radioButton52.Checked = false; radioButton51.Checked = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int points = 0;
            if (radioButton4.Checked == true) { points += 1; }
            if (radioButton51.Checked == true) { points += 1; }
            if (radioButton31.Checked == true) { points += 1; }
            if (radioButton19.Checked == true) { points += 1; }
            if (radioButton15.Checked == true) { points += 1; }
            if (checkBox25.Checked == true) { points += 1; }
            if (checkBox8.Checked == true) { points += 1; }
            if (checkBox23.Checked == true) { points += 1; }
            if (radioButton35.Checked == true) { points += 1; }
            if (radioButton38.Checked == true) { points += 1; }
            if (radioButton47.Checked == true) { points += 1; }
            if (radioButton11.Checked == true) { points += 1; }
            label12.Text = "Оцінка: " + Convert.ToString(points);
            Rating form3 = new Rating();
            form3.score_biology = Convert.ToString(points);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Ukraine_history next_form = new Ukraine_history();
            next_form.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Chemistry prev_form = new Chemistry();
            prev_form.Show();
        }
    }
}

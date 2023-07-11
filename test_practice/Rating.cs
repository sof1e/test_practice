using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_practice
{
    public partial class Rating : Form
    {
        public Rating()
        {
            InitializeComponent();
            
        }
        public string? student_name { get; set; }
        public string? score_math { get; set; }
        public string? score_geography { get; set; }
        public string? score_biology { get; set; }
        public string? score_history { get; set; }
        public string? score_chemistry { get; set; }
        public string? score_physics { get; set; }

        DataTable rate = new DataTable();
        Menu form2 = new Menu();
        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            rate.Rows.Add(student_name, score_history, score_geography, score_physics, score_math, score_chemistry, score_biology);
        }

        private void Rating_Load(object sender, EventArgs e)
        {
            rate.Columns.Add("Ім'я студента", Type.GetType("System.String"));
            rate.Columns.Add("Історія України", Type.GetType("System.Int32"));
            rate.Columns.Add("Географія", Type.GetType("System.Int32"));
            rate.Columns.Add("Фізика", Type.GetType("System.Int32"));
            rate.Columns.Add("Математика", Type.GetType("System.Int32"));
            rate.Columns.Add("Хімія", Type.GetType("System.Int32"));
            rate.Columns.Add("Біологія", Type.GetType("System.Int32"));
            dtGV.DataSource = rate;
            button1.PerformClick();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            form2.Show();
        }
    }
}

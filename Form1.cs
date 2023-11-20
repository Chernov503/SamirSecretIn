using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.Columns.Add("x", "x");
            dataGridView1.Columns.Add("y", "y");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add(int.Parse(textBox1.Text));

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Lagrange l = new Lagrange(dataGridView1);
            textBox2.Text = Math.Round(l.ReturnSecret(), 0).ToString();
        }
    }
}

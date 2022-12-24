using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8дз
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.BackColor = Color.Black;
            button1.Text = "выключить";
            button1.ForeColor = Color.White;
            button2.BackColor = Color.White;
            button2.Text = "включить";
            button2.Visible = false;
            button2.Top = button1.Top;
            button2.Left = button1.Left;
            button2.Width = button1.Width;
            button2.Height = button1.Height;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.BackColor = Color.Black;
            button1.Visible = false;
            button2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.BackColor = Color.White;
            button2.Visible = false;
            button1.Visible = true;
        }
    }
}

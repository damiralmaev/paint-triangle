using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace рисовалка
{
    public partial class Form1 : Form
    {

        public static int x1, x2, x3, x4, y1, y2, y3, y4 = 0;
        public static string text = "";

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawLine(System.Drawing.Pens.Red, x1, y1, x2, y2);
            e.Graphics.DrawLine(System.Drawing.Pens.Red, x2, y2, x3, y3);
            e.Graphics.DrawLine(System.Drawing.Pens.Red, x1, y1, x3, y3);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                x1 = Convert.ToInt32(textBox1.Text);
                y1 = Convert.ToInt32(textBox2.Text);
                x2 = Convert.ToInt32(textBox3.Text);
                y2 = Convert.ToInt32(textBox4.Text);
                x3 = Convert.ToInt32(textBox5.Text);
                y3 = Convert.ToInt32(textBox6.Text);
                if (text == "")
                    text = xandy.Text;
                xandy.Text = Convert.ToString("x1 = " + x1 + " y1 = " + y1 + " x2 = " + x2 + " y2 = " + y2 + " x3 = " + x3 + " y3 = " + y3 + " x4 = " + x4 + " y4 = " + y4);
                pictureBox1.Refresh();
            }
            catch { MessageBox.Show("Error", "" + this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}

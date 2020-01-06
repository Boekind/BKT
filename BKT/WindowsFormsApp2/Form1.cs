using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            label1.ForeColor = RndColor();
        }

        private Color RndColor()
        {
            Random r = new Random();
            return Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256));
            
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
        }

        private void Form1_Move(object sender, EventArgs e)
        {
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.ForeColor = RndColor();
            label2.ForeColor = RndColor();
            label3.ForeColor = RndColor();
            label4.ForeColor = RndColor();
            label5.ForeColor = RndColor();
            label6.ForeColor = RndColor();
            label7.ForeColor = RndColor();
            label8.ForeColor = RndColor();
            label15.ForeColor = RndColor();
            
        }
    }
}

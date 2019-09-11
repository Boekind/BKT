using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taschenrechner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button0_Click(object sender, EventArgs e)
        {
            labelResult.Text += "0";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            labelResult.Text += "1";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            labelResult.Text += "2";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            labelResult.Text += "3";
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            labelResult.Text += "4";
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            labelResult.Text += "5";
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            labelResult.Text += "6";
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            labelResult.Text += "7";
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            labelResult.Text += "8";
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            labelResult.Text += "9";
        }

        private void ButtonAddition_Click(object sender, EventArgs e)
        {
            
        }

        private void ButtonSubstraction_Click(object sender, EventArgs e)
        {
            
        }

        private void ButtonMultiplication_Click(object sender, EventArgs e)
        {
            
        }

        private void ButtonDivision_Click(object sender, EventArgs e)
        {
            
        }

        private void ButtonComma_Click(object sender, EventArgs e)
        {
            if (!labelResult.Text.Contains(","))
            {
                labelResult.Text += ",";
            }
            

        }

        private void ButtonC_Click(object sender, EventArgs e)
        {
            labelResult.Text = "0";
        }
    }
}

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
        public string operand { get; set; }
        Calculator calc = new Calculator();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button0_Click(object sender, EventArgs e)
        {
            labelResult.Text = calc.AddNumber(labelResult.Text, "0");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            labelResult.Text = calc.AddNumber(labelResult.Text, "1");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
           labelResult.Text = calc.AddNumber(labelResult.Text, "2");
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            labelResult.Text = calc.AddNumber(labelResult.Text, "3");
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            labelResult.Text = calc.AddNumber(labelResult.Text, "4");
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            labelResult.Text = calc.AddNumber(labelResult.Text, "5");
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            labelResult.Text = calc.AddNumber(labelResult.Text, "6");
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            labelResult.Text = calc.AddNumber(labelResult.Text, "7");
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            labelResult.Text = calc.AddNumber(labelResult.Text, "8");
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            labelResult.Text = calc.AddNumber(labelResult.Text, "9");
        }

        private void ButtonAddition_Click(object sender, EventArgs e)
        {
            calc.Calculate(labelResult.Text, "+",operand);
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
            calc.AddComma(labelResult.Text);

        }

        private void ButtonC_Click(object sender, EventArgs e)
        {
            labelResult.Text = "0";
        }

        private void Button10_Click(object sender, EventArgs e)
        {

        }

        private void LabelResult_Click(object sender, EventArgs e)
        {

        }

        private void KeyboardInput(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D0: labelResult.Text = calc.AddNumber(labelResult.Text, "0"); break;
                case Keys.D1: labelResult.Text = calc.AddNumber(labelResult.Text, "1"); break;
                case Keys.D2: labelResult.Text = calc.AddNumber(labelResult.Text, "2"); break;
                case Keys.D3: labelResult.Text = calc.AddNumber(labelResult.Text, "3"); break;
                case Keys.D4: labelResult.Text = calc.AddNumber(labelResult.Text, "4"); break;
                case Keys.D5: labelResult.Text = calc.AddNumber(labelResult.Text, "5"); break;
                case Keys.D6: labelResult.Text = calc.AddNumber(labelResult.Text, "6"); break;
                case Keys.D7: labelResult.Text = calc.AddNumber(labelResult.Text, "7"); break;
                case Keys.D8: labelResult.Text = calc.AddNumber(labelResult.Text, "8"); break;
                case Keys.D9: labelResult.Text = calc.AddNumber(labelResult.Text, "9"); break;
                
                case Keys.Oemcomma: labelResult.Text = calc.AddComma(labelResult.Text); break;


            }
        }
    }
}

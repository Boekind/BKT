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
        private string currentOperator;
        private string oldValue;
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
            labelCalculate.Text = calc.AddNumber(labelCalculate.Text, "0");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            labelCalculate.Text = calc.AddNumber(labelCalculate.Text, "1");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
           labelCalculate.Text = calc.AddNumber(labelCalculate.Text, "2");
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            labelCalculate.Text = calc.AddNumber(labelCalculate.Text, "3");
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            labelCalculate.Text = calc.AddNumber(labelCalculate.Text, "4");
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            labelCalculate.Text = calc.AddNumber(labelCalculate.Text, "5");
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            labelCalculate.Text = calc.AddNumber(labelCalculate.Text, "6");
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            labelCalculate.Text = calc.AddNumber(labelCalculate.Text, "7");
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            labelCalculate.Text = calc.AddNumber(labelCalculate.Text, "8");
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            labelCalculate.Text = calc.AddNumber(labelCalculate.Text, "9");
        }

        private void ButtonAddition_Click(object sender, EventArgs e)
        {
            oldValue = calc.Calculate(labelCalculate.Text, currentOperator, oldValue);
            labelResult.Text = oldValue;
            currentOperator = "+";
            labelOperator.Text = currentOperator;
            labelCalculate.Text = "0";
        }

        private void ButtonSubstraction_Click(object sender, EventArgs e)
        {
            oldValue = calc.Calculate(labelCalculate.Text, currentOperator, oldValue);
            labelResult.Text = oldValue;
            currentOperator = "-";
            labelOperator.Text = currentOperator;
            labelCalculate.Text = "0";
        }

        private void ButtonMultiplication_Click(object sender, EventArgs e)
        {
            oldValue = calc.Calculate(labelCalculate.Text, currentOperator, oldValue);
            labelResult.Text = oldValue;
            currentOperator = "*";
            labelOperator.Text = currentOperator;
            labelCalculate.Text = "0";
        }

        //Fehlertext für "Durch 0 teilen" in Methode für Rechung allgemein?
        private void ButtonDivision_Click(object sender, EventArgs e)
        {
            if (labelCalculate.Text != "0")
            {
                oldValue = calc.Calculate(labelCalculate.Text, currentOperator, oldValue);
                labelResult.Text = oldValue;
                currentOperator = "/";
                labelOperator.Text = currentOperator;
            }
            else
            {
                labelCalculate.Text = "Du kannst nicht durch 0 teilen!";
                System.Threading.Thread.Sleep(500);
            }
            
            
            labelCalculate.Text = "0";
        }

        private void ButtonComma_Click(object sender, EventArgs e)
        {
            labelCalculate.Text = calc.AddComma(labelCalculate.Text);

        }

        private void ButtonCE_Click(object sender, EventArgs e)
        {
            labelCalculate.Text = "0";
        }
        private void ButtonC_Click(object sender, EventArgs e)
        {
            currentOperator = "";
            labelOperator.Text = "";
            oldValue = "0";
            labelCalculate.Text = "0";
            labelResult.Text = "";
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
                case Keys.D0: labelCalculate.Text = calc.AddNumber(labelCalculate.Text, "0"); break;
                case Keys.D1: labelCalculate.Text = calc.AddNumber(labelCalculate.Text, "1"); break;
                case Keys.D2: labelCalculate.Text = calc.AddNumber(labelCalculate.Text, "2"); break;
                case Keys.D3: labelCalculate.Text = calc.AddNumber(labelCalculate.Text, "3"); break;
                case Keys.D4: labelCalculate.Text = calc.AddNumber(labelCalculate.Text, "4"); break;
                case Keys.D5: labelCalculate.Text = calc.AddNumber(labelCalculate.Text, "5"); break;
                case Keys.D6: labelCalculate.Text = calc.AddNumber(labelCalculate.Text, "6"); break;
                case Keys.D7: labelCalculate.Text = calc.AddNumber(labelCalculate.Text, "7"); break;
                case Keys.D8: labelCalculate.Text = calc.AddNumber(labelCalculate.Text, "8"); break;
                case Keys.D9: labelCalculate.Text = calc.AddNumber(labelCalculate.Text, "9"); break;
                
                case Keys.Oemcomma: labelCalculate.Text = calc.AddComma(labelCalculate.Text); break;


            }
        }

        private void ButtonNegate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(labelResult.Text))
            {
                oldValue = (double.Parse(labelResult.Text) * (-1)).ToString();
                labelResult.Text = oldValue; 
            }
        }
    }
}

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
        float labelCalcFontSize = 0;
        float labelResultFontSize = 0;

        public Form1()
        {
            InitializeComponent();
            labelCalcFontSize = labelCalculate.Font.Size;
            labelResultFontSize = labelResult.Font.Size;
        }

        //Numbers

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

        private void ButtonComma_Click(object sender, EventArgs e)
        {
            labelCalculate.Text = calc.AddComma(labelCalculate.Text);

        }

        //Calculation with two operands

        private void ButtonAddition_Click(object sender, EventArgs e)
        {
            CalcWithTwoOperands("+");
        }

        private void ButtonSubstraction_Click(object sender, EventArgs e)
        {
            CalcWithTwoOperands("-");
        }

        private void ButtonMultiplication_Click(object sender, EventArgs e)
        {
            CalcWithTwoOperands("*");

        }

        private void ButtonDivision_Click(object sender, EventArgs e)
        {
           
            CalcWithTwoOperands("/");
        }

        private void ButtonMod_Click(object sender, EventArgs e)
        {
            CalcWithTwoOperands("Mod");
        }

        private void ButtonPercent_Click(object sender, EventArgs e)
        {
            CalcWithTwoOperands("%");
        }

        private void ButtonPower_Click(object sender, EventArgs e)
        {
            CalcWithTwoOperands("x^y");
        }

        //Calculation with one operand

        private void ButtonSquare_Click(object sender, EventArgs e)
        {
            CalcWithOneOperand("square");
        }

        private void ButtonRoot_Click(object sender, EventArgs e)
        {
            try
            {
                if (labelCalculate.Text.StartsWith("-"))
                    throw new Exception();

                labelCalculate.Text = calc.SinCosTan(labelCalculate.Text, "root");
                AutoFitLabelSize(labelCalculate, labelCalcFontSize);
            }
            catch
            {
                MessageBox.Show("Math Error.");
                ButtonC_Click(null, null);
            }
        }

        private void ButtonSin_Click(object sender, EventArgs e)
        {
            CalcWithOneOperand("sin");
        }

        private void ButtonCos_Click(object sender, EventArgs e)
        {
            CalcWithOneOperand("cos");
        }

        private void ButtonTan_Click(object sender, EventArgs e)
        {
            CalcWithOneOperand("tan");
        }

        //Etc.

        private void ButtonCE_Click(object sender, EventArgs e)
        {
            labelCalculate.Text = "0";
            AutoFitLabelSize(labelCalculate, labelCalcFontSize);
        }
        private void ButtonC_Click(object sender, EventArgs e)
        {
            currentOperator = "";
            labelOperator.Text = "";
            oldValue = "0";
            labelCalculate.Text = "0";
            labelResult.Text = "";
            EnableButtons(true);
            AutoFitLabelSize(labelCalculate, labelCalcFontSize);
        }
        private void ButtonNegate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(labelCalculate.Text))
            {
                labelCalculate.Text = (double.Parse(labelCalculate.Text) * (-1)).ToString();
            }
        }
        private void ButtonCalculate_Click(object sender, EventArgs e)
        {
            oldValue = calc.Calculate(labelCalculate.Text, currentOperator, labelResult.Text);
            labelCalculate.Text = oldValue;
            labelResult.Text = "";
            oldValue = "0";
            currentOperator = "";
            labelOperator.Text = currentOperator;
            AutoFitLabelSize(labelCalculate, labelCalcFontSize);
        }
        private void ButtonBackspace_Click(object sender, EventArgs e)
        {
            int textLength = labelCalculate.Text.Length;
            int charsToRemove = 1;

            if (labelCalculate.Text.Contains("E") || textLength < 2 || (textLength == 2 && labelCalculate.Text[0] == '-'))
            {
                labelCalculate.Text = "0";
                AutoFitLabelSize(labelCalculate, labelCalcFontSize);
                return;
            }

            if (textLength >= 3 && labelCalculate.Text[textLength - 2] == ',')
            {
                charsToRemove = 2;
            }

            labelCalculate.Text = labelCalculate.Text.Substring(0, textLength - charsToRemove);
            AutoFitLabelSize(labelCalculate, labelCalcFontSize);
        }
        private void EnableButtons(bool enable)
        {
            button0.Enabled = enable;
            button1.Enabled = enable;
            button2.Enabled = enable;
            button3.Enabled = enable;
            button4.Enabled = enable;
            button5.Enabled = enable;
            button6.Enabled = enable;
            button7.Enabled = enable;
            button8.Enabled = enable;
            button9.Enabled = enable;
            buttonAddition.Enabled = enable;
            buttonBackspace.Enabled = enable;
            buttonDivision.Enabled = enable;
            buttonCalculate.Enabled = enable;
            buttonCE.Enabled = enable;
            buttonComma.Enabled = enable;
            buttonCos.Enabled = enable;
            buttonMultiplication.Enabled = enable;
            buttonNegate.Enabled = enable;
            buttonC.Enabled = enable;
            buttonSin.Enabled = enable;
            buttonSubstraction.Enabled = enable;
            buttonTan.Enabled = enable;
            buttonPercent.Enabled = enable;
            buttonRoot.Enabled = enable;
            buttonSquare.Enabled = enable;
            buttonMod.Enabled = enable;
            
        }
        private void AutoFitLabelSize(Label label, float baseSize)
        {
            label.Font = new Font(label.Font.FontFamily, baseSize, label.Font.Style);
            while (label.Width < TextRenderer.MeasureText(label.Text, new Font(label.Font.FontFamily, label.Font.Size, label.Font.Style)).Width)
            {
                label.Font = new Font(label.Font.FontFamily, label.Font.Size - 0.5f, label.Font.Style);
            }
        }
        private void CalcWithTwoOperands(string switchOperator)
        {
            try
            {
                if (labelCalculate.Text == "0" && labelOperator.Text == "/")
                    throw new Exception();
                oldValue = calc.Calculate(labelCalculate.Text, currentOperator, oldValue);
                labelResult.Text = oldValue;
                currentOperator = switchOperator;
                labelOperator.Text = currentOperator;
                AutoFitLabelSize(labelOperator, labelCalcFontSize);
                labelCalculate.Text = "0";
                AutoFitLabelSize(labelResult, labelResultFontSize);
            }
            catch
            {
                MessageBox.Show("You can't divide by zero.");
                ButtonC_Click(null, null);
            }
        }
        private void CalcWithOneOperand(string switchOperator)
        {
            labelCalculate.Text = calc.SinCosTan(labelCalculate.Text, switchOperator);
            AutoFitLabelSize(labelCalculate, labelCalcFontSize);
        }
    }
}

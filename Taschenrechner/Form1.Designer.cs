namespace Taschenrechner
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonBackspace = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonCE = new System.Windows.Forms.Button();
            this.labelCalculate = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonComma = new System.Windows.Forms.Button();
            this.buttonAddition = new System.Windows.Forms.Button();
            this.buttonSubstraction = new System.Windows.Forms.Button();
            this.buttonMultiplication = new System.Windows.Forms.Button();
            this.buttonDivision = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.buttonPercent = new System.Windows.Forms.Button();
            this.buttonMod = new System.Windows.Forms.Button();
            this.buttonSquare = new System.Windows.Forms.Button();
            this.buttonRoot = new System.Windows.Forms.Button();
            this.buttonNegate = new System.Windows.Forms.Button();
            this.buttonSin = new System.Windows.Forms.Button();
            this.buttonCos = new System.Windows.Forms.Button();
            this.buttonTan = new System.Windows.Forms.Button();
            this.labelOperator = new System.Windows.Forms.Label();
            this.buttonPower = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonBackspace
            // 
            this.buttonBackspace.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBackspace.Location = new System.Drawing.Point(255, 91);
            this.buttonBackspace.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonBackspace.Name = "buttonBackspace";
            this.buttonBackspace.Size = new System.Drawing.Size(57, 49);
            this.buttonBackspace.TabIndex = 37;
            this.buttonBackspace.Text = "⌫";
            this.buttonBackspace.UseVisualStyleBackColor = true;
            this.buttonBackspace.Click += new System.EventHandler(this.ButtonBackspace_Click);
            // 
            // buttonC
            // 
            this.buttonC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonC.Location = new System.Drawing.Point(132, 91);
            this.buttonC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(57, 49);
            this.buttonC.TabIndex = 36;
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = true;
            this.buttonC.Click += new System.EventHandler(this.ButtonC_Click);
            // 
            // buttonCE
            // 
            this.buttonCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCE.Location = new System.Drawing.Point(194, 91);
            this.buttonCE.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCE.Name = "buttonCE";
            this.buttonCE.Size = new System.Drawing.Size(57, 49);
            this.buttonCE.TabIndex = 35;
            this.buttonCE.Text = "CE";
            this.buttonCE.UseVisualStyleBackColor = true;
            this.buttonCE.Click += new System.EventHandler(this.ButtonCE_Click);
            // 
            // labelCalculate
            // 
            this.labelCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCalculate.Location = new System.Drawing.Point(53, 44);
            this.labelCalculate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCalculate.Name = "labelCalculate";
            this.labelCalculate.Size = new System.Drawing.Size(259, 45);
            this.labelCalculate.TabIndex = 34;
            this.labelCalculate.Text = "0";
            this.labelCalculate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelResult
            // 
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResult.ForeColor = System.Drawing.Color.SlateGray;
            this.labelResult.Location = new System.Drawing.Point(17, 15);
            this.labelResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(292, 29);
            this.labelResult.TabIndex = 33;
            this.labelResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalculate.Location = new System.Drawing.Point(255, 356);
            this.buttonCalculate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(57, 49);
            this.buttonCalculate.TabIndex = 32;
            this.buttonCalculate.Text = "=";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.ButtonCalculate_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Wheat;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(71, 303);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 49);
            this.button1.TabIndex = 16;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button0
            // 
            this.button0.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button0.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button0.FlatAppearance.CheckedBackColor = System.Drawing.Color.Wheat;
            this.button0.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button0.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button0.Location = new System.Drawing.Point(132, 356);
            this.button0.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(57, 49);
            this.button0.TabIndex = 31;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = false;
            this.button0.Click += new System.EventHandler(this.Button0_Click);
            // 
            // buttonComma
            // 
            this.buttonComma.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonComma.Location = new System.Drawing.Point(193, 356);
            this.buttonComma.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonComma.Name = "buttonComma";
            this.buttonComma.Size = new System.Drawing.Size(57, 49);
            this.buttonComma.TabIndex = 29;
            this.buttonComma.Text = ",";
            this.buttonComma.UseVisualStyleBackColor = true;
            this.buttonComma.Click += new System.EventHandler(this.ButtonComma_Click);
            // 
            // buttonAddition
            // 
            this.buttonAddition.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddition.Location = new System.Drawing.Point(255, 303);
            this.buttonAddition.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAddition.Name = "buttonAddition";
            this.buttonAddition.Size = new System.Drawing.Size(57, 49);
            this.buttonAddition.TabIndex = 28;
            this.buttonAddition.Text = "+";
            this.buttonAddition.UseVisualStyleBackColor = true;
            this.buttonAddition.Click += new System.EventHandler(this.ButtonAddition_Click);
            // 
            // buttonSubstraction
            // 
            this.buttonSubstraction.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubstraction.Location = new System.Drawing.Point(255, 250);
            this.buttonSubstraction.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSubstraction.Name = "buttonSubstraction";
            this.buttonSubstraction.Size = new System.Drawing.Size(57, 49);
            this.buttonSubstraction.TabIndex = 27;
            this.buttonSubstraction.Text = "−";
            this.buttonSubstraction.UseVisualStyleBackColor = true;
            this.buttonSubstraction.Click += new System.EventHandler(this.ButtonSubstraction_Click);
            // 
            // buttonMultiplication
            // 
            this.buttonMultiplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMultiplication.Location = new System.Drawing.Point(254, 197);
            this.buttonMultiplication.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonMultiplication.Name = "buttonMultiplication";
            this.buttonMultiplication.Size = new System.Drawing.Size(57, 49);
            this.buttonMultiplication.TabIndex = 26;
            this.buttonMultiplication.Text = "×";
            this.buttonMultiplication.UseVisualStyleBackColor = true;
            this.buttonMultiplication.Click += new System.EventHandler(this.ButtonMultiplication_Click);
            // 
            // buttonDivision
            // 
            this.buttonDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDivision.Location = new System.Drawing.Point(254, 144);
            this.buttonDivision.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDivision.Name = "buttonDivision";
            this.buttonDivision.Size = new System.Drawing.Size(57, 49);
            this.buttonDivision.TabIndex = 25;
            this.buttonDivision.Text = "÷";
            this.buttonDivision.UseVisualStyleBackColor = true;
            this.buttonDivision.Click += new System.EventHandler(this.ButtonDivision_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button9.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button9.FlatAppearance.CheckedBackColor = System.Drawing.Color.Wheat;
            this.button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(193, 197);
            this.button9.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(57, 49);
            this.button9.TabIndex = 24;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.Button9_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button8.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button8.FlatAppearance.CheckedBackColor = System.Drawing.Color.Wheat;
            this.button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(132, 197);
            this.button8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(57, 49);
            this.button8.TabIndex = 23;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.Button8_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button7.FlatAppearance.CheckedBackColor = System.Drawing.Color.Wheat;
            this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(71, 197);
            this.button7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(57, 49);
            this.button7.TabIndex = 22;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button6.FlatAppearance.CheckedBackColor = System.Drawing.Color.Wheat;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(193, 250);
            this.button6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(57, 49);
            this.button6.TabIndex = 21;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button5.FlatAppearance.CheckedBackColor = System.Drawing.Color.Wheat;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(132, 250);
            this.button5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(57, 49);
            this.button5.TabIndex = 20;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button4.FlatAppearance.CheckedBackColor = System.Drawing.Color.Wheat;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(71, 250);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(57, 49);
            this.button4.TabIndex = 19;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Wheat;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(193, 303);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(57, 49);
            this.button3.TabIndex = 18;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Wheat;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(132, 303);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(57, 49);
            this.button2.TabIndex = 17;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 415);
            this.splitter1.TabIndex = 17;
            this.splitter1.TabStop = false;
            // 
            // buttonPercent
            // 
            this.buttonPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPercent.Location = new System.Drawing.Point(11, 144);
            this.buttonPercent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonPercent.Name = "buttonPercent";
            this.buttonPercent.Size = new System.Drawing.Size(57, 49);
            this.buttonPercent.TabIndex = 38;
            this.buttonPercent.Text = "%";
            this.buttonPercent.UseVisualStyleBackColor = true;
            this.buttonPercent.Click += new System.EventHandler(this.ButtonPercent_Click);
            // 
            // buttonMod
            // 
            this.buttonMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMod.Location = new System.Drawing.Point(11, 355);
            this.buttonMod.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonMod.Name = "buttonMod";
            this.buttonMod.Size = new System.Drawing.Size(57, 49);
            this.buttonMod.TabIndex = 39;
            this.buttonMod.Text = "Mod";
            this.buttonMod.UseVisualStyleBackColor = true;
            this.buttonMod.Click += new System.EventHandler(this.ButtonMod_Click);
            // 
            // buttonSquare
            // 
            this.buttonSquare.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonSquare.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonSquare.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSquare.Location = new System.Drawing.Point(11, 250);
            this.buttonSquare.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSquare.Name = "buttonSquare";
            this.buttonSquare.Size = new System.Drawing.Size(57, 49);
            this.buttonSquare.TabIndex = 40;
            this.buttonSquare.Text = " x²";
            this.buttonSquare.UseVisualStyleBackColor = false;
            this.buttonSquare.Click += new System.EventHandler(this.ButtonSquare_Click);
            // 
            // buttonRoot
            // 
            this.buttonRoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRoot.Location = new System.Drawing.Point(11, 197);
            this.buttonRoot.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonRoot.Name = "buttonRoot";
            this.buttonRoot.Size = new System.Drawing.Size(57, 49);
            this.buttonRoot.TabIndex = 41;
            this.buttonRoot.Text = "²√";
            this.buttonRoot.UseVisualStyleBackColor = true;
            this.buttonRoot.Click += new System.EventHandler(this.ButtonRoot_Click);
            // 
            // buttonNegate
            // 
            this.buttonNegate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNegate.Location = new System.Drawing.Point(71, 356);
            this.buttonNegate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonNegate.Name = "buttonNegate";
            this.buttonNegate.Size = new System.Drawing.Size(57, 49);
            this.buttonNegate.TabIndex = 42;
            this.buttonNegate.Text = "±";
            this.buttonNegate.UseVisualStyleBackColor = true;
            this.buttonNegate.Click += new System.EventHandler(this.ButtonNegate_Click);
            // 
            // buttonSin
            // 
            this.buttonSin.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonSin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSin.Location = new System.Drawing.Point(71, 144);
            this.buttonSin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSin.Name = "buttonSin";
            this.buttonSin.Size = new System.Drawing.Size(57, 49);
            this.buttonSin.TabIndex = 43;
            this.buttonSin.Text = "sin";
            this.buttonSin.UseVisualStyleBackColor = false;
            this.buttonSin.Click += new System.EventHandler(this.ButtonSin_Click);
            // 
            // buttonCos
            // 
            this.buttonCos.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonCos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCos.Location = new System.Drawing.Point(132, 144);
            this.buttonCos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCos.Name = "buttonCos";
            this.buttonCos.Size = new System.Drawing.Size(57, 49);
            this.buttonCos.TabIndex = 44;
            this.buttonCos.Text = "cos";
            this.buttonCos.UseVisualStyleBackColor = false;
            this.buttonCos.Click += new System.EventHandler(this.ButtonCos_Click);
            // 
            // buttonTan
            // 
            this.buttonTan.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonTan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTan.Location = new System.Drawing.Point(194, 144);
            this.buttonTan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonTan.Name = "buttonTan";
            this.buttonTan.Size = new System.Drawing.Size(57, 49);
            this.buttonTan.TabIndex = 45;
            this.buttonTan.Text = "tan";
            this.buttonTan.UseVisualStyleBackColor = false;
            this.buttonTan.Click += new System.EventHandler(this.ButtonTan_Click);
            // 
            // labelOperator
            // 
            this.labelOperator.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelOperator.AutoEllipsis = true;
            this.labelOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOperator.Location = new System.Drawing.Point(15, 44);
            this.labelOperator.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOperator.Name = "labelOperator";
            this.labelOperator.Size = new System.Drawing.Size(42, 45);
            this.labelOperator.TabIndex = 46;
            this.labelOperator.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonPower
            // 
            this.buttonPower.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonPower.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPower.Location = new System.Drawing.Point(11, 303);
            this.buttonPower.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPower.Name = "buttonPower";
            this.buttonPower.Size = new System.Drawing.Size(57, 49);
            this.buttonPower.TabIndex = 47;
            this.buttonPower.Text = " x^y";
            this.buttonPower.UseVisualStyleBackColor = false;
            this.buttonPower.Click += new System.EventHandler(this.ButtonPower_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 415);
            this.Controls.Add(this.buttonPower);
            this.Controls.Add(this.labelOperator);
            this.Controls.Add(this.buttonTan);
            this.Controls.Add(this.buttonCos);
            this.Controls.Add(this.buttonSin);
            this.Controls.Add(this.buttonNegate);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.buttonRoot);
            this.Controls.Add(this.buttonSquare);
            this.Controls.Add(this.labelCalculate);
            this.Controls.Add(this.buttonMod);
            this.Controls.Add(this.buttonPercent);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonBackspace);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonC);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttonCE);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.buttonComma);
            this.Controls.Add(this.buttonDivision);
            this.Controls.Add(this.buttonAddition);
            this.Controls.Add(this.buttonMultiplication);
            this.Controls.Add(this.buttonSubstraction);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Taschenrechner";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyboardInput);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonComma;
        private System.Windows.Forms.Button buttonAddition;
        private System.Windows.Forms.Button buttonSubstraction;
        private System.Windows.Forms.Button buttonMultiplication;
        private System.Windows.Forms.Button buttonDivision;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelCalculate;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Button buttonBackspace;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonCE;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button buttonRoot;
        private System.Windows.Forms.Button buttonSquare;
        private System.Windows.Forms.Button buttonMod;
        private System.Windows.Forms.Button buttonPercent;
        private System.Windows.Forms.Button buttonNegate;
        private System.Windows.Forms.Button buttonSin;
        private System.Windows.Forms.Button buttonCos;
        private System.Windows.Forms.Button buttonTan;
        private System.Windows.Forms.Label labelOperator;
        private System.Windows.Forms.Button buttonPower;
    }
}


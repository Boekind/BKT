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
            this.buttonASin = new System.Windows.Forms.Button();
            this.buttonPi = new System.Windows.Forms.Button();
            this.buttonRound = new System.Windows.Forms.Button();
            this.buttonATan = new System.Windows.Forms.Button();
            this.buttonACos = new System.Windows.Forms.Button();
            this.buttonScience = new System.Windows.Forms.Button();
            this.buttonFloor = new System.Windows.Forms.Button();
            this.buttonCeil = new System.Windows.Forms.Button();
            this.buttonLn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonBackspace
            // 
            this.buttonBackspace.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBackspace.Location = new System.Drawing.Point(382, 140);
            this.buttonBackspace.Name = "buttonBackspace";
            this.buttonBackspace.Size = new System.Drawing.Size(86, 75);
            this.buttonBackspace.TabIndex = 37;
            this.buttonBackspace.Text = "⌫";
            this.buttonBackspace.UseVisualStyleBackColor = true;
            this.buttonBackspace.Click += new System.EventHandler(this.ButtonBackspace_Click);
            // 
            // buttonC
            // 
            this.buttonC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonC.Location = new System.Drawing.Point(198, 140);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(86, 75);
            this.buttonC.TabIndex = 36;
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = true;
            this.buttonC.Click += new System.EventHandler(this.ButtonC_Click);
            // 
            // buttonCE
            // 
            this.buttonCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCE.Location = new System.Drawing.Point(291, 140);
            this.buttonCE.Name = "buttonCE";
            this.buttonCE.Size = new System.Drawing.Size(86, 75);
            this.buttonCE.TabIndex = 35;
            this.buttonCE.Text = "CE";
            this.buttonCE.UseVisualStyleBackColor = true;
            this.buttonCE.Click += new System.EventHandler(this.ButtonCE_Click);
            // 
            // labelCalculate
            // 
            this.labelCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCalculate.Location = new System.Drawing.Point(79, 68);
            this.labelCalculate.Name = "labelCalculate";
            this.labelCalculate.Size = new System.Drawing.Size(388, 69);
            this.labelCalculate.TabIndex = 34;
            this.labelCalculate.Text = "0";
            this.labelCalculate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelResult
            // 
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResult.ForeColor = System.Drawing.Color.SlateGray;
            this.labelResult.Location = new System.Drawing.Point(29, 23);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(438, 45);
            this.labelResult.TabIndex = 33;
            this.labelResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalculate.Location = new System.Drawing.Point(382, 548);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(86, 75);
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
            this.button1.Location = new System.Drawing.Point(106, 466);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 75);
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
            this.button0.Location = new System.Drawing.Point(198, 548);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(86, 75);
            this.button0.TabIndex = 31;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = false;
            this.button0.Click += new System.EventHandler(this.Button0_Click);
            // 
            // buttonComma
            // 
            this.buttonComma.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonComma.Location = new System.Drawing.Point(290, 548);
            this.buttonComma.Name = "buttonComma";
            this.buttonComma.Size = new System.Drawing.Size(86, 75);
            this.buttonComma.TabIndex = 29;
            this.buttonComma.Text = ",";
            this.buttonComma.UseVisualStyleBackColor = true;
            this.buttonComma.Click += new System.EventHandler(this.ButtonComma_Click);
            // 
            // buttonAddition
            // 
            this.buttonAddition.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddition.Location = new System.Drawing.Point(382, 466);
            this.buttonAddition.Name = "buttonAddition";
            this.buttonAddition.Size = new System.Drawing.Size(86, 75);
            this.buttonAddition.TabIndex = 28;
            this.buttonAddition.Text = "+";
            this.buttonAddition.UseVisualStyleBackColor = true;
            this.buttonAddition.Click += new System.EventHandler(this.ButtonAddition_Click);
            // 
            // buttonSubstraction
            // 
            this.buttonSubstraction.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubstraction.Location = new System.Drawing.Point(382, 385);
            this.buttonSubstraction.Name = "buttonSubstraction";
            this.buttonSubstraction.Size = new System.Drawing.Size(86, 75);
            this.buttonSubstraction.TabIndex = 27;
            this.buttonSubstraction.Text = "−";
            this.buttonSubstraction.UseVisualStyleBackColor = true;
            this.buttonSubstraction.Click += new System.EventHandler(this.ButtonSubstraction_Click);
            // 
            // buttonMultiplication
            // 
            this.buttonMultiplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMultiplication.Location = new System.Drawing.Point(381, 303);
            this.buttonMultiplication.Name = "buttonMultiplication";
            this.buttonMultiplication.Size = new System.Drawing.Size(86, 75);
            this.buttonMultiplication.TabIndex = 26;
            this.buttonMultiplication.Text = "×";
            this.buttonMultiplication.UseVisualStyleBackColor = true;
            this.buttonMultiplication.Click += new System.EventHandler(this.ButtonMultiplication_Click);
            // 
            // buttonDivision
            // 
            this.buttonDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDivision.Location = new System.Drawing.Point(381, 222);
            this.buttonDivision.Name = "buttonDivision";
            this.buttonDivision.Size = new System.Drawing.Size(86, 75);
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
            this.button9.Location = new System.Drawing.Point(290, 303);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(86, 75);
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
            this.button8.Location = new System.Drawing.Point(198, 303);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(86, 75);
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
            this.button7.Location = new System.Drawing.Point(106, 303);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(86, 75);
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
            this.button6.Location = new System.Drawing.Point(290, 385);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(86, 75);
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
            this.button5.Location = new System.Drawing.Point(198, 385);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(86, 75);
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
            this.button4.Location = new System.Drawing.Point(106, 385);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(86, 75);
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
            this.button3.Location = new System.Drawing.Point(290, 466);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 75);
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
            this.button2.Location = new System.Drawing.Point(198, 466);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 75);
            this.button2.TabIndex = 17;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(4, 638);
            this.splitter1.TabIndex = 17;
            this.splitter1.TabStop = false;
            // 
            // buttonPercent
            // 
            this.buttonPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPercent.Location = new System.Drawing.Point(16, 222);
            this.buttonPercent.Name = "buttonPercent";
            this.buttonPercent.Size = new System.Drawing.Size(86, 75);
            this.buttonPercent.TabIndex = 38;
            this.buttonPercent.Text = "%";
            this.buttonPercent.UseVisualStyleBackColor = true;
            this.buttonPercent.Click += new System.EventHandler(this.ButtonPercent_Click);
            // 
            // buttonMod
            // 
            this.buttonMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMod.Location = new System.Drawing.Point(16, 546);
            this.buttonMod.Name = "buttonMod";
            this.buttonMod.Size = new System.Drawing.Size(86, 75);
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
            this.buttonSquare.Location = new System.Drawing.Point(16, 385);
            this.buttonSquare.Name = "buttonSquare";
            this.buttonSquare.Size = new System.Drawing.Size(86, 75);
            this.buttonSquare.TabIndex = 40;
            this.buttonSquare.Text = " x²";
            this.buttonSquare.UseVisualStyleBackColor = false;
            this.buttonSquare.Click += new System.EventHandler(this.ButtonSquare_Click);
            // 
            // buttonRoot
            // 
            this.buttonRoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRoot.Location = new System.Drawing.Point(16, 303);
            this.buttonRoot.Name = "buttonRoot";
            this.buttonRoot.Size = new System.Drawing.Size(86, 75);
            this.buttonRoot.TabIndex = 41;
            this.buttonRoot.Text = "²√";
            this.buttonRoot.UseVisualStyleBackColor = true;
            this.buttonRoot.Click += new System.EventHandler(this.ButtonRoot_Click);
            // 
            // buttonNegate
            // 
            this.buttonNegate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNegate.Location = new System.Drawing.Point(106, 548);
            this.buttonNegate.Name = "buttonNegate";
            this.buttonNegate.Size = new System.Drawing.Size(86, 75);
            this.buttonNegate.TabIndex = 42;
            this.buttonNegate.Text = "±";
            this.buttonNegate.UseVisualStyleBackColor = true;
            this.buttonNegate.Click += new System.EventHandler(this.ButtonNegate_Click);
            // 
            // buttonSin
            // 
            this.buttonSin.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonSin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSin.Location = new System.Drawing.Point(106, 222);
            this.buttonSin.Name = "buttonSin";
            this.buttonSin.Size = new System.Drawing.Size(86, 75);
            this.buttonSin.TabIndex = 43;
            this.buttonSin.Text = "sin";
            this.buttonSin.UseVisualStyleBackColor = false;
            this.buttonSin.Click += new System.EventHandler(this.ButtonSin_Click);
            // 
            // buttonCos
            // 
            this.buttonCos.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonCos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCos.Location = new System.Drawing.Point(198, 222);
            this.buttonCos.Name = "buttonCos";
            this.buttonCos.Size = new System.Drawing.Size(86, 75);
            this.buttonCos.TabIndex = 44;
            this.buttonCos.Text = "cos";
            this.buttonCos.UseVisualStyleBackColor = false;
            this.buttonCos.Click += new System.EventHandler(this.ButtonCos_Click);
            // 
            // buttonTan
            // 
            this.buttonTan.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonTan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTan.Location = new System.Drawing.Point(291, 222);
            this.buttonTan.Name = "buttonTan";
            this.buttonTan.Size = new System.Drawing.Size(86, 75);
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
            this.labelOperator.Location = new System.Drawing.Point(12, 69);
            this.labelOperator.Name = "labelOperator";
            this.labelOperator.Size = new System.Drawing.Size(63, 69);
            this.labelOperator.TabIndex = 46;
            this.labelOperator.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonPower
            // 
            this.buttonPower.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonPower.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPower.Location = new System.Drawing.Point(16, 466);
            this.buttonPower.Name = "buttonPower";
            this.buttonPower.Size = new System.Drawing.Size(86, 75);
            this.buttonPower.TabIndex = 47;
            this.buttonPower.Text = " x^y";
            this.buttonPower.UseVisualStyleBackColor = false;
            this.buttonPower.Click += new System.EventHandler(this.ButtonPower_Click);
            // 
            // buttonASin
            // 
            this.buttonASin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonASin.Location = new System.Drawing.Point(493, 303);
            this.buttonASin.Name = "buttonASin";
            this.buttonASin.Size = new System.Drawing.Size(86, 75);
            this.buttonASin.TabIndex = 48;
            this.buttonASin.Text = "aSin";
            this.buttonASin.UseVisualStyleBackColor = true;
            this.buttonASin.Click += new System.EventHandler(this.ButtonASin_Click);
            // 
            // buttonPi
            // 
            this.buttonPi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPi.Location = new System.Drawing.Point(493, 548);
            this.buttonPi.Name = "buttonPi";
            this.buttonPi.Size = new System.Drawing.Size(86, 75);
            this.buttonPi.TabIndex = 49;
            this.buttonPi.Text = "Pi";
            this.buttonPi.UseVisualStyleBackColor = true;
            this.buttonPi.Click += new System.EventHandler(this.ButtonPi_Click);
            // 
            // buttonRound
            // 
            this.buttonRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRound.Location = new System.Drawing.Point(588, 385);
            this.buttonRound.Name = "buttonRound";
            this.buttonRound.Size = new System.Drawing.Size(86, 75);
            this.buttonRound.TabIndex = 50;
            this.buttonRound.Text = "Round";
            this.buttonRound.UseVisualStyleBackColor = true;
            this.buttonRound.Click += new System.EventHandler(this.ButtonRound_Click);
            // 
            // buttonATan
            // 
            this.buttonATan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonATan.Location = new System.Drawing.Point(493, 467);
            this.buttonATan.Name = "buttonATan";
            this.buttonATan.Size = new System.Drawing.Size(86, 75);
            this.buttonATan.TabIndex = 51;
            this.buttonATan.Text = "aTan";
            this.buttonATan.UseVisualStyleBackColor = true;
            this.buttonATan.Click += new System.EventHandler(this.ButtonATan_Click);
            // 
            // buttonACos
            // 
            this.buttonACos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonACos.Location = new System.Drawing.Point(493, 386);
            this.buttonACos.Name = "buttonACos";
            this.buttonACos.Size = new System.Drawing.Size(86, 75);
            this.buttonACos.TabIndex = 52;
            this.buttonACos.Text = "aCos";
            this.buttonACos.UseVisualStyleBackColor = true;
            this.buttonACos.Click += new System.EventHandler(this.ButtonACos_Click);
            // 
            // buttonScience
            // 
            this.buttonScience.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonScience.Location = new System.Drawing.Point(16, 141);
            this.buttonScience.Name = "buttonScience";
            this.buttonScience.Size = new System.Drawing.Size(86, 75);
            this.buttonScience.TabIndex = 53;
            this.buttonScience.Text = "W";
            this.buttonScience.UseVisualStyleBackColor = true;
            this.buttonScience.Click += new System.EventHandler(this.ButtonScience_Click);
            // 
            // buttonFloor
            // 
            this.buttonFloor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFloor.Location = new System.Drawing.Point(588, 466);
            this.buttonFloor.Name = "buttonFloor";
            this.buttonFloor.Size = new System.Drawing.Size(86, 75);
            this.buttonFloor.TabIndex = 55;
            this.buttonFloor.Text = "Floor";
            this.buttonFloor.UseVisualStyleBackColor = true;
            this.buttonFloor.Click += new System.EventHandler(this.ButtonFloor_Click);
            // 
            // buttonCeil
            // 
            this.buttonCeil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCeil.Location = new System.Drawing.Point(588, 303);
            this.buttonCeil.Name = "buttonCeil";
            this.buttonCeil.Size = new System.Drawing.Size(86, 75);
            this.buttonCeil.TabIndex = 56;
            this.buttonCeil.Text = "Ceil";
            this.buttonCeil.UseVisualStyleBackColor = true;
            this.buttonCeil.Click += new System.EventHandler(this.ButtonCeil_Click);
            // 
            // buttonLn
            // 
            this.buttonLn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLn.Location = new System.Drawing.Point(588, 547);
            this.buttonLn.Name = "buttonLn";
            this.buttonLn.Size = new System.Drawing.Size(86, 75);
            this.buttonLn.TabIndex = 57;
            this.buttonLn.Text = "ln";
            this.buttonLn.UseVisualStyleBackColor = true;
            this.buttonLn.Click += new System.EventHandler(this.ButtonLn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 638);
            this.Controls.Add(this.buttonLn);
            this.Controls.Add(this.buttonCeil);
            this.Controls.Add(this.buttonFloor);
            this.Controls.Add(this.buttonScience);
            this.Controls.Add(this.buttonACos);
            this.Controls.Add(this.buttonATan);
            this.Controls.Add(this.buttonRound);
            this.Controls.Add(this.buttonPi);
            this.Controls.Add(this.buttonASin);
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
        private System.Windows.Forms.Button buttonASin;
        private System.Windows.Forms.Button buttonPi;
        private System.Windows.Forms.Button buttonRound;
        private System.Windows.Forms.Button buttonATan;
        private System.Windows.Forms.Button buttonACos;
        private System.Windows.Forms.Button buttonScience;
        private System.Windows.Forms.Button buttonFloor;
        private System.Windows.Forms.Button buttonCeil;
        private System.Windows.Forms.Button buttonLn;
    }
}


namespace Calculator
{
    partial class Calculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.txtUi = new System.Windows.Forms.TextBox();
            this.txtHistory = new System.Windows.Forms.TextBox();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdoDeg = new System.Windows.Forms.RadioButton();
            this.rdoGrads = new System.Windows.Forms.RadioButton();
            this.rdoRadians = new System.Windows.Forms.RadioButton();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnLeftBrac = new System.Windows.Forms.Button();
            this.btnRightBrac = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDec = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnMemMinus = new System.Windows.Forms.Button();
            this.btnMemRecall = new System.Windows.Forms.Button();
            this.btnMemClr = new System.Windows.Forms.Button();
            this.btnMemSet = new System.Windows.Forms.Button();
            this.btnSinh = new System.Windows.Forms.Button();
            this.btnSin = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.btnMPlus = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUi
            // 
            this.txtUi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtUi.Location = new System.Drawing.Point(4, 1);
            this.txtUi.Name = "txtUi";
            this.txtUi.ReadOnly = true;
            this.txtUi.Size = new System.Drawing.Size(508, 26);
            this.txtUi.TabIndex = 1;
            // 
            // txtHistory
            // 
            this.txtHistory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtHistory.Location = new System.Drawing.Point(517, 31);
            this.txtHistory.Multiline = true;
            this.txtHistory.Name = "txtHistory";
            this.txtHistory.ReadOnly = true;
            this.txtHistory.Size = new System.Drawing.Size(128, 325);
            this.txtHistory.TabIndex = 2;
            this.txtHistory.TabStop = false;
            this.txtHistory.UseSystemPasswordChar = true;
            // 
            // txtAnswer
            // 
            this.txtAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtAnswer.Location = new System.Drawing.Point(518, 1);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.ReadOnly = true;
            this.txtAnswer.Size = new System.Drawing.Size(128, 26);
            this.txtAnswer.TabIndex = 14;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.rdoDeg);
            this.groupBox2.Controls.Add(this.rdoGrads);
            this.groupBox2.Controls.Add(this.rdoRadians);
            this.groupBox2.Location = new System.Drawing.Point(2, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(274, 47);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            // 
            // rdoDeg
            // 
            this.rdoDeg.AutoSize = true;
            this.rdoDeg.Location = new System.Drawing.Point(6, 19);
            this.rdoDeg.Name = "rdoDeg";
            this.rdoDeg.Size = new System.Drawing.Size(65, 17);
            this.rdoDeg.TabIndex = 25;
            this.rdoDeg.TabStop = true;
            this.rdoDeg.Text = "Degrees";
            this.rdoDeg.UseVisualStyleBackColor = true;
            this.rdoDeg.CheckedChanged += new System.EventHandler(this.rdoDeg_CheckedChanged);
            // 
            // rdoGrads
            // 
            this.rdoGrads.AutoSize = true;
            this.rdoGrads.Location = new System.Drawing.Point(215, 19);
            this.rdoGrads.Name = "rdoGrads";
            this.rdoGrads.Size = new System.Drawing.Size(53, 17);
            this.rdoGrads.TabIndex = 27;
            this.rdoGrads.TabStop = true;
            this.rdoGrads.Text = "Grads";
            this.rdoGrads.UseVisualStyleBackColor = true;
            // 
            // rdoRadians
            // 
            this.rdoRadians.AutoSize = true;
            this.rdoRadians.Location = new System.Drawing.Point(111, 19);
            this.rdoRadians.Name = "rdoRadians";
            this.rdoRadians.Size = new System.Drawing.Size(64, 17);
            this.rdoRadians.TabIndex = 26;
            this.rdoRadians.TabStop = true;
            this.rdoRadians.Text = "Radians";
            this.rdoRadians.UseVisualStyleBackColor = true;
            this.rdoRadians.CheckedChanged += new System.EventHandler(this.rdoRadians_CheckedChanged);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn7.Location = new System.Drawing.Point(4, 137);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(50, 50);
            this.btn7.TabIndex = 53;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.Number_Expression);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn8.Location = new System.Drawing.Point(60, 137);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(50, 50);
            this.btn8.TabIndex = 54;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.Number_Expression);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn9.Location = new System.Drawing.Point(116, 137);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(50, 50);
            this.btn9.TabIndex = 55;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.Number_Expression);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button3.Location = new System.Drawing.Point(172, 137);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 50);
            this.button3.TabIndex = 62;
            this.button3.Text = "-";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Basic_Expression);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn4.Location = new System.Drawing.Point(116, 193);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(50, 50);
            this.btn4.TabIndex = 50;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.Number_Expression);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn5.Location = new System.Drawing.Point(60, 193);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(50, 50);
            this.btn5.TabIndex = 51;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.Number_Expression);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn6.Location = new System.Drawing.Point(4, 193);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(50, 50);
            this.btn6.TabIndex = 52;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.Number_Expression);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button4.Location = new System.Drawing.Point(228, 193);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(50, 50);
            this.button4.TabIndex = 59;
            this.button4.Text = "+";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Basic_Expression);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn1.Location = new System.Drawing.Point(116, 249);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(50, 50);
            this.btn1.TabIndex = 47;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.Number_Expression);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn2.Location = new System.Drawing.Point(60, 249);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(50, 50);
            this.btn2.TabIndex = 48;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.Number_Expression);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn3.Location = new System.Drawing.Point(4, 249);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(50, 50);
            this.btn3.TabIndex = 49;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.Number_Expression);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button2.Location = new System.Drawing.Point(172, 193);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 50);
            this.button2.TabIndex = 61;
            this.button2.Text = "*";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Basic_Expression);
            // 
            // btnLeftBrac
            // 
            this.btnLeftBrac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnLeftBrac.Location = new System.Drawing.Point(116, 305);
            this.btnLeftBrac.Name = "btnLeftBrac";
            this.btnLeftBrac.Size = new System.Drawing.Size(50, 50);
            this.btnLeftBrac.TabIndex = 56;
            this.btnLeftBrac.Text = "(";
            this.btnLeftBrac.UseVisualStyleBackColor = true;
            this.btnLeftBrac.Click += new System.EventHandler(this.Basic_Expression);
            // 
            // btnRightBrac
            // 
            this.btnRightBrac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnRightBrac.Location = new System.Drawing.Point(172, 305);
            this.btnRightBrac.Name = "btnRightBrac";
            this.btnRightBrac.Size = new System.Drawing.Size(50, 50);
            this.btnRightBrac.TabIndex = 57;
            this.btnRightBrac.Text = ")";
            this.btnRightBrac.UseVisualStyleBackColor = true;
            this.btnRightBrac.Click += new System.EventHandler(this.Basic_Expression);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn0.Location = new System.Drawing.Point(4, 305);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(106, 50);
            this.btn0.TabIndex = 46;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.Number_Expression);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Location = new System.Drawing.Point(228, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 60;
            this.button1.Text = "/";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Basic_Expression);
            // 
            // btnDec
            // 
            this.btnDec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDec.Location = new System.Drawing.Point(172, 249);
            this.btnDec.Name = "btnDec";
            this.btnDec.Size = new System.Drawing.Size(50, 50);
            this.btnDec.TabIndex = 58;
            this.btnDec.Text = ".";
            this.btnDec.UseVisualStyleBackColor = true;
            this.btnDec.Click += new System.EventHandler(this.btnDec_Click);
            // 
            // btnEquals
            // 
            this.btnEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnEquals.Location = new System.Drawing.Point(228, 249);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(50, 106);
            this.btnEquals.TabIndex = 63;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = true;
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnClear.Location = new System.Drawing.Point(293, 82);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(50, 50);
            this.btnClear.TabIndex = 64;
            this.btnClear.Text = "CLR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnMemMinus
            // 
            this.btnMemMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnMemMinus.Location = new System.Drawing.Point(60, 81);
            this.btnMemMinus.Name = "btnMemMinus";
            this.btnMemMinus.Size = new System.Drawing.Size(50, 50);
            this.btnMemMinus.TabIndex = 81;
            this.btnMemMinus.Text = "M-";
            this.btnMemMinus.UseVisualStyleBackColor = true;
            this.btnMemMinus.Click += new System.EventHandler(this.btnMemMinus_Click);
            // 
            // btnMemRecall
            // 
            this.btnMemRecall.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnMemRecall.Location = new System.Drawing.Point(229, 81);
            this.btnMemRecall.Name = "btnMemRecall";
            this.btnMemRecall.Size = new System.Drawing.Size(50, 50);
            this.btnMemRecall.TabIndex = 80;
            this.btnMemRecall.Text = "MR";
            this.btnMemRecall.UseVisualStyleBackColor = true;
            this.btnMemRecall.Click += new System.EventHandler(this.button24_Click);
            // 
            // btnMemClr
            // 
            this.btnMemClr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnMemClr.Location = new System.Drawing.Point(172, 81);
            this.btnMemClr.Name = "btnMemClr";
            this.btnMemClr.Size = new System.Drawing.Size(50, 50);
            this.btnMemClr.TabIndex = 82;
            this.btnMemClr.Text = "MC";
            this.btnMemClr.UseVisualStyleBackColor = true;
            this.btnMemClr.Click += new System.EventHandler(this.btnMemClear_Click);
            // 
            // btnMemSet
            // 
            this.btnMemSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnMemSet.Location = new System.Drawing.Point(116, 81);
            this.btnMemSet.Name = "btnMemSet";
            this.btnMemSet.Size = new System.Drawing.Size(50, 50);
            this.btnMemSet.TabIndex = 84;
            this.btnMemSet.Text = "MS";
            this.btnMemSet.UseVisualStyleBackColor = true;
            this.btnMemSet.Click += new System.EventHandler(this.btnMemSet_Click);
            // 
            // btnSinh
            // 
            this.btnSinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSinh.Location = new System.Drawing.Point(293, 138);
            this.btnSinh.Name = "btnSinh";
            this.btnSinh.Size = new System.Drawing.Size(50, 50);
            this.btnSinh.TabIndex = 65;
            this.btnSinh.Text = "sinh";
            this.btnSinh.UseVisualStyleBackColor = true;
            this.btnSinh.Click += new System.EventHandler(this.btnSinh_Click);
            // 
            // btnSin
            // 
            this.btnSin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSin.Location = new System.Drawing.Point(349, 138);
            this.btnSin.Name = "btnSin";
            this.btnSin.Size = new System.Drawing.Size(50, 50);
            this.btnSin.TabIndex = 66;
            this.btnSin.Text = "Exp";
            this.btnSin.UseVisualStyleBackColor = true;
            // 
            // btnMod
            // 
            this.btnMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnMod.Location = new System.Drawing.Point(405, 138);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(50, 50);
            this.btnMod.TabIndex = 67;
            this.btnMod.Text = "Mod";
            this.btnMod.UseVisualStyleBackColor = true;
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button11.Location = new System.Drawing.Point(461, 138);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(50, 50);
            this.button11.TabIndex = 68;
            this.button11.Text = "Log";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button12.Location = new System.Drawing.Point(293, 194);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(50, 50);
            this.button12.TabIndex = 69;
            this.button12.Text = "!";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button13.Location = new System.Drawing.Point(349, 194);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(50, 50);
            this.button13.TabIndex = 70;
            this.button13.Text = "√x";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button14.Location = new System.Drawing.Point(405, 194);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(50, 50);
            this.button14.TabIndex = 71;
            this.button14.Text = "3√x";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button15
            // 
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button15.Location = new System.Drawing.Point(461, 194);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(50, 50);
            this.button15.TabIndex = 72;
            this.button15.Text = "10^x";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button16
            // 
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button16.Location = new System.Drawing.Point(293, 250);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(50, 50);
            this.button16.TabIndex = 73;
            this.button16.Text = "x^2";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button17
            // 
            this.button17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button17.Location = new System.Drawing.Point(349, 250);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(50, 50);
            this.button17.TabIndex = 74;
            this.button17.Text = "cosh";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button18
            // 
            this.button18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button18.Location = new System.Drawing.Point(405, 250);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(50, 50);
            this.button18.TabIndex = 75;
            this.button18.Text = "cos";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // button19
            // 
            this.button19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button19.Location = new System.Drawing.Point(461, 250);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(50, 50);
            this.button19.TabIndex = 76;
            this.button19.Text = "x^y";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button19_Click_1);
            // 
            // btnMPlus
            // 
            this.btnMPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnMPlus.Location = new System.Drawing.Point(4, 81);
            this.btnMPlus.Name = "btnMPlus";
            this.btnMPlus.Size = new System.Drawing.Size(50, 50);
            this.btnMPlus.TabIndex = 83;
            this.btnMPlus.Text = "M+";
            this.btnMPlus.UseVisualStyleBackColor = true;
            this.btnMPlus.Click += new System.EventHandler(this.memplus_Click);
            // 
            // button20
            // 
            this.button20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button20.Location = new System.Drawing.Point(349, 306);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(50, 50);
            this.button20.TabIndex = 77;
            this.button20.Text = "sin";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // button21
            // 
            this.button21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button21.Location = new System.Drawing.Point(405, 306);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(50, 50);
            this.button21.TabIndex = 78;
            this.button21.Text = "tanh";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // button22
            // 
            this.button22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button22.Location = new System.Drawing.Point(461, 306);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(50, 50);
            this.button22.TabIndex = 79;
            this.button22.Text = "tan";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // button23
            // 
            this.button23.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button23.Location = new System.Drawing.Point(293, 306);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(50, 50);
            this.button23.TabIndex = 85;
            this.button23.Text = "x^3";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.button23_Click);
            // 
            // btnC
            // 
            this.btnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnC.Location = new System.Drawing.Point(349, 83);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(50, 50);
            this.btnC.TabIndex = 86;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 364);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.btnMemMinus);
            this.Controls.Add(this.btnMemRecall);
            this.Controls.Add(this.btnMemClr);
            this.Controls.Add(this.btnMemSet);
            this.Controls.Add(this.btnSinh);
            this.Controls.Add(this.btnSin);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.btnMPlus);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnLeftBrac);
            this.Controls.Add(this.btnRightBrac);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDec);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.txtHistory);
            this.Controls.Add(this.txtUi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtUi;
        private System.Windows.Forms.TextBox txtHistory;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdoDeg;
        private System.Windows.Forms.RadioButton rdoGrads;
        private System.Windows.Forms.RadioButton rdoRadians;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnLeftBrac;
        private System.Windows.Forms.Button btnRightBrac;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDec;
        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnMemMinus;
        private System.Windows.Forms.Button btnMemRecall;
        private System.Windows.Forms.Button btnMemClr;
        private System.Windows.Forms.Button btnMemSet;
        private System.Windows.Forms.Button btnSinh;
        private System.Windows.Forms.Button btnSin;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button btnMPlus;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button btnC;
    }
}


namespace Calculator
{
    partial class mainPage
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
            this.txtBox1 = new System.Windows.Forms.TextBox();
            this.txtBox2 = new System.Windows.Forms.TextBox();
            this.txtBoxOp = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonDot = new System.Windows.Forms.Button();
            this.buttonEqualTo = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonMultiplication = new System.Windows.Forms.Button();
            this.buttonDevide = new System.Windows.Forms.Button();
            this.lblResault = new System.Windows.Forms.Label();
            this.checkBoxPower = new System.Windows.Forms.CheckBox();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonModulus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBox1
            // 
            this.txtBox1.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox1.Location = new System.Drawing.Point(-3, 51);
            this.txtBox1.Multiline = true;
            this.txtBox1.Name = "txtBox1";
            this.txtBox1.Size = new System.Drawing.Size(100, 31);
            this.txtBox1.TabIndex = 0;
            this.txtBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtBox1_MouseClick);
            this.txtBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox1_KeyPress);
            // 
            // txtBox2
            // 
            this.txtBox2.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox2.Location = new System.Drawing.Point(167, 51);
            this.txtBox2.Multiline = true;
            this.txtBox2.Name = "txtBox2";
            this.txtBox2.Size = new System.Drawing.Size(111, 31);
            this.txtBox2.TabIndex = 1;
            this.txtBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBox2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtBox2_MouseClick);
            this.txtBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox1_KeyPress);
            // 
            // txtBoxOp
            // 
            this.txtBoxOp.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxOp.Location = new System.Drawing.Point(103, 61);
            this.txtBoxOp.Name = "txtBoxOp";
            this.txtBoxOp.Size = new System.Drawing.Size(58, 21);
            this.txtBoxOp.TabIndex = 2;
            this.txtBoxOp.Text = "Operator";
            this.txtBoxOp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxOp.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtBoxOp_MouseClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Schoolbook", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(16, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 46);
            this.button1.TabIndex = 5;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Century Schoolbook", 24F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(79, 195);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(57, 46);
            this.button2.TabIndex = 6;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Century Schoolbook", 24F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(142, 195);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(57, 46);
            this.button3.TabIndex = 7;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Century Schoolbook", 24F, System.Drawing.FontStyle.Bold);
            this.button4.Location = new System.Drawing.Point(16, 247);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(57, 46);
            this.button4.TabIndex = 8;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Century Schoolbook", 24F, System.Drawing.FontStyle.Bold);
            this.button5.Location = new System.Drawing.Point(79, 247);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(59, 46);
            this.button5.TabIndex = 9;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Century Schoolbook", 24F, System.Drawing.FontStyle.Bold);
            this.button6.Location = new System.Drawing.Point(144, 247);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(55, 46);
            this.button6.TabIndex = 10;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Century Schoolbook", 24F, System.Drawing.FontStyle.Bold);
            this.button7.Location = new System.Drawing.Point(16, 299);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(57, 46);
            this.button7.TabIndex = 11;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Century Schoolbook", 24F, System.Drawing.FontStyle.Bold);
            this.button8.Location = new System.Drawing.Point(79, 299);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(59, 46);
            this.button8.TabIndex = 12;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Century Schoolbook", 24F, System.Drawing.FontStyle.Bold);
            this.button9.Location = new System.Drawing.Point(144, 299);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(55, 46);
            this.button9.TabIndex = 13;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button0
            // 
            this.button0.Font = new System.Drawing.Font("Century Schoolbook", 24F, System.Drawing.FontStyle.Bold);
            this.button0.Location = new System.Drawing.Point(79, 351);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(59, 46);
            this.button0.TabIndex = 14;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // buttonDot
            // 
            this.buttonDot.Font = new System.Drawing.Font("Century Schoolbook", 24F, System.Drawing.FontStyle.Bold);
            this.buttonDot.Location = new System.Drawing.Point(16, 351);
            this.buttonDot.Name = "buttonDot";
            this.buttonDot.Size = new System.Drawing.Size(57, 46);
            this.buttonDot.TabIndex = 15;
            this.buttonDot.Text = ".";
            this.buttonDot.UseVisualStyleBackColor = true;
            this.buttonDot.Click += new System.EventHandler(this.buttonDot_Click);
            // 
            // buttonEqualTo
            // 
            this.buttonEqualTo.Font = new System.Drawing.Font("Century Schoolbook", 24F, System.Drawing.FontStyle.Bold);
            this.buttonEqualTo.Location = new System.Drawing.Point(205, 144);
            this.buttonEqualTo.Name = "buttonEqualTo";
            this.buttonEqualTo.Size = new System.Drawing.Size(62, 45);
            this.buttonEqualTo.TabIndex = 16;
            this.buttonEqualTo.Text = "=";
            this.buttonEqualTo.UseVisualStyleBackColor = true;
            this.buttonEqualTo.Click += new System.EventHandler(this.buttonEqualTo_Click);
            // 
            // buttonPlus
            // 
            this.buttonPlus.Font = new System.Drawing.Font("Century Schoolbook", 24F, System.Drawing.FontStyle.Bold);
            this.buttonPlus.Location = new System.Drawing.Point(205, 351);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(62, 45);
            this.buttonPlus.TabIndex = 17;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // buttonMinus
            // 
            this.buttonMinus.Font = new System.Drawing.Font("Century Schoolbook", 24F, System.Drawing.FontStyle.Bold);
            this.buttonMinus.Location = new System.Drawing.Point(205, 299);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(62, 46);
            this.buttonMinus.TabIndex = 18;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = true;
            this.buttonMinus.Click += new System.EventHandler(this.buttonMinus_Click);
            // 
            // buttonMultiplication
            // 
            this.buttonMultiplication.Font = new System.Drawing.Font("Century Schoolbook", 24F, System.Drawing.FontStyle.Bold);
            this.buttonMultiplication.Location = new System.Drawing.Point(205, 247);
            this.buttonMultiplication.Name = "buttonMultiplication";
            this.buttonMultiplication.Size = new System.Drawing.Size(62, 46);
            this.buttonMultiplication.TabIndex = 19;
            this.buttonMultiplication.Text = "*";
            this.buttonMultiplication.UseVisualStyleBackColor = true;
            this.buttonMultiplication.Click += new System.EventHandler(this.buttonMultiplication_Click);
            // 
            // buttonDevide
            // 
            this.buttonDevide.Font = new System.Drawing.Font("Century Schoolbook", 24F, System.Drawing.FontStyle.Bold);
            this.buttonDevide.Location = new System.Drawing.Point(205, 195);
            this.buttonDevide.Name = "buttonDevide";
            this.buttonDevide.Size = new System.Drawing.Size(62, 46);
            this.buttonDevide.TabIndex = 20;
            this.buttonDevide.Text = "/";
            this.buttonDevide.UseVisualStyleBackColor = true;
            this.buttonDevide.Click += new System.EventHandler(this.buttonDevide_Click);
            // 
            // lblResault
            // 
            this.lblResault.AutoSize = true;
            this.lblResault.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblResault.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblResault.Font = new System.Drawing.Font("Century Schoolbook", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResault.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblResault.Location = new System.Drawing.Point(28, 96);
            this.lblResault.Name = "lblResault";
            this.lblResault.Size = new System.Drawing.Size(32, 34);
            this.lblResault.TabIndex = 21;
            this.lblResault.Text = "0";
            this.lblResault.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBoxPower
            // 
            this.checkBoxPower.AutoSize = true;
            this.checkBoxPower.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxPower.Location = new System.Drawing.Point(16, 161);
            this.checkBoxPower.Name = "checkBoxPower";
            this.checkBoxPower.Size = new System.Drawing.Size(81, 23);
            this.checkBoxPower.TabIndex = 22;
            this.checkBoxPower.Text = "Power";
            this.checkBoxPower.UseVisualStyleBackColor = true;
            this.checkBoxPower.CheckedChanged += new System.EventHandler(this.checkBoxPower_CheckedChanged);
            // 
            // buttonC
            // 
            this.buttonC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonC.Font = new System.Drawing.Font("Century Schoolbook", 24F, System.Drawing.FontStyle.Bold);
            this.buttonC.Location = new System.Drawing.Point(142, 144);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(57, 45);
            this.buttonC.TabIndex = 23;
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = true;
            this.buttonC.Click += new System.EventHandler(this.buttonC_Click);
            // 
            // buttonModulus
            // 
            this.buttonModulus.Font = new System.Drawing.Font("Century Schoolbook", 24F, System.Drawing.FontStyle.Bold);
            this.buttonModulus.Location = new System.Drawing.Point(144, 351);
            this.buttonModulus.Name = "buttonModulus";
            this.buttonModulus.Size = new System.Drawing.Size(55, 45);
            this.buttonModulus.TabIndex = 24;
            this.buttonModulus.Text = "%";
            this.buttonModulus.UseVisualStyleBackColor = true;
            this.buttonModulus.Click += new System.EventHandler(this.buttonModulus_Click);
            // 
            // mainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(279, 406);
            this.Controls.Add(this.buttonModulus);
            this.Controls.Add(this.buttonC);
            this.Controls.Add(this.checkBoxPower);
            this.Controls.Add(this.lblResault);
            this.Controls.Add(this.buttonDevide);
            this.Controls.Add(this.buttonMultiplication);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.buttonEqualTo);
            this.Controls.Add(this.buttonDot);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBoxOp);
            this.Controls.Add(this.txtBox2);
            this.Controls.Add(this.txtBox1);
            this.Name = "mainPage";
            this.Text = "Calculator";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mainPage_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox1;
        private System.Windows.Forms.TextBox txtBox2;
        private System.Windows.Forms.TextBox txtBoxOp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonDot;
        private System.Windows.Forms.Button buttonEqualTo;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonMultiplication;
        private System.Windows.Forms.Button buttonDevide;
        private System.Windows.Forms.Label lblResault;
        private System.Windows.Forms.CheckBox checkBoxPower;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonModulus;
    }
}


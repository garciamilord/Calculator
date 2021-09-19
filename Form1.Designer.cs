namespace Calculator

{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.digit0 = new System.Windows.Forms.Button();
            this.digit1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.plus = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.calculate = new System.Windows.Forms.Button();
            this.decimalPoint = new System.Windows.Forms.Button();
            this.openP = new System.Windows.Forms.Button();
            this.closeP = new System.Windows.Forms.Button();
            this.digit2 = new System.Windows.Forms.Button();
            this.digit3 = new System.Windows.Forms.Button();
            this.digit4 = new System.Windows.Forms.Button();
            this.digit5 = new System.Windows.Forms.Button();
            this.digit6 = new System.Windows.Forms.Button();
            this.digit7 = new System.Windows.Forms.Button();
            this.digit8 = new System.Windows.Forms.Button();
            this.digit9 = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // digit0
            // 
            this.digit0.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.digit0.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.digit0.Location = new System.Drawing.Point(134, 450);
            this.digit0.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.digit0.Name = "digit0";
            this.digit0.Size = new System.Drawing.Size(80, 83);
            this.digit0.TabIndex = 0;
            this.digit0.Text = "0";
            this.digit0.UseVisualStyleBackColor = true;
            this.digit0.Click += new System.EventHandler(this.digit0_Click);
            // 
            // digit1
            // 
            this.digit1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.digit1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.digit1.Location = new System.Drawing.Point(42, 354);
            this.digit1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.digit1.Name = "digit1";
            this.digit1.Size = new System.Drawing.Size(80, 83);
            this.digit1.TabIndex = 1;
            this.digit1.Text = "1";
            this.digit1.UseVisualStyleBackColor = true;
            this.digit1.Click += new System.EventHandler(this.digit1_Click);
            // 
            // textBox1
            // 
            this.textBox1.AcceptsReturn = true;
            this.textBox1.AllowDrop = true;
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox1.Location = new System.Drawing.Point(42, 87);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(446, 53);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // plus
            // 
            this.plus.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.plus.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plus.Location = new System.Drawing.Point(318, 450);
            this.plus.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(80, 83);
            this.plus.TabIndex = 3;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // minus
            // 
            this.minus.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.minus.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minus.Location = new System.Drawing.Point(318, 354);
            this.minus.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(80, 83);
            this.minus.TabIndex = 4;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // multiply
            // 
            this.multiply.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.multiply.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiply.Location = new System.Drawing.Point(318, 258);
            this.multiply.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(80, 83);
            this.multiply.TabIndex = 5;
            this.multiply.Text = "*";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.multiply_Click);
            // 
            // divide
            // 
            this.divide.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.divide.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divide.Location = new System.Drawing.Point(410, 258);
            this.divide.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(80, 83);
            this.divide.TabIndex = 6;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.divide_Click);
            // 
            // calculate
            // 
            this.calculate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.calculate.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculate.Location = new System.Drawing.Point(410, 354);
            this.calculate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(80, 179);
            this.calculate.TabIndex = 7;
            this.calculate.Text = "=";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // decimalPoint
            // 
            this.decimalPoint.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.decimalPoint.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decimalPoint.Location = new System.Drawing.Point(226, 450);
            this.decimalPoint.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.decimalPoint.Name = "decimalPoint";
            this.decimalPoint.Size = new System.Drawing.Size(80, 83);
            this.decimalPoint.TabIndex = 8;
            this.decimalPoint.Text = ".";
            this.decimalPoint.UseVisualStyleBackColor = true;
            this.decimalPoint.Click += new System.EventHandler(this.decimalPoint_Click);
            // 
            // openP
            // 
            this.openP.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.openP.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openP.Location = new System.Drawing.Point(318, 162);
            this.openP.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.openP.Name = "openP";
            this.openP.Size = new System.Drawing.Size(80, 83);
            this.openP.TabIndex = 9;
            this.openP.Text = "(";
            this.openP.UseVisualStyleBackColor = true;
            this.openP.Click += new System.EventHandler(this.openP_Click);
            // 
            // closeP
            // 
            this.closeP.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.closeP.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeP.Location = new System.Drawing.Point(410, 162);
            this.closeP.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.closeP.Name = "closeP";
            this.closeP.Size = new System.Drawing.Size(80, 83);
            this.closeP.TabIndex = 10;
            this.closeP.Text = ")";
            this.closeP.UseVisualStyleBackColor = true;
            this.closeP.Click += new System.EventHandler(this.closeP_Click);
            // 
            // digit2
            // 
            this.digit2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.digit2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.digit2.Location = new System.Drawing.Point(134, 354);
            this.digit2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.digit2.Name = "digit2";
            this.digit2.Size = new System.Drawing.Size(80, 83);
            this.digit2.TabIndex = 11;
            this.digit2.Text = "2";
            this.digit2.UseVisualStyleBackColor = true;
            this.digit2.Click += new System.EventHandler(this.digit2_Click);
            // 
            // digit3
            // 
            this.digit3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.digit3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.digit3.Location = new System.Drawing.Point(226, 354);
            this.digit3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.digit3.Name = "digit3";
            this.digit3.Size = new System.Drawing.Size(80, 83);
            this.digit3.TabIndex = 12;
            this.digit3.Text = "3";
            this.digit3.UseVisualStyleBackColor = true;
            this.digit3.Click += new System.EventHandler(this.digit3_Click);
            // 
            // digit4
            // 
            this.digit4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.digit4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.digit4.Location = new System.Drawing.Point(42, 258);
            this.digit4.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.digit4.Name = "digit4";
            this.digit4.Size = new System.Drawing.Size(80, 83);
            this.digit4.TabIndex = 13;
            this.digit4.Text = "4";
            this.digit4.UseVisualStyleBackColor = true;
            this.digit4.Click += new System.EventHandler(this.digit4_Click);
            // 
            // digit5
            // 
            this.digit5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.digit5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.digit5.Location = new System.Drawing.Point(134, 258);
            this.digit5.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.digit5.Name = "digit5";
            this.digit5.Size = new System.Drawing.Size(80, 83);
            this.digit5.TabIndex = 14;
            this.digit5.Text = "5";
            this.digit5.UseVisualStyleBackColor = true;
            this.digit5.Click += new System.EventHandler(this.digit5_Click);
            // 
            // digit6
            // 
            this.digit6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.digit6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.digit6.Location = new System.Drawing.Point(226, 258);
            this.digit6.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.digit6.Name = "digit6";
            this.digit6.Size = new System.Drawing.Size(80, 83);
            this.digit6.TabIndex = 15;
            this.digit6.Text = "6";
            this.digit6.UseVisualStyleBackColor = true;
            this.digit6.Click += new System.EventHandler(this.digit6_Click);
            // 
            // digit7
            // 
            this.digit7.AutoSize = true;
            this.digit7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.digit7.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.digit7.Location = new System.Drawing.Point(42, 162);
            this.digit7.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.digit7.Name = "digit7";
            this.digit7.Size = new System.Drawing.Size(80, 83);
            this.digit7.TabIndex = 16;
            this.digit7.Text = "7";
            this.digit7.UseVisualStyleBackColor = true;
            this.digit7.Click += new System.EventHandler(this.digit7_Click);
            // 
            // digit8
            // 
            this.digit8.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.digit8.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.digit8.Location = new System.Drawing.Point(134, 162);
            this.digit8.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.digit8.Name = "digit8";
            this.digit8.Size = new System.Drawing.Size(80, 83);
            this.digit8.TabIndex = 17;
            this.digit8.Text = "8";
            this.digit8.UseVisualStyleBackColor = true;
            this.digit8.Click += new System.EventHandler(this.digit8_Click);
            // 
            // digit9
            // 
            this.digit9.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.digit9.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.digit9.Location = new System.Drawing.Point(226, 162);
            this.digit9.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.digit9.Name = "digit9";
            this.digit9.Size = new System.Drawing.Size(80, 83);
            this.digit9.TabIndex = 18;
            this.digit9.Text = "9";
            this.digit9.UseVisualStyleBackColor = true;
            this.digit9.Click += new System.EventHandler(this.digit9_Click);
            // 
            // clear
            // 
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.clear.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(42, 450);
            this.clear.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(80, 83);
            this.clear.TabIndex = 19;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, -2);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 52);
            this.label1.TabIndex = 20;
            this.label1.Text = "Enter An Expression";
            // 
            // textBox2
            // 
            this.textBox2.AcceptsReturn = true;
            this.textBox2.BackColor = System.Drawing.SystemColors.Window;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox2.Location = new System.Drawing.Point(42, 44);
            this.textBox2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(446, 38);
            this.textBox2.TabIndex = 21;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(528, 565);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.digit9);
            this.Controls.Add(this.digit8);
            this.Controls.Add(this.digit7);
            this.Controls.Add(this.digit6);
            this.Controls.Add(this.digit5);
            this.Controls.Add(this.digit4);
            this.Controls.Add(this.digit3);
            this.Controls.Add(this.digit2);
            this.Controls.Add(this.closeP);
            this.Controls.Add(this.openP);
            this.Controls.Add(this.decimalPoint);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.digit1);
            this.Controls.Add(this.digit0);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.DoubleClick += new System.EventHandler(this.form1_DoubleClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button digit0;
        private System.Windows.Forms.Button digit1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Button decimalPoint;
        private System.Windows.Forms.Button openP;
        private System.Windows.Forms.Button closeP;
        private System.Windows.Forms.Button digit2;
        private System.Windows.Forms.Button digit3;
        private System.Windows.Forms.Button digit4;
        private System.Windows.Forms.Button digit5;
        private System.Windows.Forms.Button digit6;
        private System.Windows.Forms.Button digit7;
        private System.Windows.Forms.Button digit8;
        private System.Windows.Forms.Button digit9;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
    }
}


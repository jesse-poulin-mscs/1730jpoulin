﻿namespace jpoulin2f1
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
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.input1ATextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.result1TextBox = new System.Windows.Forms.TextBox();
            this.result2TextBox = new System.Windows.Forms.TextBox();
            this.result3TextBox = new System.Windows.Forms.TextBox();
            this.result4TextBox = new System.Windows.Forms.TextBox();
            this.result5TextBox = new System.Windows.Forms.TextBox();
            this.result6TextBox = new System.Windows.Forms.TextBox();
            this.input2ATextBox = new System.Windows.Forms.TextBox();
            this.input3ATextBox = new System.Windows.Forms.TextBox();
            this.input4ATextBox = new System.Windows.Forms.TextBox();
            this.input5ATextBox = new System.Windows.Forms.TextBox();
            this.input6ATextBox = new System.Windows.Forms.TextBox();
            this.input6BTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.input7ATextBox = new System.Windows.Forms.TextBox();
            this.input8BTextBox = new System.Windows.Forms.TextBox();
            this.input8ATextBox = new System.Windows.Forms.TextBox();
            this.input9ATextBox = new System.Windows.Forms.TextBox();
            this.input9BTextBox = new System.Windows.Forms.TextBox();
            this.input10BTextBox = new System.Windows.Forms.TextBox();
            this.input10ATextBox = new System.Windows.Forms.TextBox();
            this.result7TextBox = new System.Windows.Forms.TextBox();
            this.result8TextBox = new System.Windows.Forms.TextBox();
            this.result9TextBox = new System.Windows.Forms.TextBox();
            this.result10TextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(343, 678);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(136, 46);
            this.buttonCalculate.TabIndex = 0;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.ButtonCalculate_Click);
            // 
            // input1ATextBox
            // 
            this.input1ATextBox.Location = new System.Drawing.Point(245, 51);
            this.input1ATextBox.Name = "input1ATextBox";
            this.input1ATextBox.Size = new System.Drawing.Size(184, 31);
            this.input1ATextBox.TabIndex = 1;
            this.input1ATextBox.Text = "100.00";
            this.input1ATextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "1)if";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "2)if {block}";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "3)if else";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "4)if else if";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "5)Better range test";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 374);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "6)Nested if else";
            // 
            // result1TextBox
            // 
            this.result1TextBox.Location = new System.Drawing.Point(577, 51);
            this.result1TextBox.Name = "result1TextBox";
            this.result1TextBox.ReadOnly = true;
            this.result1TextBox.Size = new System.Drawing.Size(200, 31);
            this.result1TextBox.TabIndex = 8;
            this.result1TextBox.TabStop = false;
            this.result1TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // result2TextBox
            // 
            this.result2TextBox.Location = new System.Drawing.Point(577, 115);
            this.result2TextBox.Name = "result2TextBox";
            this.result2TextBox.ReadOnly = true;
            this.result2TextBox.Size = new System.Drawing.Size(200, 31);
            this.result2TextBox.TabIndex = 9;
            this.result2TextBox.TabStop = false;
            this.result2TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // result3TextBox
            // 
            this.result3TextBox.Location = new System.Drawing.Point(577, 179);
            this.result3TextBox.Name = "result3TextBox";
            this.result3TextBox.ReadOnly = true;
            this.result3TextBox.Size = new System.Drawing.Size(200, 31);
            this.result3TextBox.TabIndex = 10;
            this.result3TextBox.TabStop = false;
            this.result3TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // result4TextBox
            // 
            this.result4TextBox.Location = new System.Drawing.Point(577, 243);
            this.result4TextBox.Name = "result4TextBox";
            this.result4TextBox.ReadOnly = true;
            this.result4TextBox.Size = new System.Drawing.Size(200, 31);
            this.result4TextBox.TabIndex = 11;
            this.result4TextBox.TabStop = false;
            this.result4TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // result5TextBox
            // 
            this.result5TextBox.Location = new System.Drawing.Point(577, 307);
            this.result5TextBox.Name = "result5TextBox";
            this.result5TextBox.ReadOnly = true;
            this.result5TextBox.Size = new System.Drawing.Size(200, 31);
            this.result5TextBox.TabIndex = 12;
            this.result5TextBox.TabStop = false;
            this.result5TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // result6TextBox
            // 
            this.result6TextBox.Location = new System.Drawing.Point(577, 371);
            this.result6TextBox.Name = "result6TextBox";
            this.result6TextBox.ReadOnly = true;
            this.result6TextBox.Size = new System.Drawing.Size(200, 31);
            this.result6TextBox.TabIndex = 13;
            this.result6TextBox.TabStop = false;
            this.result6TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // input2ATextBox
            // 
            this.input2ATextBox.Location = new System.Drawing.Point(245, 115);
            this.input2ATextBox.Name = "input2ATextBox";
            this.input2ATextBox.Size = new System.Drawing.Size(184, 31);
            this.input2ATextBox.TabIndex = 14;
            this.input2ATextBox.Text = "100.00";
            this.input2ATextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // input3ATextBox
            // 
            this.input3ATextBox.Location = new System.Drawing.Point(245, 179);
            this.input3ATextBox.Name = "input3ATextBox";
            this.input3ATextBox.Size = new System.Drawing.Size(184, 31);
            this.input3ATextBox.TabIndex = 15;
            this.input3ATextBox.Text = "100.00";
            this.input3ATextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // input4ATextBox
            // 
            this.input4ATextBox.Location = new System.Drawing.Point(245, 243);
            this.input4ATextBox.Name = "input4ATextBox";
            this.input4ATextBox.Size = new System.Drawing.Size(184, 31);
            this.input4ATextBox.TabIndex = 16;
            this.input4ATextBox.Text = "100.00";
            this.input4ATextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // input5ATextBox
            // 
            this.input5ATextBox.Location = new System.Drawing.Point(245, 307);
            this.input5ATextBox.Name = "input5ATextBox";
            this.input5ATextBox.Size = new System.Drawing.Size(184, 31);
            this.input5ATextBox.TabIndex = 17;
            this.input5ATextBox.Text = "100.00";
            this.input5ATextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // input6ATextBox
            // 
            this.input6ATextBox.Location = new System.Drawing.Point(245, 371);
            this.input6ATextBox.Name = "input6ATextBox";
            this.input6ATextBox.Size = new System.Drawing.Size(184, 31);
            this.input6ATextBox.TabIndex = 18;
            this.input6ATextBox.Text = "100.00";
            this.input6ATextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // input6BTextBox
            // 
            this.input6BTextBox.Location = new System.Drawing.Point(452, 371);
            this.input6BTextBox.Name = "input6BTextBox";
            this.input6BTextBox.Size = new System.Drawing.Size(64, 31);
            this.input6BTextBox.TabIndex = 19;
            this.input6BTextBox.Text = "R";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 438);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 25);
            this.label7.TabIndex = 20;
            this.label7.Text = "7)Validate Input";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 502);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(206, 25);
            this.label8.TabIndex = 21;
            this.label8.Text = "8)Price * quant, ship";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 566);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(186, 25);
            this.label9.TabIndex = 22;
            this.label9.Text = "9)Difference * rate";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 630);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(157, 25);
            this.label10.TabIndex = 23;
            this.label10.Text = "10)Divide large";
            // 
            // input7ATextBox
            // 
            this.input7ATextBox.Location = new System.Drawing.Point(245, 435);
            this.input7ATextBox.Name = "input7ATextBox";
            this.input7ATextBox.Size = new System.Drawing.Size(184, 31);
            this.input7ATextBox.TabIndex = 24;
            this.input7ATextBox.Text = "100.00";
            this.input7ATextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // input8BTextBox
            // 
            this.input8BTextBox.Location = new System.Drawing.Point(452, 499);
            this.input8BTextBox.Name = "input8BTextBox";
            this.input8BTextBox.Size = new System.Drawing.Size(64, 31);
            this.input8BTextBox.TabIndex = 26;
            this.input8BTextBox.Text = "2";
            this.input8BTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // input8ATextBox
            // 
            this.input8ATextBox.Location = new System.Drawing.Point(245, 499);
            this.input8ATextBox.Name = "input8ATextBox";
            this.input8ATextBox.Size = new System.Drawing.Size(184, 31);
            this.input8ATextBox.TabIndex = 25;
            this.input8ATextBox.Text = "25.00";
            this.input8ATextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // input9ATextBox
            // 
            this.input9ATextBox.Location = new System.Drawing.Point(245, 563);
            this.input9ATextBox.Name = "input9ATextBox";
            this.input9ATextBox.Size = new System.Drawing.Size(124, 31);
            this.input9ATextBox.TabIndex = 27;
            this.input9ATextBox.Text = "10000";
            this.input9ATextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // input9BTextBox
            // 
            this.input9BTextBox.Location = new System.Drawing.Point(392, 563);
            this.input9BTextBox.Name = "input9BTextBox";
            this.input9BTextBox.Size = new System.Drawing.Size(124, 31);
            this.input9BTextBox.TabIndex = 28;
            this.input9BTextBox.Text = "11000";
            this.input9BTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // input10BTextBox
            // 
            this.input10BTextBox.Location = new System.Drawing.Point(392, 627);
            this.input10BTextBox.Name = "input10BTextBox";
            this.input10BTextBox.Size = new System.Drawing.Size(124, 31);
            this.input10BTextBox.TabIndex = 30;
            this.input10BTextBox.Text = "2";
            this.input10BTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // input10ATextBox
            // 
            this.input10ATextBox.Location = new System.Drawing.Point(245, 627);
            this.input10ATextBox.Name = "input10ATextBox";
            this.input10ATextBox.Size = new System.Drawing.Size(124, 31);
            this.input10ATextBox.TabIndex = 29;
            this.input10ATextBox.Text = "1";
            this.input10ATextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // result7TextBox
            // 
            this.result7TextBox.Location = new System.Drawing.Point(577, 435);
            this.result7TextBox.Name = "result7TextBox";
            this.result7TextBox.ReadOnly = true;
            this.result7TextBox.Size = new System.Drawing.Size(200, 31);
            this.result7TextBox.TabIndex = 31;
            this.result7TextBox.TabStop = false;
            this.result7TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // result8TextBox
            // 
            this.result8TextBox.Location = new System.Drawing.Point(577, 499);
            this.result8TextBox.Name = "result8TextBox";
            this.result8TextBox.ReadOnly = true;
            this.result8TextBox.Size = new System.Drawing.Size(200, 31);
            this.result8TextBox.TabIndex = 32;
            this.result8TextBox.TabStop = false;
            this.result8TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // result9TextBox
            // 
            this.result9TextBox.Location = new System.Drawing.Point(577, 563);
            this.result9TextBox.Name = "result9TextBox";
            this.result9TextBox.ReadOnly = true;
            this.result9TextBox.Size = new System.Drawing.Size(200, 31);
            this.result9TextBox.TabIndex = 33;
            this.result9TextBox.TabStop = false;
            this.result9TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // result10TextBox
            // 
            this.result10TextBox.Location = new System.Drawing.Point(577, 627);
            this.result10TextBox.Name = "result10TextBox";
            this.result10TextBox.ReadOnly = true;
            this.result10TextBox.Size = new System.Drawing.Size(200, 31);
            this.result10TextBox.TabIndex = 34;
            this.result10TextBox.TabStop = false;
            this.result10TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 736);
            this.Controls.Add(this.result10TextBox);
            this.Controls.Add(this.result9TextBox);
            this.Controls.Add(this.result8TextBox);
            this.Controls.Add(this.result7TextBox);
            this.Controls.Add(this.input10BTextBox);
            this.Controls.Add(this.input10ATextBox);
            this.Controls.Add(this.input9BTextBox);
            this.Controls.Add(this.input9ATextBox);
            this.Controls.Add(this.input8BTextBox);
            this.Controls.Add(this.input8ATextBox);
            this.Controls.Add(this.input7ATextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.input6BTextBox);
            this.Controls.Add(this.input6ATextBox);
            this.Controls.Add(this.input5ATextBox);
            this.Controls.Add(this.input4ATextBox);
            this.Controls.Add(this.input3ATextBox);
            this.Controls.Add(this.input2ATextBox);
            this.Controls.Add(this.result6TextBox);
            this.Controls.Add(this.result5TextBox);
            this.Controls.Add(this.result4TextBox);
            this.Controls.Add(this.result3TextBox);
            this.Controls.Add(this.result2TextBox);
            this.Controls.Add(this.result1TextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.input1ATextBox);
            this.Controls.Add(this.buttonCalculate);
            this.Name = "Form1";
            this.Text = " jpoulin2f1: If Statements";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.TextBox input1ATextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox result1TextBox;
        private System.Windows.Forms.TextBox result2TextBox;
        private System.Windows.Forms.TextBox result3TextBox;
        private System.Windows.Forms.TextBox result4TextBox;
        private System.Windows.Forms.TextBox result5TextBox;
        private System.Windows.Forms.TextBox result6TextBox;
        private System.Windows.Forms.TextBox input2ATextBox;
        private System.Windows.Forms.TextBox input3ATextBox;
        private System.Windows.Forms.TextBox input4ATextBox;
        private System.Windows.Forms.TextBox input5ATextBox;
        private System.Windows.Forms.TextBox input6ATextBox;
        private System.Windows.Forms.TextBox input6BTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox input7ATextBox;
        private System.Windows.Forms.TextBox input8BTextBox;
        private System.Windows.Forms.TextBox input8ATextBox;
        private System.Windows.Forms.TextBox input9ATextBox;
        private System.Windows.Forms.TextBox input9BTextBox;
        private System.Windows.Forms.TextBox input10BTextBox;
        private System.Windows.Forms.TextBox input10ATextBox;
        private System.Windows.Forms.TextBox result7TextBox;
        private System.Windows.Forms.TextBox result8TextBox;
        private System.Windows.Forms.TextBox result9TextBox;
        private System.Windows.Forms.TextBox result10TextBox;
    }
}


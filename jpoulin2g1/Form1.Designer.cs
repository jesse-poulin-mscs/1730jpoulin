﻿namespace jpoulin2g1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.calcButton = new System.Windows.Forms.Button();
            this.input1aTextBox = new System.Windows.Forms.TextBox();
            this.resultSwitch01TextBox = new System.Windows.Forms.TextBox();
            this.resultIf01TextBox = new System.Windows.Forms.TextBox();
            this.resultElseIf01TextBox = new System.Windows.Forms.TextBox();
            this.resultNestedIf01TextBox = new System.Windows.Forms.TextBox();
            this.resultSwitchDefault01TextBox = new System.Windows.Forms.TextBox();
            this.resultIfDefault0TextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.resultElseIfDefault01TextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.resultNestedDefaultIf01TextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.resultNestedIf02TextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.resultElseIf02TextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.resultIf02TextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.resultSwitch02TextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.input2aTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "1) Switch R/C";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "2) If R/C";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "3) ElseIf R/C";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "4) Nested If-else";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "5) Switch w/default";
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(256, 772);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(120, 50);
            this.calcButton.TabIndex = 5;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // input1aTextBox
            // 
            this.input1aTextBox.Location = new System.Drawing.Point(256, 47);
            this.input1aTextBox.Name = "input1aTextBox";
            this.input1aTextBox.Size = new System.Drawing.Size(134, 31);
            this.input1aTextBox.TabIndex = 6;
            this.input1aTextBox.Text = "R";
            // 
            // resultSwitch01TextBox
            // 
            this.resultSwitch01TextBox.Location = new System.Drawing.Point(459, 47);
            this.resultSwitch01TextBox.Name = "resultSwitch01TextBox";
            this.resultSwitch01TextBox.ReadOnly = true;
            this.resultSwitch01TextBox.Size = new System.Drawing.Size(134, 31);
            this.resultSwitch01TextBox.TabIndex = 7;
            this.resultSwitch01TextBox.TabStop = false;
            // 
            // resultIf01TextBox
            // 
            this.resultIf01TextBox.Location = new System.Drawing.Point(459, 107);
            this.resultIf01TextBox.Name = "resultIf01TextBox";
            this.resultIf01TextBox.ReadOnly = true;
            this.resultIf01TextBox.Size = new System.Drawing.Size(134, 31);
            this.resultIf01TextBox.TabIndex = 9;
            this.resultIf01TextBox.TabStop = false;
            // 
            // resultElseIf01TextBox
            // 
            this.resultElseIf01TextBox.Location = new System.Drawing.Point(459, 167);
            this.resultElseIf01TextBox.Name = "resultElseIf01TextBox";
            this.resultElseIf01TextBox.ReadOnly = true;
            this.resultElseIf01TextBox.Size = new System.Drawing.Size(134, 31);
            this.resultElseIf01TextBox.TabIndex = 11;
            this.resultElseIf01TextBox.TabStop = false;
            // 
            // resultNestedIf01TextBox
            // 
            this.resultNestedIf01TextBox.Location = new System.Drawing.Point(459, 227);
            this.resultNestedIf01TextBox.Name = "resultNestedIf01TextBox";
            this.resultNestedIf01TextBox.ReadOnly = true;
            this.resultNestedIf01TextBox.Size = new System.Drawing.Size(134, 31);
            this.resultNestedIf01TextBox.TabIndex = 13;
            this.resultNestedIf01TextBox.TabStop = false;
            // 
            // resultSwitchDefault01TextBox
            // 
            this.resultSwitchDefault01TextBox.Location = new System.Drawing.Point(459, 287);
            this.resultSwitchDefault01TextBox.Name = "resultSwitchDefault01TextBox";
            this.resultSwitchDefault01TextBox.ReadOnly = true;
            this.resultSwitchDefault01TextBox.Size = new System.Drawing.Size(134, 31);
            this.resultSwitchDefault01TextBox.TabIndex = 15;
            this.resultSwitchDefault01TextBox.TabStop = false;
            // 
            // resultIfDefault0TextBox
            // 
            this.resultIfDefault0TextBox.Location = new System.Drawing.Point(459, 347);
            this.resultIfDefault0TextBox.Name = "resultIfDefault0TextBox";
            this.resultIfDefault0TextBox.ReadOnly = true;
            this.resultIfDefault0TextBox.Size = new System.Drawing.Size(134, 31);
            this.resultIfDefault0TextBox.TabIndex = 17;
            this.resultIfDefault0TextBox.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 350);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "6) If R/C, default";
            // 
            // resultElseIfDefault01TextBox
            // 
            this.resultElseIfDefault01TextBox.Location = new System.Drawing.Point(459, 407);
            this.resultElseIfDefault01TextBox.Name = "resultElseIfDefault01TextBox";
            this.resultElseIfDefault01TextBox.ReadOnly = true;
            this.resultElseIfDefault01TextBox.Size = new System.Drawing.Size(134, 31);
            this.resultElseIfDefault01TextBox.TabIndex = 19;
            this.resultElseIfDefault01TextBox.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 410);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(209, 25);
            this.label7.TabIndex = 18;
            this.label7.Text = "7) ElseIf R/C, default";
            // 
            // resultNestedDefaultIf01TextBox
            // 
            this.resultNestedDefaultIf01TextBox.Location = new System.Drawing.Point(459, 467);
            this.resultNestedDefaultIf01TextBox.Name = "resultNestedDefaultIf01TextBox";
            this.resultNestedDefaultIf01TextBox.ReadOnly = true;
            this.resultNestedDefaultIf01TextBox.Size = new System.Drawing.Size(134, 31);
            this.resultNestedDefaultIf01TextBox.TabIndex = 21;
            this.resultNestedDefaultIf01TextBox.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 470);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 25);
            this.label8.TabIndex = 20;
            this.label8.Text = "8) Nested If-else";
            // 
            // resultNestedIf02TextBox
            // 
            this.resultNestedIf02TextBox.Location = new System.Drawing.Point(459, 705);
            this.resultNestedIf02TextBox.Name = "resultNestedIf02TextBox";
            this.resultNestedIf02TextBox.ReadOnly = true;
            this.resultNestedIf02TextBox.Size = new System.Drawing.Size(134, 31);
            this.resultNestedIf02TextBox.TabIndex = 29;
            this.resultNestedIf02TextBox.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(45, 708);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(181, 25);
            this.label9.TabIndex = 28;
            this.label9.Text = "12) Nested If-else";
            // 
            // resultElseIf02TextBox
            // 
            this.resultElseIf02TextBox.Location = new System.Drawing.Point(459, 645);
            this.resultElseIf02TextBox.Name = "resultElseIf02TextBox";
            this.resultElseIf02TextBox.ReadOnly = true;
            this.resultElseIf02TextBox.Size = new System.Drawing.Size(134, 31);
            this.resultElseIf02TextBox.TabIndex = 27;
            this.resultElseIf02TextBox.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(45, 648);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(163, 25);
            this.label10.TabIndex = 26;
            this.label10.Text = "11) ElseIf R/C/T";
            // 
            // resultIf02TextBox
            // 
            this.resultIf02TextBox.Location = new System.Drawing.Point(459, 585);
            this.resultIf02TextBox.Name = "resultIf02TextBox";
            this.resultIf02TextBox.ReadOnly = true;
            this.resultIf02TextBox.Size = new System.Drawing.Size(134, 31);
            this.resultIf02TextBox.TabIndex = 25;
            this.resultIf02TextBox.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(45, 588);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 25);
            this.label11.TabIndex = 24;
            this.label11.Text = "10) If R/C/T";
            // 
            // resultSwitch02TextBox
            // 
            this.resultSwitch02TextBox.Location = new System.Drawing.Point(459, 525);
            this.resultSwitch02TextBox.Name = "resultSwitch02TextBox";
            this.resultSwitch02TextBox.ReadOnly = true;
            this.resultSwitch02TextBox.Size = new System.Drawing.Size(134, 31);
            this.resultSwitch02TextBox.TabIndex = 23;
            this.resultSwitch02TextBox.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(45, 528);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(161, 25);
            this.label12.TabIndex = 22;
            this.label12.Text = "9) Switch R/C/T";
            // 
            // input2aTextBox
            // 
            this.input2aTextBox.Location = new System.Drawing.Point(256, 525);
            this.input2aTextBox.Name = "input2aTextBox";
            this.input2aTextBox.Size = new System.Drawing.Size(134, 31);
            this.input2aTextBox.TabIndex = 30;
            this.input2aTextBox.Text = "R";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 872);
            this.Controls.Add(this.input2aTextBox);
            this.Controls.Add(this.resultNestedIf02TextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.resultElseIf02TextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.resultIf02TextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.resultSwitch02TextBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.resultNestedDefaultIf01TextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.resultElseIfDefault01TextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.resultIfDefault0TextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.resultSwitchDefault01TextBox);
            this.Controls.Add(this.resultNestedIf01TextBox);
            this.Controls.Add(this.resultElseIf01TextBox);
            this.Controls.Add(this.resultIf01TextBox);
            this.Controls.Add(this.resultSwitch01TextBox);
            this.Controls.Add(this.input1aTextBox);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "jpoulin1g1: Switch, if-else";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.TextBox input1aTextBox;
        private System.Windows.Forms.TextBox resultSwitch01TextBox;
        private System.Windows.Forms.TextBox resultIf01TextBox;
        private System.Windows.Forms.TextBox resultElseIf01TextBox;
        private System.Windows.Forms.TextBox resultNestedIf01TextBox;
        private System.Windows.Forms.TextBox resultSwitchDefault01TextBox;
        private System.Windows.Forms.TextBox resultIfDefault0TextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox resultElseIfDefault01TextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox resultNestedDefaultIf01TextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox resultNestedIf02TextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox resultElseIf02TextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox resultIf02TextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox resultSwitch02TextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox input2aTextBox;
    }
}


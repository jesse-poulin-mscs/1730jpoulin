namespace jpoulin2b1
{
    partial class frmCurrencyConverter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCurrencyConverter));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTotalUSD = new System.Windows.Forms.TextBox();
            this.txtUSDJapan = new System.Windows.Forms.TextBox();
            this.txtUSDChina = new System.Windows.Forms.TextBox();
            this.txtUSDUK = new System.Windows.Forms.TextBox();
            this.txtUSDAustralia = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRateAustralia = new System.Windows.Forms.TextBox();
            this.txtRateJapan = new System.Windows.Forms.TextBox();
            this.txtRateChina = new System.Windows.Forms.TextBox();
            this.txtRateUK = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAmountUK = new System.Windows.Forms.TextBox();
            this.txtAmountChina = new System.Windows.Forms.TextBox();
            this.txtAmountJapan = new System.Windows.Forms.TextBox();
            this.txtAmountAustralia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(508, 398);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(191, 38);
            this.btnExit.TabIndex = 42;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(311, 398);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(191, 38);
            this.btnReset.TabIndex = 39;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(935, 312);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 37);
            this.label9.TabIndex = 59;
            this.label9.Text = "+";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 319);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 25);
            this.label8.TabIndex = 58;
            this.label8.Text = "$US";
            // 
            // txtTotalUSD
            // 
            this.txtTotalUSD.Location = new System.Drawing.Point(977, 312);
            this.txtTotalUSD.Name = "txtTotalUSD";
            this.txtTotalUSD.ReadOnly = true;
            this.txtTotalUSD.Size = new System.Drawing.Size(191, 31);
            this.txtTotalUSD.TabIndex = 57;
            this.txtTotalUSD.TabStop = false;
            this.txtTotalUSD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtUSDJapan
            // 
            this.txtUSDJapan.Location = new System.Drawing.Point(313, 316);
            this.txtUSDJapan.Name = "txtUSDJapan";
            this.txtUSDJapan.ReadOnly = true;
            this.txtUSDJapan.Size = new System.Drawing.Size(191, 31);
            this.txtUSDJapan.TabIndex = 56;
            this.txtUSDJapan.TabStop = false;
            this.txtUSDJapan.Text = "0.00";
            this.txtUSDJapan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtUSDChina
            // 
            this.txtUSDChina.Location = new System.Drawing.Point(512, 316);
            this.txtUSDChina.Name = "txtUSDChina";
            this.txtUSDChina.ReadOnly = true;
            this.txtUSDChina.Size = new System.Drawing.Size(191, 31);
            this.txtUSDChina.TabIndex = 55;
            this.txtUSDChina.TabStop = false;
            this.txtUSDChina.Text = "0.00";
            this.txtUSDChina.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtUSDUK
            // 
            this.txtUSDUK.Location = new System.Drawing.Point(711, 316);
            this.txtUSDUK.Name = "txtUSDUK";
            this.txtUSDUK.ReadOnly = true;
            this.txtUSDUK.Size = new System.Drawing.Size(191, 31);
            this.txtUSDUK.TabIndex = 54;
            this.txtUSDUK.TabStop = false;
            this.txtUSDUK.Text = "0.00";
            this.txtUSDUK.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtUSDAustralia
            // 
            this.txtUSDAustralia.Location = new System.Drawing.Point(112, 316);
            this.txtUSDAustralia.Name = "txtUSDAustralia";
            this.txtUSDAustralia.ReadOnly = true;
            this.txtUSDAustralia.Size = new System.Drawing.Size(191, 31);
            this.txtUSDAustralia.TabIndex = 53;
            this.txtUSDAustralia.TabStop = false;
            this.txtUSDAustralia.Text = "0.00";
            this.txtUSDAustralia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 25);
            this.label7.TabIndex = 52;
            this.label7.Text = "Rate:";
            // 
            // txtRateAustralia
            // 
            this.txtRateAustralia.Location = new System.Drawing.Point(112, 258);
            this.txtRateAustralia.Name = "txtRateAustralia";
            this.txtRateAustralia.Size = new System.Drawing.Size(191, 31);
            this.txtRateAustralia.TabIndex = 44;
            this.txtRateAustralia.Text = "0.686345";
            this.txtRateAustralia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRateAustralia.TextChanged += new System.EventHandler(this.calculate);
            // 
            // txtRateJapan
            // 
            this.txtRateJapan.Location = new System.Drawing.Point(313, 257);
            this.txtRateJapan.Name = "txtRateJapan";
            this.txtRateJapan.Size = new System.Drawing.Size(191, 31);
            this.txtRateJapan.TabIndex = 46;
            this.txtRateJapan.Text = "0.00933012";
            this.txtRateJapan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRateJapan.TextChanged += new System.EventHandler(this.calculate);
            // 
            // txtRateChina
            // 
            this.txtRateChina.Location = new System.Drawing.Point(512, 257);
            this.txtRateChina.Name = "txtRateChina";
            this.txtRateChina.Size = new System.Drawing.Size(191, 31);
            this.txtRateChina.TabIndex = 47;
            this.txtRateChina.Text = "0.140410";
            this.txtRateChina.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRateChina.TextChanged += new System.EventHandler(this.calculate);
            // 
            // txtRateUK
            // 
            this.txtRateUK.Location = new System.Drawing.Point(711, 257);
            this.txtRateUK.Name = "txtRateUK";
            this.txtRateUK.Size = new System.Drawing.Size(191, 31);
            this.txtRateUK.TabIndex = 50;
            this.txtRateUK.Text = "1.23445";
            this.txtRateUK.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRateUK.TextChanged += new System.EventHandler(this.calculate);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 25);
            this.label6.TabIndex = 51;
            this.label6.Text = "Amount:";
            // 
            // txtAmountUK
            // 
            this.txtAmountUK.Location = new System.Drawing.Point(711, 216);
            this.txtAmountUK.Name = "txtAmountUK";
            this.txtAmountUK.Size = new System.Drawing.Size(191, 31);
            this.txtAmountUK.TabIndex = 38;
            this.txtAmountUK.Text = "0.00";
            this.txtAmountUK.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAmountUK.TextChanged += new System.EventHandler(this.calculate);
            // 
            // txtAmountChina
            // 
            this.txtAmountChina.Location = new System.Drawing.Point(512, 216);
            this.txtAmountChina.Name = "txtAmountChina";
            this.txtAmountChina.Size = new System.Drawing.Size(191, 31);
            this.txtAmountChina.TabIndex = 36;
            this.txtAmountChina.Text = "0.00";
            this.txtAmountChina.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAmountChina.TextChanged += new System.EventHandler(this.calculate);
            // 
            // txtAmountJapan
            // 
            this.txtAmountJapan.Location = new System.Drawing.Point(313, 216);
            this.txtAmountJapan.Name = "txtAmountJapan";
            this.txtAmountJapan.Size = new System.Drawing.Size(191, 31);
            this.txtAmountJapan.TabIndex = 33;
            this.txtAmountJapan.Text = "0.00";
            this.txtAmountJapan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAmountJapan.TextChanged += new System.EventHandler(this.calculate);
            // 
            // txtAmountAustralia
            // 
            this.txtAmountAustralia.Location = new System.Drawing.Point(112, 216);
            this.txtAmountAustralia.Name = "txtAmountAustralia";
            this.txtAmountAustralia.Size = new System.Drawing.Size(191, 31);
            this.txtAmountAustralia.TabIndex = 32;
            this.txtAmountAustralia.Text = "0.00";
            this.txtAmountAustralia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAmountAustralia.TextChanged += new System.EventHandler(this.calculate);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1021, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 25);
            this.label5.TabIndex = 49;
            this.label5.Text = "US Dollar";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(977, 22);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(191, 163);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 48;
            this.pictureBox5.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(752, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 25);
            this.label4.TabIndex = 45;
            this.label4.Text = "UK Pound";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(711, 22);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(191, 163);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 43;
            this.pictureBox4.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(533, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 25);
            this.label3.TabIndex = 41;
            this.label3.Text = "Chinese Yuan";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(512, 22);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(191, 163);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 40;
            this.pictureBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(333, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 25);
            this.label2.TabIndex = 37;
            this.label2.Text = "Japanese Yen";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(313, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(191, 163);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 25);
            this.label1.TabIndex = 34;
            this.label1.Text = "Australian Dollar";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(112, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(191, 163);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // frmCurrencyConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 466);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTotalUSD);
            this.Controls.Add(this.txtUSDJapan);
            this.Controls.Add(this.txtUSDChina);
            this.Controls.Add(this.txtUSDUK);
            this.Controls.Add(this.txtUSDAustralia);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtRateAustralia);
            this.Controls.Add(this.txtRateJapan);
            this.Controls.Add(this.txtRateChina);
            this.Controls.Add(this.txtRateUK);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAmountUK);
            this.Controls.Add(this.txtAmountChina);
            this.Controls.Add(this.txtAmountJapan);
            this.Controls.Add(this.txtAmountAustralia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmCurrencyConverter";
            this.Text = "Form";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTotalUSD;
        private System.Windows.Forms.TextBox txtUSDJapan;
        private System.Windows.Forms.TextBox txtUSDChina;
        private System.Windows.Forms.TextBox txtUSDUK;
        private System.Windows.Forms.TextBox txtUSDAustralia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRateAustralia;
        private System.Windows.Forms.TextBox txtRateJapan;
        private System.Windows.Forms.TextBox txtRateChina;
        private System.Windows.Forms.TextBox txtRateUK;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAmountUK;
        private System.Windows.Forms.TextBox txtAmountChina;
        private System.Windows.Forms.TextBox txtAmountJapan;
        private System.Windows.Forms.TextBox txtAmountAustralia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


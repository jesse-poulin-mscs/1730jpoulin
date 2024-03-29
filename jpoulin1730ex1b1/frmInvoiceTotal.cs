﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jpoulin1730ex1b
{
    public partial class frmInvoiceTotal : Form
    {
        public frmInvoiceTotal()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            //Different formatting just for fun.
            //decimal subTotal = Convert.ToDecimal(txtSubtotal.Text);
            //decimal discountPercent = Convert.ToDecimal(txtDiscountPercent.Text) / 100;
            //txtDiscountAmount.Text = (subTotal * discountPercent).ToString("0.00");
            //decimal discountAmount = Convert.ToDecimal(txtDiscountAmount.Text);
            //txtTotal.Text = (subTotal - discountAmount).ToString("0.00");

            txtDiscountAmount.Text = 
                (Convert.ToDecimal(txtSubtotal.Text)
                * Convert.ToDecimal(txtDiscountPercent.Text) / 100).ToString("0.00");

            txtTotal.Text = 
                (Convert.ToDecimal(txtSubtotal.Text)
                - Convert.ToDecimal(txtDiscountAmount.Text)).ToString("0.00");
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

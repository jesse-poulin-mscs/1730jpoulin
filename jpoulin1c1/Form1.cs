﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jpoulin1c1
{
    public partial class frmFoodTruck : Form
    {
        public frmFoodTruck()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            txtHotDogsSubtotal.Text = (
                Convert.ToDecimal(txtHotDogs.Text) * 4m
                ).ToString("0.00");

            txtHamburgersSubtotal.Text = (
                Convert.ToDecimal(txtHamburgers.Text) * 5m
                ).ToString("0.00");

            txtPretaxTotal.Text = (
                Convert.ToDecimal(txtHamburgersSubtotal.Text) +
                Convert.ToDecimal(txtHotDogsSubtotal.Text)
                ).ToString("0.00");

            txtTax.Text = (
                Convert.ToDecimal(txtPretaxTotal.Text) * .06875m
                ).ToString("0.00");

            txtTotal.Text = (
                Convert.ToDecimal(txtPretaxTotal.Text) +
                Convert.ToDecimal(txtTax.Text)
                ).ToString("0.00");
            btnClear.Focus();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtHotDogs.Text = "0";
            txtHamburgers.Text = "0";

            txtHamburgersSubtotal.Text = "";
            txtHotDogsSubtotal.Text = "";
            txtPretaxTotal.Text = "";
            txtTax.Text = "";
            txtTotal.Text = "";

            txtHotDogs.Focus();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jpoulin1d1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Reset Button 
        private void Button1_Click(object sender, EventArgs e)
        {
            txtAmountAustralia.Text = "0.00";
            txtAmountJapan.Text = "0.00";
            txtAmountChina.Text = "0.00";
            txtAmountUK.Text = "0.00";

            txtRateAustralia.Text = "0.686345";
            txtRateJapan.Text = "0.00933012";
            txtRateChina.Text = "0.140410";
            txtRateUK.Text = "1.23445";
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void australiaTextChanged(object sender, EventArgs e)
        {
            txtUSDAustralia.Text = (
                Convert.ToDecimal(txtAmountAustralia.Text) 
                * Convert.ToDecimal(txtRateAustralia.Text)
                ).ToString("0.00");
        }

        private void japanTextChanged(object sender, EventArgs e)
        {
            txtUSDJapan.Text = (
                Convert.ToDecimal(txtAmountJapan.Text)
                * Convert.ToDecimal(txtRateJapan.Text)
                ).ToString("0.00");
        }

        private void chinaTextChanged(object sender, EventArgs e)
        {
            txtUSDChina.Text = (
                Convert.ToDecimal(txtAmountChina.Text)
                * Convert.ToDecimal(txtRateChina.Text)
                ).ToString("0.00");
        }

        private void UKTextChanged(object sender, EventArgs e)
        {
            txtUSDUK.Text = (
                Convert.ToDecimal(txtAmountUK.Text)
                * Convert.ToDecimal(txtRateUK.Text)
                ).ToString("0.00");
        }

        private void usdTextChanged(object sender, EventArgs e)
        {
            txtTotalUSD.Text = (
                Convert.ToDecimal(txtUSDAustralia.Text) +
                Convert.ToDecimal(txtUSDChina.Text) +
                Convert.ToDecimal(txtUSDJapan.Text) +
                Convert.ToDecimal(txtUSDUK.Text)
                ).ToString("0.00");
        }
    }
}

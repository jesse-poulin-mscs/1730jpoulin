using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jpoulin2b1
{
    public partial class frmCurrencyConverter : Form
    {
        public frmCurrencyConverter()
        {
            InitializeComponent();
        }

        private void calculate(object sender, EventArgs e)
        {
            decimal amountAustralia = Convert.ToDecimal(txtAmountAustralia.Text);
            decimal rateAustralia = Convert.ToDecimal(txtRateAustralia.Text);
            decimal usdAustralia = amountAustralia * rateAustralia;
            txtUSDAustralia.Text = usdAustralia.ToString("0.00");

            decimal amountJapan = Convert.ToDecimal(txtAmountJapan.Text);
            decimal rateJapan = Convert.ToDecimal(txtRateJapan.Text);
            decimal usdJapan = amountJapan * rateJapan;
            txtUSDJapan.Text = usdJapan.ToString("0.00");

            decimal amountChina = Convert.ToDecimal(txtAmountChina.Text);
            decimal rateChina = Convert.ToDecimal(txtRateChina.Text);
            decimal usdChina = amountChina * rateChina;
            txtUSDChina.Text = usdChina.ToString("0.00");

            decimal amountUK = Convert.ToDecimal(txtAmountUK.Text);
            decimal rateUK = Convert.ToDecimal(txtRateUK.Text);
            decimal usdUK = amountUK * rateUK;
            txtUSDUK.Text = usdUK.ToString("0.00");

            txtTotalUSD.Text = (usdAustralia + usdChina + usdJapan + usdUK).ToString("0.00");
        }

        private void BtnReset_Click(object sender, EventArgs e)
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
    }
}

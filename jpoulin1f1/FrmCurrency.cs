using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jpoulin1f1
{
    public partial class FrmCurrency : Form
    {
        public FrmCurrency()
        {
            InitializeComponent();
        }

        private void FrmCurrency_Load(object sender, EventArgs e)
        {
            btnUK.BackgroundImage = picUK.Image;
            btnEU.BackgroundImage = picEUDim.Image;
            btnChina.BackgroundImage = picChinaDim.Image;
            btnJapan.BackgroundImage = picJapanDim.Image;

            lblCurrency.Text = btnUK.Text + ":";
            txtRate.Text = "1.24730";
            txtCurrency.Focus();
        }

        private void BtnUK_Click(object sender, EventArgs e)
        {
            btnUK.BackgroundImage = picUK.Image;
            btnEU.BackgroundImage = picEUDim.Image;
            btnChina.BackgroundImage = picChinaDim.Image;
            btnJapan.BackgroundImage = picJapanDim.Image;

            lblCurrency.Text = btnUK.Text + ":";
            txtRate.Text = "1.24730";
            txtCurrency.Focus();
        }

        private void BtnEU_Click(object sender, EventArgs e)
        {
            btnUK.BackgroundImage = picUKDim.Image;
            btnEU.BackgroundImage = picEU.Image;
            btnChina.BackgroundImage = picChinaDim.Image;
            btnJapan.BackgroundImage = picJapanDim.Image;

            lblCurrency.Text = btnEU.Text + ":";
            txtRate.Text = "1.10376";
            txtCurrency.Focus();
        }

        private void BtnChina_Click(object sender, EventArgs e)
        {
            btnUK.BackgroundImage = picUKDim.Image;
            btnEU.BackgroundImage = picEUDim.Image;
            btnChina.BackgroundImage = picChina.Image;
            btnJapan.BackgroundImage = picJapanDim.Image;

            lblCurrency.Text = btnChina.Text + ":";
            txtRate.Text = "0.140795";
            txtCurrency.Focus();
        }

        private void BtnJapan_Click(object sender, EventArgs e)
        {
            btnUK.BackgroundImage = picUKDim.Image;
            btnEU.BackgroundImage = picEUDim.Image;
            btnChina.BackgroundImage = picChinaDim.Image;
            btnJapan.BackgroundImage = picJapan.Image;

            lblCurrency.Text = btnJapan.Text + ":";
            txtRate.Text = "0.00927004";
            txtCurrency.Focus();
        }

        private void CalcUSD(object sender, EventArgs e)
        {
            txtUSDollar.Text = (
                Convert.ToDecimal(txtCurrency.Text) 
                * Convert.ToDecimal(txtRate.Text)
                ).ToString("0.00");
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            lblCalculation.Text = lblCalculation.Text + " + " + txtUSDollar.Text;
            txtTotal.Text = (
                Convert.ToDecimal(txtUSDollar.Text)
                + Convert.ToDecimal(txtTotal.Text)
                ).ToString("0.00");

            txtCurrency.Focus();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            txtCurrency.Text = "0.00";
            txtUSDollar.Text = "0.00";
            txtTotal.Text = "0.00";
            lblCalculation.Text = "";

            btnUK.BackgroundImage = picUK.Image;
            btnEU.BackgroundImage = picEUDim.Image;
            btnChina.BackgroundImage = picChinaDim.Image;
            btnJapan.BackgroundImage = picJapanDim.Image;

            lblCurrency.Text = btnUK.Text + ":";
            txtRate.Text = "1.24730";
            txtCurrency.Focus();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtCurrency_Enter(object sender, EventArgs e)
        {
            txtCurrency.SelectAll();
        }
    }
}

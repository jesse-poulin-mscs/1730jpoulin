using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jpoulin1e1
{
    public partial class frmAvgTestScore : Form
    {
        public frmAvgTestScore()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            txtAverage.Text = ((Convert.ToDecimal(txtScoreOne.Text)
                + Convert.ToDecimal(txtScoreTwo.Text)
                + Convert.ToDecimal(txtScoreThree.Text))
                / 3m)
                .ToString("0.00");
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtScoreOne.Text = "0";
            txtScoreTwo.Text = "0";
            txtScoreThree.Text = "0";
            txtAverage.Text = "";
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

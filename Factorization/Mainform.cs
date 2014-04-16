using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NumberProcessor;

namespace FactorizationProgram
{
    public partial class Mainform : Form
    {
        Factorization fac = new Factorization();
        public Mainform()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtInput.Text) < 0) //check if negative number
                MessageBox.Show("Negative numbers are not allowed", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                lstResults.Items.Clear(); //initialize the list box
                try
                {
                    List<int> aList = new List<int>();
                    aList = fac.findFactors(Convert.ToInt32(txtInput.Text));
                    foreach (int element in aList)
                        lstResults.Items.Add(element);


                    txtSum.Text = fac.getSum(aList).ToString();
                    txtAverage.Text = fac.getAverage(aList).ToString();

                    if (fac.isPerfectNumber(aList, (Convert.ToInt32(txtInput.Text))) == true)
                        txtPerfect.Text = "Yes";
                    else
                        txtPerfect.Text = "No";
                    aList.Clear(); // to avoid concatenation
                }

                catch (Exception ex)
                {
                    if (ex is FormatException) //non-number input
                        MessageBox.Show("Invalid input", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (ex is OverflowException) //beyond int range
                        MessageBox.Show("Out of range", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
           
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lstResults.Items.Clear();
            txtAverage.Text = "";
            txtInput.Text = "";
            txtPerfect.Text = "";
            txtSum.Text = "";
        }
    }
}

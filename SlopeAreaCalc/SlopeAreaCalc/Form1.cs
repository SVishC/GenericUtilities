using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlopeAreaCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblError.Text = "";
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            try
            {
                double area = 0;
                double factor1 = 0;
                double factor2 = 0;
                lblError.Text = "";
                factor1 = (Convert.ToDouble(txty2.Text) + Convert.ToDouble(txty1.Text)) / 2;
                factor2 = Convert.ToDouble(txtx2.Text) - Convert.ToDouble(txtx1.Text);
                area = factor1 * factor2;
                txtArea.Text = area.ToString();

            }
            catch (Exception ex)
            {

                lblError.Text = ex.Message;
            }

            
        }

        private void btnSlope_Click(object sender, EventArgs e)
        {
            try
            {
                double slope = 0;
                double num = 0;
                double den = 0;
                lblError.Text = "";
                num = Convert.ToDouble(txty2.Text) - Convert.ToDouble(txty1.Text);
                den = Convert.ToDouble(txtx2.Text) - Convert.ToDouble(txtx1.Text);
                slope = num / den;

                txtSlope.Text = slope.ToString();
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }

            
        }

        private void btnCalcY3_Click(object sender, EventArgs e)
        {
            try
            {
                double y3 = 0;
                double factor1 = 0;
                double factor2 = 0;
                lblError.Text = "";
                if (!String.IsNullOrWhiteSpace(txtSlope.Text.ToString()))
                {
                    factor1 = Convert.ToDouble(txtSlope.Text.ToString());
                    factor2 = Convert.ToDouble(txtx3.Text) - Convert.ToDouble(txtx1.Text);
                    y3 = (factor1 * factor2) + Convert.ToDouble(txty1.Text);
                }
                txty3.Text = y3.ToString();

            }
            catch (Exception ex)
            {

                lblError.Text = ex.Message;
            }
           

        }

        private void btnArea2_Click(object sender, EventArgs e)
        {
            try
            {
                double area = 0;
                double factor1 = 0;
                double factor2 = 0;
                lblError.Text = "";
                if (cbx1.Checked)
                {
                   
                    factor1 = (Convert.ToDouble(txty3.Text) + Convert.ToDouble(txty1.Text)) / 2;
                    factor2 = Convert.ToDouble(txtx3.Text) - Convert.ToDouble(txtx1.Text);
                    area = factor1 * factor2;
                }
                else if (cbx2.Checked)
                {
                    factor1 = (Convert.ToDouble(txty3.Text) + Convert.ToDouble(txty2.Text)) / 2;
                    factor2 = Convert.ToDouble(txtx3.Text) - Convert.ToDouble(txtx2.Text);
                    area = factor1 * factor2;
                }
                txtArea2.Text = area.ToString();
                txtArea3.Text = Convert.ToString(area/5);

            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
            
        }

        private double CalcArea()
        {
            return 0;
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            try
            {
                txtx2.Text = txtx3.Text;
                txty2.Text = txty3.Text;
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
        }
    }

    public class Abc : IObserver<int>
    {
        public void OnCompleted()
        {
            throw new NotImplementedException();
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnNext(int value)
        {
            throw new NotImplementedException();
        }
    }

}

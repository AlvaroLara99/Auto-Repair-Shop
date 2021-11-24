using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auto_Repair_Shop
{
    public partial class frmMain : Form
    {
        const decimal oil = 26;
        const decimal lube = 18;
        const decimal radiator = 30;
        const decimal transmission = 80;
        const decimal inspection = 15;
        const decimal muffler = 100;
        const decimal rotation = 20;
        const decimal tax = 0.06m;

        public frmMain()
        {
            InitializeComponent();
        }

        private void bntCalculate_Click(object sender, EventArgs e)
        {
            decimal services;
            decimal parts;
            decimal tax;
            decimal total;

            services = OilLubeCharges() + FlushCharges() + MiscCharges() + OtherCharges();
            parts = PartsCost();
            tax = CalcTax();
            total = services + tax;

            txtTotalServices.Text = services.ToString("c");
            txtTotalParts.Text = parts.ToString("c");
            txtTax.Text = tax.ToString("c");
            txtTotal.Text = total.ToString("c");
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Exits the program
            Application.Exit();
        }

            //Function returns the cost of Oil and Lube Charges
            private decimal OilLubeCharges()
        {
            decimal oilLubeCost = 0;
            if (cbxOil.Checked == true)
            {
                oilLubeCost += 26;
            }

            if (cbxLube.Checked == true)
            {
                oilLubeCost += 18;
            }

            return oilLubeCost;
        }

        private decimal FlushCharges()
        {
            decimal flushCharge = 0;

            if (cbxRadiator.Checked == true)
            {
                flushCharge += 30;
            }

            if (cbxTransmission.Checked == true)
            {
                flushCharge += 80;
            }

            return flushCharge;
        }

        private decimal MiscCharges()
        {
            decimal miscCharge = 0;

            if (cbxInspection.Checked == true)
            {
                miscCharge += 15;
            }

            if (cbxMuffler.Checked == true)
            {
                miscCharge += 100;
            }

            if (cbxTire.Checked == true)
            {
                miscCharge += 20;
            }

            return miscCharge;
        }

        private decimal PartsCost()
        {
            decimal temp;

            decimal partsCharge = 0;

            if(decimal.TryParse(txtParts.Text, out temp))
            {
                partsCharge = temp;
            }
            

            return partsCharge;
        }

        private decimal OtherCharges()
        {
            decimal temp;

            decimal laborCharges = 0;

            if (decimal.TryParse(txtLabor.Text, out temp))
            {
                laborCharges = temp;
            }

            return laborCharges;
        }

        private decimal CalcTax()
        {
            decimal partsCost = 0;

            if(txtParts.Text == string.Empty)
            {
                return 0;
            }
            else
            {
                partsCost = decimal.Parse(txtParts.Text);

                return partsCost * tax;
            }
        }

        private void Clear()
        {
            cbxOil.Checked = false;
            cbxLube.Checked = false;
            cbxRadiator.Checked = false;
            cbxTransmission.Checked = false;
            cbxInspection.Checked = false;
            cbxMuffler.Checked = false;
            cbxTire.Checked = false;

            txtTotalServices.Clear();
            txtTotalParts.Clear();
            txtTax.Clear();
            txtTotal.Clear();
        }
    }
}

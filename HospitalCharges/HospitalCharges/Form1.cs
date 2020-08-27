using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalCharges
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double CalcStayCharges(double days)
        {
            return days * 350;
        }

        private double CalcMiscCharges(double med, double surg, double lab, double rehab)
        {
            return (med + surg + lab + rehab);
        }


        private double CalcTotalCharges(double days, double med, double surg, double lab, double rehab)
        {
            return (CalcStayCharges(days) + CalcMiscCharges(med, surg, lab, rehab));
        }

        private void stayCharge_Click(object sender, EventArgs e)
        {
          MessageBox.Show(CalcStayCharges(Double.Parse(days.Text)).ToString());
            
        }

        private void MiscCharges_Click(object sender, EventArgs e)
        {
            double medInput = Double.Parse(med.Text);
            double surgInput = Double.Parse(surg.Text);
            double labInput = Double.Parse(lab.Text);
            double rehabInput = Double.Parse(rehab.Text);

            double miscTotal = CalcMiscCharges(medInput, surgInput, labInput, rehabInput);

            MessageBox.Show(miscTotal.ToString());

        }

        private void totalCharges_Click(object sender, EventArgs e)
        {
            double daysInput = Double.Parse(days.Text);
            double medInput = Double.Parse(med.Text);
            double surgInput = Double.Parse(surg.Text);
            double labInput = Double.Parse(lab.Text);
            double rehabInput = Double.Parse(rehab.Text);

            double totalCharge = CalcTotalCharges(daysInput, medInput, surgInput, labInput, rehabInput);

            MessageBox.Show(totalCharge.ToString());
        }
    }
}

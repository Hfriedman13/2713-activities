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
            return (days * 350.0);
        }

        private double CalcMiscCharges(double med, double surg, double lab, double rehab)
        {
            return (med + surg + lab + rehab);
        }


        private double CalcTotalCharges(double days, double med, double surg, double lab, double rehab)
        {
            return (CalcStayCharges(days) + CalcTotalCharges(days, med, surg, lab, rehab));
        }

        private void stayCharge_Click(object sender, EventArgs e)
        {
           (CalcStayCharges(Double.Parse(days.Text)));
           
        }

        private void MiscCharges_Click(object sender, EventArgs e)
        {

        }

        private void totalCharges_Click(object sender, EventArgs e)
        {

        }
    }
}

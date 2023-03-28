using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DaireAlanCevreHesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        const double pisayisi = 3.14;
        int yaricap;
        double alansonuc;
        double cevresonuc;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_hesapla_Click(object sender, EventArgs e)
        {
            yaricap = Convert.ToInt32(tbx_yariCap.Text);
            alansonuc = pisayisi * Math.Pow(yaricap,2);
            label4.Text = Convert.ToString(alansonuc);
            cevresonuc = 2 * pisayisi * yaricap;
            label5.Text = Convert.ToString(cevresonuc);
        }
    }
}

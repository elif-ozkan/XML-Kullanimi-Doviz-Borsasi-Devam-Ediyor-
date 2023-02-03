using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace XML_Kullanımı_ve_Döviz_Borsası
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            XmlDocument xmldosya = new XmlDocument();
            xmldosya.Load("https://www.tcmb.gov.tr/kurlar/today.xml");

            double dolarsatış= Convert.ToDouble(xmldosya.SelectSingleNode(string.Format("Tarih_Date/Currency[@Kod='{0}']/BanknoteSelling", "USD")).InnerText.Replace(".", ","));
            LblDolarAlış.Text = dolarsatış.ToString();

            double dolaralış = Convert.ToDouble(xmldosya.SelectSingleNode(string.Format("Tarih_Date/Currency[@Kod='{0}']/BanknoteBuying", "USD")).InnerText.Replace(".", ","));
            LblDolarSatış.Text = dolaralış.ToString();

            double euroalış = Convert.ToDouble(xmldosya.SelectSingleNode(string.Format("Tarih_Date/Currency[@Kod='{0}']/BanknoteBuying", "EUR")).InnerText.Replace(".", ","));
            LblEuroAlış.Text = euroalış.ToString();

            double eurosatış = Convert.ToDouble(xmldosya.SelectSingleNode(string.Format("Tarih_Date/Currency[@Kod='{0}']/BanknoteSelling", "EUR")).InnerText.Replace(".", ","));
            LblEuroSatış.Text = eurosatış.ToString();


        }

        private void BtnDolarAl_Click(object sender, EventArgs e)
        {
            TxtKur.Text = LblDolarAlış.Text;
        }

        private void BtnDolarSat_Click(object sender, EventArgs e)
        {
            TxtKur.Text = LblDolarSatış.Text;
        }

        private void BtnEuroSat_Click(object sender, EventArgs e)
        {
            TxtKur.Text = LblEuroSatış.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double kur, miktar, tutar;
            kur = Convert.ToDouble(TxtKur.Text);
            miktar=Convert.ToDouble(TxtMiktar.Text);
            tutar = miktar * kur;
            TxtTutar.Text=tutar.ToString();

        }

        private void TxtKur_TextChanged(object sender, EventArgs e)
        {
            TxtKur.Text = TxtKur.Text.Replace(".", ",");

        }

        private void button6_Click(object sender, EventArgs e)
        {
            double kur = Convert.ToDouble(TxtKur.Text);
            int miktar = Convert.ToInt32(TxtMiktar.Text);
            int tutar = Convert.ToInt32(miktar/kur);
            TxtTutar.Text = tutar.ToString();

            double kalan;
            kalan = miktar % kur;
            TxtKalan.Text = kalan.ToString();

        }
    }
}

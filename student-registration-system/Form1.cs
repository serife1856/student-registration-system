using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace student_registration_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonHes_Click(object sender, EventArgs e)
        {
            int vize, final;
            double ort;
            string durum;
            vize=Convert.ToInt32(textVize.Text);
            final=Convert.ToInt32(textFinal.Text);
            ort= (double)(vize*0.4+final*0.6);
            textOrt.Text = Convert.ToString(ort);

            if (ort>=50 && ort<60)
            {
                durum= "Koşullu Geçti";
            }
            else if (ort>=60)
            {
                durum="Başarılı Geçti";
            }
            else
            {
                durum="Kaldı";
            }
            textDrm.Text = durum;
        }
        int kisi=1;
       
        private void buttonkaydet_Click(object sender, EventArgs e)
        {
            if (textDrm.Text!="")
            {
                string adsoyad, numara, ders;
                adsoyad=textAd.Text;
                numara=maskedTextNo.Text;
                ders=comboBox1.Text;
                listBox1.Items.Add(kisi+"."+adsoyad+" "+numara+" "+ders+" "+"Ortalama:"+textOrt.Text+"  "+"Durum:"+textDrm.Text);
                kisi++;
            }
            else
            {
                MessageBox.Show("Lütfen ortalama ve durumu hesaplayınız","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("------------------------------------------------------------------------------------------");
        }
        private void buttonTem_Click(object sender, EventArgs e)
        {
            textAd.Text="";
            textDrm.Clear();
            textFinal.Text="";
            textVize.Text="";
            textOrt.Text="";
            maskedTextNo.Text="";
            textAd.Focus();
            comboBox1.Text="";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

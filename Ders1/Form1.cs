using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        byte sayi;// değişken tanımladık
        float pi;
        string adSoyad;
        float not1;
        string isimSoyisim;
        int dyil;

        double birimFiyat,indfiyat;
        double hesap;
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba 10-H");
            sayi = 10;// değişkene değer atama işlemini gerçekleştirdik
            pi = 3.1415f;// değişkene değer atama işlemi gerçekleştirdik
            yazdir.Text = sayi.ToString();
            
        }


        private void btnSelamla_Click(object sender, EventArgs e)
        {
            btnSelamla.Text = "Hoşgeldiiniz";

        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            isimSoyisim = txtAdSoyad.Text;
            dyil = 2026 - Convert.ToInt32(txtdyil.Text);
            MessageBox.Show("Hoşgeldiniz : "+isimSoyisim+" Yaşınız :"+dyil);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool secim;// secim adında bir değişken tanımladık
            secim = checkBox1.Checked; //Checked özelliği True veya False değerleri alır.
            lblDurum.Text = secim.ToString();
            groupBox1.BackColor = Color.Yellow;
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int girilensayi, sonuc;
            girilensayi = Convert.ToInt16(textBox1.Text);
            sonuc = girilensayi * girilensayi;
            label5.Text = sonuc.ToString();
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            int sayim1, sayim2, toplam;
            sayim1 =Convert.ToInt16( txt1.Text);
            sayim2 = Convert.ToInt16(txt2.Text);
            toplam = sayim1 + sayim2;
            label8.Text = toplam.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            birimFiyat = Convert.ToDouble(textBox2.Text);
            indfiyat = (birimFiyat * 25) / 100;
            hesap = birimFiyat - indfiyat;
            label10.Text = hesap.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            birimFiyat = Convert.ToDouble(textBox2.Text);
            indfiyat = (birimFiyat * 50) / 100;
            hesap = birimFiyat - indfiyat;
            label10.Text = hesap.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            birimFiyat = Convert.ToDouble(textBox2.Text);
            indfiyat = (birimFiyat * 75) / 100;
            hesap = birimFiyat - indfiyat;
            label10.Text = hesap.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            birimFiyat = Convert.ToDouble(textBox2.Text);
            indfiyat = (birimFiyat * 10) / 100;
            hesap = birimFiyat - indfiyat;
            label10.Text = hesap.ToString();

        }
    }
}

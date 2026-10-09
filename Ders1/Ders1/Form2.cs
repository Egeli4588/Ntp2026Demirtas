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
    public partial class Form2: Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Sabit değerlerimizi tanımlıyoruz
            double GlassBirimFiyat = 40000.0;
            double standartKargoUcreti = 40.0;

 
            double adet = Convert.ToDouble(numericUpDown1.Value);
            double kargoKatSayisi = Convert.ToDouble(numericUpDown2.Value);

         
            double toplamGlassBedeli = GlassBirimFiyat * adet;
            double kdv = (toplamGlassBedeli * 18) / 100;
            double toplamKargoBedeli = standartKargoUcreti * kargoKatSayisi;

            double fisToplami = toplamGlassBedeli + toplamKargoBedeli+kdv;

            // Fişi ekrana yazdırma
            label3.Text= $"*** ALIŞVERİŞ FİŞİ ***\n" +
                         $"Gözlük Birim Fiyatı: {GlassBirimFiyat} TL\n" +
                         $"Adet: {adet}\n" +
                         $"Kargo Ücreti: {toplamKargoBedeli} TL\n" +
                         $"KDV Tutarı(%18)  : {kdv} TL\n"+
                         $"-----------------------\n" +
                         $"TOPLAM TUTAR: {fisToplami} TL";
        }
    }
}

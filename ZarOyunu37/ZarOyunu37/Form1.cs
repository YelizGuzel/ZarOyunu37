using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZarOyunu37
{
    public partial class ZarOyunu : Form
    {
        int zar1=0;
        int zar2=0;
        int toplam = 0;
        int turSayisi = 0;
        int oyunuKacinciKezOynadınız;
        int toplamPuan;
        int puan;
        public ZarOyunu()
        {
            InitializeComponent();         
        }

        private void BtnHesapla_Click(object sender, EventArgs e)
        {
            //Zar numaraları kullanıcıdan alınır.
            zar1 = Convert.ToInt32(txtZar1.Text);
            zar2 = Convert.ToInt32(txtZar2.Text);
            //Yüzeyler toplanır.
            toplam += zar1 + zar2;
            if (toplam <= 37)
            {
                //Kazanacağı puan için kaç tur oynadığı önemli olduğu için her hamlede tur sayısı kontrol edilir.
                turSayisi++;
                MessageBox.Show("Toplam değeriniz:" + " " + toplam + "\n" + "Tur sayınız:" + turSayisi + "\n" + "Lütfen bir çift zar daha seçin");
              
            }
            else
            {
                turSayisi++;
                //Oyuncu eğer buraya geldiyse kazanmadan önceki son hamlesidir.
                oyunuKacinciKezOynadınız++;
                //Bir kere yendiğinde aldığı puan:
                puan = turSayisi * 37;
                lblSonuc.Text = "Oyunu kazandınız.\nTur sayınız:" + turSayisi + "\n" + "Puanınız:" + puan;
                
            }
       
         
        }
   
    }
    
   
}

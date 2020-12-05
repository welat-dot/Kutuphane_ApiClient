using KutuphaneClient.ClientIslemleri;
using KutuphaneClient.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneClient
{
    public partial class KitapEkle : Form
    {
        private KitapResponse kitap;
        public KitapEkle(KitapResponse kitap)
        {
            InitializeComponent();
            this.kitap = kitap;
        }
        private Dictionary<string, int> yazar = new Dictionary<string, int>();       
        private async void button1_Click(object sender, EventArgs e)
        {
            Kitap kitap1 = new Kitap();


          
            bool alanlar = true;
            if (textBox1.Text == "")
                alanlar = false;
            if (numericUpDown1.Value <= 0)
                alanlar = false;
            if (comboBox1.Text == "")
                alanlar = false;
            if(alanlar)
            {
                kitap1.Id = kitap.Id;
                kitap1.kitap_adi = textBox1.Text;
                kitap1.sayfaSayisi = Convert.ToInt32(numericUpDown1.Value);
                try
                {
                    kitap1.yazar_id = yazar[comboBox1.Text]; kitap1.yazar_id = yazar[comboBox1.Text];
                    ClientManager clientManager = new ClientManager("https://localhost:44363");
                    Result<Kitap> result = new Result<Kitap>();
                    if (kitap.Id == 0)
                        result = await clientManager.PostAsync<Kitap, Kitap>(kitap1, "api/Kitaplar/kitapEkle");
                    else
                        result = await clientManager.PostAsync<Kitap, Kitap>(kitap1, "api/Kitaplar/kitapDuzenle");
                    MessageBox.Show(result.Mesage + "\n" + result.Data.kitap_adi + "\n kitabı eklendi");
                    Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("lutfen yazarı listeden Seciniz ");
                    Close();
                }
               
               
               
            }
            else
            {
                MessageBox.Show("alanları doğru doldurduğunuza emin olun");
            }


        }

        private async void KitapEkle_Load(object sender, EventArgs e)
        {
            if(kitap.Id==0)
            {
                textBox1.Text = "";

            }
            else
            {
                textBox1.Text = kitap.kitap_adi;
                numericUpDown1.Value = kitap.sayfaSayisi;
                comboBox1.Text = kitap.yazar;
            }
            ClientManager clientManager = new ClientManager("https://localhost:44363");
            Result<List<Yazar>> result = await clientManager.GetAsync<List<Yazar>>("api/Yazar/yazarGetir");
            foreach (Yazar yazaritem in result.Data)
            {
                comboBox1.Items.Add(yazaritem.yazar_Ad_Soyad);
                yazar[yazaritem.yazar_Ad_Soyad] = yazaritem.Id;
               
            }
            if (yazar.Count == 0)
            {
                MessageBox.Show("once yazar ekleyiniz");
                Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

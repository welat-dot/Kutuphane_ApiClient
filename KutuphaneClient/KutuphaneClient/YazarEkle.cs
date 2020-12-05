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
    public partial class YazarEkle : Form
    {
        public YazarEkle()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            ClientManager clientManager = new ClientManager("https://localhost:44363");
            bool alanlar = true;
            if (textBox1.Text == "")
                alanlar = false;

            if (alanlar)
            {
                Yazar yazar = new Yazar();
                yazar.yazar_Ad_Soyad = textBox1.Text;
                Result<Yazar> result = await clientManager.PostAsync<Yazar, Yazar>(yazar, "api/Yazar/ekle");
                MessageBox.Show(result.Mesage);
                Close();

            }
            else
                MessageBox.Show("alanları doldurunuz");
        }
    }
}

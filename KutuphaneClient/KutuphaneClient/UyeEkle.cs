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
    public partial class UyeEkle : Form
    {
        private Uye uye;
        public UyeEkle(Uye uye)
        {
            InitializeComponent();
            this.uye = uye;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            ClientManager clientManager = new ClientManager("https://localhost:44363");
           
            uye.uye_Adi = textBox1.Text;
            uye.uye_Soy_Adi = textBox2.Text;
            Result<Uye> result = new Result<Uye>();
            bool alanlar = true;
            if (textBox1.Text == "")
                alanlar = false;
            if (textBox1.Text == "")
                alanlar = false;

            if (alanlar)
            {
                if (uye.Id == 0)
                    result = await clientManager.PostAsync<Uye, Uye>(uye, "api/Uye/uyeEkle");
                else
                    result = await clientManager.PostAsync<Uye, Uye>(uye, "api/Uye/uyeDuzenle");
                MessageBox.Show(result.Mesage);
                Close();
            }
            else
                MessageBox.Show("alanları doldurunuz");



        }

        private void UyeEkle_Load(object sender, EventArgs e)
        {
            if(uye.Id==0)
            {
                textBox1.Text = "";
                textBox2.Text = "";
            }
           else
            {
                textBox1.Text = uye.uye_Adi;
                textBox2.Text = uye.uye_Soy_Adi;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

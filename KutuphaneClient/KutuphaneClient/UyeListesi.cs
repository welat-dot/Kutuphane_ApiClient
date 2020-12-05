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
    public partial class UyeListesi : Form
    {
        public UyeListesi()
        {
            InitializeComponent();
        }

        private async void UyeListesi_Load(object sender, EventArgs e)
        {
            ClientManager clientManager = new ClientManager("https://localhost:44363");
            Result<List<Uye>> uyelist = await clientManager.GetAsync<List<Uye>>("api/Uye/uyeGetir");
            dataGridView1.DataSource = uyelist.Data;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            yenile();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
                MessageBox.Show("secim yapınız");
            else
            {
                Uye uye = new Uye();
                uye.Id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
                uye.uye_Adi = dataGridView1.SelectedRows[0].Cells["uye_Adi"].Value.ToString();
                uye.uye_Soy_Adi = dataGridView1.SelectedRows[0].Cells["uye_Soy_Adi"].Value.ToString();
                uye.okunan_KitapSayi = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["okunan_KitapSayi"].Value);
                UyeEkle uyeEkle = new UyeEkle(uye);
                uyeEkle.Show();
                yenile();
            }

        }
        private async void yenile()
        {
            ClientManager clientManager = new ClientManager("https://localhost:44363");
            Result<List<Uye>> uyelist = await clientManager.GetAsync<List<Uye>>("api/Uye/uyeGetir");
            dataGridView1.DataSource = uyelist.Data;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
                MessageBox.Show("secim yapınız");
            else
            {
                Uye uye = new Uye();
                uye.Id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
                uye.uye_Adi = dataGridView1.SelectedRows[0].Cells["uye_Adi"].Value.ToString();
                uye.uye_Soy_Adi = dataGridView1.SelectedRows[0].Cells["uye_Soy_Adi"].Value.ToString();
                uye.okunan_KitapSayi = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["okunan_KitapSayi"].Value);
                ClientManager clientManager = new ClientManager("https://localhost:44363");
                Result<bool> uyelist = await clientManager.PostAsync<Uye, bool>(uye, "api/Uye/uyeSil");

                yenile();
            }
        }
    }
}

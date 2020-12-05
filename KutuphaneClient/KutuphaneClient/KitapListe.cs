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
    public partial class KitapListe : Form
    {
        public KitapListe()
        {
            InitializeComponent();
        }
        private Dictionary<string, int> yazar = new Dictionary<string, int>();
        private async void KitapListe_Load(object sender, EventArgs e)
        {
            ClientManager clientManager = new ClientManager("https://localhost:44363");
            Result<List<Yazar>> result = await clientManager.GetAsync<List<Yazar>>("api/Yazar/yazarGetir");
            foreach (Yazar yazaritem in result.Data)
            {                
                yazar[yazaritem.yazar_Ad_Soyad] = yazaritem.Id;
            }
            ClientManager clientManager1 = new ClientManager("https://localhost:44363");
            Result<List<KitapResponse>> aa = await clientManager1.GetAsync<List<KitapResponse>>("api/Kitaplar/kitapGetir");
            dataGridView1.DataSource = aa.Data;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count == 0)
                MessageBox.Show("lutfen secim yapınız");
            else
            {
                KitapResponse kitap = new KitapResponse();
                kitap.Id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
                kitap.kitap_adi = dataGridView1.SelectedRows[0].Cells["kitap_adi"].Value.ToString();
                kitap.yazar = dataGridView1.SelectedRows[0].Cells["yazar"].Value.ToString();
                kitap.sayfaSayisi = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["sayfaSayisi"].Value);
                KitapEkle kitapEkle = new KitapEkle(kitap);
                kitapEkle.Show();
                yenile();
            }

        }

        private async void button1_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count == 0)
                MessageBox.Show("lutfen seçim yapınız");
            else
            {
                Kitap kitap = new Kitap();
                kitap.Id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
                kitap.kitap_adi = dataGridView1.SelectedRows[0].Cells["kitap_adi"].Value.ToString();
                kitap.sayfaSayisi = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["sayfaSayisi"].Value);
                kitap.yazar_id = yazar[dataGridView1.SelectedRows[0].Cells["yazar"].Value.ToString()];
                ClientManager clientManager1 = new ClientManager("https://localhost:44363");
                Result<bool> aa = await clientManager1.PostAsync<Kitap, bool>(kitap, "api/Kitaplar/kitapSil");
                if (aa.Data)
                {
                    MessageBox.Show(aa.Mesage);

                }

                yenile();
            }
        }

        private  void button3_Click(object sender, EventArgs e)
        {
            yenile();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }
        private async void yenile()
        {
            ClientManager clientManager = new ClientManager("https://localhost:44363");
            Result<List<Yazar>> result = await clientManager.GetAsync<List<Yazar>>("api/Yazar/yazarGetir");
            foreach (Yazar yazaritem in result.Data)
            {
                yazar[yazaritem.yazar_Ad_Soyad] = yazaritem.Id;
            }
            ClientManager clientManager1 = new ClientManager("https://localhost:44363");
            Result<List<KitapResponse>> aa = await clientManager1.GetAsync<List<KitapResponse>>("api/Kitaplar/kitapGetir");
            dataGridView1.DataSource = aa.Data;
        }
    }
}

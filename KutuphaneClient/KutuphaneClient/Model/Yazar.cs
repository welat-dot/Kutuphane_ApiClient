using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneClient.Model
{
    public class Yazar
    {
        public int Id { get; set; }
        public string yazar_Ad_Soyad { get; set; }
        public int yazar_Kitap_Sayisi { get; set; } = 0;
    }
}

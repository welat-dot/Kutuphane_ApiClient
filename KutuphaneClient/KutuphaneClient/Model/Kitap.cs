using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneClient.Model
{
    public class Kitap
    {
        public int Id { get; set; }       
        public string kitap_adi { get; set; }       
        public int yazar_id { get; set; }
        public int sayfaSayisi { get; set; }
    }
}

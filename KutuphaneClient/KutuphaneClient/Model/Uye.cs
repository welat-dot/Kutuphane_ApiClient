using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneClient.Model
{
    public class Uye
    {
        public int Id { get; set; }        
        public string uye_Adi { get; set; }       
        public string uye_Soy_Adi { get; set; }
        public int okunan_KitapSayi { get; set; } = 0;
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace KutuphaneDataAccess.Model.Response
{
   public  class KitapResponse
    {
        
        public int Id { get; set; }        
        public string kitap_adi { get; set; }        
        public int sayfaSayisi { get; set; }
        public string yazar { get; set; }
    }
}

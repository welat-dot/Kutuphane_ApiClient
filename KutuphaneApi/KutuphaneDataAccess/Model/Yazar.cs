using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KutuphaneDataAccess.Model
{
    public class Yazar
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [MaxLength(65)]
        public string yazar_Ad_Soyad { get; set; }
        public int yazar_Kitap_Sayisi { get; set; } = 0;
       
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KutuphaneDataAccess.Model
{
    public class Uye
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [MaxLength(50)]
        public string uye_Adi { get; set; }
        [MaxLength(100)]
        public string uye_Soy_Adi { get; set; }
        public int okunan_KitapSayi { get; set; } = 0;
    }
}

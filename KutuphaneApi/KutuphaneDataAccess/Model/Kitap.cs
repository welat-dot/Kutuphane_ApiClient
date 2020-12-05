using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KutuphaneDataAccess.Model
{
    public class Kitap
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [MaxLength(60)]
        public string kitap_adi { get; set; }
        [ForeignKey(nameof(Yazar))]
        public int yazar_id { get; set; }
        public int sayfaSayisi { get; set; }
        

    }
}

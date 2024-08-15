using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MedicalCenter.Core.Models
{
    [Table("COUNTRIES")]
    public class CountryDTO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }


        [Column("NAME"), MaxLength(50), Required]
        public string Name { get; set; }
    }
}

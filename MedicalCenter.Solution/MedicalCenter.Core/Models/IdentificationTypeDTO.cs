using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MedicalCenter.Core.Models
{
    [Table("IDENTIFICATIONTYPES")]
    public class IdentificationTypeDTO
    {
        [Key]
        public int ID { get; set; }


        [Column("NAME"), MaxLength(4), Required]
        public string Name { get; set; }
    }
}

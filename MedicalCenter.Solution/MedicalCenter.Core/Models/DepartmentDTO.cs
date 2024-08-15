using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MedicalCenter.Core.Models
{
    [Table("DEPARTMENTS")]
    public class DepartmentDTO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }


        [Column("NAME"), MaxLength(50), Required]
        public string Name { get; set; }


        [ForeignKey("COUNTRIES")]
        public int CountryId { get; set; }


        public virtual CountryDTO Country { get; set; }
    }
}

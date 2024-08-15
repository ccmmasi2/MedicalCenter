using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MedicalCenter.Core.Models
{
    [Table("CITIES")]
    public class CityDTO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }


        [Column("NAME"), MaxLength(50), Required]
        public string Name { get; set; }


        [ForeignKey("DEPARTMENTS")]
        public int DepartmentId { get; set; }


        public virtual DepartmentDTO Department { get; set; }
    }
}

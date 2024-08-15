using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MedicalCenter.Core.Models
{
    [Table("CUSTOMERS")]
    public class CustomerDTO
    {
        [Key]
        public int ID { get; set; }


        [Column("IDENTIFICATION"), Required]
        public long Identification { get; set; }


        [Column("NAME"), MaxLength(50), Required]
        public string Name { get; set; }


        [Column("LASTNAME"), MaxLength(50), Required]
        public string LastName { get; set; }


        [Column("BIRTHDAY"), Required]
        public DateTime BirthDay { get; set; }


        [ForeignKey("IDENTIFICATIONTYPES")]
        public int IdentificationTypeId { get; set; }


        [ForeignKey("Cities")]
        public int CityId { get; set; }


        [Column("ACTIVE"), Required]
        public bool Active { get; set; }

        public virtual IdentificationTypeDTO IdentificationType { get; set; }

        public virtual CityDTO City { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace PointOfSalesV2.Entities
{
    public class User : ICommonData
    {
        
        [Key]
        public Guid UserId { get; set; }

        public virtual Guid CreatedBy { get; set; }
        public virtual string CreatedByName { get; set; }

        public virtual Guid? ModifiedBy { get; set; }
        public virtual string ModifiedByName { get; set; }
        public virtual DateTime CreatedDate { get; set; }

        public virtual DateTime? ModifiedDate { get; set; }
        [MaxLength(2)]
        public virtual string LanguageCode { get; set; } = "EN";

        public virtual bool Active { get; set; }

        [ForeignKey("LanguageCode")]
        public Language Language { get; set; }

        [NotMapped]
        public string TokenKey { get; set; }

        [MaxLength(30)]
        [DataMember]
        [Required]
        public string Name { get; set; }


        [MaxLength(30)]
        [DataMember]
        [Required]
        public string LastName { get; set; }

        [DataMember]
        public DateTime? BirthDay { get; set; }


        [DataMember]
        [MaxLength(15)]
        public string Phone { get; set; }

        [MaxLength(15)]
        [DataMember]
        public string Mobile { get; set; }

        [MaxLength(200)]
        [DataMember]
        public string Address { get; set; }


        [MaxLength(30)]
        [DataMember]
        [Required]
        public string UserName { get; set; }

        [DataType(DataType.Password)]
        [DataMember]
        [Required]
        public string Password { get; set; }

        [MaxLength(150)]
        [DataType(DataType.EmailAddress)]
        [DataMember]
        [Display(Name = "Email")]
        public string Email { get; set; }

        public byte[] ImageData { get; set; }
        [MaxLength(15)]
        public string ContentType { get; set; }
        public double? Width { get; set; }
        public double? Height { get; set; }

        public double? Size { get; set; }

        public long? BranchOfficeId { get; set; }
        public long? CashRegisterId { get; set; }
        public long? WarehouseId { get; set; }
        public int CashRegisterOpenningTimeHours { get; set; }



        [NotMapped]
        public string FullName => $"{Name}  {LastName}";
        [DataMember]
        public virtual char Gender { get; set; }

        [ForeignKey("BranchOfficeId")]
        public virtual BranchOffice BranchOffice { get; set; }
        [ForeignKey("CashRegisterId")]
        public virtual CashRegister CashRegister { get; set; }
        [ForeignKey("WarehouseId")]
        public virtual Warehouse Warehouse { get; set; }

        public virtual List<UserClaims> Claims { get; set; }

        public virtual IEnumerable<CashRegisterOpening> CashRegisterOpeningClosings { get; set; }

        public virtual List<UserOperation> Permissions { get; set; }
       [NotMapped]
        public long Id { get ; set ; }
        [NotMapped]
        public string TranslationData { get; set; }


        }
}

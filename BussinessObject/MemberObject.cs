using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BussinessObject
{
    [Table("Members")]
    public class MemberObject
    {
        [Key]
        public int MemberId { get; set; }
        [MaxLength(100)]
        public string Email { get; set; }
        [MaxLength(40)]
        public string CompanyName { get; set; }
        [MaxLength(15)]
        public string City { get; set; }
        [MaxLength(15)]
        public string Country { get; set; }
        [MaxLength(30)]
        public string Password { get; set; }
        public virtual ICollection<OrderObject>? Orders { get; set; }

        public override string ToString()
        {
            return $"{MemberId} - {Email}";
        }
    }
}
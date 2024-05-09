using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObject
{
    [Table("Orders")]
    public class OrderObject
    {
        [Key]
        public int OrderId { get; set; }
        public int MemberId { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime? RequiredDate { get; set; }
        public DateTime? ShippedDate { get; set; }
        [Column(TypeName = "money")]
        public decimal? Freight { get; set;}

        [ForeignKey(nameof(OrderObject.MemberId))]
        public virtual MemberObject? Member { get; set; }
        public virtual ICollection<OrderDetailsObject> Details { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObject
{
    [Table("OrderDetails")]
    public class OrderDetailsObject
    {
        public int ProductId { get; set; }
        public int OrderId { get; set; }
        [Column(TypeName = "money")]
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        [Column(TypeName = "float")]
        public float Discount { get; set; }

        [ForeignKey(nameof(OrderId))]
        public virtual OrderObject OrderObject { get; set; }
        [ForeignKey(nameof(ProductId))]
        public virtual ProductObject ProductObject { get; set; }

    }
}

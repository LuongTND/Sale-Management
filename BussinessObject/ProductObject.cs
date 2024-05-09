using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObject
{
    [Table("Products")]
    public class ProductObject
    {
        [Key]
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        [MaxLength(40)]
        public string ProductName { get; set; }
        [MaxLength(20)]
        public string Weight { get; set; }
        [Column(TypeName = "money")]
        public decimal UnitPrice { get; set; }
        public int UnitslnStock { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public virtual CategoryObject Category { get; set; }
        public virtual ICollection<OrderDetailsObject> Details { get; set; }

        public override string ToString()
        {
            return ProductName;
        }
    }
}

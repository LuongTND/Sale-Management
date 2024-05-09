using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObject
{
    [Table("Categories")]
    public class CategoryObject
    {
        [Key]
        public int CategoryId { get; set; }
        [StringLength(100)]
        public string CategoryName { get; set; }

        public virtual ICollection<ProductObject> Products { get; set; }

        public override string ToString()
        {
            return CategoryName;
        }
    }
}

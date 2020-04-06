using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public class Good
    {
        [Key]
        public int Id { get; set; }
        public string GName { get; set; }
        public int TypeId { get; set; }
        public decimal Gprice { get; set; }
        public int SupplierId { get; set; }
        public string remark { get; set; }

        [ForeignKey("TypeId")]
        public virtual GoodType GoodType { get; set; }

        [ForeignKey("SupplierId")]
        public virtual Supplier Supplier { get; set; }
    }
}

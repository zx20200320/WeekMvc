using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace DataModel
{
    /// <summary>
    /// 供应商
    /// </summary>
    public class Supplier
    {
        [Key]
        public int Id { get; set; }
        public string SupplierName { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudiaProgramm
{
    public class products
    {
        [Key]
        public int id { get; set; }
        public string? products_name { get; set; }
        public string? Production_time { get; set; }
        public int Price { get; set; }

        public static products CurrentProd = null;
    }
}

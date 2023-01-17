using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudiaProgramm
{
    public class Client
    {
        [Key]
        public int user_id { get; set; }
        public string? Name { get; set; }
        public string? Password { get; set; }
        public string? Phone { get; set; }
        public string? email { get; set; }

        public static Client CurrentProd = null;
    }
}

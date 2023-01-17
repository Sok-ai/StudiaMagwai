using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class User
{
    [Key]
    public int role_id { get; set; }
    public string? Login { get; set; }
    public string? Password { get; set; }

    public static User CurrentUser = null;
}

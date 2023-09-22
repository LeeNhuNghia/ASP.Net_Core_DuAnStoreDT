using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DuAnStoreDT.Models
{
    public class Admin
    {
        [Key]
        public string useradmin { get; set; }
        public string passwordadmin { get; set; }
    }
}

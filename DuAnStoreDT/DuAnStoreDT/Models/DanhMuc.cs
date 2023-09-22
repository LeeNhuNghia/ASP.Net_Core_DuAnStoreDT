using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DuAnStoreDT.Models
{
    public class DanhMuc
    {
        [Key]
        public string madm { get; set; }
        public string tendm { get; set; }
    }
}

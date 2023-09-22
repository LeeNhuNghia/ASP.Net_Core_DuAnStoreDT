using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DuAnStoreDT.Models
{
    public class NhaCungCap
    {
        [Key]
        public string mancc { get; set; }
        public string tenncc { get; set; }
    }
}

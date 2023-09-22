using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DuAnStoreDT.Models
{
    public class ChiTietHoaDonMua
    {
        [Key]
        public string macthdm { get; set; }
        public string masp { get; set; }
        [ForeignKey("masp")]
        public SanPham SanPham { get; set; }
        public int dongiamua { get; set; }
        public int soluong { get; set; }
    }
}

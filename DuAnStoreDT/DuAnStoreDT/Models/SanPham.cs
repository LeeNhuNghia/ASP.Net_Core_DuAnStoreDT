using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DuAnStoreDT.Models
{
    public class SanPham
    {
        [Key]
        public string masp { get; set; }
        public string tensp { get; set; }
        public int giacu { get; set; }
        public int giamoi { get; set; }
        public string hinhanh { get; set; }
        public string madm { get; set; }
        [ForeignKey("madm")]
        public DanhMuc DanhMuc { get; set; }
        public string mancc { get; set; }
        [ForeignKey("mancc")]
        public NhaCungCap NhaCungCap { get; set; }
    }
}

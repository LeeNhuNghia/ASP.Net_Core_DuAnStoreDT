using System;
using System.Collections.Generic;

#nullable disable

namespace DuAnASPnetCore_storeDT.Models
{
    public partial class Account
    {
        public int Tkid { get; set; }
        public string Tkusername { get; set; }
        public string Tkpassword { get; set; }
        public string Tkname { get; set; }
        public string Tkemail { get; set; }
        public string Tkphone { get; set; }
        public DateTime? Tkdate { get; set; }
        public string LoaiTaiKhoan { get; set; }
    }
}

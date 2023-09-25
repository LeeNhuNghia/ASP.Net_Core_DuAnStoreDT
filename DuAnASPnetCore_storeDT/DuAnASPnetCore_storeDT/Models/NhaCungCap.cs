using System;
using System.Collections.Generic;

#nullable disable

namespace DuAnASPnetCore_storeDT.Models
{
    public partial class NhaCungCap
    {
        public NhaCungCap()
        {
            Products = new HashSet<Product>();
        }

        public string Nccid { get; set; }
        public string Nccname { get; set; }
        public string Nccaddress { get; set; }
        public string Nccphone { get; set; }
        public string Nccemail { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}

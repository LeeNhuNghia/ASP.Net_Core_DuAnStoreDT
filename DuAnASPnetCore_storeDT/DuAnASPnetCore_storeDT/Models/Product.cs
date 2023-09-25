using System;
using System.Collections.Generic;

#nullable disable

namespace DuAnASPnetCore_storeDT.Models
{
    public partial class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductImg { get; set; }
        public int? Price { get; set; }
        public int? ProductQuantity { get; set; }
        public string Descriptions { get; set; }
        public string CategoryId { get; set; }
        public string Nccid { get; set; }

        public virtual Category Category { get; set; }
        public virtual NhaCungCap Ncc { get; set; }
    }
}

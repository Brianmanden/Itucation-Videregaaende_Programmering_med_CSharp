using System;
using System.Collections.Generic;

namespace Exercise_1_DatabaseFirstMVCCore.Models;

public partial class Product
{
    public int PId { get; set; }

    public string PName { get; set; } = null!;

    public int? PPrice { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}

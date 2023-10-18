using System;
using System.Collections.Generic;

namespace Exercise_1_DatabaseFirstMVCCore.Models;

public partial class Customer
{
    public int CId { get; set; }

    public string CName { get; set; } = null!;

    public string? CEmail { get; set; }

    public int? CPhone { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}

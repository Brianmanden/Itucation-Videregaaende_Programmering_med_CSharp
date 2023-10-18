using System;
using System.Collections.Generic;

namespace Exercise_1_DatabaseFirstMVCCore.Models;

public partial class SalesView
{
    public string CName { get; set; } = null!;

    public DateTime? OrderDate { get; set; }

    public string PName { get; set; } = null!;

    public int? UnitPrice { get; set; }

    public int? TotalAmount { get; set; }

    public string? PaymentStatus { get; set; }
}

using System;
using System.Collections.Generic;

namespace Exercise_1_DatabaseFirstMVCCore.Models;

public partial class Order
{
    public int OId { get; set; }

    public int? CId { get; set; }

    public int? PId { get; set; }

    public DateTime? OrderDate { get; set; }

    public bool? PaymentStatus { get; set; }

    public int? Quantity { get; set; }

    public virtual Customer? CIdNavigation { get; set; }

    public virtual Product? PIdNavigation { get; set; }
}

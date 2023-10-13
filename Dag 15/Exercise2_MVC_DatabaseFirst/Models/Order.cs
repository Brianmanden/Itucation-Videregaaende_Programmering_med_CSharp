using System;
using System.ComponentModel.DataAnnotations;

namespace Exercise2_MVC_DatabaseFirst.Models
{
    public partial class Order
    {
        [Key]
        public int oID { get; set; }

        public int? cID { get; set; }

        public int? pID { get; set; }

        public DateTime? orderDate { get; set; }

        public bool? paymentStatus { get; set; }

        public int? quantity { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Product Product { get; set; }
    }
}

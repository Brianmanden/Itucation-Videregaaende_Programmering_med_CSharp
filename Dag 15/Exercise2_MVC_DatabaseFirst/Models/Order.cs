using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Exercise2_MVC_DatabaseFirst.Models
{
    public partial class Order
    {
        [Key]
        public int oID { get; set; }

        [DisplayName("Customer Name")]
        public int? cID { get; set; }

        [DisplayName("Product Name")]
        public int? pID { get; set; }

        [DisplayName("Order Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime? orderDate { get; set; }

        [DisplayName("Payment Status")]
        public bool? paymentStatus { get; set; }

        [DisplayName("Quantity")]
        public int? quantity { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Product Product { get; set; }
    }
}

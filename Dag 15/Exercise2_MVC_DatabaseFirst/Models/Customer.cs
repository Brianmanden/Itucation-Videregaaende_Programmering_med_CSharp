using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Exercise2_MVC_DatabaseFirst.Models
{
    public partial class Customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customer()
        {
            Orders = new HashSet<Order>();
        }

        [Key]
        public int cID { get; set; }

        [Required]
        [StringLength(30)]
        public string cName { get; set; }

        [StringLength(45)]
        public string cEmail { get; set; }

        public int? cPhone { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }
    }
}

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Exercise2_MVC_DatabaseFirst.Models
{
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            Orders = new HashSet<Order>();
        }

        [Key]
        public int pID { get; set; }

        [Required]
        [StringLength(50)]
        public string pName { get; set; }

        public int? pPrice { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }
    }
}

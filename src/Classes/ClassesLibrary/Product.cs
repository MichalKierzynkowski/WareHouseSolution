namespace ClassesLibrary
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            Returns = new HashSet<Returns>();
            Sales = new HashSet<Sales>();
        }

        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal IdProduct { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? IdWarehouse { get; set; }

        public int? Type { get; set; }

        public int? BarNumber { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        public int? PurchaseMethod { get; set; }

        [Column(TypeName = "money")]
        public decimal? PurchasePrice { get; set; }

        [Column(TypeName = "money")]
        public decimal? SellPrice { get; set; }

        public virtual Warehouse Warehouse { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Returns> Returns { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sales> Sales { get; set; }
    }
}

namespace ClassesLibrary
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sales
    {
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal IdSales { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ProIdProduct { get; set; }

        public int? IdProduct { get; set; }

        public DateTime? Date { get; set; }

        [Column(TypeName = "money")]
        public decimal? Profit { get; set; }

        public int? Quantity { get; set; }

        public virtual Product Product { get; set; }
    }
}

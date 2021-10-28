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
        public decimal Id_Sales { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Pro_Id_Product { get; set; }

        public int? Id_Product { get; set; }

        public DateTime? Date { get; set; }

        [Column(TypeName = "money")]
        public decimal? Profit { get; set; }

        public int? Quantity { get; set; }

        public virtual Product Product { get; set; }
    }
}

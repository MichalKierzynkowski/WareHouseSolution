namespace ClassesLibrary
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Returns
    {
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal Id_Returns { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Pro_Id_Product { get; set; }

        public int? Id_Product { get; set; }

        public DateTime? Date { get; set; }

        public virtual Product Product { get; set; }
    }
}

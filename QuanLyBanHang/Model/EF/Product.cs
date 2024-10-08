namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        public int ID { get; set; }

        [StringLength(10)]
        public string Code { get; set; }

        [StringLength(250)]
        public string Name { get; set; }

        [StringLength(50)]
        public string MetaTitle { get; set; }

        [Required]
        [StringLength(50)]
        public string Description { get; set; }

        [StringLength(10)]
        public string Image { get; set; }

        public bool? VAT { get; set; }

        [Column(TypeName = "xml")]
        public string MoreImg { get; set; }

        public decimal? PromotionPrice { get; set; }

        public decimal? Price { get; set; }

        [StringLength(10)]
        public string Quantity { get; set; }

        public long? CategoryID { get; set; }

        [StringLength(10)]
        public string Detail { get; set; }

        public int? Waranty { get; set; }

        public DateTime? CreateDate { get; set; }

        [StringLength(50)]
        public string CreateBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        [StringLength(50)]
        public string ModifiedBy { get; set; }

        [StringLength(50)]
        public string MetaKeyWords { get; set; }

        [StringLength(10)]
        public string MetaDes { get; set; }

        public bool? Status { get; set; }

        public DateTime? TopHot { get; set; }

        public int? ViewCount { get; set; }
    }
}

namespace model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Account")]
    public partial class Account
    {
        public long id { get; set; }

        [StringLength(50)]
        public string username { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        [StringLength(50)]
        public string password { get; set; }

        public int? phone { get; set; }

        [StringLength(50)]
        public string mail { get; set; }

        [StringLength(50)]
        public string adress { get; set; }
    }
}

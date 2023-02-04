namespace WebMaterialApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Mst_Rights
    {
        public int? RoleId { get; set; }

        public string Rights { get; set; }

        public DateTime? CreatedOn { get; set; }

        public int? CreatedBy { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public int? UpdatedBy { get; set; }

        public DateTime? DeletedOn { get; set; }

        public int? DeletedBy { get; set; }

        [Key]
        public int RID { get; set; }
    }
}

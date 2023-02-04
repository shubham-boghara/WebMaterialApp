namespace WebMaterialApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Mst_WebAdmins
    {
        [Key]
        public int Web_Admin_Id { get; set; }

        public string UserName { get; set; }

        public string LsatName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public bool? IsActive { get; set; }

        public int? RoleId { get; set; }

        public DateTime? CreatedOn { get; set; }

        public int? CretatedBy { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public int? UpdatedBy { get; set; }

        public DateTime? DeletedOn { get; set; }

        public int? DeletedBy { get; set; }
    }
}

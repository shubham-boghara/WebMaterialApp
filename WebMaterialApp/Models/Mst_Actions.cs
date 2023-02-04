namespace WebMaterialApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Mst_Actions
    {
        [Key]
        public int ActionId { get; set; }

        public string Name { get; set; }
    }
}

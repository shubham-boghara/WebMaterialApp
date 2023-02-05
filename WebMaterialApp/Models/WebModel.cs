using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WebMaterialApp.Models
{
    public partial class WebModel : DbContext
    {
        public WebModel()
            : base("name=WebModels")
        {
        }

        public virtual DbSet<Mst_Actions> Mst_Actions { get; set; }
        public virtual DbSet<Mst_Rights> Mst_Rights { get; set; }
        public virtual DbSet<Mst_Roles> Mst_Roles { get; set; }
        public virtual DbSet<Mst_Users> Mst_Users { get; set; }
        public virtual DbSet<Mst_WebAdmins> Mst_WebAdmins { get; set; }
        public virtual DbSet<Mst_Exceptions> Mst_Exceptions { get; set; }
        public virtual DbSet<Mst_AdminRoutes> Mst_AdminRouts { get; set; }

        public virtual DbSet<Vw_Mst_WebAdmins> Vw_Mst_WebAdmins { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebMaterialApp.Models
{
    public class Mst_AdminRoutes
    {
        [Key]
        public int RouteId { get; set; }

        public string RouteName { get; set; }

        public int? ParentRouteId { get; set; }

        public string RouteIndex { get; set; }

        public bool? IsActive { get; set; }

        public int? SortOdr { get; set; }

        public DateTime? CreatedOn { get; set; }

        public int? CreatedBy { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public int? UpdatedBy { get; set; }

        public DateTime? DeletedOn { get; set; }

        public int? DeletedBy { get; set; }

    }
}
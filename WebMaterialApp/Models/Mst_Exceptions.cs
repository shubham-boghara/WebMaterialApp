using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebMaterialApp.Models
{
    public class Mst_Exceptions
    {
        [Key]
        public int ExId { get; set; }
        public string ExceptionName { get; set; }
        public string RouteName { get; set; }
        public string InnerException { get; set; }
        public DateTime? CreatedOn { get; set; }

    }
}
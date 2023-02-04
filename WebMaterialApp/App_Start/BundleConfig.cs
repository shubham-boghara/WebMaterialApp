using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace WebMaterialApp.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/bs-jq-bundle").Include(
                          "~/Content/plugins/jquery/jquery.min.js",
                          "~/Content/plugins/bootstrap/js/bootstrap.bundle.min.js",
                          "~/Content/dist/js/adminlte.min.js",
                          "~/Content/plugins/datatables/jquery.dataTables.min.js",
                          "~/Content/plugins/datatables-bs4/js/dataTables.bootstrap4.min.js",
                          "~/Content/plugins/datatables-responsive/js/dataTables.responsive.min.js",
                          "~/Content/plugins/datatables-responsive/js/responsive.bootstrap4.min.js",
                          "~/Content/plugins/datatables-buttons/js/dataTables.buttons.min.js",
                          "~/Content/plugins/datatables-buttons/js/buttons.bootstrap4.min.js",
                          "~/Content/plugins/jszip/jszip.min.js",
                          "~/Content/plugins/pdfmake/pdfmake.min.js",
                          "~/Content/plugins/pdfmake/vfs_fonts.js",
                          "~/Content/plugins/datatables-buttons/js/buttons.html5.min.js",
                          "~/Content/plugins/datatables-buttons/js/buttons.print.min.js",
                          "~/Content/plugins/datatables-buttons/js/buttons.colVis.min.js",
                          "~/Content/plugins/bs-custom-file-input/bs-custom-file-input.min.js",
                          "~/Content/plugins/select2/js/select2.full.min.js",
                          "~/Content/plugins/bootstrap4-duallistbox/jquery.bootstrap-duallistbox.min.js",
                          "~/Content/plugins/moment/moment.min.js",
                          "~/Content/plugins/inputmask/jquery.inputmask.min.js",
                          "~/Content/plugins/daterangepicker/daterangepicker.js",
                          "~/Content/plugins/bootstrap-colorpicker/js/bootstrap-colorpicker.min.js",
                          "~/Content/plugins/tempusdominus-bootstrap-4/js/tempusdominus-bootstrap-4.min.js",
                          "~/Content/plugins/bootstrap-switch/js/bootstrap-switch.min.js",
                          "~/Content/plugins/bs-stepper/js/bs-stepper.min.js",
                          "~/Content/plugins/dropzone/min/dropzone.min.js"
                          ));

            var font_cdn = "https://fonts.googleapis.com/css?family=Source+Sans+Pro:300,400,400i,700&display=fallback";

            bundles.Add(new StyleBundle("~/bundles/css",font_cdn).Include(
                                                    "~/Content/plugins/fontawesome-free/css/all.min.css",
                                                    "~/Content/dist/css/adminlte.min.css",
                                                    "~/Content/plugins/datatables-bs4/css/dataTables.bootstrap4.min.css",
                                                    "~/Content/plugins/datatables-responsive/css/responsive.bootstrap4.min.css",
                                                    "~/Content/plugins/datatables-buttons/css/buttons.bootstrap4.min.css",
                                                    "~/Content/plugins/daterangepicker/daterangepicker.css",
                                                    "~/Content/plugins/icheck-bootstrap/icheck-bootstrap.min.css",
                                                    "~/Content/plugins/bootstrap-colorpicker/css/bootstrap-colorpicker.min.css",
                                                    "~/Content/plugins/tempusdominus-bootstrap-4/css/tempusdominus-bootstrap-4.min.css",
                                                    "~/Content/plugins/select2/css/select2.min.css",
                                                    "~/Content/plugins/select2-bootstrap4-theme/select2-bootstrap4.min.css",
                                                    "~/Content/plugins/bootstrap4-duallistbox/bootstrap-duallistbox.min.css",
                                                    "~/Content/plugins/bs-stepper/css/bs-stepper.min.css",
                                                    "~/Content/plugins/dropzone/min/dropzone.min.css"
                                                ));
           
            //the following creates bundles in debug mode;
            //BundleTable.EnableOptimizations = true;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrganizzeReports.MVC.Integration.Dtos
{
    public class Category
    {
        public int id { get; set; }
        public string name { get; set; }
        public string color { get; set; }
        public int? parent_id { get; set; }
    }

}

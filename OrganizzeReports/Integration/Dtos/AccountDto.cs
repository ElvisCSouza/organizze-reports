using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrganizzeReports.Integration.Dtos
{
    public class Account
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public bool archived { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public bool _default { get; set; }
        public string type { get; set; }
    }

}

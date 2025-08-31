using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class Job
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int SalaryMin { get; set; }
        public int SalaryMax { get; set; }
        public string LSocation { get; set; }
        public string ?ImageUrl { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; }

    }
}

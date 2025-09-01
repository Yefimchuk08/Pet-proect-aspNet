using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class Job
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "This field REQUIRED"), MinLength(5, ErrorMessage = "Length must be more than 5 symbols")]
        public string Title { get; set; }
        [Required(ErrorMessage ="This field REQUIRED"), MinLength(20, ErrorMessage = "Length must be more than 20 symbols")]
        public string Description { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "Salary can not be < 0")]
        public int SalaryMin { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "Salary can not be < 0")]
        public int SalaryMax { get; set; }
        public string LSocation { get; set; }
        [Url(ErrorMessage = "This field must started with 'http/https'")]
        public string ImageUrl { get; set; }
        public int CompanyId { get; set; }
        public Company ?Company { get; set; }

    }
}

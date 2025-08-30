using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string Role { get; set; }
        public string ProfileInfo { get; set; }

        // Навігаційні властивості без каскадного видалення
        public ICollection<Company> OwnedCompanies { get; set; }
    }
}

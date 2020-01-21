using System.Collections.Generic;

namespace DataAccessLayer.Models
{
    public class Employe
    {
        public int Id { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public string Name { get; set; }

        public string Position { get; set; }

        public string Address { get; set; }

        public string PhoneNumber { get; set; }

        public virtual ICollection<Collect> Collects { get; set; }
    }
}

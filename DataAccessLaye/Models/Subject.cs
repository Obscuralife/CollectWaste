using System.Collections.Generic;

namespace DataAccessLayer.Models
{
    /// <summary>
    /// Represents subject entity.
    /// </summary>
    public class Subject
    {        
        public int Id { get; set; }

        public string Name { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public string Address  { get; set; }

        public virtual ICollection<Collect> Collects { get; set; }
    }
}

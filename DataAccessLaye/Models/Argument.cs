using System.Collections.Generic;

namespace DataAccessLayer.Models
{
    public class Argument
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public virtual ICollection<Collect> Collects { get; set; }
    }
}

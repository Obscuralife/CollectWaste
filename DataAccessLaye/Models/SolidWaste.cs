using System.Collections.Generic;

namespace DataAccessLayer.Models
{
    /// <summary>
    /// Represents municipal solid waste.
    /// </summary>
    public class SolidWaste
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public virtual ICollection<Collect> Collects { get; set; }
    }
}

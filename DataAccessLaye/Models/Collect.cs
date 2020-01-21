using System;
using System.Collections.Generic;

namespace DataAccessLayer.Models
{
    /// <summary>
    /// Represents collect entity.
    /// </summary>
    public class Collect
    {
        /// <summary>
        /// Gets or sets Collect id.
        /// </summary>
        public int Id { get; set; }

        public int EmployeId { get; set; }

        public virtual Employe Employe { get; set; }

        /// <summary>
        /// Gets or sets date of collect.
        /// </summary>
        public DateTime DateTime { get; set; }

        /// <summary>
        /// Gets or sets subject of collect.
        /// </summary>
        public int SubjectId { get; set; }

        public virtual Subject Subject { get; set; }

        /// <summary>
        /// Gets or sets municipal solid waste Id
        /// </summary>
        public int SolidWasteId { get; set; }

        public virtual SolidWaste SolidWaste { get; set; }

        /// <summary>
        /// Gets or sets argument id.
        /// </summary>
        public int ArgumentId { get; set; }

        public virtual Argument Argument { get; set; }

        
    }
}

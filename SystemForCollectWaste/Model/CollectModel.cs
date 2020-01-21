using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemForCollectWaste.Model
{
    internal sealed class CollectModel : IModel
    {
        public int Id { get; set; }

        public int EmployeId { get; set; }

        public DateTime DateTime { get; set; }

        public int SubjectId { get; set; }

        public int SolidWasteId { get; set; }

        public int ArgumentId { get; set; }
    }
}

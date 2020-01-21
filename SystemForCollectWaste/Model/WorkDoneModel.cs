using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemForCollectWaste.Model
{
    public class WorkDoneModel : IModel
    {
        public DateTime Date { get; set; }
        public string Subject { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string SolidWaste { get; set; }
        public string Description { get; set; }
        public int Id { get; set; }
    }
}

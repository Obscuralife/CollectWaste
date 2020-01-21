using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemForCollectWaste.Model
{
    internal sealed class ArgumentModel : IModel
    {
        public int Id { get; set; }
        public string Description { get; set; }
    }
}

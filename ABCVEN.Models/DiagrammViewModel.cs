using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCVEN.Models
{
    public class DiagrammViewModel
    {
        public bool IncludeA { get; set; } = false;
        public bool IncludeB { get; set; } = false;
        public bool IncludeC { get; set; } = false;
        public bool IncludeV { get; set; } = false;
        public bool IncludeE { get; set; } = false;
        public bool IncludeN { get; set; } = false;

        public DiagrammUnitModel A { get; set; }
        public DiagrammUnitModel B { get; set; }
        public DiagrammUnitModel C { get; set; }
        public DiagrammUnitModel Total { get; set; }
    }

    public class DiagrammUnitModel
    {
        public double V { get; set; }
        public double E { get; set; }
        public double N { get; set; }
    }
}

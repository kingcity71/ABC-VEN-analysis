using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCVEN.Models
{
    public class ABCGroupModel
    {
        public List<ABCUnitModel> ABCModels { get; set; }
        public double PercentageOfTotalCount { get; set; }
    }
}

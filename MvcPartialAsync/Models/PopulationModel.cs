using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcPartialAsync.Models
{
    public class PopulationModel
    {
        public PopulationModel()
        {
            regions = new List<Region>();
        }
        public List<Region> regions { get; set; }
    }
    public class Region
    {
        public string RegionName { get; set; }
        public long Population { get; set; }
        public long Area { get; set; }
    }
}

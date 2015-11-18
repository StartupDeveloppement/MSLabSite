using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSLab.OpenData.Paris.Data
{
    public class Geometry : IGeometry
    {
        public string type { get; set; }
        public List<double> coordinates { get; set; }
    }
}

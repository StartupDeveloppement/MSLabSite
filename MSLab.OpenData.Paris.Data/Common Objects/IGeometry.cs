using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSLab.OpenData.Paris.Data
{
    public interface IGeometry
    {
        string type { get; set; }
        List<double> coordinates { get; set; }
    }
}

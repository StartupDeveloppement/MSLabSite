using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSLab.OpenData.Paris.Data
{
    public interface IGeoShape
    {
        string type { get; set; }
        List<List<List<double>>> coordinates { get; set; }
    }
}

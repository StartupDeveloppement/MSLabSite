using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSLab.OpenData.Paris.Data
{
    public class IRecord<T>
    {
        string datasetid { get; set; }
        string recordid { get; set; }
        T fields { get; set; }
        Geometry geometry { get; set; }
        string record_timestamp { get; set; }
    }
}

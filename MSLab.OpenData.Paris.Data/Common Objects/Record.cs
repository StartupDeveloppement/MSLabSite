using MSLab.OpenData.Paris.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSLab.OpenData.Paris.Data
{
    public class Record<T> : IRecord<T>
    {
        public string datasetid { get; set; }
        public string recordid { get; set; }
        public T fields { get; set; }
        public Geometry geometry { get; set; }
        public string record_timestamp { get; set; }
    }
}

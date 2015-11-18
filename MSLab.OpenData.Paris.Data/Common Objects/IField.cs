using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSLab.OpenData.Paris.Data
{
    public interface IField
    {
        string name { get; set; }
        string label { get; set; }
        string type { get; set; }
        List<Annotation> annotations { get; set; }
        string description { get; set; }
    }
}

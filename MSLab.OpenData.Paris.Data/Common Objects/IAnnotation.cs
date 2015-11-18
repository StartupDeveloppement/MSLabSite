using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSLab.OpenData.Paris.Data
{
    public interface IAnnotation
    {
        string name { get; set; }
        List<string> args { get; set; }
    }
}

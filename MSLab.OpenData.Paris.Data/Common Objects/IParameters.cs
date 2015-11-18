using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSLab.OpenData.Paris.Data
{
    public interface IParameters
    {
        string timezone { get; set; }
        int rows { get; set; }
        string format { get; set; }
        bool staged { get; set; }
    }
}

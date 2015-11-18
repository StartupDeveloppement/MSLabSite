using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSLab.OpenData.Paris.Data
{
    public class DatasetDetail : IParisOpenDatabase
    {
        public List<Dataset> datasets { get; set; }

        public int nhits { get; set; }

        public Parameters parameters { get; set; }
        
    }
}

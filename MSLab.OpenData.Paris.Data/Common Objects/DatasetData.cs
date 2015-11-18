using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSLab.OpenData.Paris.Data
{
    public class DatasetData : IParisOpenDatabase
    {
        public int nhits { get; set; }

        public Parameters parameters { get; set; }

        public List<Record> records { get; set; }
    }
}

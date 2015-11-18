using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSLab.OpenData.Paris.Data
{
    public class Field : IField
    {
        public List<Annotation> annotations { get; set; }

        public string description { get; set; }

        public string label { get; set; }

        public string name { get; set; }

        public string type { get; set; }
    }
}

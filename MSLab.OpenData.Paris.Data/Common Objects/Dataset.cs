using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSLab.OpenData.Paris.Data
{
    public class Dataset : IDataset
    {
        public List<object> attachments { get; set; }

        public string datasetid { get; set; }

        public List<object> features { get; set; }

        public List<Field> fields { get; set; }

        public bool has_records { get; set; }

        public Metas metas { get; set; }
    }
}

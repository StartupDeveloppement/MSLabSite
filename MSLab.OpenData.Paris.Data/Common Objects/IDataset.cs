using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSLab.OpenData.Paris.Data
{
    public interface IDataset
    {
        string datasetid { get; set; }
        Metas metas { get; set; }
        bool has_records { get; set; }
        List<object> features { get; set; }
        List<object> attachments { get; set; }
        List<Field> fields { get; set; }
    }
}

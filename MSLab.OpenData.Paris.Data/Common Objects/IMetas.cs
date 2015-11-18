using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSLab.OpenData.Paris.Data
{
    public interface IMetas
    {
        string publisher { get; set; }
        string domain { get; set; }
        string description { get; set; }
        string license { get; set; }
        int records_count { get; set; }
        string title { get; set; }
        string modified { get; set; }
        string visibility { get; set; }
        string language { get; set; }
        object theme { get; set; }
        string metadata_processed { get; set; }
        object keyword { get; set; }
        string data_processed { get; set; }
        string attributions { get; set; }
        string references { get; set; }
    }
}

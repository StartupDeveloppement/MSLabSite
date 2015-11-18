using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSLab.OpenData.Paris.Data
{
    public class Parameters : IParameters
    {
        public string format
        {
            get;
            set;
        }

        public int rows
        {
            get;
            set;
        }

        public bool staged
        {
            get;

            set;
        }

        public string timezone
        {
            get;

            set;
        }
    }
}

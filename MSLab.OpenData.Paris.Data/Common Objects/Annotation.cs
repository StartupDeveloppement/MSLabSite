using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSLab.OpenData.Paris.Data
{
    public class Annotation : IAnnotation
    {
        public List<string> args
        {
            get;

            set;
        }

        public string name
        {
            get;

            set;
        }
    }
}

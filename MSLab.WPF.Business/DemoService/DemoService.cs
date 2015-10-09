using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSLab.WPF.Business
{
    public class DemoService
    {
        public DateTime WhatTimeIsIt()
        {
            MSLabDemoService.MSLabServiceClient msLab = new MSLabDemoService.MSLabServiceClient();
            return msLab.WhatTimeIsIt();
        }
    }
}

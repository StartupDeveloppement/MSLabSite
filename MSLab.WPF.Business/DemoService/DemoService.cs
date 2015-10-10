using System;
using MSLab.WPF.Business.MSLabDemoService;

namespace MSLab.WPF.Business
{
    public class DemoService
    {
        public DateTime WhatTimeIsIt()
        {
            var msLab = new MSLabServiceClient();
            return msLab.WhatTimeIsIt();
        }
    }
}
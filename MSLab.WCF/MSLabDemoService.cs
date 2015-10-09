using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSLab.WCF
{
    public class MSLabDemoService : IMSLabService
    {
        DateTime IMSLabService.WhatTimeIsIt()
        {
            Console.WriteLine("Client asked for Time !");
            return DateTime.Now;
        }
    }
}

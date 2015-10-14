using System;

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
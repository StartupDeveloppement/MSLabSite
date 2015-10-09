using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace MSLab.WCF
{
    [ServiceContract]
    public interface IMSLabService
    {
        [OperationContract]
        DateTime WhatTimeIsIt();
    }
}

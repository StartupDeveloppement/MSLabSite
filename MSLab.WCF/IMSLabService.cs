using System;
using System.ServiceModel;

namespace MSLab.WCF
{
    [ServiceContract]
    public interface IMSLabService
    {
        [OperationContract]
        DateTime WhatTimeIsIt();
    }
}
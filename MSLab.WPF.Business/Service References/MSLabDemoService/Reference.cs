﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MSLab.WPF.Business.MSLabDemoService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MSLabDemoService.IMSLabService")]
    public interface IMSLabService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMSLabService/WhatTimeIsIt", ReplyAction="http://tempuri.org/IMSLabService/WhatTimeIsItResponse")]
        System.DateTime WhatTimeIsIt();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMSLabService/WhatTimeIsIt", ReplyAction="http://tempuri.org/IMSLabService/WhatTimeIsItResponse")]
        System.Threading.Tasks.Task<System.DateTime> WhatTimeIsItAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMSLabServiceChannel : MSLab.WPF.Business.MSLabDemoService.IMSLabService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MSLabServiceClient : System.ServiceModel.ClientBase<MSLab.WPF.Business.MSLabDemoService.IMSLabService>, MSLab.WPF.Business.MSLabDemoService.IMSLabService {
        
        public MSLabServiceClient() {
        }
        
        public MSLabServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MSLabServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MSLabServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MSLabServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.DateTime WhatTimeIsIt() {
            return base.Channel.WhatTimeIsIt();
        }
        
        public System.Threading.Tasks.Task<System.DateTime> WhatTimeIsItAsync() {
            return base.Channel.WhatTimeIsItAsync();
        }
    }
}

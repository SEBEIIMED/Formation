﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FormationIHM.FormationServicesReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="FormationServicesReference.IFormationServices")]
    public interface IFormationServices {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFormationServices/AddFormateur", ReplyAction="http://tempuri.org/IFormationServices/AddFormateurResponse")]
        void AddFormateur();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFormationServices/AddFormateur", ReplyAction="http://tempuri.org/IFormationServices/AddFormateurResponse")]
        System.Threading.Tasks.Task AddFormateurAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IFormationServicesChannel : FormationIHM.FormationServicesReference.IFormationServices, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class FormationServicesClient : System.ServiceModel.ClientBase<FormationIHM.FormationServicesReference.IFormationServices>, FormationIHM.FormationServicesReference.IFormationServices {
        
        public FormationServicesClient() {
        }
        
        public FormationServicesClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public FormationServicesClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FormationServicesClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FormationServicesClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void AddFormateur() {
            base.Channel.AddFormateur();
        }
        
        public System.Threading.Tasks.Task AddFormateurAsync() {
            return base.Channel.AddFormateurAsync();
        }
    }
}

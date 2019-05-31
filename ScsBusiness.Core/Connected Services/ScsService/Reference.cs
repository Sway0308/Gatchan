//------------------------------------------------------------------------------
// <自動產生>
//     這段程式碼是由工具產生的。
//     //
//     變更此檔案可能會導致不正確的行為，而且若已重新產生
//     程式碼，則會遺失變更。
// </自動產生>
//------------------------------------------------------------------------------

namespace ScsService
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://scsservices.net/", ConfigurationName="ScsService.SCSServiceSoap")]
    public interface SCSServiceSoap
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://scsservices.net/HelloWorld", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<string> HelloWorldAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://scsservices.net/SystemObjectRun", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowRollbackOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowRollbackInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowRejectOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowRejectInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowApproveOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowApproveInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TWsBaseOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TWsBaseInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TUpdateFormStatusInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TBaseOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TKeyCollectionItem))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TCollectionItem))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TBaseInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterItem[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TUpdateGridColumn[]))]
        System.Threading.Tasks.Task<ScsService.TSystemObjectRunResult> SystemObjectRunAsync(ScsService.TSystemObjectRunArgs args);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://scsservices.net/SystemObjectJson", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowRollbackOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowRollbackInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowRejectOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowRejectInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowApproveOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowApproveInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TWsBaseOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TWsBaseInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TUpdateFormStatusInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TBaseOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TKeyCollectionItem))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TCollectionItem))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TBaseInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterItem[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TUpdateGridColumn[]))]
        System.Threading.Tasks.Task<string> SystemObjectJsonAsync(string sessionGuid, ScsService.ESystemObjectAction action, string json);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://scsservices.net/BusinessObjectRun", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowRollbackOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowRollbackInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowRejectOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowRejectInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowApproveOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowApproveInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TWsBaseOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TWsBaseInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TUpdateFormStatusInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TBaseOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TKeyCollectionItem))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TCollectionItem))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TBaseInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterItem[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TUpdateGridColumn[]))]
        System.Threading.Tasks.Task<ScsService.TBusinessObjectRunResult> BusinessObjectRunAsync(ScsService.TBusinessObjectRunArgs args);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://scsservices.net/BusinessObjectJson", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowRollbackOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowRollbackInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowRejectOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowRejectInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowApproveOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowApproveInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TWsBaseOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TWsBaseInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TUpdateFormStatusInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TBaseOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TKeyCollectionItem))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TCollectionItem))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TBaseInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterItem[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TUpdateGridColumn[]))]
        System.Threading.Tasks.Task<string> BusinessObjectJsonAsync(string sessionGuid, string progID, ScsService.EBusinessObjectAction action, string json);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://scsservices.net/GetCompanyItems", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowRollbackOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowRollbackInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowRejectOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowRejectInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowApproveOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowApproveInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TWsBaseOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TWsBaseInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TUpdateFormStatusInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TBaseOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TKeyCollectionItem))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TCollectionItem))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TBaseInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterItem[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TUpdateGridColumn[]))]
        System.Threading.Tasks.Task<ScsService.TWsGetCompanyItemsOutputResult> GetCompanyItemsAsync(ScsService.TWsGetCompanyItemsInputArgs inputArgs);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://scsservices.net/Login", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowRollbackOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowRollbackInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowRejectOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowRejectInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowApproveOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowApproveInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TWsBaseOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TWsBaseInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TUpdateFormStatusInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TBaseOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TKeyCollectionItem))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TCollectionItem))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TBaseInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterItem[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TUpdateGridColumn[]))]
        System.Threading.Tasks.Task<ScsService.TWsLoginOutputResult> LoginAsync(ScsService.TWsLoginInputArgs inputArgs);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://scsservices.net/Logout", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowRollbackOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowRollbackInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowRejectOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowRejectInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowApproveOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowApproveInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TWsBaseOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TWsBaseInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TUpdateFormStatusInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TBaseOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TKeyCollectionItem))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TCollectionItem))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TBaseInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterItem[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TUpdateGridColumn[]))]
        System.Threading.Tasks.Task<ScsService.TWsLogoutOutputResult> LogoutAsync(ScsService.TWsLogoutInputArgs inputArgs);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://scsservices.net/CreateSessionGuid", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowRollbackOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowRollbackInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowRejectOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowRejectInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowApproveOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowApproveInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TWsBaseOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TWsBaseInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TUpdateFormStatusInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TBaseOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TKeyCollectionItem))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TCollectionItem))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TBaseInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterItem[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TUpdateGridColumn[]))]
        System.Threading.Tasks.Task<System.Guid> CreateSessionGuidAsync(string companyID, string userID, string languageID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://scsservices.net/GetCompanyInfo", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowRollbackOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowRollbackInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowRejectOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowRejectInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowApproveOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowApproveInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TWsBaseOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TWsBaseInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TUpdateFormStatusInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TBaseOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TKeyCollectionItem))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TCollectionItem))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TBaseInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterItem[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TUpdateGridColumn[]))]
        System.Threading.Tasks.Task<ScsService.TWsGetCompanyInfoOutputResult> GetCompanyInfoAsync(ScsService.TWsGetCompanyInfoInputArgs inputArgs);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://scsservices.net/GetMarqueeMessage", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowRollbackOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowRollbackInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowRejectOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowRejectInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowApproveOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowApproveInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TWsBaseOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TWsBaseInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TUpdateFormStatusInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TBaseOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TKeyCollectionItem))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TCollectionItem))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TBaseInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterItem[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TUpdateGridColumn[]))]
        System.Threading.Tasks.Task<ScsService.TWsGetMarqueeMessageOutputResult> GetMarqueeMessageAsync(ScsService.TWsGetMarqueeMessageInputArgs inputArgs);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://scsservices.net/BOFind", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowRollbackOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowRollbackInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowRejectOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowRejectInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowApproveOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowApproveInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TWsBaseOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TWsBaseInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TUpdateFormStatusInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TBaseOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TKeyCollectionItem))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TCollectionItem))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TBaseInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterItem[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TUpdateGridColumn[]))]
        System.Threading.Tasks.Task<ScsService.TWsBOFindOutputResult> BOFindAsync(ScsService.TWsBOFindInputArgs inputArgs);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://scsservices.net/BOMove", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowRollbackOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowRollbackInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowRejectOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowRejectInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowApproveOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowApproveInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TWsBaseOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TWsBaseInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TUpdateFormStatusInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TBaseOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TKeyCollectionItem))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TCollectionItem))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TBaseInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterItem[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TUpdateGridColumn[]))]
        System.Threading.Tasks.Task<ScsService.TWsBOMoveOutputResult> BOMoveAsync(ScsService.TWsBOMoveInputArgs inputArgs);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://scsservices.net/BOAdd", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowRollbackOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowRollbackInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowRejectOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowRejectInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowApproveOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowApproveInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TWsBaseOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TWsBaseInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TUpdateFormStatusInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TBaseOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TKeyCollectionItem))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TCollectionItem))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TBaseInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterItem[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TUpdateGridColumn[]))]
        System.Threading.Tasks.Task<ScsService.TWsBOAddOutputResult> BOAddAsync(ScsService.TWsBOAddInputArgs inputArgs);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://scsservices.net/BODelete", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowRollbackOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowRollbackInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowRejectOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowRejectInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowApproveOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowApproveInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TWsBaseOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TWsBaseInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TUpdateFormStatusInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TBaseOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TKeyCollectionItem))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TCollectionItem))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TBaseInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterItem[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TUpdateGridColumn[]))]
        System.Threading.Tasks.Task<ScsService.TWsBODeleteOutputResult> BODeleteAsync(ScsService.TWsBODeleteInputArgs inputArgs);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://scsservices.net/BOUpdateFormStatus", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowRollbackOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowRollbackInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowRejectOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowRejectInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowApproveOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowApproveInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TWsBaseOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TWsBaseInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TUpdateFormStatusInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TBaseOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TKeyCollectionItem))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TCollectionItem))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TBaseInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterItem[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TUpdateGridColumn[]))]
        System.Threading.Tasks.Task<ScsService.TWsBOUpdateFormStatusOutputResult> BOUpdateFormStatusAsync(ScsService.TWsBOUpdateFormStatusInputArgs inputArgs);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://scsservices.net/BOExecFunc", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowRollbackOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowRollbackInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowRejectOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowRejectInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowApproveOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowApproveInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TWsBaseOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TWsBaseInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TUpdateFormStatusInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TBaseOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TKeyCollectionItem))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TCollectionItem))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TBaseInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterItem[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TUpdateGridColumn[]))]
        System.Threading.Tasks.Task<ScsService.TWsBOExecFuncOutputResult> BOExecFuncAsync(ScsService.TWsBOExecFuncInputArgs inputArgs);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://scsservices.net/BOImport", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowRollbackOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowRollbackInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowRejectOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowRejectInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowApproveOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowApproveInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TWsBaseOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TWsBaseInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TUpdateFormStatusInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TBaseOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TKeyCollectionItem))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TCollectionItem))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TBaseInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterItem[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TUpdateGridColumn[]))]
        System.Threading.Tasks.Task<ScsService.TWsBOImportOutputResult> BOImportAsync(ScsService.TWsBOImportInputArgs inputArgs);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://scsservices.net/BOExpData", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowRollbackOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowRollbackInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowRejectOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowRejectInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowApproveOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowApproveInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TWsBaseOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TWsBaseInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TUpdateFormStatusInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TBaseOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TKeyCollectionItem))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TCollectionItem))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TBaseInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterItem[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TUpdateGridColumn[]))]
        System.Threading.Tasks.Task<string> BOExpDataAsync(string companyID, string funcID, string filter);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://scsservices.net/BOImpData", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowRollbackOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowRollbackInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowRejectOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowRejectInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowApproveOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowApproveInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TWsBaseOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TWsBaseInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TUpdateFormStatusInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TBaseOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TKeyCollectionItem))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TCollectionItem))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TBaseInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterItem[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TUpdateGridColumn[]))]
        System.Threading.Tasks.Task<string> BOImpDataAsync(string companyID, string funcID, string xmlData);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://scsservices.net/MBOSave", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowRollbackOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowRollbackInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowRejectOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowRejectInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowApproveOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowApproveInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TWsBaseOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TWsBaseInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TUpdateFormStatusInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TBaseOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TKeyCollectionItem))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TCollectionItem))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TBaseInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterItem[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TUpdateGridColumn[]))]
        System.Threading.Tasks.Task<ScsService.TWsBOMobileFuncOutputResult> MBOSaveAsync(ScsService.TWsBOMobileFuncInputArgs inputArgs);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://scsservices.net/FlowStart", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowRollbackOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowRollbackInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowRejectOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowRejectInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowApproveOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowApproveInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TWsBaseOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TWsBaseInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TUpdateFormStatusInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TBaseOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TKeyCollectionItem))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TCollectionItem))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TBaseInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterItem[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TUpdateGridColumn[]))]
        System.Threading.Tasks.Task<ScsService.TWsFlowStartOutputResult> FlowStartAsync(ScsService.TWsFlowStartInputArgs inputArgs);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://scsservices.net/FlowApprove", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowRollbackOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowRollbackInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowRejectOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowRejectInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowApproveOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowApproveInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TWsBaseOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TWsBaseInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TUpdateFormStatusInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TBaseOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TKeyCollectionItem))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TCollectionItem))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TBaseInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterItem[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TUpdateGridColumn[]))]
        System.Threading.Tasks.Task<ScsService.TWsFlowApproveOutputResult> FlowApproveAsync(ScsService.TWsFlowApproveInputArgs inputArgs);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://scsservices.net/FlowReject", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowRollbackOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowRollbackInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowRejectOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowRejectInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowApproveOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowApproveInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TWsBaseOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TWsBaseInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TUpdateFormStatusInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TBaseOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TKeyCollectionItem))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TCollectionItem))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TBaseInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterItem[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TUpdateGridColumn[]))]
        System.Threading.Tasks.Task<ScsService.TWsFlowRejectOutputResult> FlowRejectAsync(ScsService.TWsFlowRejectInputArgs inputArgs);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://scsservices.net/FlowRollback", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowRollbackOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowRollbackInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowRejectOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowRejectInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowApproveOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TFlowApproveInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TWsBaseOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TWsBaseInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TUpdateFormStatusInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TBaseOutputResult))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TKeyCollectionItem))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TCollectionItem))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TBaseInputArgs))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(FilterItem[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(TUpdateGridColumn[]))]
        System.Threading.Tasks.Task<ScsService.TWsFlowRollbackOutputResult> FlowRollbackAsync(ScsService.TWsFlowRollbackInputArgs inputArgs);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://scsservices.net/")]
    public partial class TSystemObjectRunArgs
    {
        
        private System.Guid sessionGuidField;
        
        private ESystemObjectAction actionField;
        
        private ETransmissionFormat formatField;
        
        private byte[] bytesField;
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public System.Guid SessionGuid
        {
            get
            {
                return this.sessionGuidField;
            }
            set
            {
                this.sessionGuidField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public ESystemObjectAction Action
        {
            get
            {
                return this.actionField;
            }
            set
            {
                this.actionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public ETransmissionFormat Format
        {
            get
            {
                return this.formatField;
            }
            set
            {
                this.formatField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary", Order=3)]
        public byte[] Bytes
        {
            get
            {
                return this.bytesField;
            }
            set
            {
                this.bytesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://scsservices.net/")]
    public enum ESystemObjectAction
    {
        
        /// <remarks/>
        GetLoginInfo,
        
        /// <remarks/>
        Login,
        
        /// <remarks/>
        Logout,
        
        /// <remarks/>
        GetApplicationSettings,
        
        /// <remarks/>
        SaveApplicationSettings,
        
        /// <remarks/>
        GetCompanyItems,
        
        /// <remarks/>
        GetRoles,
        
        /// <remarks/>
        GetPermissionSettings,
        
        /// <remarks/>
        SavePermissionSettings,
        
        /// <remarks/>
        GetProgramRunSettings,
        
        /// <remarks/>
        GetUserProgramSettings,
        
        /// <remarks/>
        GetCompanyInfo,
        
        /// <remarks/>
        GetFlowActivityUsers,
        
        /// <remarks/>
        GetFlowHistory,
        
        /// <remarks/>
        GetUserFlowWait,
        
        /// <remarks/>
        GetUserFlowApprove,
        
        /// <remarks/>
        GetUserFlowStart,
        
        /// <remarks/>
        FlowApprove,
        
        /// <remarks/>
        FlowReject,
        
        /// <remarks/>
        FlowRollback,
        
        /// <remarks/>
        FlowAdvise,
        
        /// <remarks/>
        FlowWaitAdd,
        
        /// <remarks/>
        GetFlowSettings,
        
        /// <remarks/>
        SaveFlowSettings,
        
        /// <remarks/>
        GetFlowDefine,
        
        /// <remarks/>
        SaveFlowDefine,
        
        /// <remarks/>
        DeleteFlowDefine,
        
        /// <remarks/>
        GetFlowFormSettings,
        
        /// <remarks/>
        SaveFlowFormSettings,
        
        /// <remarks/>
        FlowSimulate,
        
        /// <remarks/>
        GetProgramUserDefine,
        
        /// <remarks/>
        SaveProgramUserDefine,
        
        /// <remarks/>
        GetMarqueeMessage,
        
        /// <remarks/>
        GetRegister,
        
        /// <remarks/>
        Register,
        
        /// <remarks/>
        Unregister,
        
        /// <remarks/>
        CreateCompany,
        
        /// <remarks/>
        PasswordForget,
        
        /// <remarks/>
        UserUnlock,
        
        /// <remarks/>
        UserUnlockValidate,
        
        /// <remarks/>
        GetLoginLogs,
        
        /// <remarks/>
        GetFlowDepartmentTree,
        
        /// <remarks/>
        GetFlowRoles,
        
        /// <remarks/>
        GetScheduleSettings,
        
        /// <remarks/>
        SendSchedule,
        
        /// <remarks/>
        GetSchedules,
        
        /// <remarks/>
        SaveSchedule,
        
        /// <remarks/>
        DeleteSchedule,
        
        /// <remarks/>
        EnableSchedule,
        
        /// <remarks/>
        GetScheduleHistory,
        
        /// <remarks/>
        GetMailTasks,
        
        /// <remarks/>
        ResetMailTask,
        
        /// <remarks/>
        ResetMailTasks,
        
        /// <remarks/>
        DeleteMailTasks,
        
        /// <remarks/>
        SaveLanguageFile,
        
        /// <remarks/>
        ExecFunc,
        
        /// <remarks/>
        DownloadFile,
        
        /// <remarks/>
        UploadFile,
        
        /// <remarks/>
        DeleteFile,
        
        /// <remarks/>
        GetReportTemplates,
        
        /// <remarks/>
        SaveFormDefine,
        
        /// <remarks/>
        GetDefine,
        
        /// <remarks/>
        ADAuth,
        
        /// <remarks/>
        ExecuteDataTable,
        
        /// <remarks/>
        ExecuteNonQuery,
        
        /// <remarks/>
        GetCompanySettings,
        
        /// <remarks/>
        SaveCompanySettings,
        
        /// <remarks/>
        FlowJump,
        
        /// <remarks/>
        GetFlowInstance,
        
        /// <remarks/>
        FlowWaitNotice,
        
        /// <remarks/>
        CreateDatabase,
        
        /// <remarks/>
        CreateTable,
        
        /// <remarks/>
        OnlineRegister,
        
        /// <remarks/>
        GetLanguageFile,
        
        /// <remarks/>
        GetExecLogs,
        
        /// <remarks/>
        GetExecDayLogs,
        
        /// <remarks/>
        GetExecActionLogs,
        
        /// <remarks/>
        UploadImportFile,
        
        /// <remarks/>
        ImportExcel,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://scsservices.net/")]
    public enum ETransmissionFormat
    {
        
        /// <remarks/>
        GZip,
        
        /// <remarks/>
        AES256,
        
        /// <remarks/>
        Xml,
        
        /// <remarks/>
        Json,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TWsFlowRollbackOutputResult))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://scsservices.net/")]
    public partial class TFlowRollbackOutputResult
    {
        
        private EFormStatus formStatusField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public EFormStatus FormStatus
        {
            get
            {
                return this.formStatusField;
            }
            set
            {
                this.formStatusField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://scsservices.net/")]
    public enum EFormStatus
    {
        
        /// <remarks/>
        Draft,
        
        /// <remarks/>
        Approved,
        
        /// <remarks/>
        Processing,
        
        /// <remarks/>
        Invalid,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://scsservices.net/")]
    public partial class TWsFlowRollbackOutputResult : TFlowRollbackOutputResult
    {
        
        private TWsException exceptionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public TWsException Exception
        {
            get
            {
                return this.exceptionField;
            }
            set
            {
                this.exceptionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://scsservices.net/")]
    public partial class TWsException
    {
        
        private string messageField;
        
        private string stackTraceField;
        
        private bool isHandleField;
        
        public TWsException()
        {
            this.messageField = "";
            this.stackTraceField = "";
            this.isHandleField = false;
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string Message
        {
            get
            {
                return this.messageField;
            }
            set
            {
                this.messageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string StackTrace
        {
            get
            {
                return this.stackTraceField;
            }
            set
            {
                this.stackTraceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool IsHandle
        {
            get
            {
                return this.isHandleField;
            }
            set
            {
                this.isHandleField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TWsFlowRollbackInputArgs))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://scsservices.net/")]
    public partial class TFlowRollbackInputArgs
    {
        
        private System.Guid flowInstanceIDField;
        
        private string activityIDField;
        
        private string approverIDField;
        
        private string opinionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public System.Guid FlowInstanceID
        {
            get
            {
                return this.flowInstanceIDField;
            }
            set
            {
                this.flowInstanceIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string ActivityID
        {
            get
            {
                return this.activityIDField;
            }
            set
            {
                this.activityIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string ApproverID
        {
            get
            {
                return this.approverIDField;
            }
            set
            {
                this.approverIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string Opinion
        {
            get
            {
                return this.opinionField;
            }
            set
            {
                this.opinionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://scsservices.net/")]
    public partial class TWsFlowRollbackInputArgs : TFlowRollbackInputArgs
    {
        
        private System.Guid sessionGuidField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public System.Guid SessionGuid
        {
            get
            {
                return this.sessionGuidField;
            }
            set
            {
                this.sessionGuidField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TWsFlowRejectOutputResult))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://scsservices.net/")]
    public partial class TFlowRejectOutputResult
    {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://scsservices.net/")]
    public partial class TWsFlowRejectOutputResult : TFlowRejectOutputResult
    {
        
        private TWsException exceptionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public TWsException Exception
        {
            get
            {
                return this.exceptionField;
            }
            set
            {
                this.exceptionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TWsFlowRejectInputArgs))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://scsservices.net/")]
    public partial class TFlowRejectInputArgs
    {
        
        private System.Guid flowWaitIDField;
        
        private string opinionField;
        
        private Parameter[] flowFieldsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public System.Guid FlowWaitID
        {
            get
            {
                return this.flowWaitIDField;
            }
            set
            {
                this.flowWaitIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Opinion
        {
            get
            {
                return this.opinionField;
            }
            set
            {
                this.opinionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=2)]
        public Parameter[] FlowFields
        {
            get
            {
                return this.flowFieldsField;
            }
            set
            {
                this.flowFieldsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://scsservices.net/")]
    public partial class Parameter : TKeyCollectionItem
    {
        
        private string nameField;
        
        private object valueField;
        
        private EParameterDataType dataTypeField;
        
        private string xmlField;
        
        public Parameter()
        {
            this.dataTypeField = EParameterDataType.NotSet;
            this.xmlField = "";
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public object Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        [System.ComponentModel.DefaultValueAttribute(EParameterDataType.NotSet)]
        public EParameterDataType DataType
        {
            get
            {
                return this.dataTypeField;
            }
            set
            {
                this.dataTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string Xml
        {
            get
            {
                return this.xmlField;
            }
            set
            {
                this.xmlField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://scsservices.net/")]
    public enum EParameterDataType
    {
        
        /// <remarks/>
        NotSet,
        
        /// <remarks/>
        DataTable,
        
        /// <remarks/>
        FilterItemCollection,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ErrorCategory))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Parameter))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TUpdateGridColumn))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TUserDepartment))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LoginLanguage))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CompanyItem))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://scsservices.net/")]
    public abstract partial class TKeyCollectionItem
    {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://scsservices.net/")]
    public partial class ErrorCategory : TKeyCollectionItem
    {
        
        private string nameField;
        
        private ErrorItem[] itemsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=1)]
        public ErrorItem[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://scsservices.net/")]
    public partial class ErrorItem : TCollectionItem
    {
        
        private EErrorType errorTypeField;
        
        private string messageField;
        
        private int rowIndexField;
        
        private string fieldNameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public EErrorType ErrorType
        {
            get
            {
                return this.errorTypeField;
            }
            set
            {
                this.errorTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Message
        {
            get
            {
                return this.messageField;
            }
            set
            {
                this.messageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public int RowIndex
        {
            get
            {
                return this.rowIndexField;
            }
            set
            {
                this.rowIndexField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string FieldName
        {
            get
            {
                return this.fieldNameField;
            }
            set
            {
                this.fieldNameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://scsservices.net/")]
    public enum EErrorType
    {
        
        /// <remarks/>
        Warning,
        
        /// <remarks/>
        Error,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ErrorItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TUpdateItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TUpdateField))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TUpdateFieldControl))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TUpdateGridControl))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TUpdateTable))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TUpdateTabPageControl))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FilterItem))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TMarqueeMessageItem))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://scsservices.net/")]
    public partial class TCollectionItem
    {
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TUpdateField))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TUpdateFieldControl))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TUpdateGridControl))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TUpdateTable))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TUpdateTabPageControl))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://scsservices.net/")]
    public abstract partial class TUpdateItem : TCollectionItem
    {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://scsservices.net/")]
    public partial class TUpdateField : TUpdateItem
    {
        
        private string fieldNameField;
        
        private object fieldValueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string FieldName
        {
            get
            {
                return this.fieldNameField;
            }
            set
            {
                this.fieldNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public object FieldValue
        {
            get
            {
                return this.fieldValueField;
            }
            set
            {
                this.fieldValueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://scsservices.net/")]
    public partial class TUpdateFieldControl : TUpdateItem
    {
        
        private string fieldNameField;
        
        private ENotSetBoolean readOnlyField;
        
        private ENotSetBoolean visibleField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string FieldName
        {
            get
            {
                return this.fieldNameField;
            }
            set
            {
                this.fieldNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public ENotSetBoolean ReadOnly
        {
            get
            {
                return this.readOnlyField;
            }
            set
            {
                this.readOnlyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public ENotSetBoolean Visible
        {
            get
            {
                return this.visibleField;
            }
            set
            {
                this.visibleField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://scsservices.net/")]
    public enum ENotSetBoolean
    {
        
        /// <remarks/>
        NotSet,
        
        /// <remarks/>
        True,
        
        /// <remarks/>
        False,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://scsservices.net/")]
    public partial class TUpdateGridControl : TUpdateItem
    {
        
        private string tableNameField;
        
        private ENotSetBoolean readOnlyField;
        
        private TUpdateGridColumn[] columnsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string TableName
        {
            get
            {
                return this.tableNameField;
            }
            set
            {
                this.tableNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public ENotSetBoolean ReadOnly
        {
            get
            {
                return this.readOnlyField;
            }
            set
            {
                this.readOnlyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=2)]
        public TUpdateGridColumn[] Columns
        {
            get
            {
                return this.columnsField;
            }
            set
            {
                this.columnsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://scsservices.net/")]
    public partial class TUpdateGridColumn : TKeyCollectionItem
    {
        
        private string fieldNameField;
        
        private ENotSetBoolean readOnlyField;
        
        private ENotSetBoolean visibleField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string FieldName
        {
            get
            {
                return this.fieldNameField;
            }
            set
            {
                this.fieldNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public ENotSetBoolean ReadOnly
        {
            get
            {
                return this.readOnlyField;
            }
            set
            {
                this.readOnlyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public ENotSetBoolean Visible
        {
            get
            {
                return this.visibleField;
            }
            set
            {
                this.visibleField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://scsservices.net/")]
    public partial class TUpdateTable : TUpdateItem
    {
        
        private string tableNameField;
        
        private TUpdateTableDataTable dataTableField;
        
        private ETableUpdateMode updateModeField;
        
        private ENotSetBoolean readOnlyField;
        
        private ENotSetBoolean allowAddField;
        
        private ENotSetBoolean allowDeleteField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string TableName
        {
            get
            {
                return this.tableNameField;
            }
            set
            {
                this.tableNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public TUpdateTableDataTable DataTable
        {
            get
            {
                return this.dataTableField;
            }
            set
            {
                this.dataTableField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public ETableUpdateMode UpdateMode
        {
            get
            {
                return this.updateModeField;
            }
            set
            {
                this.updateModeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public ENotSetBoolean ReadOnly
        {
            get
            {
                return this.readOnlyField;
            }
            set
            {
                this.readOnlyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public ENotSetBoolean AllowAdd
        {
            get
            {
                return this.allowAddField;
            }
            set
            {
                this.allowAddField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public ENotSetBoolean AllowDelete
        {
            get
            {
                return this.allowDeleteField;
            }
            set
            {
                this.allowDeleteField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://scsservices.net/")]
    public partial class TUpdateTableDataTable
    {
        
        private System.Xml.Linq.XElement[] anyField;
        
        private System.Xml.Linq.XElement any1Field;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Namespace="http://www.w3.org/2001/XMLSchema", Order=0)]
        public System.Xml.Linq.XElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Namespace="urn:schemas-microsoft-com:xml-diffgram-v1", Order=1)]
        public System.Xml.Linq.XElement Any1
        {
            get
            {
                return this.any1Field;
            }
            set
            {
                this.any1Field = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://scsservices.net/")]
    public enum ETableUpdateMode
    {
        
        /// <remarks/>
        None,
        
        /// <remarks/>
        Replace,
        
        /// <remarks/>
        AddRows,
        
        /// <remarks/>
        DeleteRowsThenAddRows,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://scsservices.net/")]
    public partial class TUpdateTabPageControl : TUpdateItem
    {
        
        private string tabPageNameField;
        
        private ENotSetBoolean visibleField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string TabPageName
        {
            get
            {
                return this.tabPageNameField;
            }
            set
            {
                this.tabPageNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public ENotSetBoolean Visible
        {
            get
            {
                return this.visibleField;
            }
            set
            {
                this.visibleField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://scsservices.net/")]
    public partial class FilterItem : TCollectionItem
    {
        
        private string fieldNameField;
        
        private string filterValueField;
        
        private EComparisonOperator comparisonOperatorField;
        
        private ECombineOperator combineOperatorField;
        
        private int groupNumberField;
        
        public FilterItem()
        {
            this.combineOperatorField = ECombineOperator.And;
            this.groupNumberField = -1;
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FieldName
        {
            get
            {
                return this.fieldNameField;
            }
            set
            {
                this.fieldNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FilterValue
        {
            get
            {
                return this.filterValueField;
            }
            set
            {
                this.filterValueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public EComparisonOperator ComparisonOperator
        {
            get
            {
                return this.comparisonOperatorField;
            }
            set
            {
                this.comparisonOperatorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(ECombineOperator.And)]
        public ECombineOperator CombineOperator
        {
            get
            {
                return this.combineOperatorField;
            }
            set
            {
                this.combineOperatorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(-1)]
        public int GroupNumber
        {
            get
            {
                return this.groupNumberField;
            }
            set
            {
                this.groupNumberField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://scsservices.net/")]
    public enum EComparisonOperator
    {
        
        /// <remarks/>
        Equal,
        
        /// <remarks/>
        NotEqual,
        
        /// <remarks/>
        Less,
        
        /// <remarks/>
        LessOrEqual,
        
        /// <remarks/>
        Greater,
        
        /// <remarks/>
        GreaterOrEqual,
        
        /// <remarks/>
        Like,
        
        /// <remarks/>
        Between,
        
        /// <remarks/>
        In,
        
        /// <remarks/>
        NotIn,
        
        /// <remarks/>
        Variable,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://scsservices.net/")]
    public enum ECombineOperator
    {
        
        /// <remarks/>
        And,
        
        /// <remarks/>
        Or,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://scsservices.net/")]
    public partial class TMarqueeMessageItem : TCollectionItem
    {
        
        private string messageField;
        
        private string urlField;
        
        private string fontColorField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Message
        {
            get
            {
                return this.messageField;
            }
            set
            {
                this.messageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Url
        {
            get
            {
                return this.urlField;
            }
            set
            {
                this.urlField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string FontColor
        {
            get
            {
                return this.fontColorField;
            }
            set
            {
                this.fontColorField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://scsservices.net/")]
    public partial class TUserDepartment : TKeyCollectionItem
    {
        
        private string idField;
        
        private string viewIDField;
        
        private string nameField;
        
        private string levelField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string ViewID
        {
            get
            {
                return this.viewIDField;
            }
            set
            {
                this.viewIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string Level
        {
            get
            {
                return this.levelField;
            }
            set
            {
                this.levelField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://scsservices.net/")]
    public partial class LoginLanguage : TKeyCollectionItem
    {
        
        private string languageCodeField;
        
        private string displayNameField;
        
        private string noteField;
        
        private bool enabledField;
        
        public LoginLanguage()
        {
            this.noteField = "";
            this.enabledField = true;
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LanguageCode
        {
            get
            {
                return this.languageCodeField;
            }
            set
            {
                this.languageCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DisplayName
        {
            get
            {
                return this.displayNameField;
            }
            set
            {
                this.displayNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string Note
        {
            get
            {
                return this.noteField;
            }
            set
            {
                this.noteField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool Enabled
        {
            get
            {
                return this.enabledField;
            }
            set
            {
                this.enabledField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://scsservices.net/")]
    public partial class CompanyItem : TKeyCollectionItem
    {
        
        private EDefaultBoolean winMenuExpandAllField;
        
        private EDefaultBoolean webMenuExpandAllField;
        
        private LoginLanguage[] loginLanguagesField;
        
        private string idField;
        
        private string groupIDField;
        
        private string companyIDField;
        
        private string databaseIDField;
        
        private string displayNameField;
        
        private string websiteField;
        
        private string redirectUrlField;
        
        private string customizedIDField;
        
        private bool isDemoField;
        
        private bool isLockField;
        
        private string lockMessageField;
        
        private EDefaultFlowApprovePageStyle flowApprovePageStyleField;
        
        private EDefaultBoolean flowRevokeField;
        
        private EDefaultBoolean flowMailUrlAutoLoginField;
        
        private bool enabledField;
        
        private bool cloudEnabledField;
        
        private string noteField;
        
        public CompanyItem()
        {
            this.winMenuExpandAllField = EDefaultBoolean.Default;
            this.webMenuExpandAllField = EDefaultBoolean.Default;
            this.groupIDField = "";
            this.websiteField = "";
            this.redirectUrlField = "";
            this.customizedIDField = "";
            this.isDemoField = false;
            this.isLockField = false;
            this.lockMessageField = "";
            this.flowApprovePageStyleField = EDefaultFlowApprovePageStyle.Default;
            this.flowRevokeField = EDefaultBoolean.Default;
            this.flowMailUrlAutoLoginField = EDefaultBoolean.Default;
            this.enabledField = true;
            this.cloudEnabledField = false;
            this.noteField = "";
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        [System.ComponentModel.DefaultValueAttribute(EDefaultBoolean.Default)]
        public EDefaultBoolean WinMenuExpandAll
        {
            get
            {
                return this.winMenuExpandAllField;
            }
            set
            {
                this.winMenuExpandAllField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        [System.ComponentModel.DefaultValueAttribute(EDefaultBoolean.Default)]
        public EDefaultBoolean WebMenuExpandAll
        {
            get
            {
                return this.webMenuExpandAllField;
            }
            set
            {
                this.webMenuExpandAllField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=2)]
        public LoginLanguage[] LoginLanguages
        {
            get
            {
                return this.loginLanguagesField;
            }
            set
            {
                this.loginLanguagesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string GroupID
        {
            get
            {
                return this.groupIDField;
            }
            set
            {
                this.groupIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CompanyID
        {
            get
            {
                return this.companyIDField;
            }
            set
            {
                this.companyIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DatabaseID
        {
            get
            {
                return this.databaseIDField;
            }
            set
            {
                this.databaseIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DisplayName
        {
            get
            {
                return this.displayNameField;
            }
            set
            {
                this.displayNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string Website
        {
            get
            {
                return this.websiteField;
            }
            set
            {
                this.websiteField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string RedirectUrl
        {
            get
            {
                return this.redirectUrlField;
            }
            set
            {
                this.redirectUrlField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string CustomizedID
        {
            get
            {
                return this.customizedIDField;
            }
            set
            {
                this.customizedIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool IsDemo
        {
            get
            {
                return this.isDemoField;
            }
            set
            {
                this.isDemoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool IsLock
        {
            get
            {
                return this.isLockField;
            }
            set
            {
                this.isLockField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string LockMessage
        {
            get
            {
                return this.lockMessageField;
            }
            set
            {
                this.lockMessageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(EDefaultFlowApprovePageStyle.Default)]
        public EDefaultFlowApprovePageStyle FlowApprovePageStyle
        {
            get
            {
                return this.flowApprovePageStyleField;
            }
            set
            {
                this.flowApprovePageStyleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(EDefaultBoolean.Default)]
        public EDefaultBoolean FlowRevoke
        {
            get
            {
                return this.flowRevokeField;
            }
            set
            {
                this.flowRevokeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(EDefaultBoolean.Default)]
        public EDefaultBoolean FlowMailUrlAutoLogin
        {
            get
            {
                return this.flowMailUrlAutoLoginField;
            }
            set
            {
                this.flowMailUrlAutoLoginField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool Enabled
        {
            get
            {
                return this.enabledField;
            }
            set
            {
                this.enabledField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool CloudEnabled
        {
            get
            {
                return this.cloudEnabledField;
            }
            set
            {
                this.cloudEnabledField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string Note
        {
            get
            {
                return this.noteField;
            }
            set
            {
                this.noteField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://scsservices.net/")]
    public enum EDefaultBoolean
    {
        
        /// <remarks/>
        Default,
        
        /// <remarks/>
        True,
        
        /// <remarks/>
        False,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://scsservices.net/")]
    public enum EDefaultFlowApprovePageStyle
    {
        
        /// <remarks/>
        Default,
        
        /// <remarks/>
        FormOnTop,
        
        /// <remarks/>
        FormOnBottom,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://scsservices.net/")]
    public partial class TWsFlowRejectInputArgs : TFlowRejectInputArgs
    {
        
        private System.Guid sessionGuidField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public System.Guid SessionGuid
        {
            get
            {
                return this.sessionGuidField;
            }
            set
            {
                this.sessionGuidField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TWsFlowApproveOutputResult))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://scsservices.net/")]
    public partial class TFlowApproveOutputResult
    {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://scsservices.net/")]
    public partial class TWsFlowApproveOutputResult : TFlowApproveOutputResult
    {
        
        private TWsException exceptionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public TWsException Exception
        {
            get
            {
                return this.exceptionField;
            }
            set
            {
                this.exceptionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TWsFlowApproveInputArgs))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://scsservices.net/")]
    public partial class TFlowApproveInputArgs
    {
        
        private System.Guid flowWaitIDField;
        
        private string opinionField;
        
        private Parameter[] flowFieldsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public System.Guid FlowWaitID
        {
            get
            {
                return this.flowWaitIDField;
            }
            set
            {
                this.flowWaitIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Opinion
        {
            get
            {
                return this.opinionField;
            }
            set
            {
                this.opinionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=2)]
        public Parameter[] FlowFields
        {
            get
            {
                return this.flowFieldsField;
            }
            set
            {
                this.flowFieldsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://scsservices.net/")]
    public partial class TWsFlowApproveInputArgs : TFlowApproveInputArgs
    {
        
        private System.Guid sessionGuidField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public System.Guid SessionGuid
        {
            get
            {
                return this.sessionGuidField;
            }
            set
            {
                this.sessionGuidField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TWsFlowStartOutputResult))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://scsservices.net/")]
    public partial class TWsBaseOutputResult
    {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://scsservices.net/")]
    public partial class TWsFlowStartOutputResult : TWsBaseOutputResult
    {
        
        private System.Guid flowInstanceIDField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public System.Guid FlowInstanceID
        {
            get
            {
                return this.flowInstanceIDField;
            }
            set
            {
                this.flowInstanceIDField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TWsFlowStartInputArgs))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://scsservices.net/")]
    public abstract partial class TWsBaseInputArgs
    {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://scsservices.net/")]
    public partial class TWsFlowStartInputArgs : TWsBaseInputArgs
    {
        
        private string companyIDField;
        
        private string userIDField;
        
        private string progIDField;
        
        private string formIDField;
        
        private string formViewIDField;
        
        private EFlowStartAction flowStartActionField;
        
        private string opinionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string CompanyID
        {
            get
            {
                return this.companyIDField;
            }
            set
            {
                this.companyIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string UserID
        {
            get
            {
                return this.userIDField;
            }
            set
            {
                this.userIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string ProgID
        {
            get
            {
                return this.progIDField;
            }
            set
            {
                this.progIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string FormID
        {
            get
            {
                return this.formIDField;
            }
            set
            {
                this.formIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string FormViewID
        {
            get
            {
                return this.formViewIDField;
            }
            set
            {
                this.formViewIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public EFlowStartAction FlowStartAction
        {
            get
            {
                return this.flowStartActionField;
            }
            set
            {
                this.flowStartActionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public string Opinion
        {
            get
            {
                return this.opinionField;
            }
            set
            {
                this.opinionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://scsservices.net/")]
    public enum EFlowStartAction
    {
        
        /// <remarks/>
        Add,
        
        /// <remarks/>
        Revoke,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TWsBOUpdateFormStatusInputArgs))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://scsservices.net/")]
    public partial class TUpdateFormStatusInputArgs
    {
        
        private string formIDField;
        
        private string formViewIDField;
        
        private EFormStatus formStatusField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string FormID
        {
            get
            {
                return this.formIDField;
            }
            set
            {
                this.formIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string FormViewID
        {
            get
            {
                return this.formViewIDField;
            }
            set
            {
                this.formViewIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public EFormStatus FormStatus
        {
            get
            {
                return this.formStatusField;
            }
            set
            {
                this.formStatusField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://scsservices.net/")]
    public partial class TWsBOUpdateFormStatusInputArgs : TUpdateFormStatusInputArgs
    {
        
        private System.Guid sessionGuidField;
        
        private string progIDField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public System.Guid SessionGuid
        {
            get
            {
                return this.sessionGuidField;
            }
            set
            {
                this.sessionGuidField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string ProgID
        {
            get
            {
                return this.progIDField;
            }
            set
            {
                this.progIDField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://scsservices.net/")]
    public partial class TErrorInfo
    {
        
        private ErrorCategory[] categoriesField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=0)]
        public ErrorCategory[] Categories
        {
            get
            {
                return this.categoriesField;
            }
            set
            {
                this.categoriesField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://scsservices.net/")]
    public partial class TEmployeeInfo
    {
        
        private string idField;
        
        private string viewIDField;
        
        private string nameField;
        
        private string departmentIDField;
        
        private string departmentViewIDField;
        
        private string departmentLevelField;
        
        private string departmentNameField;
        
        private string rootDepartmentIDField;
        
        private string rootDepartmentViewIDField;
        
        private string rootDepartmentLevelField;
        
        private string rootDepartmentNameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string ViewID
        {
            get
            {
                return this.viewIDField;
            }
            set
            {
                this.viewIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string DepartmentID
        {
            get
            {
                return this.departmentIDField;
            }
            set
            {
                this.departmentIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string DepartmentViewID
        {
            get
            {
                return this.departmentViewIDField;
            }
            set
            {
                this.departmentViewIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public string DepartmentLevel
        {
            get
            {
                return this.departmentLevelField;
            }
            set
            {
                this.departmentLevelField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public string DepartmentName
        {
            get
            {
                return this.departmentNameField;
            }
            set
            {
                this.departmentNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public string RootDepartmentID
        {
            get
            {
                return this.rootDepartmentIDField;
            }
            set
            {
                this.rootDepartmentIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public string RootDepartmentViewID
        {
            get
            {
                return this.rootDepartmentViewIDField;
            }
            set
            {
                this.rootDepartmentViewIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=9)]
        public string RootDepartmentLevel
        {
            get
            {
                return this.rootDepartmentLevelField;
            }
            set
            {
                this.rootDepartmentLevelField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=10)]
        public string RootDepartmentName
        {
            get
            {
                return this.rootDepartmentNameField;
            }
            set
            {
                this.rootDepartmentNameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://scsservices.net/")]
    public partial class TSessionInfo
    {
        
        private System.Guid sessionGuidField;
        
        private EAppName appNameField;
        
        private string databaseIDField;
        
        private EDatabaseType databaseTypeField;
        
        private string companyIDField;
        
        private string companyNameField;
        
        private string customizedIDField;
        
        private bool cloudEnabledField;
        
        private bool flowRevokeField;
        
        private string languageIDField;
        
        private EDefaultViewName viewNameField;
        
        private double utcOffsetField;
        
        private string userIDField;
        
        private string userNameField;
        
        private string sourceUserIDField;
        
        private string sourceUserNameField;
        
        private string userHostAddressField;
        
        private string machineNameField;
        
        private string rolesField;
        
        private bool isAdminField;
        
        private bool isSuperAdminField;
        
        private bool isHRAdminField;
        
        private bool isHRGroupField;
        
        private bool isITAdminField;
        
        private bool isDataPermissionUserFieldsField;
        
        private bool isDataPermissionSysDepartmentIDField;
        
        private EUserType userTypeField;
        
        private string targetIDField;
        
        private TEmployeeInfo employeeField;
        
        private TUserDepartment[] departmentsField;
        
        private System.DateTime lastTimeField;
        
        private int timeoutField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public System.Guid SessionGuid
        {
            get
            {
                return this.sessionGuidField;
            }
            set
            {
                this.sessionGuidField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public EAppName AppName
        {
            get
            {
                return this.appNameField;
            }
            set
            {
                this.appNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string DatabaseID
        {
            get
            {
                return this.databaseIDField;
            }
            set
            {
                this.databaseIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public EDatabaseType DatabaseType
        {
            get
            {
                return this.databaseTypeField;
            }
            set
            {
                this.databaseTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string CompanyID
        {
            get
            {
                return this.companyIDField;
            }
            set
            {
                this.companyIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public string CompanyName
        {
            get
            {
                return this.companyNameField;
            }
            set
            {
                this.companyNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public string CustomizedID
        {
            get
            {
                return this.customizedIDField;
            }
            set
            {
                this.customizedIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public bool CloudEnabled
        {
            get
            {
                return this.cloudEnabledField;
            }
            set
            {
                this.cloudEnabledField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public bool FlowRevoke
        {
            get
            {
                return this.flowRevokeField;
            }
            set
            {
                this.flowRevokeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=9)]
        public string LanguageID
        {
            get
            {
                return this.languageIDField;
            }
            set
            {
                this.languageIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=10)]
        public EDefaultViewName ViewName
        {
            get
            {
                return this.viewNameField;
            }
            set
            {
                this.viewNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=11)]
        public double UtcOffset
        {
            get
            {
                return this.utcOffsetField;
            }
            set
            {
                this.utcOffsetField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=12)]
        public string UserID
        {
            get
            {
                return this.userIDField;
            }
            set
            {
                this.userIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=13)]
        public string UserName
        {
            get
            {
                return this.userNameField;
            }
            set
            {
                this.userNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=14)]
        public string SourceUserID
        {
            get
            {
                return this.sourceUserIDField;
            }
            set
            {
                this.sourceUserIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=15)]
        public string SourceUserName
        {
            get
            {
                return this.sourceUserNameField;
            }
            set
            {
                this.sourceUserNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=16)]
        public string UserHostAddress
        {
            get
            {
                return this.userHostAddressField;
            }
            set
            {
                this.userHostAddressField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=17)]
        public string MachineName
        {
            get
            {
                return this.machineNameField;
            }
            set
            {
                this.machineNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=18)]
        public string Roles
        {
            get
            {
                return this.rolesField;
            }
            set
            {
                this.rolesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=19)]
        public bool IsAdmin
        {
            get
            {
                return this.isAdminField;
            }
            set
            {
                this.isAdminField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=20)]
        public bool IsSuperAdmin
        {
            get
            {
                return this.isSuperAdminField;
            }
            set
            {
                this.isSuperAdminField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=21)]
        public bool IsHRAdmin
        {
            get
            {
                return this.isHRAdminField;
            }
            set
            {
                this.isHRAdminField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=22)]
        public bool IsHRGroup
        {
            get
            {
                return this.isHRGroupField;
            }
            set
            {
                this.isHRGroupField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=23)]
        public bool IsITAdmin
        {
            get
            {
                return this.isITAdminField;
            }
            set
            {
                this.isITAdminField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=24)]
        public bool IsDataPermissionUserFields
        {
            get
            {
                return this.isDataPermissionUserFieldsField;
            }
            set
            {
                this.isDataPermissionUserFieldsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=25)]
        public bool IsDataPermissionSysDepartmentID
        {
            get
            {
                return this.isDataPermissionSysDepartmentIDField;
            }
            set
            {
                this.isDataPermissionSysDepartmentIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=26)]
        public EUserType UserType
        {
            get
            {
                return this.userTypeField;
            }
            set
            {
                this.userTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=27)]
        public string TargetID
        {
            get
            {
                return this.targetIDField;
            }
            set
            {
                this.targetIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=28)]
        public TEmployeeInfo Employee
        {
            get
            {
                return this.employeeField;
            }
            set
            {
                this.employeeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=29)]
        public TUserDepartment[] Departments
        {
            get
            {
                return this.departmentsField;
            }
            set
            {
                this.departmentsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=30)]
        public System.DateTime LastTime
        {
            get
            {
                return this.lastTimeField;
            }
            set
            {
                this.lastTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=31)]
        public int Timeout
        {
            get
            {
                return this.timeoutField;
            }
            set
            {
                this.timeoutField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://scsservices.net/")]
    public enum EAppName
    {
        
        /// <remarks/>
        SCSClient,
        
        /// <remarks/>
        SCSWeb,
        
        /// <remarks/>
        AISTools,
        
        /// <remarks/>
        AISSysTools,
        
        /// <remarks/>
        FlowService,
        
        /// <remarks/>
        ScheduleService,
        
        /// <remarks/>
        App,
        
        /// <remarks/>
        Other,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://scsservices.net/")]
    public enum EDatabaseType
    {
        
        /// <remarks/>
        SQLServer,
        
        /// <remarks/>
        MySQL,
        
        /// <remarks/>
        Oracle,
        
        /// <remarks/>
        OleDb,
        
        /// <remarks/>
        Odbc,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://scsservices.net/")]
    public enum EDefaultViewName
    {
        
        /// <remarks/>
        Default,
        
        /// <remarks/>
        Name,
        
        /// <remarks/>
        EngName,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://scsservices.net/")]
    public enum EUserType
    {
        
        /// <remarks/>
        Employee,
        
        /// <remarks/>
        Customer,
        
        /// <remarks/>
        Factory,
        
        /// <remarks/>
        Guest,
        
        /// <remarks/>
        CompanyUser,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TMobileFuncOutputResult))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TWsBOMobileFuncOutputResult))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TImportOutputResult))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TWsBOImportOutputResult))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TExecFuncOutputResult))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TWsBOExecFuncOutputResult))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TUpdateFormStatusOutputResult))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TWsBOUpdateFormStatusOutputResult))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TDeleteOutputResult))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TWsBODeleteOutputResult))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TAddOutputResult))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TWsBOAddOutputResult))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TMoveOutputResult))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TWsBOMoveOutputResult))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TFindOutputResult))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TWsBOFindOutputResult))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TGetMarqueeMessageOutputResult))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TWsGetMarqueeMessageOutputResult))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TGetCompanyInfoOutputResult))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TWsGetCompanyInfoOutputResult))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TLogoutOutputResult))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TWsLogoutOutputResult))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TLoginOutputResult))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TWsLoginOutputResult))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TGetCompanyItemsOutputResult))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TWsGetCompanyItemsOutputResult))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://scsservices.net/")]
    public abstract partial class TBaseOutputResult
    {
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TWsBOMobileFuncOutputResult))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://scsservices.net/")]
    public partial class TMobileFuncOutputResult : TBaseOutputResult
    {
        
        private bool resultField;
        
        private string messageField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public bool Result
        {
            get
            {
                return this.resultField;
            }
            set
            {
                this.resultField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Message
        {
            get
            {
                return this.messageField;
            }
            set
            {
                this.messageField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://scsservices.net/")]
    public partial class TWsBOMobileFuncOutputResult : TMobileFuncOutputResult
    {
        
        private TWsException exceptionField;
        
        private string resultDataField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public TWsException Exception
        {
            get
            {
                return this.exceptionField;
            }
            set
            {
                this.exceptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string ResultData
        {
            get
            {
                return this.resultDataField;
            }
            set
            {
                this.resultDataField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TWsBOImportOutputResult))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://scsservices.net/")]
    public partial class TImportOutputResult : TBaseOutputResult
    {
        
        private TImportOutputResultDataTable dataTableField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public TImportOutputResultDataTable DataTable
        {
            get
            {
                return this.dataTableField;
            }
            set
            {
                this.dataTableField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://scsservices.net/")]
    public partial class TImportOutputResultDataTable
    {
        
        private System.Xml.Linq.XElement[] anyField;
        
        private System.Xml.Linq.XElement any1Field;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Namespace="http://www.w3.org/2001/XMLSchema", Order=0)]
        public System.Xml.Linq.XElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Namespace="urn:schemas-microsoft-com:xml-diffgram-v1", Order=1)]
        public System.Xml.Linq.XElement Any1
        {
            get
            {
                return this.any1Field;
            }
            set
            {
                this.any1Field = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://scsservices.net/")]
    public partial class TWsBOImportOutputResult : TImportOutputResult
    {
        
        private TWsException exceptionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public TWsException Exception
        {
            get
            {
                return this.exceptionField;
            }
            set
            {
                this.exceptionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TWsBOExecFuncOutputResult))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://scsservices.net/")]
    public partial class TExecFuncOutputResult : TBaseOutputResult
    {
        
        private string funcIDField;
        
        private Parameter[] parametersField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string FuncID
        {
            get
            {
                return this.funcIDField;
            }
            set
            {
                this.funcIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=1)]
        public Parameter[] Parameters
        {
            get
            {
                return this.parametersField;
            }
            set
            {
                this.parametersField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://scsservices.net/")]
    public partial class TWsBOExecFuncOutputResult : TExecFuncOutputResult
    {
        
        private TWsException exceptionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public TWsException Exception
        {
            get
            {
                return this.exceptionField;
            }
            set
            {
                this.exceptionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TWsBOUpdateFormStatusOutputResult))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://scsservices.net/")]
    public partial class TUpdateFormStatusOutputResult : TBaseOutputResult
    {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://scsservices.net/")]
    public partial class TWsBOUpdateFormStatusOutputResult : TUpdateFormStatusOutputResult
    {
        
        private TWsException exceptionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public TWsException Exception
        {
            get
            {
                return this.exceptionField;
            }
            set
            {
                this.exceptionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TWsBODeleteOutputResult))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://scsservices.net/")]
    public partial class TDeleteOutputResult : TBaseOutputResult
    {
        
        private TErrorInfo errorInfoField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public TErrorInfo ErrorInfo
        {
            get
            {
                return this.errorInfoField;
            }
            set
            {
                this.errorInfoField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://scsservices.net/")]
    public partial class TWsBODeleteOutputResult : TDeleteOutputResult
    {
        
        private TWsException exceptionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public TWsException Exception
        {
            get
            {
                return this.exceptionField;
            }
            set
            {
                this.exceptionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TWsBOAddOutputResult))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://scsservices.net/")]
    public partial class TAddOutputResult : TBaseOutputResult
    {
        
        private ScsService.ArrayOfXElement dataSetField;
        
        private TUpdateItem[] updateItemsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public ScsService.ArrayOfXElement DataSet
        {
            get
            {
                return this.dataSetField;
            }
            set
            {
                this.dataSetField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=1)]
        public TUpdateItem[] UpdateItems
        {
            get
            {
                return this.updateItemsField;
            }
            set
            {
                this.updateItemsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://scsservices.net/")]
    public partial class TWsBOAddOutputResult : TAddOutputResult
    {
        
        private TWsException exceptionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public TWsException Exception
        {
            get
            {
                return this.exceptionField;
            }
            set
            {
                this.exceptionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TWsBOMoveOutputResult))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://scsservices.net/")]
    public partial class TMoveOutputResult : TBaseOutputResult
    {
        
        private ScsService.ArrayOfXElement dataSetField;
        
        private TUpdateItem[] updateItemsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public ScsService.ArrayOfXElement DataSet
        {
            get
            {
                return this.dataSetField;
            }
            set
            {
                this.dataSetField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=1)]
        public TUpdateItem[] UpdateItems
        {
            get
            {
                return this.updateItemsField;
            }
            set
            {
                this.updateItemsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://scsservices.net/")]
    public partial class TWsBOMoveOutputResult : TMoveOutputResult
    {
        
        private TWsException exceptionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public TWsException Exception
        {
            get
            {
                return this.exceptionField;
            }
            set
            {
                this.exceptionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TWsBOFindOutputResult))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://scsservices.net/")]
    public partial class TFindOutputResult : TBaseOutputResult
    {
        
        private TFindOutputResultDataTable dataTableField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public TFindOutputResultDataTable DataTable
        {
            get
            {
                return this.dataTableField;
            }
            set
            {
                this.dataTableField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://scsservices.net/")]
    public partial class TFindOutputResultDataTable
    {
        
        private System.Xml.Linq.XElement[] anyField;
        
        private System.Xml.Linq.XElement any1Field;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Namespace="http://www.w3.org/2001/XMLSchema", Order=0)]
        public System.Xml.Linq.XElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Namespace="urn:schemas-microsoft-com:xml-diffgram-v1", Order=1)]
        public System.Xml.Linq.XElement Any1
        {
            get
            {
                return this.any1Field;
            }
            set
            {
                this.any1Field = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://scsservices.net/")]
    public partial class TWsBOFindOutputResult : TFindOutputResult
    {
        
        private TWsException exceptionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public TWsException Exception
        {
            get
            {
                return this.exceptionField;
            }
            set
            {
                this.exceptionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TWsGetMarqueeMessageOutputResult))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://scsservices.net/")]
    public partial class TGetMarqueeMessageOutputResult : TBaseOutputResult
    {
        
        private TMarqueeMessageItem[] itemsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=0)]
        public TMarqueeMessageItem[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://scsservices.net/")]
    public partial class TWsGetMarqueeMessageOutputResult : TGetMarqueeMessageOutputResult
    {
        
        private TWsException exceptionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public TWsException Exception
        {
            get
            {
                return this.exceptionField;
            }
            set
            {
                this.exceptionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TWsGetCompanyInfoOutputResult))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://scsservices.net/")]
    public partial class TGetCompanyInfoOutputResult : TBaseOutputResult
    {
        
        private string versionField;
        
        private string aPPVersionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string APPVersion
        {
            get
            {
                return this.aPPVersionField;
            }
            set
            {
                this.aPPVersionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://scsservices.net/")]
    public partial class TWsGetCompanyInfoOutputResult : TGetCompanyInfoOutputResult
    {
        
        private string xmlField;
        
        private TWsException exceptionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Xml
        {
            get
            {
                return this.xmlField;
            }
            set
            {
                this.xmlField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public TWsException Exception
        {
            get
            {
                return this.exceptionField;
            }
            set
            {
                this.exceptionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TWsLogoutOutputResult))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://scsservices.net/")]
    public partial class TLogoutOutputResult : TBaseOutputResult
    {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://scsservices.net/")]
    public partial class TWsLogoutOutputResult : TLogoutOutputResult
    {
        
        private TWsException exceptionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public TWsException Exception
        {
            get
            {
                return this.exceptionField;
            }
            set
            {
                this.exceptionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TWsLoginOutputResult))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://scsservices.net/")]
    public partial class TLoginOutputResult : TBaseOutputResult
    {
        
        private System.Guid sessionGuidField;
        
        private TSessionInfo sessionInfoField;
        
        private bool isPasswordChangeField;
        
        private string passwordChangeMessageField;
        
        private bool cloudEnabledField;
        
        private bool resultField;
        
        private string messageField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public System.Guid SessionGuid
        {
            get
            {
                return this.sessionGuidField;
            }
            set
            {
                this.sessionGuidField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public TSessionInfo SessionInfo
        {
            get
            {
                return this.sessionInfoField;
            }
            set
            {
                this.sessionInfoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public bool IsPasswordChange
        {
            get
            {
                return this.isPasswordChangeField;
            }
            set
            {
                this.isPasswordChangeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string PasswordChangeMessage
        {
            get
            {
                return this.passwordChangeMessageField;
            }
            set
            {
                this.passwordChangeMessageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public bool CloudEnabled
        {
            get
            {
                return this.cloudEnabledField;
            }
            set
            {
                this.cloudEnabledField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public bool Result
        {
            get
            {
                return this.resultField;
            }
            set
            {
                this.resultField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public string Message
        {
            get
            {
                return this.messageField;
            }
            set
            {
                this.messageField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://scsservices.net/")]
    public partial class TWsLoginOutputResult : TLoginOutputResult
    {
        
        private TWsException exceptionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public TWsException Exception
        {
            get
            {
                return this.exceptionField;
            }
            set
            {
                this.exceptionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TWsGetCompanyItemsOutputResult))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://scsservices.net/")]
    public partial class TGetCompanyItemsOutputResult : TBaseOutputResult
    {
        
        private CompanyItem[] companyItemsField;
        
        private string versionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=0)]
        public CompanyItem[] CompanyItems
        {
            get
            {
                return this.companyItemsField;
            }
            set
            {
                this.companyItemsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://scsservices.net/")]
    public partial class TWsGetCompanyItemsOutputResult : TGetCompanyItemsOutputResult
    {
        
        private TWsException exceptionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public TWsException Exception
        {
            get
            {
                return this.exceptionField;
            }
            set
            {
                this.exceptionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TMobileFuncInputArgs))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TWsBOMobileFuncInputArgs))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TImportInputArgs))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TWsBOImportInputArgs))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TExecFuncInputArgs))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TWsBOExecFuncInputArgs))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TDeleteInputArgs))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TWsBODeleteInputArgs))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TAddInputArgs))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TWsBOAddInputArgs))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TMoveInputArgs))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TWsBOMoveInputArgs))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TFindInputArgs))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TWsBOFindInputArgs))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TGetMarqueeMessageInputArgs))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TWsGetMarqueeMessageInputArgs))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TGetCompanyInfoInputArgs))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TWsGetCompanyInfoInputArgs))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TLogoutInputArgs))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TWsLogoutInputArgs))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TLoginInputArgs))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TWsLoginInputArgs))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TGetCompanyItemsInputArgs))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TWsGetCompanyItemsInputArgs))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://scsservices.net/")]
    public abstract partial class TBaseInputArgs
    {
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TWsBOMobileFuncInputArgs))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://scsservices.net/")]
    public partial class TMobileFuncInputArgs : TBaseInputArgs
    {
        
        private EMobileFuncType funcTypeField;
        
        private string argsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public EMobileFuncType FuncType
        {
            get
            {
                return this.funcTypeField;
            }
            set
            {
                this.funcTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Args
        {
            get
            {
                return this.argsField;
            }
            set
            {
                this.argsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://scsservices.net/")]
    public enum EMobileFuncType
    {
        
        /// <remarks/>
        Save,
        
        /// <remarks/>
        Move,
        
        /// <remarks/>
        Find,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://scsservices.net/")]
    public partial class TWsBOMobileFuncInputArgs : TMobileFuncInputArgs
    {
        
        private System.Guid sessionGuidField;
        
        private string progIDField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public System.Guid SessionGuid
        {
            get
            {
                return this.sessionGuidField;
            }
            set
            {
                this.sessionGuidField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string ProgID
        {
            get
            {
                return this.progIDField;
            }
            set
            {
                this.progIDField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TWsBOImportInputArgs))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://scsservices.net/")]
    public partial class TImportInputArgs : TBaseInputArgs
    {
        
        private ScsService.ArrayOfXElement dataSetField;
        
        private bool emptyUpdateField;
        
        private EFormFlowAction formFlowActionField;
        
        private bool validateModeField;
        
        private bool isFormLogField;
        
        private EImportHelperSource sourceTypeField;
        
        private ELinkImportMode linkImportModeField;
        
        public TImportInputArgs()
        {
            this.isFormLogField = true;
            this.linkImportModeField = ELinkImportMode.Replace;
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public ScsService.ArrayOfXElement DataSet
        {
            get
            {
                return this.dataSetField;
            }
            set
            {
                this.dataSetField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public bool EmptyUpdate
        {
            get
            {
                return this.emptyUpdateField;
            }
            set
            {
                this.emptyUpdateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public EFormFlowAction FormFlowAction
        {
            get
            {
                return this.formFlowActionField;
            }
            set
            {
                this.formFlowActionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public bool ValidateMode
        {
            get
            {
                return this.validateModeField;
            }
            set
            {
                this.validateModeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool IsFormLog
        {
            get
            {
                return this.isFormLogField;
            }
            set
            {
                this.isFormLogField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public EImportHelperSource SourceType
        {
            get
            {
                return this.sourceTypeField;
            }
            set
            {
                this.sourceTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        [System.ComponentModel.DefaultValueAttribute(ELinkImportMode.Replace)]
        public ELinkImportMode LinkImportMode
        {
            get
            {
                return this.linkImportModeField;
            }
            set
            {
                this.linkImportModeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://scsservices.net/")]
    public enum EFormFlowAction
    {
        
        /// <remarks/>
        FlowStart,
        
        /// <remarks/>
        Approved,
        
        /// <remarks/>
        Draft,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://scsservices.net/")]
    public enum EImportHelperSource
    {
        
        /// <remarks/>
        NoSet,
        
        /// <remarks/>
        WsBOImport,
        
        /// <remarks/>
        WsBOImpData,
        
        /// <remarks/>
        Other,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://scsservices.net/")]
    public enum ELinkImportMode
    {
        
        /// <remarks/>
        Replace,
        
        /// <remarks/>
        Append,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://scsservices.net/")]
    public partial class TWsBOImportInputArgs : TImportInputArgs
    {
        
        private System.Guid sessionGuidField;
        
        private string progIDField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public System.Guid SessionGuid
        {
            get
            {
                return this.sessionGuidField;
            }
            set
            {
                this.sessionGuidField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string ProgID
        {
            get
            {
                return this.progIDField;
            }
            set
            {
                this.progIDField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TWsBOExecFuncInputArgs))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://scsservices.net/")]
    public partial class TExecFuncInputArgs : TBaseInputArgs
    {
        
        private string funcIDField;
        
        private Parameter[] parametersField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string FuncID
        {
            get
            {
                return this.funcIDField;
            }
            set
            {
                this.funcIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=1)]
        public Parameter[] Parameters
        {
            get
            {
                return this.parametersField;
            }
            set
            {
                this.parametersField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://scsservices.net/")]
    public partial class TWsBOExecFuncInputArgs : TExecFuncInputArgs
    {
        
        private System.Guid sessionGuidField;
        
        private string progIDField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public System.Guid SessionGuid
        {
            get
            {
                return this.sessionGuidField;
            }
            set
            {
                this.sessionGuidField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string ProgID
        {
            get
            {
                return this.progIDField;
            }
            set
            {
                this.progIDField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TWsBODeleteInputArgs))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://scsservices.net/")]
    public partial class TDeleteInputArgs : TBaseInputArgs
    {
        
        private string formIDField;
        
        private string formViewIDField;
        
        private System.DateTime formDateField;
        
        private bool isValidateCloseDateField;
        
        private bool isFormLogField;
        
        private bool validateModeField;
        
        private Parameter[] parametersField;
        
        private FilterItem[] filterItemsField;
        
        public TDeleteInputArgs()
        {
            this.isFormLogField = true;
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string FormID
        {
            get
            {
                return this.formIDField;
            }
            set
            {
                this.formIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string FormViewID
        {
            get
            {
                return this.formViewIDField;
            }
            set
            {
                this.formViewIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public System.DateTime FormDate
        {
            get
            {
                return this.formDateField;
            }
            set
            {
                this.formDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public bool IsValidateCloseDate
        {
            get
            {
                return this.isValidateCloseDateField;
            }
            set
            {
                this.isValidateCloseDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool IsFormLog
        {
            get
            {
                return this.isFormLogField;
            }
            set
            {
                this.isFormLogField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public bool ValidateMode
        {
            get
            {
                return this.validateModeField;
            }
            set
            {
                this.validateModeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=6)]
        public Parameter[] Parameters
        {
            get
            {
                return this.parametersField;
            }
            set
            {
                this.parametersField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=7)]
        public FilterItem[] FilterItems
        {
            get
            {
                return this.filterItemsField;
            }
            set
            {
                this.filterItemsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://scsservices.net/")]
    public partial class TWsBODeleteInputArgs : TDeleteInputArgs
    {
        
        private System.Guid sessionGuidField;
        
        private string progIDField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public System.Guid SessionGuid
        {
            get
            {
                return this.sessionGuidField;
            }
            set
            {
                this.sessionGuidField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string ProgID
        {
            get
            {
                return this.progIDField;
            }
            set
            {
                this.progIDField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TWsBOAddInputArgs))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://scsservices.net/")]
    public partial class TAddInputArgs : TBaseInputArgs
    {
        
        private bool isCopyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public bool IsCopy
        {
            get
            {
                return this.isCopyField;
            }
            set
            {
                this.isCopyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://scsservices.net/")]
    public partial class TWsBOAddInputArgs : TAddInputArgs
    {
        
        private System.Guid sessionGuidField;
        
        private string progIDField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public System.Guid SessionGuid
        {
            get
            {
                return this.sessionGuidField;
            }
            set
            {
                this.sessionGuidField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string ProgID
        {
            get
            {
                return this.progIDField;
            }
            set
            {
                this.progIDField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TWsBOMoveInputArgs))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://scsservices.net/")]
    public partial class TMoveInputArgs : TBaseInputArgs
    {
        
        private string formIDField;
        
        private ESystemFilterOptions systemFilterOptionsField;
        
        private bool isApproveFormField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string FormID
        {
            get
            {
                return this.formIDField;
            }
            set
            {
                this.formIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public ESystemFilterOptions SystemFilterOptions
        {
            get
            {
                return this.systemFilterOptionsField;
            }
            set
            {
                this.systemFilterOptionsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public bool IsApproveForm
        {
            get
            {
                return this.isApproveFormField;
            }
            set
            {
                this.isApproveFormField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.FlagsAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://scsservices.net/")]
    public enum ESystemFilterOptions
    {
        
        /// <remarks/>
        Session = 1,
        
        /// <remarks/>
        DataPermission = 2,
        
        /// <remarks/>
        EmployeeLevel = 4,
        
        /// <remarks/>
        BeginEndDate = 8,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://scsservices.net/")]
    public partial class TWsBOMoveInputArgs : TMoveInputArgs
    {
        
        private System.Guid sessionGuidField;
        
        private string progIDField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public System.Guid SessionGuid
        {
            get
            {
                return this.sessionGuidField;
            }
            set
            {
                this.sessionGuidField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string ProgID
        {
            get
            {
                return this.progIDField;
            }
            set
            {
                this.progIDField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TWsBOFindInputArgs))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://scsservices.net/")]
    public partial class TFindInputArgs : TBaseInputArgs
    {
        
        private int selectCountField;
        
        private int selectSectionField;
        
        private string selectFieldsField;
        
        private string keywordField;
        
        private FilterItem[] filterItemsField;
        
        private ESystemFilterOptions systemFilterOptionsField;
        
        private string dataPermissionProgIDField;
        
        private System.DateTime dateValueField;
        
        private string userFilterField;
        
        private bool isBuildVirtualFieldField;
        
        private bool isBuildSelectedFieldField;
        
        private bool isBuildFlowLightSignalFieldField;
        
        public TFindInputArgs()
        {
            this.keywordField = "";
            this.dataPermissionProgIDField = "";
            this.userFilterField = "";
            this.isBuildVirtualFieldField = false;
            this.isBuildSelectedFieldField = false;
            this.isBuildFlowLightSignalFieldField = false;
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int SelectCount
        {
            get
            {
                return this.selectCountField;
            }
            set
            {
                this.selectCountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public int SelectSection
        {
            get
            {
                return this.selectSectionField;
            }
            set
            {
                this.selectSectionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string SelectFields
        {
            get
            {
                return this.selectFieldsField;
            }
            set
            {
                this.selectFieldsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string Keyword
        {
            get
            {
                return this.keywordField;
            }
            set
            {
                this.keywordField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=4)]
        public FilterItem[] FilterItems
        {
            get
            {
                return this.filterItemsField;
            }
            set
            {
                this.filterItemsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public ESystemFilterOptions SystemFilterOptions
        {
            get
            {
                return this.systemFilterOptionsField;
            }
            set
            {
                this.systemFilterOptionsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string DataPermissionProgID
        {
            get
            {
                return this.dataPermissionProgIDField;
            }
            set
            {
                this.dataPermissionProgIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public System.DateTime DateValue
        {
            get
            {
                return this.dateValueField;
            }
            set
            {
                this.dateValueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string UserFilter
        {
            get
            {
                return this.userFilterField;
            }
            set
            {
                this.userFilterField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=9)]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool IsBuildVirtualField
        {
            get
            {
                return this.isBuildVirtualFieldField;
            }
            set
            {
                this.isBuildVirtualFieldField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=10)]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool IsBuildSelectedField
        {
            get
            {
                return this.isBuildSelectedFieldField;
            }
            set
            {
                this.isBuildSelectedFieldField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=11)]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool IsBuildFlowLightSignalField
        {
            get
            {
                return this.isBuildFlowLightSignalFieldField;
            }
            set
            {
                this.isBuildFlowLightSignalFieldField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://scsservices.net/")]
    public partial class TWsBOFindInputArgs : TFindInputArgs
    {
        
        private System.Guid sessionGuidField;
        
        private string progIDField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public System.Guid SessionGuid
        {
            get
            {
                return this.sessionGuidField;
            }
            set
            {
                this.sessionGuidField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string ProgID
        {
            get
            {
                return this.progIDField;
            }
            set
            {
                this.progIDField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TWsGetMarqueeMessageInputArgs))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://scsservices.net/")]
    public partial class TGetMarqueeMessageInputArgs : TBaseInputArgs
    {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://scsservices.net/")]
    public partial class TWsGetMarqueeMessageInputArgs : TGetMarqueeMessageInputArgs
    {
        
        private System.Guid sessionGuidField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public System.Guid SessionGuid
        {
            get
            {
                return this.sessionGuidField;
            }
            set
            {
                this.sessionGuidField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TWsGetCompanyInfoInputArgs))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://scsservices.net/")]
    public partial class TGetCompanyInfoInputArgs : TBaseInputArgs
    {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://scsservices.net/")]
    public partial class TWsGetCompanyInfoInputArgs : TGetCompanyInfoInputArgs
    {
        
        private System.Guid sessionGuidField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public System.Guid SessionGuid
        {
            get
            {
                return this.sessionGuidField;
            }
            set
            {
                this.sessionGuidField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TWsLogoutInputArgs))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://scsservices.net/")]
    public partial class TLogoutInputArgs : TBaseInputArgs
    {
        
        private EAppName appNameField;
        
        private bool isDeleteSessionBufferField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public EAppName AppName
        {
            get
            {
                return this.appNameField;
            }
            set
            {
                this.appNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public bool IsDeleteSessionBuffer
        {
            get
            {
                return this.isDeleteSessionBufferField;
            }
            set
            {
                this.isDeleteSessionBufferField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://scsservices.net/")]
    public partial class TWsLogoutInputArgs : TLogoutInputArgs
    {
        
        private System.Guid sessionGuidField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public System.Guid SessionGuid
        {
            get
            {
                return this.sessionGuidField;
            }
            set
            {
                this.sessionGuidField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TWsLoginInputArgs))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://scsservices.net/")]
    public partial class TLoginInputArgs : TBaseInputArgs
    {
        
        private EAppName appNameField;
        
        private string companyIDField;
        
        private string userIDField;
        
        private string passwordField;
        
        private string languageIDField;
        
        private string machineNameField;
        
        private string validateCodeField;
        
        public TLoginInputArgs()
        {
            this.appNameField = EAppName.Other;
            this.validateCodeField = "";
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        [System.ComponentModel.DefaultValueAttribute(EAppName.Other)]
        public EAppName AppName
        {
            get
            {
                return this.appNameField;
            }
            set
            {
                this.appNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string CompanyID
        {
            get
            {
                return this.companyIDField;
            }
            set
            {
                this.companyIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string UserID
        {
            get
            {
                return this.userIDField;
            }
            set
            {
                this.userIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string Password
        {
            get
            {
                return this.passwordField;
            }
            set
            {
                this.passwordField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string LanguageID
        {
            get
            {
                return this.languageIDField;
            }
            set
            {
                this.languageIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public string MachineName
        {
            get
            {
                return this.machineNameField;
            }
            set
            {
                this.machineNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string ValidateCode
        {
            get
            {
                return this.validateCodeField;
            }
            set
            {
                this.validateCodeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://scsservices.net/")]
    public partial class TWsLoginInputArgs : TLoginInputArgs
    {
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TWsGetCompanyItemsInputArgs))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://scsservices.net/")]
    public partial class TGetCompanyItemsInputArgs : TBaseInputArgs
    {
        
        private string authorizeCodeField;
        
        private string idField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string AuthorizeCode
        {
            get
            {
                return this.authorizeCodeField;
            }
            set
            {
                this.authorizeCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://scsservices.net/")]
    public partial class TWsGetCompanyItemsInputArgs : TGetCompanyItemsInputArgs
    {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://scsservices.net/")]
    public partial class TBusinessObjectRunResult
    {
        
        private string progIDField;
        
        private EBusinessObjectAction actionField;
        
        private ETransmissionFormat formatField;
        
        private byte[] bytesField;
        
        private string valueField;
        
        private TWsException exceptionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string ProgID
        {
            get
            {
                return this.progIDField;
            }
            set
            {
                this.progIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public EBusinessObjectAction Action
        {
            get
            {
                return this.actionField;
            }
            set
            {
                this.actionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public ETransmissionFormat Format
        {
            get
            {
                return this.formatField;
            }
            set
            {
                this.formatField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary", Order=3)]
        public byte[] Bytes
        {
            get
            {
                return this.bytesField;
            }
            set
            {
                this.bytesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public TWsException Exception
        {
            get
            {
                return this.exceptionField;
            }
            set
            {
                this.exceptionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://scsservices.net/")]
    public enum EBusinessObjectAction
    {
        
        /// <remarks/>
        Move,
        
        /// <remarks/>
        Save,
        
        /// <remarks/>
        Add,
        
        /// <remarks/>
        Edit,
        
        /// <remarks/>
        Delete,
        
        /// <remarks/>
        Revoke,
        
        /// <remarks/>
        Invalid,
        
        /// <remarks/>
        Find,
        
        /// <remarks/>
        Select,
        
        /// <remarks/>
        TableSave,
        
        /// <remarks/>
        ExecFunc,
        
        /// <remarks/>
        ExecReport,
        
        /// <remarks/>
        ProcessLoad,
        
        /// <remarks/>
        ProcessExecute,
        
        /// <remarks/>
        ListLoad,
        
        /// <remarks/>
        ExecFlowStart,
        
        /// <remarks/>
        ExecFlowAbort,
        
        /// <remarks/>
        ExecFlowEnd,
        
        /// <remarks/>
        ExecFlowRollback,
        
        /// <remarks/>
        UpdateFormStatus,
        
        /// <remarks/>
        FieldValueChange,
        
        /// <remarks/>
        UploadImageFile,
        
        /// <remarks/>
        DeleteImageFile,
        
        /// <remarks/>
        UploadAttachFile,
        
        /// <remarks/>
        DownloadAttachFile,
        
        /// <remarks/>
        DeleteAttachFile,
        
        /// <remarks/>
        GetAttachFiles,
        
        /// <remarks/>
        GetDownloadLogs,
        
        /// <remarks/>
        GetViewLogs,
        
        /// <remarks/>
        GetFormLogs,
        
        /// <remarks/>
        MobileFunc,
        
        /// <remarks/>
        Import,
        
        /// <remarks/>
        FormLoad,
        
        /// <remarks/>
        BeforeShowSelectReturnForm,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://scsservices.net/")]
    public partial class TBusinessObjectRunArgs
    {
        
        private System.Guid sessionGuidField;
        
        private string progIDField;
        
        private EBusinessObjectAction actionField;
        
        private ETransmissionFormat formatField;
        
        private byte[] bytesField;
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public System.Guid SessionGuid
        {
            get
            {
                return this.sessionGuidField;
            }
            set
            {
                this.sessionGuidField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string ProgID
        {
            get
            {
                return this.progIDField;
            }
            set
            {
                this.progIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public EBusinessObjectAction Action
        {
            get
            {
                return this.actionField;
            }
            set
            {
                this.actionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public ETransmissionFormat Format
        {
            get
            {
                return this.formatField;
            }
            set
            {
                this.formatField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary", Order=4)]
        public byte[] Bytes
        {
            get
            {
                return this.bytesField;
            }
            set
            {
                this.bytesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://scsservices.net/")]
    public partial class TSystemObjectRunResult
    {
        
        private ESystemObjectAction actionField;
        
        private ETransmissionFormat formatField;
        
        private byte[] bytesField;
        
        private string valueField;
        
        private TWsException exceptionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public ESystemObjectAction Action
        {
            get
            {
                return this.actionField;
            }
            set
            {
                this.actionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public ETransmissionFormat Format
        {
            get
            {
                return this.formatField;
            }
            set
            {
                this.formatField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary", Order=2)]
        public byte[] Bytes
        {
            get
            {
                return this.bytesField;
            }
            set
            {
                this.bytesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public TWsException Exception
        {
            get
            {
                return this.exceptionField;
            }
            set
            {
                this.exceptionField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public interface SCSServiceSoapChannel : ScsService.SCSServiceSoap, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public partial class SCSServiceSoapClient : System.ServiceModel.ClientBase<ScsService.SCSServiceSoap>, ScsService.SCSServiceSoap
    {
        
    /// <summary>
    /// 實作此部分方法來設定服務端點。
    /// </summary>
    /// <param name="serviceEndpoint">要設定的端點</param>
    /// <param name="clientCredentials">用戶端認證</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public SCSServiceSoapClient(EndpointConfiguration endpointConfiguration) : 
                base(SCSServiceSoapClient.GetBindingForEndpoint(endpointConfiguration), SCSServiceSoapClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public SCSServiceSoapClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(SCSServiceSoapClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public SCSServiceSoapClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(SCSServiceSoapClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public SCSServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<string> HelloWorldAsync()
        {
            return base.Channel.HelloWorldAsync();
        }
        
        public System.Threading.Tasks.Task<ScsService.TSystemObjectRunResult> SystemObjectRunAsync(ScsService.TSystemObjectRunArgs args)
        {
            return base.Channel.SystemObjectRunAsync(args);
        }
        
        public System.Threading.Tasks.Task<string> SystemObjectJsonAsync(string sessionGuid, ScsService.ESystemObjectAction action, string json)
        {
            return base.Channel.SystemObjectJsonAsync(sessionGuid, action, json);
        }
        
        public System.Threading.Tasks.Task<ScsService.TBusinessObjectRunResult> BusinessObjectRunAsync(ScsService.TBusinessObjectRunArgs args)
        {
            return base.Channel.BusinessObjectRunAsync(args);
        }
        
        public System.Threading.Tasks.Task<string> BusinessObjectJsonAsync(string sessionGuid, string progID, ScsService.EBusinessObjectAction action, string json)
        {
            return base.Channel.BusinessObjectJsonAsync(sessionGuid, progID, action, json);
        }
        
        public System.Threading.Tasks.Task<ScsService.TWsGetCompanyItemsOutputResult> GetCompanyItemsAsync(ScsService.TWsGetCompanyItemsInputArgs inputArgs)
        {
            return base.Channel.GetCompanyItemsAsync(inputArgs);
        }
        
        public System.Threading.Tasks.Task<ScsService.TWsLoginOutputResult> LoginAsync(ScsService.TWsLoginInputArgs inputArgs)
        {
            return base.Channel.LoginAsync(inputArgs);
        }
        
        public System.Threading.Tasks.Task<ScsService.TWsLogoutOutputResult> LogoutAsync(ScsService.TWsLogoutInputArgs inputArgs)
        {
            return base.Channel.LogoutAsync(inputArgs);
        }
        
        public System.Threading.Tasks.Task<System.Guid> CreateSessionGuidAsync(string companyID, string userID, string languageID)
        {
            return base.Channel.CreateSessionGuidAsync(companyID, userID, languageID);
        }
        
        public System.Threading.Tasks.Task<ScsService.TWsGetCompanyInfoOutputResult> GetCompanyInfoAsync(ScsService.TWsGetCompanyInfoInputArgs inputArgs)
        {
            return base.Channel.GetCompanyInfoAsync(inputArgs);
        }
        
        public System.Threading.Tasks.Task<ScsService.TWsGetMarqueeMessageOutputResult> GetMarqueeMessageAsync(ScsService.TWsGetMarqueeMessageInputArgs inputArgs)
        {
            return base.Channel.GetMarqueeMessageAsync(inputArgs);
        }
        
        public System.Threading.Tasks.Task<ScsService.TWsBOFindOutputResult> BOFindAsync(ScsService.TWsBOFindInputArgs inputArgs)
        {
            return base.Channel.BOFindAsync(inputArgs);
        }
        
        public System.Threading.Tasks.Task<ScsService.TWsBOMoveOutputResult> BOMoveAsync(ScsService.TWsBOMoveInputArgs inputArgs)
        {
            return base.Channel.BOMoveAsync(inputArgs);
        }
        
        public System.Threading.Tasks.Task<ScsService.TWsBOAddOutputResult> BOAddAsync(ScsService.TWsBOAddInputArgs inputArgs)
        {
            return base.Channel.BOAddAsync(inputArgs);
        }
        
        public System.Threading.Tasks.Task<ScsService.TWsBODeleteOutputResult> BODeleteAsync(ScsService.TWsBODeleteInputArgs inputArgs)
        {
            return base.Channel.BODeleteAsync(inputArgs);
        }
        
        public System.Threading.Tasks.Task<ScsService.TWsBOUpdateFormStatusOutputResult> BOUpdateFormStatusAsync(ScsService.TWsBOUpdateFormStatusInputArgs inputArgs)
        {
            return base.Channel.BOUpdateFormStatusAsync(inputArgs);
        }
        
        public System.Threading.Tasks.Task<ScsService.TWsBOExecFuncOutputResult> BOExecFuncAsync(ScsService.TWsBOExecFuncInputArgs inputArgs)
        {
            return base.Channel.BOExecFuncAsync(inputArgs);
        }
        
        public System.Threading.Tasks.Task<ScsService.TWsBOImportOutputResult> BOImportAsync(ScsService.TWsBOImportInputArgs inputArgs)
        {
            return base.Channel.BOImportAsync(inputArgs);
        }
        
        public System.Threading.Tasks.Task<string> BOExpDataAsync(string companyID, string funcID, string filter)
        {
            return base.Channel.BOExpDataAsync(companyID, funcID, filter);
        }
        
        public System.Threading.Tasks.Task<string> BOImpDataAsync(string companyID, string funcID, string xmlData)
        {
            return base.Channel.BOImpDataAsync(companyID, funcID, xmlData);
        }
        
        public System.Threading.Tasks.Task<ScsService.TWsBOMobileFuncOutputResult> MBOSaveAsync(ScsService.TWsBOMobileFuncInputArgs inputArgs)
        {
            return base.Channel.MBOSaveAsync(inputArgs);
        }
        
        public System.Threading.Tasks.Task<ScsService.TWsFlowStartOutputResult> FlowStartAsync(ScsService.TWsFlowStartInputArgs inputArgs)
        {
            return base.Channel.FlowStartAsync(inputArgs);
        }
        
        public System.Threading.Tasks.Task<ScsService.TWsFlowApproveOutputResult> FlowApproveAsync(ScsService.TWsFlowApproveInputArgs inputArgs)
        {
            return base.Channel.FlowApproveAsync(inputArgs);
        }
        
        public System.Threading.Tasks.Task<ScsService.TWsFlowRejectOutputResult> FlowRejectAsync(ScsService.TWsFlowRejectInputArgs inputArgs)
        {
            return base.Channel.FlowRejectAsync(inputArgs);
        }
        
        public System.Threading.Tasks.Task<ScsService.TWsFlowRollbackOutputResult> FlowRollbackAsync(ScsService.TWsFlowRollbackInputArgs inputArgs)
        {
            return base.Channel.FlowRollbackAsync(inputArgs);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.SCSServiceSoap))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            if ((endpointConfiguration == EndpointConfiguration.SCSServiceSoap12))
            {
                System.ServiceModel.Channels.CustomBinding result = new System.ServiceModel.Channels.CustomBinding();
                System.ServiceModel.Channels.TextMessageEncodingBindingElement textBindingElement = new System.ServiceModel.Channels.TextMessageEncodingBindingElement();
                textBindingElement.MessageVersion = System.ServiceModel.Channels.MessageVersion.CreateVersion(System.ServiceModel.EnvelopeVersion.Soap12, System.ServiceModel.Channels.AddressingVersion.None);
                result.Elements.Add(textBindingElement);
                System.ServiceModel.Channels.HttpTransportBindingElement httpBindingElement = new System.ServiceModel.Channels.HttpTransportBindingElement();
                httpBindingElement.AllowCookies = true;
                httpBindingElement.MaxBufferSize = int.MaxValue;
                httpBindingElement.MaxReceivedMessageSize = int.MaxValue;
                result.Elements.Add(httpBindingElement);
                return result;
            }
            throw new System.InvalidOperationException(string.Format("找不到名為 \'{0}\' 的端點。", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.SCSServiceSoap))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost/scsweb/scsservice.asmx");
            }
            if ((endpointConfiguration == EndpointConfiguration.SCSServiceSoap12))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost/scsweb/scsservice.asmx");
            }
            throw new System.InvalidOperationException(string.Format("找不到名為 \'{0}\' 的端點。", endpointConfiguration));
        }
        
        public enum EndpointConfiguration
        {
            
            SCSServiceSoap,
            
            SCSServiceSoap12,
        }
    }
    
    [System.Xml.Serialization.XmlSchemaProviderAttribute(null, IsAny=true)]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public partial class ArrayOfXElement : object, System.Xml.Serialization.IXmlSerializable
    {
        
        private System.Collections.Generic.List<System.Xml.Linq.XElement> nodesList = new System.Collections.Generic.List<System.Xml.Linq.XElement>();
        
        public ArrayOfXElement()
        {
        }
        
        public virtual System.Collections.Generic.List<System.Xml.Linq.XElement> Nodes
        {
            get
            {
                return this.nodesList;
            }
        }
        
        public virtual System.Xml.Schema.XmlSchema GetSchema()
        {
            throw new System.NotImplementedException();
        }
        
        public virtual void WriteXml(System.Xml.XmlWriter writer)
        {
            System.Collections.Generic.IEnumerator<System.Xml.Linq.XElement> e = nodesList.GetEnumerator();
            for (
            ; e.MoveNext(); 
            )
            {
                ((System.Xml.Serialization.IXmlSerializable)(e.Current)).WriteXml(writer);
            }
        }
        
        public virtual void ReadXml(System.Xml.XmlReader reader)
        {
            for (
            ; (reader.NodeType != System.Xml.XmlNodeType.EndElement); 
            )
            {
                if ((reader.NodeType == System.Xml.XmlNodeType.Element))
                {
                    System.Xml.Linq.XElement elem = new System.Xml.Linq.XElement("default");
                    ((System.Xml.Serialization.IXmlSerializable)(elem)).ReadXml(reader);
                    Nodes.Add(elem);
                }
                else
                {
                    reader.Skip();
                }
            }
        }
    }
}

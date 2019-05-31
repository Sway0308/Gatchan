using Elementary;
using ScsService;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Xml.Serialization;
using static ScsService.SCSServiceSoapClient;

namespace ScsBusiness.Core
{
    public class ScsProgram
    {
        public ScsProgram(string url)
        {
            this.ScsClient = new SCSServiceSoapClient(EndpointConfiguration.SCSServiceSoap, url);

            var task = Login("SCS003", "07001", "scsadmin");
            task.GetAwaiter().GetResult();
            //Test();
        }

        private SCSServiceSoapClient ScsClient { get; }
        private TSessionInfo SessionInfo { get; set; }
        private Guid SessionGuid { get => this.SessionInfo.SessionGuid; }

        private async Task Login(string companyID, string userName, string password)
        {
            var args = new TLoginInputArgs { CompanyID = companyID, UserID = userName, Password = password };
            var json = JsonFunc.ObjectToJson(args);
            var resultData = await this.ScsClient.SystemObjectRunAsync(new TSystemObjectRunArgs { Action = ESystemObjectAction.Login, Format = ETransmissionFormat.Json, Value = json });
            var result = JsonFunc.JsonToObject<TLoginOutputResult>(resultData.Value);
            this.SessionInfo = result.SessionInfo;
        }

        private async Task GetCompanyItems()
        {
            var args = new TGetCompanyItemsInputArgs();
            var xml = BaseFunc.ObjectToXml(args);
            var result = await this.ScsClient.GetCompanyItemsAsync(new TWsGetCompanyItemsInputArgs());
        }

        private void Test()
        {
            var args = new TLoginInputArgs { CompanyID = "SCS003", UserID = "07001", Password = "scsadmin" };
            var xml = BaseFunc.ObjectToXml(args);
            var b = BaseFunc.XmlToObject<TLoginInputArgs>(xml);
        }
    }
}

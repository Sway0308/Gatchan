using Element.Core;
using ScsService;
using System;
using System.Data;
using System.IO;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ScsBusiness
{
    public class ScsProgram
    {
        public ScsProgram()
        {
            this.ScsService = new SCSServiceSoapClient(SCSServiceSoapClient.EndpointConfiguration.SCSServiceSoap, "http://localhost/scsweb/scsservice.asmx");
            this.Connect("SCS003", "07001", "scsadmin");
        }

        private SCSServiceSoapClient ScsService { get; }

        private Guid SessionGuid { get; set; }

        private void Connect(string companyID, string userID, string password)
        {
            var result = this.ScsService.LoginAsync(new TWsLoginInputArgs { CompanyID = companyID, UserID = userID, Password = password });
            this.SessionGuid = result.GetAwaiter().GetResult().SessionGuid;   
        }

        public async Task<DataSet> BOAdd(string progID)
        {
            var result = await this.ScsService.BOAddAsync(new TWsBOAddInputArgs { SessionGuid = this.SessionGuid, ProgID = progID });
            var xml = result.DataSet;

            var dataSet = new DataSet();
            dataSet.ReadXml(new StringReader(xml.ToString()));
            return dataSet;
            //var oSerializer = new XmlSerializer(typeof(DataSet));
            //
            //var a = xml.Nodes[1];
            //
            //var oStringReader = new StringReader(a.Value);
            //var oValue = oSerializer.Deserialize(oStringReader) as DataSet;
            //oStringReader.Close();
            //return oValue;
        }
    }
}

using ScsService;
using System;
using System.Threading.Tasks;

namespace ScsBusiness
{
    public class ScsProgram
    {
        public ScsProgram(string url, string companyID, string userID, string password)
        {
            this.ScsService = Connect(url, companyID, userID, password).GetAwaiter().GetResult();
        }

        private SCSServiceSoapClient ScsService { get; }

        private async Task<SCSServiceSoapClient> Connect(string url, string companyID, string userID, string password)
        {

            var client = new SCSServiceSoapClient(SCSServiceSoapClient.EndpointConfiguration.SCSServiceSoap, url);
            var result = await client.LoginAsync(new TWsLoginInputArgs { CompanyID = companyID, UserID = userID, Password = password });
            
        }
    }
}

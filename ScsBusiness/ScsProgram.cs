using Elementary;
using ScsBusiness.ScsService;
using System;
using System.Data;

namespace ScsBusiness
{
    public class ScsProgram
    {
        public ScsProgram()
        {
            this.ScsServices = new ScsService.SCSService();
            this.ScsServices.Url = @"http://localhost/scsweb/scsservice.asmx";
            var loginResult = this.ScsServices.Login(new ScsService.TWsLoginInputArgs { CompanyID = "SCS003", UserID = "07001", Password = "scsadmin" });
            this.SessionGuid = loginResult.SessionGuid;
        }

        private ScsService.SCSService ScsServices { get; }

        private Guid SessionGuid { get; }

        public DataTable Find(string progID)
        {
            var args = new TFindInputArgs();
            var json = JsonFunc.ObjectToJson(args);
            var result = this.ScsServices.BusinessObjectJson(this.SessionGuid.ToString(), progID, EBusinessObjectAction.Find, json);



            if (StrFunc.StrContains(result, "StackTrace"))
            {
                return null;
            }
            else
            {
                // 將回傳的 JSON 字串反序列化為物件
                var findResult = JsonFunc.JsonToObject<TFindOutputResult>(result);
                return findResult.DataTable;
            }
        }
    }
}

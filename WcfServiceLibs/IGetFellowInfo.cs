using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Data;
using System.Runtime.Serialization;
using WcfServiceLibs.Model;
using System.IO;


namespace WcfServiceLibs
{
    [ServiceContract]
    interface IGetFellowInfo
    {
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate=@"getFellows",BodyStyle = WebMessageBodyStyle.Bare,
            ResponseFormat= WebMessageFormat.Json)]
        List<SchoolFellow> getSchoolFellowsList(Stream data);
      
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = @"getFellowDetail?id={id}", ResponseFormat = WebMessageFormat.Json)]
        SchoolFellow getSchoolFellows(string id="0");
    }

  
}

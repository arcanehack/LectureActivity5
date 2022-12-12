using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace LectureActivity5
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        [WebGet(UriTemplate = "reverse?str={str}", ResponseFormat = WebMessageFormat.Json)]

        string reverse(string str);

        [OperationContract]
        [WebGet(UriTemplate = "sum?digits={digits}", ResponseFormat = WebMessageFormat.Json)]
        int sumOfDigits(int digits);

        [OperationContract]
        [WebGet(UriTemplate = "filter?str={str}", ResponseFormat = WebMessageFormat.Json)]
        string filter(string str);
    }
}

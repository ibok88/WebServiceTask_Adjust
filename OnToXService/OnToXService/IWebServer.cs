using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace OnToXService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IWebServer" in both code and config file together.
    [ServiceContract]
    public interface IWebServer
    {
        [OperationContract]
        List<int> GetJsonArray(int input_number);
    }
}

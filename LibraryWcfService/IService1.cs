using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace LibraryWcfService
{
    [ServiceContract]
    public interface ILibraryWCFService
    {
        [OperationContract]
        string GetBookContent(int code, string clientId);
    }

}

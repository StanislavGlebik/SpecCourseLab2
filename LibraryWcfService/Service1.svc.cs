using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace LibraryWcfService
{
    public class LibraryWCFService : ILibraryWCFService
    {
        List<string> booksContent = new List<string> { "Night watch", "Content", "content2", "content3" };
        private const string PRODUCT_ID = "9441878d-c071-4258-937d-6c226da8bc48";

        public string GetBookContent(int code, string clientId)
        {
            try
            {
                Register reg = new Register();
                bool isPaid;
                bool isPaidSpecified;
                reg.IsPaid(clientId, PRODUCT_ID, out isPaid, out isPaidSpecified);

                if (isPaidSpecified && isPaid)
                {
                    if (booksContent.Count() > code && code >= 0)
                    {
                        return booksContent[code];
                    }
                    return "No such content";
                }
                else {
                    return "You'll pay for this!!!!";
                }

            }
            catch (Exception)
            {
                return "Error happened!";
            }
        }
    }
}

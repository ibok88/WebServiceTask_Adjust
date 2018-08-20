using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Description;


namespace OnToXService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "WebServer" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select WebServer.svc or WebServer.svc.cs at the Solution Explorer and start debugging.
    public class WebServer : IWebServer
    {
        

        public List<int> GetJsonArray(int input_number)
        {
            int StartNumber = 1;
            var Collection_Numbers = new List<int>();
            

           
                if (input_number != 0 && input_number > StartNumber)
                {
                    for (int i = StartNumber; i < input_number + 1; i++)
                    {
                        Collection_Numbers.Add(i);
                    }
                }
                else
                {
                    return Collection_Numbers;
                
                }
            
            

            return Collection_Numbers;
        }
    }
}

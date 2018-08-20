using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Description;


namespace OnToXService
{
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

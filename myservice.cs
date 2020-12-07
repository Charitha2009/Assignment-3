using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace RESTservice
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IAddService
    {
       public String username(String id)
        {
            int id1 = Int32.Parse(id);
            IDictionary<int, string> numberNames = new Dictionary<int, string>();
            numberNames.Add(1, "Tush"); 
            numberNames.Add(2, "Solly");
            numberNames.Add(3, "Candy");
            numberNames.Add(4, "Chris");
            numberNames.Add(5, "William");
            numberNames.Add(6, "Jerry");
            numberNames.Add(7, "Amara");
            numberNames.Add(8, "Alex");
            numberNames.Add(9, "Sunny");
            numberNames.Add(10, "Stuart");
            numberNames.Add(11, "Bell");
            numberNames.Add(12, "Morgan");
            foreach (KeyValuePair<int, string> kvp in numberNames)
            {
                if(id1 == kvp.Key)
                {
                    return "Hello "+kvp.Value;
                }
            }
              //  Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
            return "User not found ";
        }


    }
}

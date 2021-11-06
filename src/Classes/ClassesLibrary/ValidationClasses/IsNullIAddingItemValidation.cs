using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class IsNullIAddingItemValidation
    {
        public List<string> list;

        public IsNullIAddingItemValidation()
        {

        }

        public IsNullIAddingItemValidation(string v1, string v2, string v3, string v4, string v5, string v6)
        {
            list = new List<string>();
            list.Add(v1);
            list.Add(v2);
            list.Add(v3);
            list.Add(v4);
            list.Add(v5);
            list.Add(v6);
            
            


        }


        public bool isNullValidation(List<string > listToCheck)
        {
            if (listToCheck.Any(x => x == string.Empty ))
            {
                return true;
            }
            else

            {
                return false;
            }
            
        }



        
    }
}

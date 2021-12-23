using System.Collections.Generic;
using System.Linq;

namespace ClassesLibrary
{
    public class IsNullIAddingItemValidation
    {
        public List<string> list;

        public IsNullIAddingItemValidation()
        {
        }

        public IsNullIAddingItemValidation(string bar_Number)
        {
            list = new List<string>();
            list.Clear();
            list.Add(bar_Number);
        }

        public IsNullIAddingItemValidation(string v1, string v2, string v3, string v4, string v5, string v6, string v7)
        {
            list = new List<string>();
            list.Clear();
            list.Add(v1);
            list.Add(v2);
            list.Add(v3);
            list.Add(v4);
            list.Add(v5);
            list.Add(v6);
            list.Add(v7);
        }

        public bool isNullValidation(List<string> listToCheck)
        {
            if (listToCheck.Any(x => x == string.Empty))
            {
                return true;
            }
            else

            {
                return false;
            }
        }

        public bool CheckSingleString(string word)
        {
            if (string.IsNullOrEmpty(word))
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
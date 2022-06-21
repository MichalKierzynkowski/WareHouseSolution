using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsLogic.ProductForm.Logic.Entities
{
    public class FilteringOption
    {
        public FilteringOption(string input)
        {
            Input = input;
        }

        public string Input { get; set; }

    }
}

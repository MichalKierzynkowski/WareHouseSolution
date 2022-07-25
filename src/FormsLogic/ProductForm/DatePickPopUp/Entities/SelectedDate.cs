using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsLogic.ProductForm.DatePickPopUp.Entities
{
    public class SelectedDate
    {
        public DateOnly DateFrom { get; set; }
        public DateOnly DateTo { get; set; }
        public SelectedDate(DateOnly dateFrom, DateOnly dateTo)
        {
            DateFrom = dateFrom;
            DateTo = dateTo;
        }
    }
}

namespace FormsLogic.ProductForm.DatePickPopUp.Entities
{
    public class SelectedDate
    {
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public SelectedDate(DateTime dateFrom, DateTime dateTo)
        {
            DateFrom = dateFrom;
            DateTo = dateTo;
        }
    }
}
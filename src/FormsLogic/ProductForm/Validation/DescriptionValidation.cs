namespace FormsLogic.ProductForm.Validation
{
    public class DescriptionValidation
    {
        public string Description { get; set; }

        public DescriptionValidation(string description)
        {
            Description = description;
        }

        public string ReturnValidateDescription()
        {
            if (Description == "------")
            {
                return null;
            }
            else
            {
                return Description;
            }
        }
    }
}
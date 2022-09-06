using ApplicationLayer.Dto.ProductDtos;

namespace FormsLogic.ProductForm.Validation
{
    public class DeleteProductValidation
    {
        public DeleteProductDto DeleteProductDto { get; set; }
        public bool IsFormatCorrect { get; set; }
        public DeleteProductValidation(DeleteProductDto deleteProductDto)
        {
            DeleteProductDto = deleteProductDto;
            ValidateDeleteProduct();
        }
        private void ValidateDeleteProduct()
        {
            if (DeleteProductDto.RegistrationNumber == 0)
            {
                IsFormatCorrect = false;
            }
            else
            {
                IsFormatCorrect = true;
            }
        }

    }
}

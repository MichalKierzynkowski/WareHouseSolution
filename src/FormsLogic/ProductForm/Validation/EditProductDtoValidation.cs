using ApplicationLayer.Dto.ProductDetailDtos;
using ApplicationLayer.Dto.ProductDtos;
using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsLogic.ProductForm.Validation
{
    public class EditProductDtoValidation : AbstractValidator<UpdateProductDto>
    {
        public bool IsExtraDescriptionOpen { get; set; }

        public EditProductDtoValidation(bool isExtraDescriptionOpen)
        {
            IsExtraDescriptionOpen = isExtraDescriptionOpen;
            RuleFor(x => x.EditProductDetailDto.Name).NotEmpty().WithMessage("Pole Nazwa Produktu nie może być puste!");
            RuleFor(x => x.EditProductDetailDto.ExtraDescription).Must(Description => CheckingStatusOfExtraDescription(Description)).WithMessage("Pole Opis Produktu nie może być puste!");
        }

        public bool CheckingStatusOfExtraDescription(string extraDescription)
        {
            if (IsExtraDescriptionOpen == true)
            {
                return !string.IsNullOrWhiteSpace(extraDescription);
            }
            else
            {
                return true;
            }
        }
    }
}
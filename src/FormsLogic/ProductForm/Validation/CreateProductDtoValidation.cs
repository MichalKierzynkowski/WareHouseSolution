using ApplicationLayer.Dto.ProductDtos;
using ApplicationLayer.Interfaces;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsLogic.ProductForm.Validation
{
    public class CreateProductDtoValidation : AbstractValidator<CreateProductDto>
    {
        public bool IsExtraDescriptionOpen { get; set; }
        public IProductService ProductService { get; set; }

        public CreateProductDtoValidation(bool isExtraDescriptionOpen, IProductService productService)
        {
            IsExtraDescriptionOpen = isExtraDescriptionOpen;
            ProductService = productService;
            RuleFor(x => x.RegistrationNumber).NotEmpty().WithMessage("Pole Numer Ewidencyjny nie może być puste!");
            RuleFor(x => x.RegistrationNumber).Must(RegistrationNumber => CheckAvailabilityOfRegisterNumber(RegistrationNumber)).WithMessage("Podany numer rejestracyjny znajduje się już w bazie!");
            RuleFor(x => x.CreateProductDetailDto.Name).NotEmpty().WithMessage("Pole Nazwa Produktu nie może być puste!");
            RuleFor(x => x.CreateProductDetailDto.ExtraDescription).Must(Description => CheckingStatusOfExtraDescription(Description)).WithMessage("Pole Opis Produktu nie może być puste!");
            RuleFor(x => x.CreateProductDetailDto.Type).NotEmpty().WithMessage("Pole Rodzaj Produktu nie może byc puste!");


        }

        public bool CheckingStatusOfExtraDescription(string extraDescription)
        {
            if (IsExtraDescriptionOpen)
            {
                return !string.IsNullOrWhiteSpace(extraDescription);
            }
            else
            {
                return true;
            }
        }
        public bool CheckAvailabilityOfRegisterNumber(int registrationNumber)
        {
            var product = ProductService.GetProductByRegistrationNumber(registrationNumber);
            if (product == null)
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
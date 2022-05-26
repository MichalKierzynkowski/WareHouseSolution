using ApplicationLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsLogic.ProductForm.Validation
{
    public class CheckRegisterNumberAvailability
    {
        public int RegisterNumber { get; set; }
        public string AvailabilityInformation { get; set; }
        public IProductService ProductService { get; set; }
        public string StatusCode { get; set; }

        public CheckRegisterNumberAvailability(decimal registerNumber, IProductService productService)
        {
            RegisterNumber = (int)registerNumber;
            ProductService = productService;
            IsRegisterNumberCorrect();
        }

        public void IsRegisterNumberCorrect()
        {
            if (RegisterNumber == 0)
            {
                AvailabilityInformation = "Pole numer ewidencyjny nie może być zerem!";
                StatusCode = "Failed";
            }
            else
            {
                IsThatNumberExistInDB();
            }
        }

        public void IsThatNumberExistInDB()
        {
            var product = ProductService.GetProductByRegistrationNumber(RegisterNumber);
            if (product == null)
            {
                AvailabilityInformation = "W bazie danych nie występuję Produkt z podanym numerem rejestracyjnym!";
                StatusCode = "Success";
            }
            else
            {
                AvailabilityInformation = "W bazie danych wystepuje już Produkt z podanym numerem rejestracyjnym!";
                StatusCode = "Failed";
            }
        }
    }
}
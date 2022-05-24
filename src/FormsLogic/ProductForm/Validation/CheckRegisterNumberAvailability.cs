using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsLogic.ProductForm.Validation
{
    public class CheckRegisterNumberAvailability
    {
        public decimal RegisterNumber { get; set; }
        public string AvailabilityInformation { get; set; }

        public CheckRegisterNumberAvailability(decimal registerNumber)
        {
            RegisterNumber = registerNumber;
            IsRegisterNumberCorrect();
        }

        public void IsRegisterNumberCorrect()
        {
            if (RegisterNumber == 0)
            {
                AvailabilityInformation = "Pole numer ewidencyjny nie może być zerem!";
            }
            else
            {
                IsThatNumberExistInDB();
            }
        }

        public void IsThatNumberExistInDB()
        {
        }
    }
}
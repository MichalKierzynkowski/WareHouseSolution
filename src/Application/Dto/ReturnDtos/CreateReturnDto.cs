using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.Dto.ReturnDtos
{
    public class CreateReturnDto
    {
        public int ProductRegistrationNumber { get; set; }
        public ICollection<Product> Products { get; set; }
        public int Quantity { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SellPrice { get; set; }
        public DateTime Date { get; set; }
        public string Unit { get; set; }
        public bool IsReturned { get; set; }
        public CreateReturnDto()
        {

        }
    }
}

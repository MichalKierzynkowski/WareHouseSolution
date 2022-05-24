using ApplicationLayer.Dto.ProductDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsLogic.ProductForm.Logic.Data
{
    public class ReturnDataFromDb
    {
        public IQueryable<ProductDto> Products { get; set; }

        public ReturnDataFromDb()
        {
        }
    }
}
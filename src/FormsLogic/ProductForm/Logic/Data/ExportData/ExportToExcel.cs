using ApplicationLayer.Dto.ProductDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsLogic.ProductForm.Logic.Data.ExportData
{
    public class ExportToExcel
    {
        public List<ProductDto> Products { get; set; }
        public ExportToExcel(List<ProductDto> products)
        {
            Products = products;
        }
        public void ExecuteExcelOperation()
        {

        }
    }
}

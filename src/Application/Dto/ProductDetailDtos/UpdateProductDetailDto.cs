using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.Dto.ProductDetailDtos
{
    public class UpdateProductDetailDto
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string? ExtraDescription { get; set; }
        public DateTime? LastChangedAt { get; set; }
    }
}
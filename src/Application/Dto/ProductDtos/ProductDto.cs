using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.Dto.ProductDtos
{
    public class ProductDto
    {
        public int RegistrationNumber { get; set; }
        public ProductDetail ProductDetail { get; set; }
        public DateTime AddedAt { get; set; }
    }
}
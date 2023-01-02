using ApplicationLayer.Dto.ProductDtos;
using Domain.Entities;

namespace ApplicationLayer.Dto.WareHouse
{
    public class CreateWareHouseDto:WareHouseDto
    {
        public int ProductRegistrationNumber { get; set; }
        public CreateWareHouseDto()
        {
                
        }

    }
}
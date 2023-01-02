using ApplicationLayer.Dto.WareHouse;
using ApplicationLayer.Dto.WareHouseDtos;
using ApplicationLayer.Interfaces;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;

namespace ApplicationLayer.Services
{
    public class WareHouseService:IWareHouseService
    {
        private readonly IWareHouseRepository _wareHouseRepository;
        private readonly IMapper _mapper;

        public WareHouseService(IWareHouseRepository wareHouseRepository,IMapper mapper)
        {
            _wareHouseRepository = wareHouseRepository;
            _mapper = mapper;
        }

        public IEnumerable<WareHouseDto> GetAllWareHouses()
        {
            var wareHouses = _wareHouseRepository.GetAll().ToList();
            return _mapper.Map<List<WareHouseDto>>(wareHouses);
        }

        public GetWareHouseForSaleDto GetWareHouseByIdForSale(int id)
        {
            var wareHouse = _wareHouseRepository.GetById(id);
            return _mapper.Map<GetWareHouseForSaleDto>(wareHouse);
        }

        public WareHouseDto AddNewWareHouse(CreateWareHouseDto newWareHouse)
        {
            var wareHouse = _mapper.Map<WareHouse>(newWareHouse);
            _wareHouseRepository.Add(wareHouse);
            return _mapper.Map<WareHouseDto>(wareHouse);
        }

       

    }
}
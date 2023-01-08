using ApplicationLayer.Dto.Sale;
using ApplicationLayer.Interfaces;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;

namespace ApplicationLayer.Services
{
    public class SaleService:ISaleService
    {
        private readonly ISaleRepository _saleRepository;
        private readonly IMapper _mapper;
        public SaleService(ISaleRepository saleRepository,IMapper mapper)
        {
            _saleRepository = saleRepository;
            _mapper=mapper;
        }
        public IEnumerable<SaleDto> GetAllSales()
        {
            var sales = _saleRepository.GetAll().ToList();
            return _mapper.Map<List<SaleDto>>(sales);
        }

        public SaleDto AddNewSale(CreateSaleDto newSale)
        {
            var sale = _mapper.Map<Sale>(newSale);
            _saleRepository.Add(sale);
            return _mapper.Map<SaleDto>(sale);
        }
    }
}

using ApplicationLayer.Dto.ReturnDtos;
using ApplicationLayer.Interfaces;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;

namespace ApplicationLayer.Services
{
    public class ReturnService:IReturnService
    {
        private readonly IReturnRepository _returnRepository;
        private readonly IMapper _mapper;

        public ReturnService(IReturnRepository returnRepository,IMapper mapper)
        {
            _returnRepository = returnRepository;
            _mapper = mapper;
        }
        public IEnumerable<ReturnDto> GetAllReturns()
        {
            var returns = _returnRepository.GetAll().ToList();
            return _mapper.Map<List<ReturnDto>>(returns);
        }

        public ReturnDto GetReturnById(int id)
        {
            throw new NotImplementedException();
        }

        public ReturnDto AddNewReturn(CreateReturnDto newReturn)
        {
           var returnItem =_mapper.Map<Return>(newReturn);
           _returnRepository.Add(returnItem);
           return _mapper.Map<ReturnDto>(returnItem);
        }

        public void DeleteReturnById(int id)
        {
            throw new NotImplementedException();
        }
    }
}

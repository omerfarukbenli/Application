using Application.Business.Abstract;
using Application.Entity.DTOs;
using Application.Entity.Models;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Application.API.Controllers
{
   
    public class SparepartsController : CustomBaseController
    {
        private readonly IMapper _mapper;
        private readonly IService<Sparepart> _service;

        public SparepartsController(IMapper mapper, IService<Sparepart> service)
        {
            _mapper = mapper;
            _service = service;
        }
        [HttpGet]
        public async Task<IActionResult> All()
        {
            var spareparts = await _service.GetAllAsync();
            var sparepartsDto = _mapper.Map<List<SparepartDto>>(spareparts.ToList());
            return CreateActionResult(CustomResponseDto<List<SparepartDto>>.Success(200, sparepartsDto));
        }
        [HttpPost]
        public async Task<IActionResult> Add(SparepartDto sparepartDto)
        {
            var sparepart = await _service.AddAsync(_mapper.Map<Sparepart>(sparepartDto));
            var sparepartDtos = _mapper.Map<SparepartDto>(sparepart);
            return CreateActionResult(CustomResponseDto<SparepartDto>.Success(200, sparepartDtos));
        }
            
    }
}

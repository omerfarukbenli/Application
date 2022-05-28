using Application.Business.Abstract;
using Application.DataAccess;
using Application.DataAccess.Abstract;
using Application.Entity.DTOs;
using Application.Entity.Models;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Application.API.Controllers
{

    public class ProductsController : CustomBaseController
    {
        private readonly IMapper _mapper;
        private readonly IService<Product> _servise;
        private readonly IProductRepository _productRepository;

        public ProductsController(IMapper mapper, IService<Product> servise, IProductRepository productRepository)
        {
            _mapper = mapper;
            _servise = servise;
            _productRepository = productRepository;

        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            var products = await _servise.GetAllAsync();
            var productsDto = _mapper.Map<List<ProductWithSparepartDto>>(products.ToList());
            return CreateActionResult(CustomResponseDto<List<ProductWithSparepartDto>>.Success(200, productsDto));
        }
        [HttpPost]
        public async Task<IActionResult> Add(ProductWithSparepartDto productDto)
        {
            var product = await _servise.AddAsync(_mapper.Map<Product>(productDto));
            var productsDto = _mapper.Map<ProductWithSparepartDto>(product);
            return CreateActionResult(CustomResponseDto<ProductWithSparepartDto>.Success(200, productsDto));
        }
        //[HttpPut]
        //public async Task<IActionResult> Update(ProductDto productDto)
        //{
        //    await _servise.UpdateAsync(_mapper.Map<Product>(productDto));
        //    return CreateActionResult(CustomResponseDto<ProductDto>.Success(200, productDto));
        //}
        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            var product = await _servise.GetByIdAsync(id);
            await _servise.RemoveAsync(product);
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(200));
            // return CreateActionResult(CustomResponseDto<ProductDto>.Success(200)); böylede oluyor, nocontentdto'ya gerek yok
        }

        //[HttpPost]
        //public Task<Object> AddAsync(ProductWithSparepartDto productDto)
        //{

        //    var product = _productRepository.AddAsync(productDto);
        //    var productsDto = _mapper.Map<ProductWithSparepartDto>(product);
        //    return (Task<object>)CreateActionResult(CustomResponseDto<ProductWithSparepartDto>.Success(200, productsDto));
        //}
    }
}

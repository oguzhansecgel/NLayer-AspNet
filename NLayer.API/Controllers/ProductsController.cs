using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NLayer.Core.DTOs;
using NLayer.Core.Models;
using NLayer.Core.Services;

namespace NLayer.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductsController : CustomBaseController
	{
		private readonly IMapper _mapper;
		private readonly IService<Product> _productService;

		public ProductsController(IMapper mapper, IService<Product> productService)
		{
			_mapper = mapper;
			_productService = productService;
		}

		[HttpGet]
		public async Task<IActionResult> All()
		{
			var products = await _productService.GetAllAsync();

			var productsDtos = _mapper.Map<List<ProductDto>>(products.ToList());
			return CreateActionResult(CustomResponseDto<List<ProductDto>>.Success(200, productsDtos));
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> GetById(int id)
		{
			var products = await _productService.GetByIdAsync(id);

			var productsDtos = _mapper.Map<ProductDto>(products);
			return CreateActionResult(CustomResponseDto<ProductDto>.Success(200, productsDtos));
		}


		[HttpPost]
		public async Task<IActionResult> Save(ProductDto product)
		{
			var products = await _productService.AddAsync(_mapper.Map<Product>(product));

			var productsDtos = _mapper.Map<ProductDto>(products);
			return CreateActionResult(CustomResponseDto<ProductDto>.Success(201, productsDtos));
		}

		[HttpPut]
		public async Task<IActionResult> Update(ProductDto product)
		{
			 await _productService.UpdateAsync(_mapper.Map<Product>(product));

			return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
		}
	}
}

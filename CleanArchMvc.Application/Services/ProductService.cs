using AutoMapper;
using CleanArchMvc.Application.DTOs;
using CleanArchMvc.Application.Interfaces;
using CleanArchMvc.Domain.Entities;
using CleanArchMvc.Domain.Interfaces;

namespace CleanArchMvc.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public ProductService(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository ?? 
                throw new ArgumentNullException(nameof(productRepository));
            _mapper = mapper;
        }
        public async Task Add(ProductDTO productDTO)
        {
            var ProductEntity = _mapper.Map<Product>(productDTO);
            await _productRepository.Create(ProductEntity);
        }

        public async Task<ProductDTO> GetById(int? id)
        {
            var ProductEntity = await _productRepository.GetById(id); 
            return _mapper.Map<ProductDTO>(ProductEntity);
        }

        public async Task<IEnumerable<ProductDTO>> GetProducts()
        {
            var ListProductEntity = await _productRepository.GetProduct();
            return _mapper.Map<IEnumerable<ProductDTO>>(ListProductEntity);            
        }

        public async Task Remove(int? id)
        {
            var ProductEntity = await _productRepository.GetById(id);
            await _productRepository.Remove(ProductEntity);
        }

        public async Task Update(ProductDTO productDTO)
        {
            var ProductEntity = _mapper.Map<Product>(productDTO);
            await _productRepository.Update(ProductEntity);
        }
    }
}

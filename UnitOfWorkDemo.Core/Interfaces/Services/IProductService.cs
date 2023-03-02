using Models.Entities;

namespace Abstractions.Interfaces.Services
{
    public interface IProductService
    {
        Task<bool> CreateProduct(ProductDetails productDetails);

        Task<IEnumerable<ProductDetails>> GetAllProducts();

        Task<ProductDetails> GetProductById(int productId);

        Task<bool> UpdateProduct(ProductDetails productDetails);

        Task<bool> DeleteProduct(int productId);
    }
}

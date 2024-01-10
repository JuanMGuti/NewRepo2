using ProyectoFinalProto.Models;

namespace ProyectoFinalProto.Services.ProductService
{
    public interface IProductRepository
    {

        Task<bool> AddUpdateProductAsync(ProductInfo productInfo);

        Task<bool> DeleteProductAsync(int ProductId);

        Task<ProductInfo> GetProductAsync(int ProductId);

        Task<IEnumerable<ProductInfo>> GetProductAsync();

    }
}

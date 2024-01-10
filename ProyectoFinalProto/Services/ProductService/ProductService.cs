using ProyectoFinalProto.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalProto.Services.ProductService
{
    public class ProductService : IProductRepository
    {
        public SQLiteAsyncConnection _database;
        public ProductService(string dbPath) 
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<ProductInfo>().Wait();
        }
        public async Task<bool> AddUpdateProductAsync(ProductInfo productInfo)
        {
            if(productInfo.ProductId > 0)
            {
                await _database.UpdateAsync(productInfo);
            }
            else
            {
                await _database.InsertAsync(productInfo);
            }
            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteProductAsync(int productId)
        {
            await _database.DeleteAsync<ProductInfo>(productId);
            return await Task.FromResult(true);
        }

        public async Task<ProductInfo> GetProductAsync(int productId)
        {
            return await _database.Table<ProductInfo>().Where(p => p.ProductId == productId).FirstOrDefaultAsync(); ;
        }

        public async Task<IEnumerable<ProductInfo>> GetProductAsync()
        {
            return await Task.FromResult(await _database.Table<ProductInfo>().ToListAsync());
        }
    }
}

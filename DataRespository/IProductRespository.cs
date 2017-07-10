using AspNetCore_RestApiWithDapper.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AspNetCore_RestApiWithDapper.DataRespository
{
    public interface IProductRepository
    {
        Task<Product> GetAsync(long id);

        Task<List<Product>> GetAllAsync();

        Task<int> AddAsync(Product product);
    }
}

using AspNetCore_RestApiWithDapper.Contracts;
using AspNetCore_RestApiWithDapper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore_RestApiWithDapper.Business
{
    public interface IProductBusiness
    {
        Task<ProductResponse> GetAsync(long id);

        Task<ProductResponse> GetAllAsync();

        Task<int> AddAsync(ProductRequest productRequest);
    }
}

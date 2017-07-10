using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCore_RestApiWithDapper.Contracts;
using AspNetCore_RestApiWithDapper.Models;
using System.Data;
using System.Data.SqlClient;
using Dapper;

namespace AspNetCore_RestApiWithDapper.DataRespository
{
    public class ProductRepository : IProductRepository
    {
        private readonly string _connectionString;
        private IDbConnection _connection { get { return new SqlConnection(_connectionString); } }

        public ProductRepository()
        {
            // TODO: It will be refactored...
            _connectionString = "Server=.;Database=RESTfulSampleDb;Trusted_Connection=True;MultipleActiveResultSets=true";
        }


        public async Task<int> AddAsync(Product product)
        {
            string query = @"INSERT INTO [dbo].[Products] (
                                [Id],
                                [CategoryId],
                                [Name],
                                [Description],
                                [Price],
                                [CreatedDate]) VALUES (
                                @Id,
                                @CategoryId,
                                @Name,
                                @Description,
                                @Price,
                                @CreatedDate)";

            var result = await _connection.ExecuteAsync(query, product);

            return result;
        }

        public async Task<List<Product>> GetAllAsync()
        {
            //TODO: Paging...

            string query = @"SELECT [Id] ,[CategoryId]
                                ,[Name]
                                ,[Description]
                                ,[Price]
                                ,[CreatedDate]
                                FROM [dbo].[Products]";

            var product = await _connection.QueryAsync(query);

            return product.Cast<Product>().ToList();
        }

        public async Task<Product> GetAsync(long id)
        {
            string query = @"SELECT [Id] ,[CategoryId]
                                ,[Name]
                                ,[Description]
                                ,[Price]
                                ,[CreatedDate]
                                FROM [dbo].[Products]
                                WHERE [Id] = @Id";

            //var product = await _connection.QueryFirstOrDefaultAsync(query, param);
            var product = await _connection.QueryAsync(query, new { @Id = id });

            return product.Cast<Product>().ToList().FirstOrDefault();
        }
    }
}

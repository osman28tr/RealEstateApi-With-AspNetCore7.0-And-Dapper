using Dapper;
using RealEstate_Dapper_Api.Dtos.CategoryDtos;
using RealEstate_Dapper_Api.Models.DapperContext;

namespace RealEstate_Dapper_Api.Repositories.CategoryRepository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly Context _context;

        public CategoryRepository(Context context)
        {
            _context = context;
        }
        public async Task<List<ResultCategoryDto>> GetAllAsync()
        {
            string query = "select * from Category";
            using (var _connection = _context.CreateConnection())
            {
                var values = await _connection.QueryAsync<ResultCategoryDto>(query);
                return values.ToList();
            }
        }
    }
}

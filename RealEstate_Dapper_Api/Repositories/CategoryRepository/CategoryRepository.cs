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

        public async void CreateCategoryAsync(CreateCategoryDto categoryDto)
        {
            string query = "insert into Category (CategoryName,CategoryStatus) values(@categoryname,@categorystatus)";
            var parameters = new DynamicParameters();
            parameters.Add("@categoryName",categoryDto.CategoryName);
            parameters.Add("@categoryStatus", true);
            using (var _connection = _context.CreateConnection())
            {
                await _connection.ExecuteAsync(query, parameters);
            }
        }

        public async void DeleteCategory(int id)
        {
            string query = "Delete from Category where CategoryId = @id";
            using (var _connection = _context.CreateConnection())
            {
                await _connection.ExecuteAsync(query, new { id });
            }
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

        public async void UpdateCategoryAsync(UpdateCategoryDto categoryDto)
        {
            string query = "Update Category set CategoryName=@CategoryName, CategoryStatus=@CategoryStatus where CategoryId=@CategoryId";
            using (var _connection = _context.CreateConnection())
            {
                await _connection.ExecuteAsync(query, new { categoryDto.CategoryName, categoryDto.CategoryStatus, categoryDto.CategoryId });
            }
        }
    }
}

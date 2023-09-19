using Dapper;
using RealEstate_Dapper_Api.Dtos.CategoryDtos;
using RealEstate_Dapper_Api.Dtos.ServiceDtos;
using RealEstate_Dapper_Api.Models.DapperContext;

namespace RealEstate_Dapper_Api.Repositories.ServiceRepository
{
    public class ServiceRepository : IServiceRepository
    {
        private readonly Context _context;

        public ServiceRepository(Context context)
        {
            _context = context;
        }

        public void CreateServiceAsync(CreateServiceDto categoryDto)
        {
            throw new NotImplementedException();
        }

        public void DeleteService(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ResultServiceDto>> GetAllAsync()
        {
            string query = "select * from Service";
            using (var _connection = _context.CreateConnection())
            {
                var values = await _connection.QueryAsync<ResultServiceDto>(query);
                return values.ToList();
            }
        }

        public Task<GetByIdServiceDto> GetService(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateServiceAsync(UpdateServiceDto categoryDto)
        {
            throw new NotImplementedException();
        }
    }
}

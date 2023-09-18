using Dapper;
using RealEstate_Dapper_Api.Dtos.WhoWheAreDtos;
using RealEstate_Dapper_Api.Models.DapperContext;

namespace RealEstate_Dapper_Api.Repositories.WhoWeAreRepository
{
    public class WhoWheAreRepository : IWhoWeAreRepository
    {
        private readonly Context _context;

        public WhoWheAreRepository(Context context)
        {
            _context = context;
        }
        public async Task<List<ResultWhoWeAreDto>> GetAllAsync()
        {
            string query = "select * from WhoWeAreDetail";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultWhoWeAreDto>(query);
                return values.ToList();
            }
        }
    }
}

using Dapper;
using RealEstate_Dapper_Api.Dtos.BottomGridDtos;
using RealEstate_Dapper_Api.Dtos.PopularLocationDtos;
using RealEstate_Dapper_Api.Models.DapperContext;

namespace RealEstate_Dapper_Api.Repositories.PopularLocationRepositories
{
	public class PopularLocationRepository : IPopularLocationRepository
	{
		private readonly Context _context;

		public PopularLocationRepository(Context context)
		{
			_context = context;
		}

		public async Task<List<ResultPopularLocationDto>> GetAllAsync()
		{
			string query = "select * from PopularLocations";
			using (var _connection = _context.CreateConnection())
			{
				var values = await _connection.QueryAsync<ResultPopularLocationDto>(query);
				return values.ToList();
			}
		}
	}
}

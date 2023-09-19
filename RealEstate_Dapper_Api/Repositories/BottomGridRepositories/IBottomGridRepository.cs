using RealEstate_Dapper_Api.Dtos.BottomGridDtos;
using RealEstate_Dapper_Api.Dtos.ServiceDtos;

namespace RealEstate_Dapper_Api.Repositories.BottomGridRepository
{
    public interface IBottomGridRepository
    {
        Task<List<ResultBottomGridDto>> GetAllAsync();
        void CreateBottomGridAsync(CreateBottomGridDto createBottomGridDto);
        void DeleteBottomGrid(int id);
        void UpdateBottomGridAsync(UpdateBottomGridDto updateBottomGridDto);
        Task<GetBottomGridDto> GetBottomGrid(int id);
    }
}

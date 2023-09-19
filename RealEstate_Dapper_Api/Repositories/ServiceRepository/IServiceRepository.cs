using RealEstate_Dapper_Api.Dtos.CategoryDtos;
using RealEstate_Dapper_Api.Dtos.ServiceDtos;

namespace RealEstate_Dapper_Api.Repositories.ServiceRepository
{
    public interface IServiceRepository
    {
        Task<List<ResultServiceDto>> GetAllAsync();
        void CreateServiceAsync(CreateServiceDto categoryDto);
        void DeleteService(int id);
        void UpdateServiceAsync(UpdateServiceDto categoryDto);
        Task<GetByIdServiceDto> GetService(int id);
    }
}

using RealEstate_Dapper_Api.Dtos.CategoryDtos;
using RealEstate_Dapper_Api.Dtos.ServiceDtos;

namespace RealEstate_Dapper_Api.Repositories.ServiceRepository
{
    public interface IServiceRepository
    {
        Task<List<ResultServiceDto>> GetAllAsync();
        void CreateServiceAsync(CreateServiceDto createServiceDto);
        void DeleteService(int id);
        void UpdateServiceAsync(UpdateServiceDto updateServiceDto);
        Task<GetByIdServiceDto> GetService(int id);
    }
}

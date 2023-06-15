using TestTaskForInformDevelopment.Data;

namespace TestTaskForInformDevelopment.Interfaces
{
    public interface IPropertyRepository
    {
        Task<Property> GetPropertyById(int propertyId);
        Task<List<Property>> GetAllProperties();
        Task CreateProperty(Property property);
        Task UpdateProperty(Property property);
        Task DeleteProperty(int propertyId);
        
    }
}

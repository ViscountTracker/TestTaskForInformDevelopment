using System;
using TestTaskForInformDevelopment.Data;
using TestTaskForInformDevelopment.Interfaces;

public class PropertyRepository : IPropertyRepository
{
    private readonly YourDbContext _dbContext;//TODO: AddYourDbContext and conection with DB replace name "YourDbContext"

    public PropertyRepository(YourDbContext dbContext) 
    {
        _dbContext = dbContext;// ?? throw new ArgumentNullException(nameof(dbContext)); /*TODO: I need knew add this */
    }
    public async Task<Property> GetPropertyById(int propertyId)
    {
        return await _dbContext.Properties.FindAsync(propertyId);
    }

    public async Task<List<Property>> GetAllProperties()
    {
        return await _dbContext.Properties.ToListAsync();
    }

    public async Task CreateProperty(Property property)
    {
        _dbContext.Properties.Add(property);
        await _dbContext.SaveChangesAsync();
    }

    public async Task UpdateProperty(Property property)
    {
        _dbContext.Properties.Update(property);
        await _dbContext.SaveChangeAsync();
    }

    public async Task DeleteProperty(int propertyId) 
    {
        var property = await _dbContext.Properties.FindAsync();
        if (property != null)
        {
            _dbContext.Properties.Remove(property); 
            await _dbContext.SaveChangesAsync();
        }
    }
}

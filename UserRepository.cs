using System;
using TestTaskForInformDevelopment.Data;
using TestTaskForInformDevelopment.Interfaces;

public class UserRepository : IUserRepository
{
    private readonly YourDbContext _dbContext;//TODO: AddYourDbContext and conection with DB replace name "YourDbContext"

    public UserRepository(YourDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<User> GetUserById(string userId)
    {
        return await _dbContext.Users.FindAsync(userId);
    }

    public async Task<List<User>> GetAllUsers()
    {
        return await _dbContext.Users.ToListAsync();
    }
    public async Task CreateUser(User user)
    {
        _dbContext.Users.Add(user);
        await _dbContext.SaveChangesAsync();
    }

    public async Task UpdateUser(User user) { 
        _dbContext.Users.Update(user);
        await _dbContext.SaveChangesAsync();
    }

    public async Task DeleteUser(string userId)
    {
        var user = await _dbContext.Users.FindAsync(userId);
        if (user != null)
        {
            _dbContext.Users.Remove(user);
            await _dbContext.SaveChangesAsync();
        }
    }

}


using TestTaskForInformDevelopment.Data;

namespace TestTaskForInformDevelopment.Interfaces
{
    public interface IUserRepository
    {
        Task<User> GetUserById(string userId);
        Task<List<User>> GetAllUsers();

        Task CreateUser(User user);
        Task UpdateUser(User user);
        Task DeleteUser(string userId);

    }
}

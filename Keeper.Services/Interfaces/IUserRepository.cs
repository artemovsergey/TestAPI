namespace Keeper.Services.Interfaces;

public interface IUserRepository
{
    public IEnumerable<User?> GetUsers();

    public User? GetUserById(int id);

    public void AddUser(User user);

    public void UpdateUser(User user);

    public void DeleteUser(int userId);
}

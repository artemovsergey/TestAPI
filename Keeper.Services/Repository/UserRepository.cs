using Keeper.Services.Interfaces;
using Microsoft.Extensions.Logging;

namespace Keeper.Services.Repository;

public class UserRepository : IUserRepository
{
    private readonly ILogger<UserRepository> _logger;
    private readonly TestDbContext _db; 

    public UserRepository(ILogger<UserRepository> logger, TestDbContext db)
    {
        _logger = logger;
        _db = db;
    }


    public IEnumerable<User> GetUsers()
    {
        return _db.Users.ToList();
    }

    public User? GetUserById(int id)
    {
        var user = _db.Users.Where(p => p.Id == id).FirstOrDefault();
        return user;
    }

    public void AddUser(User? user)
    {
        _db.Users.Add(user);
        try
        {
            _db.SaveChanges();
            _logger.LogInformation("AddUser");
        }
        catch (Exception ex)
        {
            _logger.LogError($"Error: {ex}");
        }
    }

    public void UpdateUser(User user)
    {
        _db.Users.Update(user);
        try
        {
            _db.SaveChanges();
            _logger.LogInformation("UpdateUser");
        }
        catch (Exception ex)
        {
            _logger.LogError($"Error: {ex}");
        }
    }

    public void DeleteUser(int userId)
    {
        var user =_db.Users.Where(p => p.Id == userId).FirstOrDefault();

        if(user != null)
        {
            _db.Users.Remove(user);
            try
            {
                _db.SaveChanges();
                _logger.LogInformation("DeleteUser");
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error: {ex}");
            }
        }
    }
}


using Domain;

namespace Application.Interfaces;

public interface IUserAccessor
{
    string GetuserId();
    Task<User> GetUserAsync();
    Task<User> GetUserWithPhotosAsync();
}

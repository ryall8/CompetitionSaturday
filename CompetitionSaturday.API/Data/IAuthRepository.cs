using System.Threading.Tasks;
using CompetitionSaturday.API.Models;

namespace CompetitionSaturday.API.Data
{
    public interface IAuthRepository
    {
         Task<User> Register(User user, string password);
         Task<User> Login(string username, string passoword);
         Task<bool> UserExists(string username);
    }
}
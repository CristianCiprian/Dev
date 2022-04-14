using PasswordGenerate.DataModels;
using PaswordGenerate.DataModels;
using System.Threading.Tasks;

namespace PaswordGenerate.Web.Services
{
    public interface IPasswordServices
    {
        Task<PasswordResponse> GetPasswordResponses(string userId);

        Task<PasswordResponse> PasswordGenerate(User user);

        Task<int> CheckPassword(string password);
    }
}

using PasswordGenerate.DataModels;
using System.Threading.Tasks;

namespace PaswordGenerate.Web.Services
{
    public interface IPasswordServices
    {
        Task<PasswordResponse> GetPasswordResponses(string userId);

        Task<int> CheckPassword(string password);
    }
}

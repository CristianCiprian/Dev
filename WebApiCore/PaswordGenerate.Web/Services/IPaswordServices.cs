using PasswordGenerate.DataModels;
using System.Threading.Tasks;

namespace PaswordGenerate.Web.Services
{
    public interface IPaswordServices
    {
        Task<PaswordResponse> GetPaswordResponses(string userId);
    }
}

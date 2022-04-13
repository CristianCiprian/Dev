using Microsoft.AspNetCore.Components;
using PasswordGenerate.DataModels;
using System.Net.Http;
using System.Threading.Tasks;

namespace PaswordGenerate.Web.Services
{
    public class PaswordServices : IPaswordServices
    {
        private readonly HttpClient httpClient;

        public PaswordServices(HttpClient _httpClient)
        {
            this.httpClient = _httpClient;
        }

        public async Task<PaswordResponse> GetPaswordResponses(string userId)
        {
            return await httpClient.GetJsonAsync<PaswordResponse>("Pasword/Pasword/{userId}");
        }
    }
}

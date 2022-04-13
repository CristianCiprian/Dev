using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using PasswordGenerate.DataModels;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace PaswordGenerate.Web.Services
{
    public class PaswordServices : IPaswordServices
    {
        IConfiguration _configuration;
        const string API_URI = "APIURI";

        public PaswordServices(IConfiguration configuration)
        {
            this._configuration = configuration;
        }
        public async Task<PaswordResponse> GetPaswordResponses(string userId)
        {
            PaswordResponse objectResponse = new PaswordResponse();

            try
            {
                using (var client = new HttpClient()) 
                {
                    client.BaseAddress = new Uri(this._configuration[API_URI]);
                    var action = string.Format("API/Pasword/{0}", userId);
                    var response = await client.GetAsync(action);
                    if (response.IsSuccessStatusCode)
                    {
                        var resultString = await response.Content.ReadAsStringAsync();
                        objectResponse = JsonConvert.DeserializeObject<PaswordResponse>(resultString);

                        return objectResponse;

                    }
                }
            }
            catch (System.Exception ex)
            {

                throw ex;
            }

            return objectResponse;
        }
    }
}

using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using PasswordGenerate.DataModels;
using PaswordGenerate.DataModels;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PaswordGenerate.Web.Services
{
    public class PasswordServices : IPasswordServices
    {
        IConfiguration _configuration;
        const string API_URI = "APIURI";

        public PasswordServices(IConfiguration configuration)
        {
            this._configuration = configuration;
        }

        public async Task<PasswordResponse> GetPasswordResponses(string userId)
        {
            PasswordResponse objectResponse = new PasswordResponse();

            try
            {
                using (var client = new HttpClient()) 
                {
                    client.BaseAddress = new Uri(this._configuration[API_URI]);
                    var action = string.Format("api/password/{0}", userId);
                    var response = await client.GetAsync(action);
                    if (response.IsSuccessStatusCode)
                    {
                        var resultString = await response.Content.ReadAsStringAsync();
                        objectResponse = JsonConvert.DeserializeObject<PasswordResponse>(resultString);

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

        public async Task<PasswordResponse> PasswordGenerate(User user)
        {
            PasswordResponse objectResponse = new PasswordResponse();

            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(this._configuration[API_URI]);
                    var action = string.Format("api/password/generate");

                    var jsonData = JsonConvert.SerializeObject(user, Formatting.None, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All });

                    var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

                    var response = await client.PostAsync(action, content);
                    
                    if (response.IsSuccessStatusCode)
                    {
                        var resultString = await response.Content.ReadAsStringAsync();
                        objectResponse = JsonConvert.DeserializeObject<PasswordResponse>(resultString);

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

        public async Task<int> CheckPassword(string password)
        {
            int objectResponse = 0;

            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(this._configuration[API_URI]);
                    var action = string.Format("api/password/check/{0}", password);
                    var response = await client.GetAsync(action);
                    if (response.IsSuccessStatusCode)
                    {
                        var resultString = await response.Content.ReadAsStringAsync();
                        objectResponse = JsonConvert.DeserializeObject<int>(resultString);

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

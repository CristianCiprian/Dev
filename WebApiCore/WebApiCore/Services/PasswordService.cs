using PasswordGenerate.DataModels;
using PaswordGenerate.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using WebApiCore.Cache;
using WebApiCore.Framework;
using WebApiCore.Helpers;

namespace WebApiCore.Services
{
    public class PasswordService : IPasswordService
    {
        
        public async Task<PasswordResponse> GeneratePassword(int userId, DateTime dateTime) {

            if (dateTime == DateTime.MinValue)
            {
                dateTime = DateTime.Now;
            }
           
            string oneTimePassword = dateTime.Day.ToString();
            oneTimePassword += dateTime.Month.ToString();
            oneTimePassword += dateTime.Year.ToString();
            oneTimePassword += dateTime.Hour.ToString();
            oneTimePassword += dateTime.Minute.ToString();
            oneTimePassword += dateTime.Second.ToString();
            oneTimePassword += dateTime.Millisecond.ToString();
            oneTimePassword += dateTime.ToString();            

            PasswordResponse passwordResponse = new PasswordResponse();

            TotpHelper totpHelper = new TotpHelper(Base32EncodingHelper.ToBytes(oneTimePassword));

            passwordResponse.Password = await totpHelper.ComputeTotp();
            passwordResponse.UserId = userId;
            passwordResponse.DateTimePasswordStarted = DateTime.Now;        
            passwordResponse.DateTimePasswordEnded = DateTime.Now.AddSeconds(30);

            //await savePassword()
             CacheForPassword.Instance.PasswordResponses.Add(passwordResponse);
                        
            return passwordResponse;
        }

        public async Task<int> CheckPassword(string password)
        {
            int i=0;

            if(CacheForPassword.Instance.PasswordResponses.Where(x => x.Password == password && x.DateTimePasswordEnded > DateTime.Now).Count() > 0)
            {
                i = 1;
            }
           
            return i;
        }


    }
}

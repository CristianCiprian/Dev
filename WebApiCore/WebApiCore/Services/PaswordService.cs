using PasswordGenerate.DataModels;
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
    public class PaswordService : IPaswordService
    {
                
        public async Task<PaswordResponse> GeneratePasword(int UserId, DateTime dateTime) {
            
            if (dateTime == DateTime.MinValue) {
                dateTime = DateTime.Now;
            }

            string oneTimePassword =  dateTime.Day.ToString();
            oneTimePassword += dateTime.Month.ToString();
            oneTimePassword += dateTime.Year.ToString();
            oneTimePassword += dateTime.Hour.ToString();
            oneTimePassword += dateTime.Minute.ToString();
            oneTimePassword += dateTime.Second.ToString();
            oneTimePassword += dateTime.Millisecond.ToString();
            oneTimePassword += UserId.ToString();            

            PaswordResponse paswordRespons = new PaswordResponse();

            var totp = new TotpHeper(Base32EncodingHelper.ToBytes(oneTimePassword));

            paswordRespons.Pasword = await totp.ComputeTotp();
            paswordRespons.UserId = UserId;
            paswordRespons.DateTimePaswordStarted = DateTime.Now.ToString("yyyy/MM/dd - HH:mm:ss", System.Globalization.CultureInfo.GetCultureInfo("en-US"));            
            paswordRespons.DateTimePaswordEnded = DateTime.Now.AddSeconds(30).ToString("yyyy/MM/dd - HH:mm:ss", System.Globalization.CultureInfo.GetCultureInfo("en-US"));

            //await savePassword()
             CacheForPassword.Instance.PaswordResponses.Add(paswordRespons);
                        
            return paswordRespons;
        }

        #region Allianz
        //public static string IdShortenerAlhpabet {
        //    get {
        //        return "jxd2GreiHYNcDPRkt4QE9FT8s1ZKJwOn5zlLCa7ImMBqogb3Uhv6p0fAVSWuyX";
        //    }
        //}

        //private static string IdShortenerProtectionSecretKey {
        //    get {
        //        return "xyz";
        //    }
        //}

        //private static int IdControlValueLength = 3;
        //private static int ProcessShortCodeValueLength = 2;
        //public static readonly int calculationBase = IdShortenerAlhpabet.Length;
        //public static string ComputeSecureIdHash(string input) {

        //    return GetHMACMD5Hash(IdShortenerProtectionSecretKey, input);

        //}

        //public static string ComputeShortId(long idValue) {
        //    if (idValue == 0) return IdShortenerAlhpabet[0].ToString();
        //    string s = string.Empty;

        //    while (idValue > 0) {
        //        s += IdShortenerAlhpabet[(int)(idValue % calculationBase)];
        //        idValue = idValue / calculationBase;
        //    }

        //    return string.Join(string.Empty, s.Reverse());
        //}

        //public static PaswordResponse ComputeSecureIdData(long IdValue, string data) {
        //    string IdValueShorted;
        //    string ControlHashValue;
        //    string IdControlValue= string.Empty;
        //    PaswordResponse paswordRespons = new PaswordResponse();

        //    IdValueShorted = ComputeShortId(IdValue);
            

        //    ControlHashValue = ComputeSecureIdHash(IdValueShorted);


        //    if (ControlHashValue.Length >= IdControlValueLength) {

        //        IdControlValue = ControlHashValue.Substring(0, IdControlValueLength);

        //    }



        //    paswordRespons.Pasword = $"{IdValueShorted}{IdControlValue}";



        //    return paswordRespons;

        //}

        //public static string GetHMACMD5Hash(string key, string data) {

        //    byte[] bKey, bData, bResult;           

        //    StringBuilder sbResult = new StringBuilder();
        //    UTF8Encoding encoder = new UTF8Encoding();

        //    bKey = encoder.GetBytes(key);
        //    bData = encoder.GetBytes(data);

        //    HMACMD5 hasher = new HMACMD5(bKey);

        //    bResult = hasher.ComputeHash(bData);

        //    foreach (byte b in bResult) {

        //        sbResult.AppendFormat("{0:x2}", b);

        //    }

        //    return sbResult.ToString();

        //}
        #endregion Allianz
         
    }
}

using PasswordGenerate.DataModels;
using System;
using System.Collections.Generic;

namespace WebApiCore.Cache
{
    public sealed class CacheForPassword
    {
        private CacheForPassword()
        {

        }

        private static CacheForPassword instance = null;
        public static CacheForPassword Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CacheForPassword();
                }
                return instance;
            }
        }

        private List<PaswordResponse> paswordResponses = new List<PaswordResponse>(); 

        public List<PaswordResponse> PaswordResponses
        {
            get { return paswordResponses; }
            set { paswordResponses = value; }
        }
    }
}

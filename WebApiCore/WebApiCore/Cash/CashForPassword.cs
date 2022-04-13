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

        private List<PasswordResponse> passwordResponses = new List<PasswordResponse>(); 

        public List<PasswordResponse> PasswordResponses
        {
            get { return passwordResponses; }
            set { passwordResponses = value; }
        }
    }
}

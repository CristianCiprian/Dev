using System;
using System.Collections.Generic;
using WebApiCore.Models;

namespace WebApiCore.Cash
{
    public sealed class CashForPassword
    {
        private CashForPassword()
        {

        }

        private static CashForPassword instance = null;
        public static CashForPassword Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CashForPassword();
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

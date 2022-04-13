using PasswordGenerate.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiCore.Framework
{
    public interface  IPaswordService
    {
        Task<PaswordResponse> GeneratePasword(int UserId, DateTime dateTime);
    }
}

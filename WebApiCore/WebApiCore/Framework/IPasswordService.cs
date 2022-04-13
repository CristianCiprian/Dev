using PasswordGenerate.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiCore.Framework
{
    public interface  IPasswordService
    {
        Task<PasswordResponse> GeneratePassword(int UserId, DateTime dateTime);

        Task<int> CheckPassword(string password);
    }
}

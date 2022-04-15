using Microsoft.EntityFrameworkCore;
using PasswordGenerate.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiCore.Models {
    public class PaswordDBContext : DbContext {
        public DbSet<PasswordResponse> PaswordResponses { get; set; }
    }
}

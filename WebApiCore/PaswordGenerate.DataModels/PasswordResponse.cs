using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerate.DataModels
{
    [DataContract]
    public class PasswordResponse
    {
        [DataMember(Name = "PasswordId")]
        public int PasswordId { get; set; }

        [DataMember(Name = "Password")]
        public string Password { get; set; }

        [DataMember(Name = "DateTimePasswordStarted")]
        public DateTime DateTimePasswordStarted { get; set; }

        [DataMember(Name = "DateTimePasswordEnded")]
        public DateTime DateTimePasswordEnded { get; set; }

        [DataMember(Name = "UserId")]
        public int UserId { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerate.DataModels
{
    [DataContract]
    public class PaswordResponse
    {
        [DataMember(Name = "PaswordId")]
        public int PaswordId { get; set; }

        [DataMember(Name = "Pasword")]
        public string Pasword { get; set; }

        [DataMember(Name = "DateTimePaswordStarted")]
        public string DateTimePaswordStarted { get; set; }

        [DataMember(Name = "DateTimePaswordEnded")]
        public string DateTimePaswordEnded { get; set; }

        [DataMember(Name = "UserId")]
        public int UserId { get; set; }
    }
}

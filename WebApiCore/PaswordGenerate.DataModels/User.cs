using System;
using System.Runtime.Serialization;

namespace PaswordGenerate.DataModels
{
    [DataContract]
    public class User
    {      
            [DataMember(Name = "UserId")]
            public int UserId { get; set; }

            [DataMember(Name = "DateTimeUser")]
            public DateTime DateTimeUser { get; set; }
               
    }
}
using System;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;

namespace PaswordGenerate.DataModels
{
    [DataContract]
    public class User
    {      
            [DataMember(Name = "UserId")]
            [Required]           
            public int UserId { get; set; }
            
            [DataMember(Name = "DateTimeUser")]           
            public DateTime DateTimeUser { get; set; }
               
    }
}
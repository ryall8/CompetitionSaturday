using System;

namespace CompetitionSaturday.API.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Username { get; set; }    

        public byte[] PasswordHash { get; set; }

        public byte[] PasswordSalt { get;set; }

        public string KnownAs { get; set; }

        public DateTime DateOfBirth { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime LastActive { get; set; }

        public string Introduction  { get; set; }
        
        public Photo Photo { get; set; }
    }
}
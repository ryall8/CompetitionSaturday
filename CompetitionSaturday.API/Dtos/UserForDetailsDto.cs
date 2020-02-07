using System;

namespace CompetitionSaturday.API.Dtos
{
    public class UserForDetailsDto
    {
        public int Id { get; set; }

        public string Username { get; set; }    

        public string KnownAs { get; set; }

        public int Age { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime LastActive { get; set; }

        public string Introduction  { get; set; }

        public string PhotoUrl { get; set; }        
    }
}
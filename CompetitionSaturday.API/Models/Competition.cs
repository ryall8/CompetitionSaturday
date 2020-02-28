using System;
using System.Collections.Generic;

namespace CompetitionSaturday.API.Models
{
    public class Competition
    {
        public int Id { get; set; }
        public string Name { get; set; }    
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string StateCode { get; set; }
        public string Zip { get; set; }
        public DateTime DateOfEvent { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastActive { get; set; }
        public ICollection<CompetitionUser> Competitors { get; set; }
    }
}
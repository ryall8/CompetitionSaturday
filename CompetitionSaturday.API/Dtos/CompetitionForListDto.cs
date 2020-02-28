using System;

namespace CompetitionSaturday.API.Dtos
{
    public class CompetitionForListDto
    {
        public int Id { get; set; }
        public string Name { get; set; }    
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string StateCode { get; set; }
        public string Zip { get; set; }
        public DateTime DateOfEvent { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
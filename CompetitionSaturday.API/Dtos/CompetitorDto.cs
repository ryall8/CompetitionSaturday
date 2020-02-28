namespace CompetitionSaturday.API.Dtos
{
    public class CompetitorDto
    {
        public int CompetitionId { get; set; }
        public int UserId { get; set; }
        public string KnownAs { get; set; }
        public string PhotoUrl { get; set; }
    }
}
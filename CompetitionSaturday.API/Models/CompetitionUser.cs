using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CompetitionSaturday.API.Models
{
    public class CompetitionUser
    {
        [Key, Column(Order = 0)]
        public int CompetitionId { get; set; }
        [Key, Column(Order = 1)]
        public int UserId { get; set; }
        public DateTime DateAdded { get; set; }

        public virtual User User { get; set; }
        public virtual Competition Competition { get; set; }
    }
}
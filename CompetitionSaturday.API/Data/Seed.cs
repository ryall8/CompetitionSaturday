using System.Collections.Generic;
using System.Linq;
using CompetitionSaturday.API.Models;
using Newtonsoft.Json;

namespace CompetitionSaturday.API.Data
{
    public class Seed
    {
        public static void SeedUsers(DataContext context)
        {
            if (!context.Users.Any())
            {
                var userData = System.IO.File.ReadAllText("Data/UserSeedData.json");
                var users = JsonConvert.DeserializeObject<List<User>>(userData);
                foreach (var user in users)
                {
                    byte[] passwordHash, passwordSalt;
                    CreatePasswordHash("password", out passwordHash, out passwordSalt);

                    user.PasswordHash = passwordHash;
                    user.PasswordSalt = passwordSalt;
                    user.Username = user.Username.ToLower();
                    context.Users.Add(user);
                }

                context.SaveChanges();
            }
        }

        private static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }
        
        public static void SeedCompetitions(DataContext context)
        {
            if (!context.Competitions.Any())
            {
                var competitionData = System.IO.File.ReadAllText("Data/CompetitionSeedData.json");
                var competitions = JsonConvert.DeserializeObject<List<Competition>>(competitionData);
                foreach (var competition in competitions)
                {
                    competition.Name = competition.Name.ToLower();
                    context.Competitions.Add(competition);
                }

                context.SaveChanges();
            }
        }

        public static void SeedCompetitionUsers(DataContext context)
        {
            if (!context.CompetitionUsers.Any())
            {
                var competitorData = System.IO.File.ReadAllText("Data/CompetitionUserSeedData.json");
                var competitors = JsonConvert.DeserializeObject<List<CompetitionUser>>(competitorData);
                foreach (var competitor in competitors)
                {
                    context.CompetitionUsers.Add(competitor);
                }

                context.SaveChanges();
            }
        }
    }
}
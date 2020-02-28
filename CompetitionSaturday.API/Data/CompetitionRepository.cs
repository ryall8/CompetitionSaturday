using System.Collections.Generic;
using System.Threading.Tasks;
using CompetitionSaturday.API.Models;
using Microsoft.EntityFrameworkCore;

namespace CompetitionSaturday.API.Data
{
    public class CompetitionRepository : ICompetitionRepository
    {
        private readonly DataContext _context;
        public CompetitionRepository(DataContext context)
        {
            _context = context;
        }
        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public async Task<Competition> GetCompetition(int id)
        {
            var competition = await _context.Competitions.Include(competition => competition.Competitors)
                                                          .ThenInclude(competitors => competitors.User)
                                                          .ThenInclude(competitor => competitor.Photo)
                                                          .FirstOrDefaultAsync(c => c.Id == id);

            return competition;
        }

        public async Task<IEnumerable<Competition>> GetCompetitions()
        {
            var competitions = await _context.Competitions.ToListAsync();

            return competitions;
        }

        public async Task<bool> SaveAll()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
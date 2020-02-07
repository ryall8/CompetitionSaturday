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

        public async Task<User> GetUser(int id)
        {
            var user = await _context.Users.Include(p => p.Photo).FirstOrDefaultAsync(u => u.Id == id);

            return user;
        }

        public async Task<IEnumerable<User>> GetUsers()
        {
            var users = await _context.Users.Include(p => p.Photo).ToListAsync();

            return users;
        }

        public async Task<bool> SaveAll()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
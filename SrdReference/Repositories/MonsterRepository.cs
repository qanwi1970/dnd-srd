using SrdReference.Infrastructure;
using SrdReference.Models.Entities;
using SrdReference.Repositories.Interfaces;

namespace SrdReference.Repositories
{
    public class MonsterRepository : Repository<Monster>, IMonsterRepository
    {
        public MonsterRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}

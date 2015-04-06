using SrdReference.Infrastructure;
using SrdReference.Models.Entities;
using SrdReference.Repositories.Interfaces;

namespace SrdReference.Repositories
{
    internal class SpellRepository : Repository<Spell>, ISpellRepository
    {
        public SpellRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}

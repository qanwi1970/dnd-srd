using SrdReference.Infrastructure;
using SrdReference.Models.Entities;
using SrdReference.Repositories.Interfaces;

namespace SrdReference.Repositories
{
    internal class CharacterClassRepository : Repository<CharacterClass>, ICharacterClassRepository
    {
        public CharacterClassRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}

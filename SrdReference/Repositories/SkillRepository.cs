using SrdReference.Infrastructure;
using SrdReference.Models.Entities;
using SrdReference.Repositories.Interfaces;

namespace SrdReference.Repositories
{
    internal class SkillRepository : Repository<Skill>, ISkillRepository
    {
        public SkillRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}

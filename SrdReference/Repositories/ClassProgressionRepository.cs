using SrdReference.Infrastructure;
using SrdReference.Models.Entities;
using SrdReference.Repositories.Interfaces;

namespace SrdReference.Repositories
{
    internal class ClassProgressionRepository : Repository<ClassProgression>, IClassProgressionRepository
    {
        public ClassProgressionRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}

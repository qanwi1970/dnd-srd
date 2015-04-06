using SrdReference.Infrastructure;
using SrdReference.Models.Entities;
using SrdReference.Repositories.Interfaces;

namespace SrdReference.Repositories
{
    internal class FeatRepository : Repository<Feat>, IFeatRepository
    {
        public FeatRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}

using SrdReference.Infrastructure;
using SrdReference.Models.Entities;
using SrdReference.Repositories.Interfaces;

namespace SrdReference.Repositories
{
    internal class PowerRepository : Repository<Power>, IPowerRepository
    {
        public PowerRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}

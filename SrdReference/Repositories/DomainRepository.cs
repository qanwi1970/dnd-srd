using SrdReference.Infrastructure;
using SrdReference.Models.Entities;
using SrdReference.Repositories.Interfaces;

namespace SrdReference.Repositories
{
    internal class DomainRepository : Repository<Domain>, IDomainRepository
    {
        public DomainRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}

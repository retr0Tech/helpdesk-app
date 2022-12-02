using System;
using static helpdesk_app.infrastructure.Data.EfRepository;

namespace helpdesk_app.infrastructure.Data
{
    public class EfRepository
	{
        public class EfRepository<T> : RepositoryBase<T>, IReadRepository<T>, IRepository<T> where T : class, IAggregateRoot
        {
            public EfRepository(AppDbContext dbContext) : base(dbContext)
            {
            }
        }
    }
}


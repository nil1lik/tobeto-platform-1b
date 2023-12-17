using Application.Services.Repositories;
using Domain.Entities;
using Core.Persistence.Repositories;
using Persistence.Contexts;

namespace Persistence.Repositories;

public class ClassRepository : EfRepositoryBase<Class, int, BaseDbContext>, IClassRepository
{
    public ClassRepository(BaseDbContext context) : base(context)
    {
    }
}
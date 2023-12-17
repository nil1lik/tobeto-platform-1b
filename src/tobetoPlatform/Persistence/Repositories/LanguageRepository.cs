using Application.Services.Repositories;
using Domain.Entities;
using Core.Persistence.Repositories;
using Persistence.Contexts;

namespace Persistence.Repositories;

public class LanguageRepository : EfRepositoryBase<Language, int, BaseDbContext>, ILanguageRepository
{
    public LanguageRepository(BaseDbContext context) : base(context)
    {
    }
}
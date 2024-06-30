
using web_farmers_api.Domain.Entities;
using web_farmers_api.Infrastructure.Data;

public class FarmRepository: GenericRepository<Farm>, IFarmRepository
{
    private readonly ProjectDbContext _dbContext;

    public FarmRepository(ProjectDbContext dbContext): base(dbContext)
    {
        _dbContext = dbContext;
    }
}


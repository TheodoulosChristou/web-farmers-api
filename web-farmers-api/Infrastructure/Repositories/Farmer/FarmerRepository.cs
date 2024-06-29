using web_farmers_api.Domain.Entities;
using web_farmers_api.Infrastructure.Data;


public class FarmerRepository: GenericRepository<Farmer>, IFarmerRepository
    {
        private readonly ProjectDbContext _dbContext;
        
        public FarmerRepository(ProjectDbContext dbContext):base(dbContext) 
        {
            _dbContext = dbContext;
        }
}


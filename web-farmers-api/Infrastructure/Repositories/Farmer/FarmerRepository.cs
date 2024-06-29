using web_farmers_api.Application.DTOs.Farmer;
using web_farmers_api.Domain.Entities;
using web_farmers_api.Infrastructure.Data;


public class FarmerRepository: GenericRepository<Farmer>, IFarmerRepository
    {
        private readonly ProjectDbContext _dbContext;
        
        public FarmerRepository(ProjectDbContext dbContext):base(dbContext) 
        {
            _dbContext = dbContext;
        }

        public async Task<List<SearchFarmerResultDto>> SearchFarmersByCriteria(SearchFarmerCriteriaDto searchCriteria)
        {
        try
        {
            List<Farmer> farmerRes = _dbContext.Farmer.Where(x=>x.ID==searchCriteria.ID || searchCriteria.ID == null
            && (x.FIRSTNAME.Contains(searchCriteria.FIRSTNAME) || searchCriteria.FIRSTNAME == null)
            && (x.LASTNAME.Contains(searchCriteria.LASTNAME) || searchCriteria.LASTNAME == null)
            && (x.EMAIL.Contains(searchCriteria.EMAIL) || searchCriteria.EMAIL == null) 
            && (x.PHONENUMBER == searchCriteria.PHONENUMBER || searchCriteria.PHONENUMBER == null)
            && (x.DOB == searchCriteria.DOB || searchCriteria.DOB == null)).ToList();

            List<SearchFarmerResultDto> result = (from  farmer in farmerRes
                                                  select new SearchFarmerResultDto
                                                  {
                                                      ID = farmer.ID,
                                                      FIRSTNAME = farmer.FIRSTNAME,
                                                      LASTNAME = farmer.LASTNAME,
                                                      EMAIL = farmer.EMAIL,
                                                      PHONENUMBER = farmer.PHONENUMBER,
                                                      DOB = farmer.DOB
                                                  }).ToList();
            return result;
        }
        catch (Exception ex)
        {
            throw ex;
        }
        }
}


using web_farmers_api.Application.DTOs.Farmer;
using web_farmers_api.Application.Interface.Repositories;
using web_farmers_api.Domain.Entities;



    public interface IFarmerRepository: IGenericRepository<Farmer>
    {
        Task<List<SearchFarmerResultDto>> SearchFarmersByCriteria(SearchFarmerCriteriaDto searchCriteria);
    }


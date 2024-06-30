using AutoMapper;
using web_farmers_api.Application.DTOs.Farm;
using web_farmers_api.Application.DTOs.Farmer;
using web_farmers_api.Domain.Entities;

namespace web_farmers_api.Application.Mapping
{
    public class AutoMapperProfile: Profile
    {

        public AutoMapperProfile()
        {
            #region Farmer
            CreateMap<FarmerDto, Farmer>().ReverseMap();
            #endregion

            #region Farm
            CreateMap<FarmDto, Farm>().ReverseMap();
            #endregion
        }
    }
}

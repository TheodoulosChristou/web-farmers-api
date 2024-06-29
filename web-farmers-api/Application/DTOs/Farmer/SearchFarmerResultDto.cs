using web_farmers_api.Application.Interface.DTOs.Farmer;

namespace web_farmers_api.Application.DTOs.Farmer
{
    public class SearchFarmerResultDto : ISearchFarmerResultDto
    {
        public int? ID { get ; set ; }
        public string? FIRSTNAME { get ; set ; }
        public string? LASTNAME { get ; set ; }
        public DateTime? DOB { get ; set ; }
        public int? PHONENUMBER { get ; set ; }
        public string? EMAIL { get ; set ; }
    }
}

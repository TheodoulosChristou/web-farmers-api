using System.ComponentModel.DataAnnotations;

namespace web_farmers_api.Application.Interface.DTOs.Farmer
{
    public interface IFarmerDto
    {
        public int ID { get; set; }

        public string FIRSTNAME { get; set; }

        public string LASTNAME { get; set; }

        public DateTime DOB { get; set; }

        public int PHONENUMBER { get; set; }

        public string EMAIL { get; set; }
    }
}

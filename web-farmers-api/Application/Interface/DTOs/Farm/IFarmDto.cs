using System.ComponentModel.DataAnnotations;

namespace web_farmers_api.Application.Interface.DTOs.Farm
{
    public interface IFarmDto
    {
        public int ID { get; set; }

        public string FARMNAME { get; set; }

        public string LOCATION { get; set; }

        public int FARMSIZE { get; set; }

        public int FARMER_ID { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace web_farmers_api.Domain.Entities
{
    public class Farm
    {
        public int ID { get; set; }

        [StringLength(100)]
        public string FARMNAME { get; set; }

        [StringLength(255)]
        public string LOCATION { get; set; }

        public int FARMSIZE { get; set; }

        public int FARMER_ID { get; set; }
    }
}

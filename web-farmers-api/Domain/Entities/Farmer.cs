using System.ComponentModel.DataAnnotations;

namespace web_farmers_api.Domain.Entities
{
    public class Farmer
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string FIRSTNAME { get; set; }

        [StringLength(50)]
        public string LASTNAME { get; set; }

        public DateTime DOB { get; set; }

        public int PHONENUMBER { get; set; }

        [StringLength(100)]
        public string EMAIL { get; set; }
    }
}

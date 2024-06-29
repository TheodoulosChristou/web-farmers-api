namespace web_farmers_api
{
    public class BaseCommandResponse
    {
        public int ID {  get; set; }

        public string ENTITY {  get; set; }

        public string MESSAGE { get; set; }

        public bool SUCCESS { get; set; }
    }
}

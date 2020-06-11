using System.Text.Json.Serialization;

namespace MailAPI.Models
{

    public class Email
    {

        public Email()
        {
            BlindCopy = "Email";
        }

        public int Id { get; set; }
        public string Recipient { get; set; }
        public string Sender { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public string HtmlBody { get; set; }

        [JsonPropertyName("cc")]
        public string Copy { get; set; }

        [JsonPropertyName("bcc")]
        public string BlindCopy { get; set; }
    }
}
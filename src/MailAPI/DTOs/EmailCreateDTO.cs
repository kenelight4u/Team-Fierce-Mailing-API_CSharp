using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace MailAPI.DTOs
{
    public class EmailCreateDTO
    {

       
        [Required]
        [JsonPropertyName("recipient")]
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
using System.Collections.Generic;
using MailAPI.Models;

namespace MailAPI.Data
{
    public class MockEmailRepo : IEmailRepo
    {
        public IEnumerable<Email> GetEmails()
        {
            var emails = new List<Email>{
                new Email{Recipient="Bob", Sender="Joy", BlindCopy="Bature"},
                new Email{Recipient="Bob0", Sender="Lisa Joy", Copy="Leah", BlindCopy="BaShir"}
            };
            return emails;
        }
    }
}
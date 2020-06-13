using System.Collections.Generic;
using MailAPI.Models;

namespace MailAPI.Data
{
    public interface IEmailRepo
    {
        IEnumerable<Email> GetEmails();
        void SendMail(Email email);
        bool SaveChanges();
    }
}
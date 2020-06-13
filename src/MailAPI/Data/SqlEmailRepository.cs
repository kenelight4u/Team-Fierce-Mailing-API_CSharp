using System;
using System.Collections.Generic;
using System.Linq;
using MailAPI.Models;

namespace MailAPI.Data
{
    public class SqlEmailRepository : IEmailRepo
    {
        private readonly EkeneDBContext _context;
        public SqlEmailRepository(EkeneDBContext context)
        {
            _context = context;
        }
        public IEnumerable<Email> GetEmails()
        {
            return _context.Emails.ToList();
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void SendMail(Email email)
        {
            if (email == null)
            {
                throw new ArgumentNullException(nameof(email));
            }
            _context.Emails.Add(email);
        }
    }
}
using System.Collections.Generic;
using System.Linq;
using MailAPI.Models;

namespace MailAPI.Data
{
    public class SqlEmailRepository : IEmailRepo
    {
        private readonly EmailDBContext _context;
        public SqlEmailRepository(EmailDBContext context)
        {
            _context = context;
        }
        public IEnumerable<Email> GetEmails()
        {
            return _context.Emails.ToList();
        }
    }
}
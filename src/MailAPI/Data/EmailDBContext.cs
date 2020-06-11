using MailAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace MailAPI.Data
{
    public class EmailDBContext : DbContext
    {
        public EmailDBContext(DbContextOptions<EmailDBContext> opt) : base(opt)
        {
            
        }

        public DbSet<Email> Emails { get; set; }
    }
}
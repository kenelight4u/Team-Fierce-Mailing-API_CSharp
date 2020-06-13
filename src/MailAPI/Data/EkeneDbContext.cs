using MailAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace MailAPI.Data
{
    public class EkeneDBContext : DbContext
    {
        public EkeneDBContext(DbContextOptions<EkeneDBContext> opt) : base(opt)
        {
            
        }

        public DbSet<Email> Emails { get; set; }
    }
}
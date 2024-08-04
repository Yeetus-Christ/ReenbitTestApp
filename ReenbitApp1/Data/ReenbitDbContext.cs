using Microsoft.EntityFrameworkCore;
using ReenbitApp1.Models;

namespace ReenbitApp1.Data
{
    public class ReenbitDbContext : DbContext
    {
        public ReenbitDbContext(DbContextOptions<ReenbitDbContext> options) : base(options)
        {

        }

        public DbSet<ChatMessage> ChatMessages { get; set; }
    }
}

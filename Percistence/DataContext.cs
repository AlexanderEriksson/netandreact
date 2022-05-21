using Microsoft.EntityFrameworkCore;
using Domain;
namespace Percistence
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions options) : base(options){

        }

        public DbSet<Message> Messages { get; set; }
        
    }
}
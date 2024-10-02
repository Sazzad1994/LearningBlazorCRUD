using CRUD.SharedOne.Models;

using Microsoft.EntityFrameworkCore;

namespace CRUD.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext>options):base(options) 
        { 
        
        }
        public DbSet<Game> Games { get; set; }
    }
}

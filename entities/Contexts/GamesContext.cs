using entities.viewmodels;
using Microsoft.EntityFrameworkCore;

namespace entities.Contexts
{
    public class GamesContext : DbContext
    {
      public GamesContext(DbContextOptions<GamesContext> options)
       :base(options) {}      
      public GamesContext(){}
      public DbSet<GamesDataList> gamesdblist {get; set;}
     
      

    }
}
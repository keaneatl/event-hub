using Microsoft.EntityFrameworkCore;

namespace EventHub.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options) 
        {   
            
        }

    }
}

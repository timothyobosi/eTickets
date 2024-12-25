using Microsoft.EntityFrameworkCore;

namespace eTickets.Data{

    public class AppDbContext: DbContext
    {
        //define constructor(default) it takes parameteter(DbContext) then pass parameter file name: AppDbContext
        public AppDbContext(DbContextOptions<AppDbContext> options): base (options)
        {

        }

    }
}
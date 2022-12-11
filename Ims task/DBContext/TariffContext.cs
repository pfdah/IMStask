using Ims_task.Model;
using Microsoft.EntityFrameworkCore;

namespace Ims_task.DBContext
{
    public class TariffContext: DbContext
    {
        public TariffContext(DbContextOptions<TariffContext> options): base(options)
        {
        }

        public DbSet<TariffMaster> TariffMaster { get; set; }
        public DbSet<TariffDetails> TariffDetails { get; set; }
    }
}

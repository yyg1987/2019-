using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace YJ.PF.EntityFrameworkCore
{
    public static class PFDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<PFDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<PFDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}

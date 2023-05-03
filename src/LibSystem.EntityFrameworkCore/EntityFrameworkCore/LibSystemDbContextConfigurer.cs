using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace LibSystem.EntityFrameworkCore
{
    public static class LibSystemDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<LibSystemDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<LibSystemDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}

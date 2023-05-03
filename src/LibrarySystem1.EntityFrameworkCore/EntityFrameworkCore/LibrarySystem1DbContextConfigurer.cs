using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace LibrarySystem1.EntityFrameworkCore
{
    public static class LibrarySystem1DbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<LibrarySystem1DbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<LibrarySystem1DbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}

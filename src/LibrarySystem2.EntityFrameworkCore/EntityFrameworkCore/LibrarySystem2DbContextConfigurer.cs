using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace LibrarySystem2.EntityFrameworkCore
{
    public static class LibrarySystem2DbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<LibrarySystem2DbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<LibrarySystem2DbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}

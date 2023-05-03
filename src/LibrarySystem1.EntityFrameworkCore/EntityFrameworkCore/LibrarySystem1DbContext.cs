using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using LibrarySystem1.Authorization.Roles;
using LibrarySystem1.Authorization.Users;
using LibrarySystem1.MultiTenancy;

namespace LibrarySystem1.EntityFrameworkCore
{
    public class LibrarySystem1DbContext : AbpZeroDbContext<Tenant, Role, User, LibrarySystem1DbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public LibrarySystem1DbContext(DbContextOptions<LibrarySystem1DbContext> options)
            : base(options)
        {
        }
    }
}

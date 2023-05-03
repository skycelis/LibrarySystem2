using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using LibSystem.Authorization.Roles;
using LibSystem.Authorization.Users;
using LibSystem.MultiTenancy;

namespace LibSystem.EntityFrameworkCore
{
    public class LibSystemDbContext : AbpZeroDbContext<Tenant, Role, User, LibSystemDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public LibSystemDbContext(DbContextOptions<LibSystemDbContext> options)
            : base(options)
        {
        }
    }
}

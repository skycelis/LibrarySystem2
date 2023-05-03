using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using LibrarySystem2.Authorization.Roles;
using LibrarySystem2.Authorization.Users;
using LibrarySystem2.MultiTenancy;
using LibrarySystem2.Entities;
using System.Diagnostics.Eventing.Reader;

namespace LibrarySystem2.EntityFrameworkCore
{
    public class LibrarySystem2DbContext : AbpZeroDbContext<Tenant, Role, User, LibrarySystem2DbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Department> Departments { get; set;} 
        public LibrarySystem2DbContext(DbContextOptions<LibrarySystem2DbContext> options)
            : base(options)
        {

        }
    }
}

﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using LibrarySystem1.Configuration;
using LibrarySystem1.Web;

namespace LibrarySystem1.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class LibrarySystem1DbContextFactory : IDesignTimeDbContextFactory<LibrarySystem1DbContext>
    {
        public LibrarySystem1DbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<LibrarySystem1DbContext>();
            
            /*
             You can provide an environmentName parameter to the AppConfigurations.Get method. 
             In this case, AppConfigurations will try to read appsettings.{environmentName}.json.
             Use Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") method or from string[] args to get environment if necessary.
             https://docs.microsoft.com/en-us/ef/core/cli/dbcontext-creation?tabs=dotnet-core-cli#args
             */
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            LibrarySystem1DbContextConfigurer.Configure(builder, configuration.GetConnectionString(LibrarySystem1Consts.ConnectionStringName));

            return new LibrarySystem1DbContext(builder.Options);
        }
    }
}

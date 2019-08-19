using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using ABPDocker.Configuration;
using ABPDocker.Web;

namespace ABPDocker.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class ABPDockerDbContextFactory : IDesignTimeDbContextFactory<ABPDockerDbContext>
    {
        public ABPDockerDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ABPDockerDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            ABPDockerDbContextConfigurer.Configure(builder, configuration.GetConnectionString(ABPDockerConsts.ConnectionStringName));

            return new ABPDockerDbContext(builder.Options);
        }
    }
}

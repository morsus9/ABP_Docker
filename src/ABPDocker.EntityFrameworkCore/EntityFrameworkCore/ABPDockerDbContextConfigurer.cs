using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace ABPDocker.EntityFrameworkCore
{
    public static class ABPDockerDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ABPDockerDbContext> builder, string connectionString)
        {
            builder.UseMySql(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<ABPDockerDbContext> builder, DbConnection connection)
        {
            builder.UseMySql(connection);
        }
    }
}

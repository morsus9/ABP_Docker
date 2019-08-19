using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using ABPDocker.Authorization.Roles;
using ABPDocker.Authorization.Users;
using ABPDocker.MultiTenancy;

namespace ABPDocker.EntityFrameworkCore
{
    public class ABPDockerDbContext : AbpZeroDbContext<Tenant, Role, User, ABPDockerDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public ABPDockerDbContext(DbContextOptions<ABPDockerDbContext> options)
            : base(options)
        {
        }
    }
}

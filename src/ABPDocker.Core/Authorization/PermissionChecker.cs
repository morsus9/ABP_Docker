using Abp.Authorization;
using ABPDocker.Authorization.Roles;
using ABPDocker.Authorization.Users;

namespace ABPDocker.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}

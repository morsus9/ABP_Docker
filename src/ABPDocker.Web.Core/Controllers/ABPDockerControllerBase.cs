using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace ABPDocker.Controllers
{
    public abstract class ABPDockerControllerBase: AbpController
    {
        protected ABPDockerControllerBase()
        {
            LocalizationSourceName = ABPDockerConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}

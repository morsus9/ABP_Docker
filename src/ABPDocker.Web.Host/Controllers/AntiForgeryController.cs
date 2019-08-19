using Microsoft.AspNetCore.Antiforgery;
using ABPDocker.Controllers;

namespace ABPDocker.Web.Host.Controllers
{
    public class AntiForgeryController : ABPDockerControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}

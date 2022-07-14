namespace Microsoft.SCIM.WebHostSample.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize]
    [Route(ServiceConstants.RouteUsers)]
    public sealed class UsersController : UsersControllerTemplate
    {
        public UsersController(IProvider provider, IMonitor monitor)
            : base(provider, monitor)
        {
        }
    }
}

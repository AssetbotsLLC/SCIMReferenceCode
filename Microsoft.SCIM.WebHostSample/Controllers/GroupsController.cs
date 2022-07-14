namespace Microsoft.SCIM.WebHostSample.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize]
    [Route(ServiceConstants.RouteGroups)]
    public sealed class GroupsController : GroupsControllerTemplate
    {
        public GroupsController(IProvider provider, IMonitor monitor)
            : base(provider, monitor)
        {
        }
    }
}

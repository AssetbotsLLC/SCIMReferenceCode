namespace Microsoft.SCIM.WebHostSample.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize]
    [Route(ServiceConstants.RouteResourceTypes)]
    public sealed class ResourceTypesController : ResourceTypesControllerTemplate
    {
        public ResourceTypesController(IProvider provider, IMonitor monitor)
            : base(provider, monitor)
        {
        }
    }
}

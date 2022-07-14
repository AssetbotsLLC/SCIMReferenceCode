namespace Microsoft.SCIM.WebHostSample.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize]
    [Route(ServiceConstants.RouteBulk)]
    public sealed class BulkRequestController : BulkRequestControllerTemplate
    {
        public BulkRequestController(IProvider provider, IMonitor monitor)
            : base(provider, monitor)
        {
        }
    }
}

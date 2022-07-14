namespace Microsoft.SCIM.WebHostSample.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize]
    [Route(ServiceConstants.RouteSchemas)]
    public sealed class SchemasController : SchemasControllerTemplate
    {
        public SchemasController(IProvider provider, IMonitor monitor)
            : base(provider, monitor)
        {
        }
    }
}

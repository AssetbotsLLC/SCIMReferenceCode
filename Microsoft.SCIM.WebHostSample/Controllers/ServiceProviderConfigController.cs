namespace Microsoft.SCIM.WebHostSample.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize]
    [Route(ServiceConstants.RouteServiceConfiguration)]
    public sealed class ServiceProviderConfigController : ServiceProviderConfigurationControllerTemplate
    {
        public ServiceProviderConfigController(IProvider provider, IMonitor monitor)
            : base(provider, monitor)
        {
        }
    }
}

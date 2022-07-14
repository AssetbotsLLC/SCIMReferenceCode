namespace Microsoft.SCIM.WebHostSample.Controllers
{
    public sealed class RootController : RootControllerTemplate
    {
        public RootController(IProvider provider, IMonitor monitor)
            : base(provider, monitor)
        {
        }
    }
}

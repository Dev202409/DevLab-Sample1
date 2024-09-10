using Sample1.Common.Domain.Model;

namespace Sample1.Common.Domain.Outgoings
{
    public interface IRequestContextService
    {
        RequestContext GetCurrentRequestContext();
        void SetCurrentRequestContext(RequestContext context);
    }
}

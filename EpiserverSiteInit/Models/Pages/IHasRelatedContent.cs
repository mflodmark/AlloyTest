using EPiServer.Core;

namespace EpiserverSiteInit.Models.Pages
{
    public interface IHasRelatedContent
    {
        ContentArea RelatedContentArea { get; }
    }
}

using Eventgo.Platform.API.Planning.Domain.Model.Aggregates;
using Eventgo.Platform.API.Planning.Domain.Model.ValueObjects;

namespace Eventgo.Platform.API.Planning.Interfaces.ACL;

public interface ISocialEventContextFacade
{
    Task<string> CreateSocialEventAsync(string eventTitle, DateTime eventDate, string customerName, string location,
        EStatusType status);
    Task<SocialEvent?> GetSocialEventByIdAsync(int socialEventId);
    Task<IEnumerable<SocialEvent>> GetAllSocialEventsAsync();
    Task<bool> UpdateSocialEventAsync(int socialEventId, string eventTitle, DateTime eventDate, string customerName, string location, EStatusType status);
    Task<bool> DeleteSocialEventAsync(int socialEventId);
    Task<IEnumerable<SocialEvent>> GetSocialEventsByCustomerNameAsync(string customerName);
    
}
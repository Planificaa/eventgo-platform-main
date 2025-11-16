using Eventgo.Platform.API.Profiles.Domain.Model.ValueObjects;

namespace Eventgo.Platform.API.Profiles.Domain.Model.Commands;

public record CreateProfileCommand(
    string FirstName,
    string LastName,
    string Email,
    string Street,
    string Number,
    string City,
    string PostalCode,
    string Country,
    string PhoneNumber,
    string WebSite,
    string Biography,
    TypeProfile Role);
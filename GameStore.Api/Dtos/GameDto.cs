namespace GameStore.Api.Dtos;

// A DTO (Data Transfer Object) is a simple object that is used to transfer data between layers of an application.
// It is often used to encapsulate data and send it from the server to the client, or vice versa. 
// A shared agreement about how data will be transferred and used.

public record GameDto(
    int Id,
    string name,
    string Genre,
    decimal Price,
    DateOnly ReleaseDate
);

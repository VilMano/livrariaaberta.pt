using Microsoft.AspNetCore.Authentication;

namespace Aberta.API.Models.Auth;

public class ApiKeyAuthenticationSchemeOptions: AuthenticationSchemeOptions {
    public string? ApiKey {get; set;}
}
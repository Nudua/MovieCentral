# MovieCentral - Fullstack ASP.NET Core Web API + Blazor WebAssembly Application
This project was started as a learning project, serving as a testbed for things I wanted to learn more about, such as Blazor, authentication with Azure AD B2C, and backend integration testing to mention a few. Since it's come to a more *complete* state, I figured I might as well share the source code.

The application lets you browse the top 250 rated movies of all time, you can filter by genre and add them to your own watchlist when you sign up.

## Live demo
A live demo is located over at https://moviecentral.ramstad.io and is hosted on [Azure App Service](https://azure.microsoft.com/en-us/services/app-service/) running inside a Docker container. Updates are automatically deployed using GitHub Actions, you can take a look at the [workflow file](.github/workflows/docker-ci-cd.yml).

[![Application Demo](preview.webp)](https://moviecentral.ramstad.io)

## Tech stack

### Frontend
- Blazor WebAssembly
- MudBlazor (UI Component Library)
- Fluxor (Redux like State Management)
- Microsoft Authentication Library (MSAL)

### Backend
- .NET 6
- Clean Architecture
- ASP.NET Core Web API
- Entity Framework Core 6
- FluentValidation
- AutoMapper
- XUnit (testing)
- FluentAssertions
- AutoFixture

### Misc
- Azure Active Directory B2C (Authentication)
- Azure App Service (Hosting)
- Docker
- DockerHub
- GitHub Actions (CI+CD)

## Running the application locally
Update appsettings.json (or add a [secrets.json](https://docs.microsoft.com/en-us/aspnet/core/security/app-secrets?view=aspnetcore-6.0&tabs=windows) file) with your own Azure B2C details. You can always follow my blog post on [Securing an ASP.NET Web App with Azure B2C](https://ramstad.io/2022/03/17/Securing-an-ASP-NET-6-Web-App-with-Azure-AD-B2C-using-Authorization-Code-Flow-with-PKCE/) on details on how to do that.

Backend: [appsettings.json](src/MovieCentral.Server/appsettings.json)
```json
"AzureAdB2C": {
    "Instance": "https://{tenant_domain_name}.b2clogin.com",
    "Domain": "{tenant_domain_name}.onmicrosoft.com",
    "TenantId": "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx",
    "ClientId": "{client_id}",
    "SignUpSignInPolicyId": "B2C_1_signup_signin",
},
```
Frontend: [appsettings.json](src/MovieCentral.Client/wwwroot/appsettings.json)
```json
  "AzureAdB2C": {
    "Authority": "https://{tenant_domain_name}.b2clogin.com/{tenant_domain_name}.onmicrosoft.com/B2C_1_signup_signin",
    "ClientId": "{ClientId}",
    "ValidateAuthority": true
  }
```
# ASP.NET Core Conventions

- `DefaultAuthorizationConvention` - automatically adds an authorization attribute `[Authorize]` to controllers that don't have any explicit authorization attribute defined. Endpoints without specific access rules are protected by default. Use the `[AllowAnonymous]` attribute to turn off the authorization.
- `KebabCaseRouteConvention` - changes route templates to kebab-case format, providing a consistent and standardized URL structure.
- `RoutePrefixConvention` - creates a common route prefix for all controllers, e.g. "api" (api/controller-route).

## Installation

Add the NuGet package source: `https://nuget.pkg.github.com/dae-ne/index.json`

You can do this by adding a `nuget.config` file to a project:

```XML
<?xml version="1.0" encoding="utf-8"?>
<configuration>
    <packageSources>
        <clear />
        <add key="nuget.org" value="https://api.nuget.org/v3/index.json" />
        <add key="dae-ne" value="https://nuget.pkg.github.com/dae-ne/index.json" />
    </packageSources>
    <activePackageSource>
        <add key="All" value="(Aggregate source)" />
    </activePackageSource>
</configuration>
```

Install the NuGet package:

```bash
dotnet add package DaeNe.AspNetCore.Conventions --version 1.0.0
```

## Configuration

```C#
builder.Services.AddControllers(options =>
{
    options.Conventions.Add(new DefaultAuthorizationConvention());
    options.Conventions.Add(new KebabCaseRouteConvention());
    options.Conventions.Add(new RoutePrefixConvention("api"));
});
```

## License

[MIT](https://choosealicense.com/licenses/mit/)

# ASP.NET Core Conventions

- `DefaultAuthorizationConvention` - automatically adds an authorization attribute `[Authorize]` to controllers that don't have any explicit authorization attribute defined. Endpoints without specific access rules are protected by default. Use the `[AllowAnonymous]` attribute to turn off the authorization.
- `KebabCaseRouteConvention` - changes route templates to kebab-case format, providing a consistent and standardized URL structure.
- `RoutePrefixConvention` - creates a common route prefix for all controllers, e.g. "api" (api/controller-route).

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

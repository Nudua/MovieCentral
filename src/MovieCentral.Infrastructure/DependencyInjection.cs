using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MovieCentral.Application.Abstractions;
using MovieCentral.Application.Abstractions.Read;
using MovieCentral.Application.Abstractions.Write;
using MovieCentral.Infrastructure.Persistence;
using MovieCentral.Infrastructure.Persistence.ReadServices;
using MovieCentral.Infrastructure.Persistence.WriteServices;

namespace MovieCentral.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<IApplicationDbContext, ApplicationDbContext>(options =>
            options.UseSqlite(configuration.GetConnectionString(ApplicationDbContext.SQLiteConnectionStringPath)));

        services.AddScoped<IReadOnlyUsersService, ReadOnlyUsersService>();
        services.AddScoped<IWriteOnlyUsersService, WriteOnlyUsersService>();

        services.AddScoped<IReadOnlyMovieService, ReadOnlyMovieService>();

        services.AddScoped<IReadOnlyWatchListService, ReadOnlyWatchListService>();
        services.AddScoped<IWriteOnlyWatchListService, WriteOnlyWatchListService>();

        return services;
    }
}

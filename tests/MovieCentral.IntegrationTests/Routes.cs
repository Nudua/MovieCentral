using System;
using MovieCentral.Shared.Constants;

namespace MovieCentral.IntegrationTests;

public static class Routes
{
    private const string BaseRoute = "api";

    public static class Movies
    {
        private const string BaseRoute = Routes.BaseRoute + "/movies";

        public static string GetPagedList(int pageNumber, int pageSize, Genre genre = Genre.None)
            => $"{BaseRoute}?pageNumber={pageNumber}&pageSize={pageSize}&genre={genre}";

        public static string Get(Guid id) => $"{BaseRoute}/{id}";
    }

    public static class Users
    {
        private const string BaseRoute = Routes.BaseRoute + "/users";

        public const string Profile = $"{BaseRoute}/profile";
        public const string Delete = BaseRoute;
        public const string UpdateNickName = $"{BaseRoute}/profile/updateNickName";
        public const string GetRoles = $"{BaseRoute}/profile/roles";
    }

    public static class WatchList
    {
        private const string BaseRoute = Routes.BaseRoute + "/watchlist";

        public const string GetList = BaseRoute;
        public const string AddMovie = BaseRoute;

        public static string RemoveMovie(Guid id) => $"{BaseRoute}/{id}";
    }
}

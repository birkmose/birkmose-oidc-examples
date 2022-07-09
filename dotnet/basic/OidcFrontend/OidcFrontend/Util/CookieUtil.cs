namespace OidcFrontend.Util
{
    public static class CookieUtil
    {
        public static void SafeAppendCookie(this IResponseCookies responseCookies, string cookieName, string value)
        {
            responseCookies.Append(cookieName, value, SafeCookieOptions());
        }

        public static void SafeClearCookie(this IResponseCookies responseCookies, string cookieName)
        {
            responseCookies.Append(cookieName, "", SafeCookieClearOptions());
        }


        private static CookieOptions SafeCookieOptions()
        {
            var option = new CookieOptions();
            option.Path = "/";
            option.HttpOnly = true;
            option.SameSite = SameSiteMode.Lax;

            return option;
        }

        private static CookieOptions SafeCookieClearOptions()
        {
            var option = SafeCookieOptions();
            option.Expires = DateTimeOffset.UnixEpoch;

            return option;
        }
    }
}

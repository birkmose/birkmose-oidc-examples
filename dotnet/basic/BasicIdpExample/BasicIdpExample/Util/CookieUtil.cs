using System;
using Microsoft.AspNetCore.Http;

namespace Heimdall.Examples.Basic.Util
{
    /// <summary>
    /// Helper utils to store/clear single sign-on cookies.
    /// </summary>
    public static class CookieUtil
    {
        /// <summary>
        /// Stores a cookie with safe options (HTTP only cookie).
        /// </summary>
        /// <param name="responseCookies">Type this method extends</param>
        /// <param name="cookieName">Name of cookie to store</param>
        /// <param name="value">Value of the cookie</param>
        public static void SafeAppendCookie(this IResponseCookies responseCookies, string cookieName, string value)
        {
            responseCookies.Append(cookieName, value, SafeCookieOptions());
        }

        /// <summary>
        /// Removes a HTTP cookie from the user-agent.
        /// </summary>
        /// <param name="responseCookies">Type this method extends</param>
        /// <param name="cookieName">Name of cookie to remove</param>
        public static void SafeClearCookie(this IResponseCookies responseCookies, string cookieName)
        {
            responseCookies.Append(cookieName, "", SafeCookieClearOptions());
        }

        // Safe cookie options (Http only cookie).
        private static CookieOptions SafeCookieOptions()
        {
          var option = new CookieOptions
          {
            Path = "/", HttpOnly = true, SameSite = SameSiteMode.Lax, Expires = DateTime.Now.AddHours(24)
          };
          return option;
        }

        // Safe cookie remove options (Http only cookie).
        private static CookieOptions SafeCookieClearOptions()
        {
            var option = SafeCookieOptions();
            option.Expires = DateTimeOffset.UnixEpoch;

            return option;
        }
    }
}

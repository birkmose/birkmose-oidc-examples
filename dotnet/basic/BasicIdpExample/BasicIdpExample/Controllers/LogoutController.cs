using Microsoft.AspNetCore.Mvc;
using Heimdall.Examples.Basic.Util;
using Heimdall.Examples.Basic.ViewModels;

namespace Heimdall.Examples.Basic.Controllers
{
    /// <summary>
    /// MVC Controller for the end session endpoint of the basic Idp example.
    /// </summary>
    public class LogoutController : Controller
    {
        private readonly HeimdallClient _heimdallClient;
        public LogoutController(HeimdallClient heimdallClient)
        {
            _heimdallClient = heimdallClient;
        }

        /// <summary>
        /// Handles the Oauth2 logout request. This is the End Session Endpoint specified by OpenID Connect.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("oauth2/v2.0/logout")]
        public async Task<IActionResult> Oauth2Logout()
        {
            // Extract the raw query string - Heimdall will process the raw query and decide what is the next
            // appropriate action that the Idp needs to carry out.
            var query = Request.QueryString.Value;

            // Read the stored single sign-on cookie (if any).
            var session = Request.Cookies["session"];

            // Send the logout requests to Heimdall backchannel api.
            var logoutResponse = await _heimdallClient.RpInitiatedLogoutAsync(new LogoutRequest
            {
                Query = query,
                Session = session,
                ConfirmLogout = true
            });

            // If we received an error from Heimdall, display it to the end-user.
            if (logoutResponse.Error != null)
            {
                Response.StatusCode = 400;
                return View("~/Views/Shared/Error.cshtml", new ErrorViewModel
                {
                    ErrorTitle = "Oidc Logout Error",
                    ErrorMessage = logoutResponse.Error.Error
                });
            }

            // Conclude the oauth2 logout request by redirecting the user-agent to the location specified by Heimdall.
            Response.Headers.Add("Location", logoutResponse.FinalResponse.Uri);

            // Clear the single sign-on session cookie.
            Response.Cookies.SafeClearCookie("session");
            return StatusCode(303);
        }
    }
}
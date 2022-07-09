using OidcFrontend.ViewModels;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Text;
using System.Security.Claims;
using HeimdallClient.Api;
using HeimdallClient.Client;
using HeimdallClient.Model;
using OidcFrontend.Configuration;
using Microsoft.Extensions.Options;
using Microsoft.VisualBasic;
using OidcFrontend.Util;

namespace OidcFrontend.Controllers
{
    public class LogoutController : Controller
    {
        private readonly ISessionApi _sessionApi;
        public LogoutController(ISessionApi sessionApi)
        {
            _sessionApi = sessionApi;
        }


        /// <summary>
        /// Handles the oauth2 logout request
        /// </summary>
        /// <param name="id_token_hint">Extracts the id_token_hint for easier processing</param>
        /// <returns></returns>
        [HttpGet]
        [Route("oauth2/v2.0/logout")]
        public async Task<IActionResult> Oauth2Logout()
        {
            // The full oauth2 query string
            var query = Request.QueryString.Value;
            var session = Request.Cookies["session"];

            var logoutResponse = await _sessionApi.RpInitiatedLogoutAsync(
                new LogoutRequest(query: query, session: session, confirmLogout: true));

            // We do not handle errors in the logout request at this point. We did a check of the logout request earlier
            // so this should never fail. If it actually fails - then there is nothing we can do.
            if (logoutResponse.Error != null)
            {
                Response.StatusCode = 400;
                return View("~/Views/Shared/Error.cshtml", new ErrorViewModel
                {
                    Title = "Oidc Logout Error",
                    Description = logoutResponse.Error.Error
                });
            }

           
            // This concludes the oauth2 logout request
            Response.Headers.Add("Location", logoutResponse.FinalResponse.Uri);
            Response.Cookies.SafeClearCookie("session");
            return StatusCode(303);

        }
    }
}
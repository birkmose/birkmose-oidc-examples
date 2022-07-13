using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Heimdall.Examples.Basic.Util;
using Heimdall.Examples.Basic.Configuration;
using Heimdall.Examples.Basic.ViewModels;

namespace Heimdall.Examples.Basic.Controllers
{
    /// <summary>
    /// MVC Controller for the authorize endpoint of the basic Idp example.
    /// </summary>
    public class AuthorizeController : Controller
    {
        private readonly HeimdallClient _heimdallClient;
        private readonly Dictionary<string, string> _userDatabase;
        private readonly string _userInformation;
        private readonly string _applicationName;

        public AuthorizeController(IOptions<IdpConfig> config, HeimdallClient heimdallClient)
        {
            _heimdallClient = heimdallClient;
            _applicationName = config.Value.ApplicationName;
            _userDatabase = config.Value.Users;

            // Construct helper text for the login prompt - we will inform the users of valid usernames/passwords
            // they can log in with. This is of course not safe, but this is just an example Idp implementation.
            _userInformation = "You can log in as one of the following users: ";
            var separator = "";
            foreach (var (username, password) in _userDatabase)
            {
                _userInformation += $"{separator}{username}  ({password})";
                separator = ", ";
            }

        }

        /// <summary>
        /// Handler that converts an authorization response from Heimdall into the next appropriate action.
        /// </summary>
        /// <param name="authResponse">Authorization response received from Heimdall</param>
        /// <returns></returns>
        private async Task<IActionResult> HandleHeimdallAuthResponse(
           AuthResponse authResponse)
        {
            // This deals with the case where Heimdall has requested us to redirect to the relying party.
            // This can either happen if some types of errors occurred - or if the authorization has completed and
            // we can redirect the browser to the relying party with an appropriate grant.
            if (authResponse?.FinalResponse != null)
            {
                // A session was created - the authorization is finalized and a single sign-on session was created.
                // We store this safely as a HTTP only browser cookie.
                if (authResponse?.FinalResponse?.Session != null)
                {
                    Response.Cookies.SafeAppendCookie("session", authResponse?.FinalResponse?.Session);
                }

                // Redirect to the relying party.
                Response.Headers["Location"] = authResponse?.FinalResponse.Uri;
                return StatusCode(303);
            }
            // This deals with the case when Heimdall has requested us to prompt the user to authenticate themselves.
            else if (authResponse?.Auth != null)
            {
                // Show login prompt.
                return View("Index", new LoginViewModel
                {
                    ApplicationName = _applicationName,
                    AuthSid = authResponse.Auth.AuthSid,
                    UserInformation = _userInformation
                });
            }
            // This deals with the case when Heimdall has requested us to prompt the user for consent.
            // In this basic example we do not request consent from the end-user, but simply approve the consent
            // immediately.
            else if (authResponse?.Consent != null)
            {
                // Inform Heimdall that the user is authenticated and have consented to all requested scopes/claims.
                var consentResponse = await _heimdallClient.ConsentAcceptAsync(new ConsentAcceptRequest
                {
                    AuthSid = authResponse.Consent.AuthSid,
                    Claims = new List<string>(),
                    Scopes = authResponse.Consent.RequestedScopes
                });

                return await HandleHeimdallAuthResponse(consentResponse);
            }
            // This deals with the case where Heimdall informed us something is wrong on a protocol level.
            // Nothing can be done at this but show the message to the end-user.
            // (An example of such an error could be an incorrect client id was specified).
            else if (authResponse.Error != null)
            {
                Response.StatusCode = authResponse.Error.StatusCode;
                return View("~/Views/Shared/Error.cshtml", new ErrorViewModel
                {
                    ErrorTitle = "Oidc Authorize Error",
                    ErrorMessage = authResponse.Error.Error
                });
            }

            // If we got this far, something went wrong.
            return StatusCode(500);
        }

        /// <summary>
        /// Handles the Oauth2 authorize request. This is the Authorization Endpoint specified by OpenID Connect.
        /// </summary>
        [HttpGet]
        [Route("oauth2/v2.0/authorize")]
        public async Task<IActionResult> Oauth2Authorize()
        {
            // Extract the raw query string - Heimdall will process the raw query and decide what is the next
            // appropriate action that the Idp needs to carry out.
            var query = Request.QueryString.Value;

            // Read the stored single sign-on cookie (if any).
            var session = Request.Cookies["session"];

            // Send the authorize requests to Heimdall backchannel api.
            var authResponse = await _heimdallClient.AuthorizeAsync(new AuthorizeRequest
            {
                Query = query,
                Session = session
            });

            // Handle the response from Heimdall.
            return await HandleHeimdallAuthResponse(authResponse);
        }

        /// <summary>
        /// Handles the form POST from the login form. 
        /// This endpoint verifies the username/password that was submitted is correct, and if so finalize the login.
        /// If the credentials are incorrect we display an error message to the end-user.
        /// </summary>
        /// <param name="username">Username entered by the user</param>
        /// <param name="password">Password entered by the user</param>
        /// <param name="authSid">Authorization session identifier stored in a hidden field of the login form</param>
        /// <returns></returns>
        [HttpPost]
        [Route("/login")]
        public async Task<IActionResult> Login(string username, string password, string authSid)
        {
            // Check if the user exists with the correct password in our database.
            if (_userDatabase.Any(u => u.Key == username && u.Value == password))
            {
                // The user entered correct credentials. We registers the end-user as having been authorized
                // using the Heimdall backchannel API.
                var authResponse = await _heimdallClient.AuthorizeAcceptAsync(
                    new AuthorizeAcceptRequest
                    {
                        AuthSid = authSid,
                        Sub = username,
                    }
                );

                return await HandleHeimdallAuthResponse(authResponse);
            }
            // The user entered incorrect credentials - display an error message.
            else
            {
                return View("Index", new LoginViewModel
                {
                    UserName = username,
                    UserInformation = _userInformation,
                    ApplicationName = _applicationName,
                    AuthSid = authSid,
                    ErrorMessage = "Invalid Username/Password",
                });
            }
        }
    }
}
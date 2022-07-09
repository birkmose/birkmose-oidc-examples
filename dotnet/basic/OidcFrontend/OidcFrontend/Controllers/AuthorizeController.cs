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
    public class AuthorizeController : Controller
    {
        private readonly IAuthzApi _authzApi;
        public AuthorizeController(IAuthzApi authzApi)
        {
            _authzApi = authzApi;
        }


        private async Task<IActionResult> HandleHeimdallAuthResponse(
           AuthResponse authResponse)
        {
            // This deals with the case where Heimdall has requested us to redirect to the RP
            // This can either happen if there is some kind of error - or if the authorization is complete and a sesion was created
            if (authResponse?.FinalResponse != null)
            {
                // A session was created - the authorization is finalized
                if (authResponse?.FinalResponse?.Session != null)
                {
                    // If a session was created - set the session cookie safely
                    Response.Cookies.SafeAppendCookie("session", authResponse?.FinalResponse?.Session);
                }

                // Redirect to the RP
                // Please note this is a simplification - the manner this is supposed to be returned to the RP can be either 
                // query redirect, or a FORM POST (for some FAPI flows). Heimdall returns instructions on how to do this,
                // but here we just do a happy path and always do a redirect, as we know this is not a FAPI client :)
                Response.Headers["Location"] = authResponse?.FinalResponse.Uri;
                return StatusCode(303);
            }
            // This deals with the case when Heimdall has requested us to prompt the user to authenthicate him/herself
            else if (authResponse?.Auth != null)
            {

                // Show login prompt with enabled login methods (based on application meta data)
                return View("Index", new LoginViewModel
                {
                    ApplicationName = "Demo Oidc Client",
                    AuthSid = authResponse.Auth.AuthSid,
                });
            }
            // This deals with the case when Heimdall has requested us to prompt the user for consent
            // We "own" our users, so we do not ask for their consent - MinSide doesn't have such a business requirement
            else if (authResponse?.Consent != null)
            {
                // Tell Heimdall that the user is authenthicated and have consented (we just passthrough everything as consented)
                // We also add the addiotional claims such as roles, permissions, etc that we got from the policy API
                var consentResponse = await _authzApi.ConsentAcceptAsync
                    (new ConsentAcceptRequest(
                        authSid: authResponse.Consent.AuthSid,
                        claims: new List<string>(),
                        scopes: authResponse.Consent.RequestedScopes));

                return await HandleHeimdallAuthResponse(consentResponse);
            }
            else if (authResponse.Error != null)
            {
                // Heimdall told us something is wrong on a protocol level. Nothing to do but show the message to the end-user
                Response.StatusCode = authResponse.Error.StatusCode;
                return View("~/Views/Shared/Error.cshtml", new ErrorViewModel
                {
                    Title = "Oidc Authorize Error",
                    Description = authResponse.Error.Error
                });
            }

            return StatusCode(500);
        }

        /// <summary>
        /// Handles the oauth2 authorize request
        /// </summary>
        [HttpGet]
        [Route("oauth2/v2.0/authorize")]
        public async Task<IActionResult> Oauth2Authorize()
        {
            // Extract the full http query string - as we need to send that to Heimdall, so that it can figure out what we are supposed to 
            // do next, according to the OIDC protocol
            var query = Request.QueryString.Value;

            // We ask Heimdall to "peek" the query to return to us the query parameters
            // We need to know the client ID so that we can check our business logic about what kind of login methods
            // are supported based on business logic (not all clients support the same login methods)
            // You could simply just have extracted the client_id part of the querystring, but calling peek below illustrates
            // a mechanism that is guranteed to work with advanced FAPI compliant oauth2 authorization requests.
            // For instance in FAPI - if you use a Pushed Access Request, we do not have the client_id in the query string - it only
            // exists in the backchannel at Heimdall. 
            // So stricly peek is not needed here - we could just extract it directly from the query string, but this is a tech demo
            // of some more advanced Heimdall capabilities


            var session = Request.Cookies["session"];
            var authResponse = await _authzApi.AuthorizeAsync(new AuthorizeRequest
            (
               query: query,
               session: session
            ));

            return await HandleHeimdallAuthResponse(authResponse);

        }

        [HttpPost]
        [Route("/login")]
        public async Task<IActionResult> Login(string user, string authSid, string application)
        {
            if (user == "u") // TBD password
            {
                var authResponse = await _authzApi.AuthorizeAcceptAsync(
                    new AuthorizeAcceptRequest(authSid: authSid, sub: "u"));

                return await HandleHeimdallAuthResponse(authResponse);
            }
            else
            {

                return View("Index", new LoginViewModel
                {
                    UserName = user,
                    ApplicationName = application,
                    AuthSid = authSid,
                    Msg = "Invalid Username/Password",

                }); ;
            }
        }
    }
}
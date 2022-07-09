namespace OidcFrontend.ViewModels
{
    /// <summary>
    /// View-model for the login dialog
    /// </summary>
    public class LoginViewModel
    { 
        /// <summary>
        /// Error message to display (if any)
        /// </summary>
        public string ErrorMessage { get; set; }
        /// <summary>
        /// Entered user-name
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// Application name to display in the title of the login dialog
        /// </summary>
        public string ApplicationName { get; set; }
        /// <summary>
        /// Authorization session identifier, identifying the current authentication session with Heimdall 
        /// </summary>
        public string AuthSid { get; set; }

        /// <summary>
        /// Information message (for demo purposes) of permitted usernames/passwords
        /// </summary>
        public string UserInformation { get; set; }
    }
}
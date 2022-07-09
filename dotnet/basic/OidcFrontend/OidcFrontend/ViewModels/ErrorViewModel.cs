namespace OidcFrontend.ViewModels
{
    /// <summary>
    /// View-model for displaying error messages to the end-user
    /// </summary>
    public class ErrorViewModel
    { 
        /// <summary>
        /// Title of the error message
        /// </summary>
        public string ErrorTitle { get; set; }

        /// <summary>
        /// Error message
        /// </summary>
        public string ErrorMessage { get; set; }
    }
}
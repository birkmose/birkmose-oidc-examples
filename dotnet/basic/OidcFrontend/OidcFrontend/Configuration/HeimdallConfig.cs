namespace OidcFrontend.Configuration
{
    /// <summary>
    /// Configuration of the Heimdall backend
    /// </summary>
    public class HeimdallConfig
    {
        /// <summary>
        /// Server root for the Heimdall backchannel-api
        /// </summary>
        public string ServerRoot { get; set; }
        /// <summary>
        /// Api Key for accessing the Heimdall backchannel-api
        /// </summary>
        public string ApiKey { get; set; }
    }
}

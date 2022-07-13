using System.Collections.Generic;

namespace Heimdall.Examples.Basic.Configuration
{
	/// <summary>
	/// Configuration of the one supported public Oidc Client
	/// </summary>
	public class PublicOidcClientConfig
	{
		/// <summary>
		/// Client identifier used in the authorize requests
		/// </summary>
		public string ClientId { get; set; }

		/// <summary>
		/// Supported return uris
		/// </summary>
		public List<string> ReturnUris { get; set; }

		/// <summary>
		/// Supported post-logout redirect uris
		/// </summary>
		public List<string> PostLogoutRedirectUris { get; set; }
	}
}

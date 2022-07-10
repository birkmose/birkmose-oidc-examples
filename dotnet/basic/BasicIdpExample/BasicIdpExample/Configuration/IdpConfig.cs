﻿namespace BasicIdpExample.Configuration
{
	/// <summary>
	/// Configuration of the Idp Server
	/// </summary>
	public class IdpConfig
	{
		/// <summary>
		/// Application name displayed at login prompt
		/// </summary>
		public string ApplicationName { get; set; }
		/// <summary>
		/// Userdatabase of permitted users, specified as key/value pairs (key = username, value = password)
		/// </summary>
		public Dictionary<string, string> Users { get; set; }
	}
}
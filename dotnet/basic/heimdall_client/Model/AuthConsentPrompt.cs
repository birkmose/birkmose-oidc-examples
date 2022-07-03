/*
 * Heimdall
 *
 * # Introduction    The Heimdall backchannel API is a [RESTful](https://wikipedia.org/wiki/Representational_state_transfer) API that allows you to do authorizations, manage sessions, do CRUD on various objects, etc.          
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = heimdall_client.Client.OpenAPIDateConverter;

namespace heimdall_client.Model
{
    /// <summary>
    /// Indicating that the user is authenthicated (for instance via a single sign-on cookie,   or following an authorize accept operation), but consent is required from   the end user. The frontend should obtain the users consent for the specified scopes and claims.  **NOTE:** This response type is still  being designed, and will be updated in future versions of Hemdall.
    /// </summary>
    [DataContract(Name = "AuthConsentPrompt")]
    public partial class AuthConsentPrompt : IEquatable<AuthConsentPrompt>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthConsentPrompt" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AuthConsentPrompt() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthConsentPrompt" /> class.
        /// </summary>
        /// <param name="authSid">Authorization session identifier of the ongoing authorization session. (required).</param>
        /// <param name="clientId">Client id of the OAuth 2.0/OIDC client that initiated the authorization request. (required).</param>
        /// <param name="sub">The user identifier for the authenticated end-user (required).</param>
        /// <param name="requestedScopes">List of scopes that the client application is requesting (required).</param>
        /// <param name="requestedClaims">List of claims that the client application is requesting (required).</param>
        public AuthConsentPrompt(string authSid = default(string), string clientId = default(string), string sub = default(string), List<string> requestedScopes = default(List<string>), List<string> requestedClaims = default(List<string>))
        {
            // to ensure "authSid" is required (not null)
            if (authSid == null) {
                throw new ArgumentNullException("authSid is a required property for AuthConsentPrompt and cannot be null");
            }
            this.AuthSid = authSid;
            // to ensure "clientId" is required (not null)
            if (clientId == null) {
                throw new ArgumentNullException("clientId is a required property for AuthConsentPrompt and cannot be null");
            }
            this.ClientId = clientId;
            // to ensure "sub" is required (not null)
            if (sub == null) {
                throw new ArgumentNullException("sub is a required property for AuthConsentPrompt and cannot be null");
            }
            this.Sub = sub;
            // to ensure "requestedScopes" is required (not null)
            if (requestedScopes == null) {
                throw new ArgumentNullException("requestedScopes is a required property for AuthConsentPrompt and cannot be null");
            }
            this.RequestedScopes = requestedScopes;
            // to ensure "requestedClaims" is required (not null)
            if (requestedClaims == null) {
                throw new ArgumentNullException("requestedClaims is a required property for AuthConsentPrompt and cannot be null");
            }
            this.RequestedClaims = requestedClaims;
        }

        /// <summary>
        /// Authorization session identifier of the ongoing authorization session.
        /// </summary>
        /// <value>Authorization session identifier of the ongoing authorization session.</value>
        [DataMember(Name = "auth_sid", IsRequired = true, EmitDefaultValue = false)]
        public string AuthSid { get; set; }

        /// <summary>
        /// Client id of the OAuth 2.0/OIDC client that initiated the authorization request.
        /// </summary>
        /// <value>Client id of the OAuth 2.0/OIDC client that initiated the authorization request.</value>
        [DataMember(Name = "client_id", IsRequired = true, EmitDefaultValue = false)]
        public string ClientId { get; set; }

        /// <summary>
        /// The user identifier for the authenticated end-user
        /// </summary>
        /// <value>The user identifier for the authenticated end-user</value>
        [DataMember(Name = "sub", IsRequired = true, EmitDefaultValue = false)]
        public string Sub { get; set; }

        /// <summary>
        /// List of scopes that the client application is requesting
        /// </summary>
        /// <value>List of scopes that the client application is requesting</value>
        [DataMember(Name = "requested_scopes", IsRequired = true, EmitDefaultValue = false)]
        public List<string> RequestedScopes { get; set; }

        /// <summary>
        /// List of claims that the client application is requesting
        /// </summary>
        /// <value>List of claims that the client application is requesting</value>
        [DataMember(Name = "requested_claims", IsRequired = true, EmitDefaultValue = false)]
        public List<string> RequestedClaims { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AuthConsentPrompt {\n");
            sb.Append("  AuthSid: ").Append(AuthSid).Append("\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  Sub: ").Append(Sub).Append("\n");
            sb.Append("  RequestedScopes: ").Append(RequestedScopes).Append("\n");
            sb.Append("  RequestedClaims: ").Append(RequestedClaims).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as AuthConsentPrompt);
        }

        /// <summary>
        /// Returns true if AuthConsentPrompt instances are equal
        /// </summary>
        /// <param name="input">Instance of AuthConsentPrompt to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuthConsentPrompt input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AuthSid == input.AuthSid ||
                    (this.AuthSid != null &&
                    this.AuthSid.Equals(input.AuthSid))
                ) && 
                (
                    this.ClientId == input.ClientId ||
                    (this.ClientId != null &&
                    this.ClientId.Equals(input.ClientId))
                ) && 
                (
                    this.Sub == input.Sub ||
                    (this.Sub != null &&
                    this.Sub.Equals(input.Sub))
                ) && 
                (
                    this.RequestedScopes == input.RequestedScopes ||
                    this.RequestedScopes != null &&
                    input.RequestedScopes != null &&
                    this.RequestedScopes.SequenceEqual(input.RequestedScopes)
                ) && 
                (
                    this.RequestedClaims == input.RequestedClaims ||
                    this.RequestedClaims != null &&
                    input.RequestedClaims != null &&
                    this.RequestedClaims.SequenceEqual(input.RequestedClaims)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.AuthSid != null)
                {
                    hashCode = (hashCode * 59) + this.AuthSid.GetHashCode();
                }
                if (this.ClientId != null)
                {
                    hashCode = (hashCode * 59) + this.ClientId.GetHashCode();
                }
                if (this.Sub != null)
                {
                    hashCode = (hashCode * 59) + this.Sub.GetHashCode();
                }
                if (this.RequestedScopes != null)
                {
                    hashCode = (hashCode * 59) + this.RequestedScopes.GetHashCode();
                }
                if (this.RequestedClaims != null)
                {
                    hashCode = (hashCode * 59) + this.RequestedClaims.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}

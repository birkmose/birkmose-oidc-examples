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
    /// AuthResponse
    /// </summary>
    [DataContract(Name = "AuthResponse")]
    public partial class AuthResponse : IEquatable<AuthResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthResponse" /> class.
        /// </summary>
        /// <param name="auth">auth.</param>
        /// <param name="finalResponse">finalResponse.</param>
        /// <param name="consent">consent.</param>
        /// <param name="error">error.</param>
        public AuthResponse(AuthPrompt auth = default(AuthPrompt), AuthFinalResponse finalResponse = default(AuthFinalResponse), AuthConsentPrompt consent = default(AuthConsentPrompt), AuthError error = default(AuthError))
        {
            this.Auth = auth;
            this.FinalResponse = finalResponse;
            this.Consent = consent;
            this.Error = error;
        }

        /// <summary>
        /// Gets or Sets Auth
        /// </summary>
        [DataMember(Name = "auth", EmitDefaultValue = false)]
        public AuthPrompt Auth { get; set; }

        /// <summary>
        /// Gets or Sets FinalResponse
        /// </summary>
        [DataMember(Name = "final_response", EmitDefaultValue = false)]
        public AuthFinalResponse FinalResponse { get; set; }

        /// <summary>
        /// Gets or Sets Consent
        /// </summary>
        [DataMember(Name = "consent", EmitDefaultValue = false)]
        public AuthConsentPrompt Consent { get; set; }

        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name = "error", EmitDefaultValue = false)]
        public AuthError Error { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AuthResponse {\n");
            sb.Append("  Auth: ").Append(Auth).Append("\n");
            sb.Append("  FinalResponse: ").Append(FinalResponse).Append("\n");
            sb.Append("  Consent: ").Append(Consent).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
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
            return this.Equals(input as AuthResponse);
        }

        /// <summary>
        /// Returns true if AuthResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of AuthResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuthResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Auth == input.Auth ||
                    (this.Auth != null &&
                    this.Auth.Equals(input.Auth))
                ) && 
                (
                    this.FinalResponse == input.FinalResponse ||
                    (this.FinalResponse != null &&
                    this.FinalResponse.Equals(input.FinalResponse))
                ) && 
                (
                    this.Consent == input.Consent ||
                    (this.Consent != null &&
                    this.Consent.Equals(input.Consent))
                ) && 
                (
                    this.Error == input.Error ||
                    (this.Error != null &&
                    this.Error.Equals(input.Error))
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
                if (this.Auth != null)
                {
                    hashCode = (hashCode * 59) + this.Auth.GetHashCode();
                }
                if (this.FinalResponse != null)
                {
                    hashCode = (hashCode * 59) + this.FinalResponse.GetHashCode();
                }
                if (this.Consent != null)
                {
                    hashCode = (hashCode * 59) + this.Consent.GetHashCode();
                }
                if (this.Error != null)
                {
                    hashCode = (hashCode * 59) + this.Error.GetHashCode();
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

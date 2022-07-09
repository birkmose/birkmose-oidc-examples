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
using OpenAPIDateConverter = HeimdallClient.Client.OpenAPIDateConverter;

namespace HeimdallClient.Model
{
    /// <summary>
    /// AuthorizeDataRequest
    /// </summary>
    [DataContract(Name = "AuthorizeDataRequest")]
    public partial class AuthorizeDataRequest : IEquatable<AuthorizeDataRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorizeDataRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AuthorizeDataRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorizeDataRequest" /> class.
        /// </summary>
        /// <param name="authSid">Authorization session identifier of the ongoing authorization session. (required).</param>
        /// <param name="data">Arbitrary data to append to the authorization session. (required).</param>
        public AuthorizeDataRequest(string authSid = default(string), Dictionary<string, Object> data = default(Dictionary<string, Object>))
        {
            // to ensure "authSid" is required (not null)
            if (authSid == null) {
                throw new ArgumentNullException("authSid is a required property for AuthorizeDataRequest and cannot be null");
            }
            this.AuthSid = authSid;
            // to ensure "data" is required (not null)
            if (data == null) {
                throw new ArgumentNullException("data is a required property for AuthorizeDataRequest and cannot be null");
            }
            this.Data = data;
        }

        /// <summary>
        /// Authorization session identifier of the ongoing authorization session.
        /// </summary>
        /// <value>Authorization session identifier of the ongoing authorization session.</value>
        [DataMember(Name = "auth_sid", IsRequired = true, EmitDefaultValue = false)]
        public string AuthSid { get; set; }

        /// <summary>
        /// Arbitrary data to append to the authorization session.
        /// </summary>
        /// <value>Arbitrary data to append to the authorization session.</value>
        [DataMember(Name = "data", IsRequired = true, EmitDefaultValue = false)]
        public Dictionary<string, Object> Data { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AuthorizeDataRequest {\n");
            sb.Append("  AuthSid: ").Append(AuthSid).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
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
            return this.Equals(input as AuthorizeDataRequest);
        }

        /// <summary>
        /// Returns true if AuthorizeDataRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of AuthorizeDataRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuthorizeDataRequest input)
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
                    this.Data == input.Data ||
                    this.Data != null &&
                    input.Data != null &&
                    this.Data.SequenceEqual(input.Data)
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
                if (this.Data != null)
                {
                    hashCode = (hashCode * 59) + this.Data.GetHashCode();
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
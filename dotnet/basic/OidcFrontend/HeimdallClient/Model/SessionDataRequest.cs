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
    /// SessionDataRequest
    /// </summary>
    [DataContract(Name = "SessionDataRequest")]
    public partial class SessionDataRequest : IEquatable<SessionDataRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SessionDataRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SessionDataRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SessionDataRequest" /> class.
        /// </summary>
        /// <param name="sid">Session identifier. (required).</param>
        /// <param name="data">Arbitrary data to append to the session. (required).</param>
        public SessionDataRequest(string sid = default(string), Dictionary<string, Object> data = default(Dictionary<string, Object>))
        {
            // to ensure "sid" is required (not null)
            if (sid == null) {
                throw new ArgumentNullException("sid is a required property for SessionDataRequest and cannot be null");
            }
            this.Sid = sid;
            // to ensure "data" is required (not null)
            if (data == null) {
                throw new ArgumentNullException("data is a required property for SessionDataRequest and cannot be null");
            }
            this.Data = data;
        }

        /// <summary>
        /// Session identifier.
        /// </summary>
        /// <value>Session identifier.</value>
        [DataMember(Name = "sid", IsRequired = true, EmitDefaultValue = false)]
        public string Sid { get; set; }

        /// <summary>
        /// Arbitrary data to append to the session.
        /// </summary>
        /// <value>Arbitrary data to append to the session.</value>
        [DataMember(Name = "data", IsRequired = true, EmitDefaultValue = false)]
        public Dictionary<string, Object> Data { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SessionDataRequest {\n");
            sb.Append("  Sid: ").Append(Sid).Append("\n");
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
            return this.Equals(input as SessionDataRequest);
        }

        /// <summary>
        /// Returns true if SessionDataRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SessionDataRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SessionDataRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Sid == input.Sid ||
                    (this.Sid != null &&
                    this.Sid.Equals(input.Sid))
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
                if (this.Sid != null)
                {
                    hashCode = (hashCode * 59) + this.Sid.GetHashCode();
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
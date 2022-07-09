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
    /// LogoutSessionState
    /// </summary>
    [DataContract(Name = "LogoutSessionState")]
    public partial class LogoutSessionState : IEquatable<LogoutSessionState>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LogoutSessionState" /> class.
        /// </summary>
        /// <param name="logoutSid">Logout session identifier of the ongoing logout session..</param>
        /// <param name="jsonData">Arbitrary data (key/value pairs of data) to append to the ongoing logout session..</param>
        public LogoutSessionState(string logoutSid = default(string), Dictionary<string, Object> jsonData = default(Dictionary<string, Object>))
        {
            this.LogoutSid = logoutSid;
            this.JsonData = jsonData;
        }

        /// <summary>
        /// Logout session identifier of the ongoing logout session.
        /// </summary>
        /// <value>Logout session identifier of the ongoing logout session.</value>
        [DataMember(Name = "logout_sid", EmitDefaultValue = true)]
        public string LogoutSid { get; set; }

        /// <summary>
        /// Arbitrary data (key/value pairs of data) to append to the ongoing logout session.
        /// </summary>
        /// <value>Arbitrary data (key/value pairs of data) to append to the ongoing logout session.</value>
        [DataMember(Name = "json_data", EmitDefaultValue = true)]
        public Dictionary<string, Object> JsonData { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LogoutSessionState {\n");
            sb.Append("  LogoutSid: ").Append(LogoutSid).Append("\n");
            sb.Append("  JsonData: ").Append(JsonData).Append("\n");
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
            return this.Equals(input as LogoutSessionState);
        }

        /// <summary>
        /// Returns true if LogoutSessionState instances are equal
        /// </summary>
        /// <param name="input">Instance of LogoutSessionState to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LogoutSessionState input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.LogoutSid == input.LogoutSid ||
                    (this.LogoutSid != null &&
                    this.LogoutSid.Equals(input.LogoutSid))
                ) && 
                (
                    this.JsonData == input.JsonData ||
                    this.JsonData != null &&
                    input.JsonData != null &&
                    this.JsonData.SequenceEqual(input.JsonData)
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
                if (this.LogoutSid != null)
                {
                    hashCode = (hashCode * 59) + this.LogoutSid.GetHashCode();
                }
                if (this.JsonData != null)
                {
                    hashCode = (hashCode * 59) + this.JsonData.GetHashCode();
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
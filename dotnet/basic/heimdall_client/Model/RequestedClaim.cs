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
    /// RequestedClaim
    /// </summary>
    [DataContract(Name = "RequestedClaim")]
    public partial class RequestedClaim : IEquatable<RequestedClaim>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RequestedClaim" /> class.
        /// </summary>
        /// <param name="essential">essential.</param>
        /// <param name="value">value.</param>
        /// <param name="values">values.</param>
        public RequestedClaim(bool essential = default(bool), string value = default(string), List<string> values = default(List<string>))
        {
            this.Essential = essential;
            this.Value = value;
            this.Values = values;
        }

        /// <summary>
        /// Gets or Sets Essential
        /// </summary>
        [DataMember(Name = "essential", EmitDefaultValue = true)]
        public bool Essential { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name = "value", EmitDefaultValue = true)]
        public string Value { get; set; }

        /// <summary>
        /// Gets or Sets Values
        /// </summary>
        [DataMember(Name = "values", EmitDefaultValue = true)]
        public List<string> Values { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RequestedClaim {\n");
            sb.Append("  Essential: ").Append(Essential).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Values: ").Append(Values).Append("\n");
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
            return this.Equals(input as RequestedClaim);
        }

        /// <summary>
        /// Returns true if RequestedClaim instances are equal
        /// </summary>
        /// <param name="input">Instance of RequestedClaim to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RequestedClaim input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Essential == input.Essential ||
                    this.Essential.Equals(input.Essential)
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.Values == input.Values ||
                    this.Values != null &&
                    input.Values != null &&
                    this.Values.SequenceEqual(input.Values)
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
                hashCode = (hashCode * 59) + this.Essential.GetHashCode();
                if (this.Value != null)
                {
                    hashCode = (hashCode * 59) + this.Value.GetHashCode();
                }
                if (this.Values != null)
                {
                    hashCode = (hashCode * 59) + this.Values.GetHashCode();
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

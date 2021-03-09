/*
 * OBADA Client Helper API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.0.1
 * Contact: techops@obada.io
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Obada.Client.Client.OpenAPIDateConverter;

namespace Obada.Client.Model
{
    /// <summary>
    /// Document hashlink
    /// </summary>
    [DataContract]
    public partial class LocalObitDocuments :  IEquatable<LocalObitDocuments>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LocalObitDocuments" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LocalObitDocuments() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LocalObitDocuments" /> class.
        /// </summary>
        /// <param name="name">Associative name of hashlink (required).</param>
        /// <param name="hashlink">Hashlink (required).</param>
        public LocalObitDocuments(string name = default(string), string hashlink = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for LocalObitDocuments and cannot be null");
            }
            else
            {
                this.Name = name;
            }

            // to ensure "hashlink" is required (not null)
            if (hashlink == null)
            {
                throw new InvalidDataException("hashlink is a required property for LocalObitDocuments and cannot be null");
            }
            else
            {
                this.Hashlink = hashlink;
            }

        }

        /// <summary>
        /// Associative name of hashlink
        /// </summary>
        /// <value>Associative name of hashlink</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Hashlink
        /// </summary>
        /// <value>Hashlink</value>
        [DataMember(Name="hashlink", EmitDefaultValue=true)]
        public string Hashlink { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LocalObitDocuments {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Hashlink: ").Append(Hashlink).Append("\n");
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
            return this.Equals(input as LocalObitDocuments);
        }

        /// <summary>
        /// Returns true if LocalObitDocuments instances are equal
        /// </summary>
        /// <param name="input">Instance of LocalObitDocuments to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LocalObitDocuments input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Hashlink == input.Hashlink ||
                    (this.Hashlink != null &&
                    this.Hashlink.Equals(input.Hashlink))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Hashlink != null)
                    hashCode = hashCode * 59 + this.Hashlink.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}

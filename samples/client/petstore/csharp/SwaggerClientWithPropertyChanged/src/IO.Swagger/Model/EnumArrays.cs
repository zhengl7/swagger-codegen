/* 
 * Swagger Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * OpenAPI spec version: 1.0.0
 * Contact: apiteam@swagger.io
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
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
using PropertyChanged;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// EnumArrays
    /// </summary>
    [DataContract]
    [ImplementPropertyChanged]
    public partial class EnumArrays :  IEquatable<EnumArrays>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets JustSymbol
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum JustSymbolEnum
        {
            
            /// <summary>
            /// Enum GreaterThanOrEqualTo for ">="
            /// </summary>
            [EnumMember(Value = ">=")]
            GreaterThanOrEqualTo = 1,
            
            /// <summary>
            /// Enum Dollar for "$"
            /// </summary>
            [EnumMember(Value = "$")]
            Dollar = 2
        }

        /// <summary>
        /// Gets or Sets JustSymbol
        /// </summary>
        [DataMember(Name="just_symbol", EmitDefaultValue=false)]
        public JustSymbolEnum? JustSymbol { get; set; }
        /// <summary>
        /// Gets or Sets ArrayEnum
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ArrayEnumEnum
        {
            
            /// <summary>
            /// Enum Fish for "fish"
            /// </summary>
            [EnumMember(Value = "fish")]
            Fish = 1,
            
            /// <summary>
            /// Enum Crab for "crab"
            /// </summary>
            [EnumMember(Value = "crab")]
            Crab = 2
        }


        /// <summary>
        /// Gets or Sets ArrayEnum
        /// </summary>
        [DataMember(Name="array_enum", EmitDefaultValue=false)]
        public List<ArrayEnumEnum> ArrayEnum { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="EnumArrays" /> class.
        /// </summary>
        /// <param name="JustSymbol">JustSymbol.</param>
        /// <param name="ArrayEnum">ArrayEnum.</param>
        public EnumArrays(JustSymbolEnum? JustSymbol = default(JustSymbolEnum?), List<ArrayEnumEnum> ArrayEnum = default(List<ArrayEnumEnum>))
        {
            this.JustSymbol = JustSymbol;
            this.ArrayEnum = ArrayEnum;
        }
        


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EnumArrays {\n");
            sb.Append("  JustSymbol: ").Append(JustSymbol).Append("\n");
            sb.Append("  ArrayEnum: ").Append(ArrayEnum).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as EnumArrays);
        }

        /// <summary>
        /// Returns true if EnumArrays instances are equal
        /// </summary>
        /// <param name="input">Instance of EnumArrays to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EnumArrays input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.JustSymbol == input.JustSymbol ||
                    (this.JustSymbol != null &&
                    this.JustSymbol.Equals(input.JustSymbol))
                ) && 
                (
                    this.ArrayEnum == input.ArrayEnum ||
                    this.ArrayEnum != null &&
                    this.ArrayEnum.SequenceEqual(input.ArrayEnum)
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
                if (this.JustSymbol != null)
                    hashCode = hashCode * 59 + this.JustSymbol.GetHashCode();
                if (this.ArrayEnum != null)
                    hashCode = hashCode * 59 + this.ArrayEnum.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// Property changed event handler
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Trigger when a property changed
        /// </summary>
        /// <param name="propertyName">Property Name</param>
        public virtual void OnPropertyChanged(string propertyName)
        {
            // NOTE: property changed is handled via "code weaving" using Fody.
            // Properties with setters are modified at compile time to notify of changes.
            var propertyChanged = PropertyChanged;
            if (propertyChanged != null)
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
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

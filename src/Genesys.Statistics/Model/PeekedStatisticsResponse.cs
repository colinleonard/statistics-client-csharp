/* 
 * Statistics Service
 *
 * Statistics Service
 *
 * OpenAPI spec version: 9.0.000.00.353
 * 
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
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = Genesys.Statistics.Client.SwaggerDateConverter;

namespace Genesys.Statistics.Model
{
    /// <summary>
    /// PeekedStatisticsResponse
    /// </summary>
    [DataContract]
    public partial class PeekedStatisticsResponse :  IEquatable<PeekedStatisticsResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PeekedStatisticsResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PeekedStatisticsResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PeekedStatisticsResponse" /> class.
        /// </summary>
        /// <param name="Data">Data.</param>
        /// <param name="Errors">Errors.</param>
        /// <param name="Path">Path.</param>
        /// <param name="Status">Status (required).</param>
        public PeekedStatisticsResponse(PeekedStatistics Data = default(PeekedStatistics), List<ApiResponse> Errors = default(List<ApiResponse>), string Path = default(string), ApiResponseStatus Status = default(ApiResponseStatus))
        {
            // to ensure "Status" is required (not null)
            if (Status == null)
            {
                throw new InvalidDataException("Status is a required property for PeekedStatisticsResponse and cannot be null");
            }
            else
            {
                this.Status = Status;
            }
            this.Data = Data;
            this.Errors = Errors;
            this.Path = Path;
        }
        
        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name="data", EmitDefaultValue=false)]
        public PeekedStatistics Data { get; set; }

        /// <summary>
        /// Gets or Sets Errors
        /// </summary>
        [DataMember(Name="errors", EmitDefaultValue=false)]
        public List<ApiResponse> Errors { get; set; }

        /// <summary>
        /// Gets or Sets Path
        /// </summary>
        [DataMember(Name="path", EmitDefaultValue=false)]
        public string Path { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public ApiResponseStatus Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PeekedStatisticsResponse {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as PeekedStatisticsResponse);
        }

        /// <summary>
        /// Returns true if PeekedStatisticsResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of PeekedStatisticsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PeekedStatisticsResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Data == other.Data ||
                    this.Data != null &&
                    this.Data.Equals(other.Data)
                ) && 
                (
                    this.Errors == other.Errors ||
                    this.Errors != null &&
                    this.Errors.SequenceEqual(other.Errors)
                ) && 
                (
                    this.Path == other.Path ||
                    this.Path != null &&
                    this.Path.Equals(other.Path)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Data != null)
                    hash = hash * 59 + this.Data.GetHashCode();
                if (this.Errors != null)
                    hash = hash * 59 + this.Errors.GetHashCode();
                if (this.Path != null)
                    hash = hash * 59 + this.Path.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                return hash;
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

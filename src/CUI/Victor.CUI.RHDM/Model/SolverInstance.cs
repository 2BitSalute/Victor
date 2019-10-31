/* 
 * KIE Server
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 7.0
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
using SwaggerDateConverter = Victor.CUI.RHDM.KIE.Client.SwaggerDateConverter;

namespace Victor.CUI.RHDM.KIE.Model
{
    /// <summary>
    /// SolverInstance
    /// </summary>
    [DataContract]
    public partial class SolverInstance :  IEquatable<SolverInstance>, IValidatableObject
    {
        /// <summary>
        /// Defines Status
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum NOTSOLVING for value: NOT_SOLVING
            /// </summary>
            [EnumMember(Value = "NOT_SOLVING")]
            NOTSOLVING = 1,
            
            /// <summary>
            /// Enum TERMINATINGEARLY for value: TERMINATING_EARLY
            /// </summary>
            [EnumMember(Value = "TERMINATING_EARLY")]
            TERMINATINGEARLY = 2,
            
            /// <summary>
            /// Enum SOLVING for value: SOLVING
            /// </summary>
            [EnumMember(Value = "SOLVING")]
            SOLVING = 3
        }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SolverInstance" /> class.
        /// </summary>
        /// <param name="containerId">containerId.</param>
        /// <param name="solverId">solverId.</param>
        /// <param name="solverConfigFile">solverConfigFile.</param>
        /// <param name="status">status.</param>
        /// <param name="score">score.</param>
        /// <param name="bestSolution">bestSolution.</param>
        public SolverInstance(string containerId = default(string), string solverId = default(string), string solverConfigFile = default(string), StatusEnum? status = default(StatusEnum?), ScoreWrapper score = default(ScoreWrapper), Object bestSolution = default(Object))
        {
            this.ContainerId = containerId;
            this.SolverId = solverId;
            this.SolverConfigFile = solverConfigFile;
            this.Status = status;
            this.Score = score;
            this.BestSolution = bestSolution;
        }
        
        /// <summary>
        /// Gets or Sets ContainerId
        /// </summary>
        [DataMember(Name="container-id", EmitDefaultValue=false)]
        public string ContainerId { get; set; }

        /// <summary>
        /// Gets or Sets SolverId
        /// </summary>
        [DataMember(Name="solver-id", EmitDefaultValue=false)]
        public string SolverId { get; set; }

        /// <summary>
        /// Gets or Sets SolverConfigFile
        /// </summary>
        [DataMember(Name="solver-config-file", EmitDefaultValue=false)]
        public string SolverConfigFile { get; set; }


        /// <summary>
        /// Gets or Sets Score
        /// </summary>
        [DataMember(Name="score", EmitDefaultValue=false)]
        public ScoreWrapper Score { get; set; }

        /// <summary>
        /// Gets or Sets BestSolution
        /// </summary>
        [DataMember(Name="best-solution", EmitDefaultValue=false)]
        public Object BestSolution { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SolverInstance {\n");
            sb.Append("  ContainerId: ").Append(ContainerId).Append("\n");
            sb.Append("  SolverId: ").Append(SolverId).Append("\n");
            sb.Append("  SolverConfigFile: ").Append(SolverConfigFile).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Score: ").Append(Score).Append("\n");
            sb.Append("  BestSolution: ").Append(BestSolution).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
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
            return this.Equals(input as SolverInstance);
        }

        /// <summary>
        /// Returns true if SolverInstance instances are equal
        /// </summary>
        /// <param name="input">Instance of SolverInstance to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SolverInstance input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ContainerId == input.ContainerId ||
                    (this.ContainerId != null &&
                    this.ContainerId.Equals(input.ContainerId))
                ) && 
                (
                    this.SolverId == input.SolverId ||
                    (this.SolverId != null &&
                    this.SolverId.Equals(input.SolverId))
                ) && 
                (
                    this.SolverConfigFile == input.SolverConfigFile ||
                    (this.SolverConfigFile != null &&
                    this.SolverConfigFile.Equals(input.SolverConfigFile))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Score == input.Score ||
                    (this.Score != null &&
                    this.Score.Equals(input.Score))
                ) && 
                (
                    this.BestSolution == input.BestSolution ||
                    (this.BestSolution != null &&
                    this.BestSolution.Equals(input.BestSolution))
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
                if (this.ContainerId != null)
                    hashCode = hashCode * 59 + this.ContainerId.GetHashCode();
                if (this.SolverId != null)
                    hashCode = hashCode * 59 + this.SolverId.GetHashCode();
                if (this.SolverConfigFile != null)
                    hashCode = hashCode * 59 + this.SolverConfigFile.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Score != null)
                    hashCode = hashCode * 59 + this.Score.GetHashCode();
                if (this.BestSolution != null)
                    hashCode = hashCode * 59 + this.BestSolution.GetHashCode();
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

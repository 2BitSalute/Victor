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
    /// Solvers
    /// </summary>
    [DataContract]
    public partial class Solvers :  IEquatable<Solvers>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Solvers" /> class.
        /// </summary>
        /// <param name="solver">solver.</param>
        public Solvers(List<SolverInstance> solver = default(List<SolverInstance>))
        {
            this.Solver = solver;
        }
        
        /// <summary>
        /// Gets or Sets Solver
        /// </summary>
        [DataMember(Name="solver", EmitDefaultValue=false)]
        public List<SolverInstance> Solver { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Solvers {\n");
            sb.Append("  Solver: ").Append(Solver).Append("\n");
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
            return this.Equals(input as Solvers);
        }

        /// <summary>
        /// Returns true if Solvers instances are equal
        /// </summary>
        /// <param name="input">Instance of Solvers to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Solvers input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Solver == input.Solver ||
                    this.Solver != null &&
                    this.Solver.SequenceEqual(input.Solver)
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
                if (this.Solver != null)
                    hashCode = hashCode * 59 + this.Solver.GetHashCode();
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

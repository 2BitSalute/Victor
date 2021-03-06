﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Victor.CUI.Vish.OpenShift.Client.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    /// <summary>
    /// Parameter defines a name/value variable that is to be processed during
    /// the Template to Config transformation.
    /// </summary>
    public partial class Comgithubopenshiftapitemplatev1Parameter
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Comgithubopenshiftapitemplatev1Parameter class.
        /// </summary>
        public Comgithubopenshiftapitemplatev1Parameter() { }

        /// <summary>
        /// Initializes a new instance of the
        /// Comgithubopenshiftapitemplatev1Parameter class.
        /// </summary>
        public Comgithubopenshiftapitemplatev1Parameter(string name, string description = default(string), string displayName = default(string), string fromProperty = default(string), string generate = default(string), bool? required = default(bool?), string value = default(string))
        {
            Description = description;
            DisplayName = displayName;
            FromProperty = fromProperty;
            Generate = generate;
            Name = name;
            Required = required;
            Value = value;
        }

        /// <summary>
        /// Description of a parameter. Optional.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Optional: The name that will show in UI instead of parameter 'Name'
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// From is an input value for the generator. Optional.
        /// </summary>
        [JsonProperty(PropertyName = "from")]
        public string FromProperty { get; set; }

        /// <summary>
        /// generate specifies the generator to be used to generate random
        /// string from an input value specified by From field. The result
        /// string is stored into Value field. If empty, no generator is
        /// being used, leaving the result Value untouched. Optional.
        /// 
        /// The only supported generator is "expression", which accepts a
        /// "from" value in the form of a simple regular expression
        /// containing the range expression "[a-zA-Z0-9]", and the length
        /// expression "a{length}".
        /// 
        /// Examples:
        /// 
        /// from             | value -----------------------------
        /// "test[0-9]{1}x"  | "test7x" "[0-1]{8}"       | "01001100"
        /// "0x[A-F0-9]{4}"  | "0xB3AF" "[a-zA-Z0-9]{8}" | "hW4yQU5i"
        /// </summary>
        [JsonProperty(PropertyName = "generate")]
        public string Generate { get; set; }

        /// <summary>
        /// Name must be set and it can be referenced in Template Items using
        /// ${PARAMETER_NAME}. Required.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Optional: Indicates the parameter must have a value.  Defaults to
        /// false.
        /// </summary>
        [JsonProperty(PropertyName = "required")]
        public bool? Required { get; set; }

        /// <summary>
        /// Value holds the Parameter data. If specified, the generator will
        /// be ignored. The value replaces all occurrences of the Parameter
        /// ${Name} expression during the Template to Config transformation.
        /// Optional.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
        }
    }
}

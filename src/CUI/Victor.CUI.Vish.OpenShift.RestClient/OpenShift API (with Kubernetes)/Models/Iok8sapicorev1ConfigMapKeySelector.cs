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
    /// Selects a key from a ConfigMap.
    /// </summary>
    public partial class Iok8sapicorev1ConfigMapKeySelector
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Iok8sapicorev1ConfigMapKeySelector class.
        /// </summary>
        public Iok8sapicorev1ConfigMapKeySelector() { }

        /// <summary>
        /// Initializes a new instance of the
        /// Iok8sapicorev1ConfigMapKeySelector class.
        /// </summary>
        public Iok8sapicorev1ConfigMapKeySelector(string key, string name = default(string), bool? optional = default(bool?))
        {
            Key = key;
            Name = name;
            Optional = optional;
        }

        /// <summary>
        /// The key to select.
        /// </summary>
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }

        /// <summary>
        /// Name of the referent. More info:
        /// https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Specify whether the ConfigMap or it's key must be defined
        /// </summary>
        [JsonProperty(PropertyName = "optional")]
        public bool? Optional { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (Key == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Key");
            }
        }
    }
}

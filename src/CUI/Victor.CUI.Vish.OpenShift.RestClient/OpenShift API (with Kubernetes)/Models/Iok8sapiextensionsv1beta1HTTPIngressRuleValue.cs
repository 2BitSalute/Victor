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
    /// HTTPIngressRuleValue is a list of http selectors pointing to backends.
    /// In the example: http://&lt;host&gt;/&lt;path&gt;?&lt;searchpart&gt;
    /// -&gt; backend where where parts of the url correspond to RFC 3986,
    /// this resource will be used to match against everything after the last
    /// '/' and before the first '?' or '#'.
    /// </summary>
    public partial class Iok8sapiextensionsv1beta1HTTPIngressRuleValue
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Iok8sapiextensionsv1beta1HTTPIngressRuleValue class.
        /// </summary>
        public Iok8sapiextensionsv1beta1HTTPIngressRuleValue() { }

        /// <summary>
        /// Initializes a new instance of the
        /// Iok8sapiextensionsv1beta1HTTPIngressRuleValue class.
        /// </summary>
        public Iok8sapiextensionsv1beta1HTTPIngressRuleValue(IList<Iok8sapiextensionsv1beta1HTTPIngressPath> paths)
        {
            Paths = paths;
        }

        /// <summary>
        /// A collection of paths that map requests to backends.
        /// </summary>
        [JsonProperty(PropertyName = "paths")]
        public IList<Iok8sapiextensionsv1beta1HTTPIngressPath> Paths { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (Paths == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Paths");
            }
            if (this.Paths != null)
            {
                foreach (var element in this.Paths)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}

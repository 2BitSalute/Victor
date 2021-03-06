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
    /// ImageStreamSpec represents options for ImageStreams.
    /// </summary>
    public partial class Comgithubopenshiftapiimagev1ImageStreamSpec
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Comgithubopenshiftapiimagev1ImageStreamSpec class.
        /// </summary>
        public Comgithubopenshiftapiimagev1ImageStreamSpec() { }

        /// <summary>
        /// Initializes a new instance of the
        /// Comgithubopenshiftapiimagev1ImageStreamSpec class.
        /// </summary>
        public Comgithubopenshiftapiimagev1ImageStreamSpec(string dockerImageRepository = default(string), Comgithubopenshiftapiimagev1ImageLookupPolicy lookupPolicy = default(Comgithubopenshiftapiimagev1ImageLookupPolicy), IList<Comgithubopenshiftapiimagev1TagReference> tags = default(IList<Comgithubopenshiftapiimagev1TagReference>))
        {
            DockerImageRepository = dockerImageRepository;
            LookupPolicy = lookupPolicy;
            Tags = tags;
        }

        /// <summary>
        /// dockerImageRepository is optional, if specified this stream is
        /// backed by a Docker repository on this server Deprecated: This
        /// field is deprecated as of v3.7 and will be removed in a future
        /// release. Specify the source for the tags to be imported in each
        /// tag via the spec.tags.from reference instead.
        /// </summary>
        [JsonProperty(PropertyName = "dockerImageRepository")]
        public string DockerImageRepository { get; set; }

        /// <summary>
        /// lookupPolicy controls how other resources reference images within
        /// this namespace.
        /// </summary>
        [JsonProperty(PropertyName = "lookupPolicy")]
        public Comgithubopenshiftapiimagev1ImageLookupPolicy LookupPolicy { get; set; }

        /// <summary>
        /// tags map arbitrary string values to specific image locators
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IList<Comgithubopenshiftapiimagev1TagReference> Tags { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (this.LookupPolicy != null)
            {
                this.LookupPolicy.Validate();
            }
            if (this.Tags != null)
            {
                foreach (var element in this.Tags)
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

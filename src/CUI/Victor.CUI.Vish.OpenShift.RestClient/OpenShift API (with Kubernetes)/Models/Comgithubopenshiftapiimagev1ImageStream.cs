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
    /// ImageStream stores a mapping of tags to images, metadata overrides
    /// that are applied when images are tagged in a stream, and an optional
    /// reference to a Docker image repository on a registry.
    /// </summary>
    public partial class Comgithubopenshiftapiimagev1ImageStream
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Comgithubopenshiftapiimagev1ImageStream class.
        /// </summary>
        public Comgithubopenshiftapiimagev1ImageStream() { }

        /// <summary>
        /// Initializes a new instance of the
        /// Comgithubopenshiftapiimagev1ImageStream class.
        /// </summary>
        public Comgithubopenshiftapiimagev1ImageStream(Comgithubopenshiftapiimagev1ImageStreamSpec spec, string apiVersion = default(string), string kind = default(string), Iok8sapimachinerypkgapismetav1ObjectMeta metadata = default(Iok8sapimachinerypkgapismetav1ObjectMeta), Comgithubopenshiftapiimagev1ImageStreamStatus status = default(Comgithubopenshiftapiimagev1ImageStreamStatus))
        {
            ApiVersion = apiVersion;
            Kind = kind;
            Metadata = metadata;
            Spec = spec;
            Status = status;
        }

        /// <summary>
        /// APIVersion defines the versioned schema of this representation of
        /// an object. Servers should convert recognized schemas to the
        /// latest internal value, and may reject unrecognized values. More
        /// info:
        /// https://git.k8s.io/community/contributors/devel/api-conventions.md#resources
        /// </summary>
        [JsonProperty(PropertyName = "apiVersion")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// Kind is a string value representing the REST resource this object
        /// represents. Servers may infer this from the endpoint the client
        /// submits requests to. Cannot be updated. In CamelCase. More info:
        /// https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        public string Kind { get; set; }

        /// <summary>
        /// Standard object's metadata.
        /// </summary>
        [JsonProperty(PropertyName = "metadata")]
        public Iok8sapimachinerypkgapismetav1ObjectMeta Metadata { get; set; }

        /// <summary>
        /// Spec describes the desired state of this stream
        /// </summary>
        [JsonProperty(PropertyName = "spec")]
        public Comgithubopenshiftapiimagev1ImageStreamSpec Spec { get; set; }

        /// <summary>
        /// Status describes the current state of this stream
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public Comgithubopenshiftapiimagev1ImageStreamStatus Status { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (Spec == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Spec");
            }
            if (this.Metadata != null)
            {
                this.Metadata.Validate();
            }
            if (this.Spec != null)
            {
                this.Spec.Validate();
            }
            if (this.Status != null)
            {
                this.Status.Validate();
            }
        }
    }
}

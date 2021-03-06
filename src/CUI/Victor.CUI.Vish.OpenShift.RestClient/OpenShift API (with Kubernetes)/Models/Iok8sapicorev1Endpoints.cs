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
    /// Endpoints is a collection of endpoints that implement the actual
    /// service. Example:
    /// Name: "mysvc",
    /// Subsets: [
    /// {
    /// Addresses: [{"ip": "10.10.1.1"}, {"ip": "10.10.2.2"}],
    /// Ports: [{"name": "a", "port": 8675}, {"name": "b", "port": 309}]
    /// },
    /// {
    /// Addresses: [{"ip": "10.10.3.3"}],
    /// Ports: [{"name": "a", "port": 93}, {"name": "b", "port": 76}]
    /// },
    /// ]
    /// </summary>
    public partial class Iok8sapicorev1Endpoints
    {
        /// <summary>
        /// Initializes a new instance of the Iok8sapicorev1Endpoints class.
        /// </summary>
        public Iok8sapicorev1Endpoints() { }

        /// <summary>
        /// Initializes a new instance of the Iok8sapicorev1Endpoints class.
        /// </summary>
        public Iok8sapicorev1Endpoints(IList<Iok8sapicorev1EndpointSubset> subsets, string apiVersion = default(string), string kind = default(string), Iok8sapimachinerypkgapismetav1ObjectMeta metadata = default(Iok8sapimachinerypkgapismetav1ObjectMeta))
        {
            ApiVersion = apiVersion;
            Kind = kind;
            Metadata = metadata;
            Subsets = subsets;
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
        /// Standard object's metadata. More info:
        /// https://git.k8s.io/community/contributors/devel/api-conventions.md#metadata
        /// </summary>
        [JsonProperty(PropertyName = "metadata")]
        public Iok8sapimachinerypkgapismetav1ObjectMeta Metadata { get; set; }

        /// <summary>
        /// The set of all endpoints is the union of all subsets. Addresses
        /// are placed into subsets according to the IPs they share. A single
        /// address with multiple ports, some of which are ready and some of
        /// which are not (because they come from different containers) will
        /// result in the address being displayed in different subsets for
        /// the different ports. No address will appear in both Addresses and
        /// NotReadyAddresses in the same subset. Sets of addresses and ports
        /// that comprise a service.
        /// </summary>
        [JsonProperty(PropertyName = "subsets")]
        public IList<Iok8sapicorev1EndpointSubset> Subsets { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (Subsets == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Subsets");
            }
            if (this.Metadata != null)
            {
                this.Metadata.Validate();
            }
        }
    }
}

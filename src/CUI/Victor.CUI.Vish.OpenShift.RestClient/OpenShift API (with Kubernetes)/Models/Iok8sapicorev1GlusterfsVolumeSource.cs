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
    /// Represents a Glusterfs mount that lasts the lifetime of a pod.
    /// Glusterfs volumes do not support ownership management or SELinux
    /// relabeling.
    /// </summary>
    public partial class Iok8sapicorev1GlusterfsVolumeSource
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Iok8sapicorev1GlusterfsVolumeSource class.
        /// </summary>
        public Iok8sapicorev1GlusterfsVolumeSource() { }

        /// <summary>
        /// Initializes a new instance of the
        /// Iok8sapicorev1GlusterfsVolumeSource class.
        /// </summary>
        public Iok8sapicorev1GlusterfsVolumeSource(string endpoints, string path, bool? readOnlyProperty = default(bool?))
        {
            Endpoints = endpoints;
            Path = path;
            ReadOnlyProperty = readOnlyProperty;
        }

        /// <summary>
        /// EndpointsName is the endpoint name that details Glusterfs
        /// topology. More info:
        /// https://releases.k8s.io/HEAD/examples/volumes/glusterfs/README.md#create-a-pod
        /// </summary>
        [JsonProperty(PropertyName = "endpoints")]
        public string Endpoints { get; set; }

        /// <summary>
        /// Path is the Glusterfs volume path. More info:
        /// https://releases.k8s.io/HEAD/examples/volumes/glusterfs/README.md#create-a-pod
        /// </summary>
        [JsonProperty(PropertyName = "path")]
        public string Path { get; set; }

        /// <summary>
        /// ReadOnly here will force the Glusterfs volume to be mounted with
        /// read-only permissions. Defaults to false. More info:
        /// https://releases.k8s.io/HEAD/examples/volumes/glusterfs/README.md#create-a-pod
        /// </summary>
        [JsonProperty(PropertyName = "readOnly")]
        public bool? ReadOnlyProperty { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (Endpoints == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Endpoints");
            }
            if (Path == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Path");
            }
        }
    }
}

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
    /// HTTPIngressPath associates a path regex with a backend. Incoming urls
    /// matching the path are forwarded to the backend.
    /// </summary>
    public partial class Iok8sapiextensionsv1beta1HTTPIngressPath
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Iok8sapiextensionsv1beta1HTTPIngressPath class.
        /// </summary>
        public Iok8sapiextensionsv1beta1HTTPIngressPath() { }

        /// <summary>
        /// Initializes a new instance of the
        /// Iok8sapiextensionsv1beta1HTTPIngressPath class.
        /// </summary>
        public Iok8sapiextensionsv1beta1HTTPIngressPath(Iok8sapiextensionsv1beta1IngressBackend backend, string path = default(string))
        {
            Backend = backend;
            Path = path;
        }

        /// <summary>
        /// Backend defines the referenced service endpoint to which the
        /// traffic will be forwarded to.
        /// </summary>
        [JsonProperty(PropertyName = "backend")]
        public Iok8sapiextensionsv1beta1IngressBackend Backend { get; set; }

        /// <summary>
        /// Path is an extended POSIX regex as defined by IEEE Std 1003.1,
        /// (i.e this follows the egrep/unix syntax, not the perl syntax)
        /// matched against the path of an incoming request. Currently it can
        /// contain characters disallowed from the conventional "path" part
        /// of a URL as defined by RFC 3986. Paths must begin with a '/'. If
        /// unspecified, the path defaults to a catch all sending traffic to
        /// the backend.
        /// </summary>
        [JsonProperty(PropertyName = "path")]
        public string Path { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (Backend == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Backend");
            }
            if (this.Backend != null)
            {
                this.Backend.Validate();
            }
        }
    }
}

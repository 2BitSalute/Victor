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
    /// RunAsUserStrategyOptions defines the strategy type and any options
    /// used to create the strategy.
    /// </summary>
    public partial class Comgithubopenshiftapisecurityv1RunAsUserStrategyOptions
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Comgithubopenshiftapisecurityv1RunAsUserStrategyOptions class.
        /// </summary>
        public Comgithubopenshiftapisecurityv1RunAsUserStrategyOptions() { }

        /// <summary>
        /// Initializes a new instance of the
        /// Comgithubopenshiftapisecurityv1RunAsUserStrategyOptions class.
        /// </summary>
        public Comgithubopenshiftapisecurityv1RunAsUserStrategyOptions(string type = default(string), long? uid = default(long?), long? uidRangeMax = default(long?), long? uidRangeMin = default(long?))
        {
            Type = type;
            Uid = uid;
            UidRangeMax = uidRangeMax;
            UidRangeMin = uidRangeMin;
        }

        /// <summary>
        /// Type is the strategy that will dictate what RunAsUser is used in
        /// the SecurityContext.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// UID is the user id that containers must run as.  Required for the
        /// MustRunAs strategy if not using namespace/service account
        /// allocated uids.
        /// </summary>
        [JsonProperty(PropertyName = "uid")]
        public long? Uid { get; set; }

        /// <summary>
        /// UIDRangeMax defines the max value for a strategy that allocates by
        /// range.
        /// </summary>
        [JsonProperty(PropertyName = "uidRangeMax")]
        public long? UidRangeMax { get; set; }

        /// <summary>
        /// UIDRangeMin defines the min value for a strategy that allocates by
        /// range.
        /// </summary>
        [JsonProperty(PropertyName = "uidRangeMin")]
        public long? UidRangeMin { get; set; }

    }
}

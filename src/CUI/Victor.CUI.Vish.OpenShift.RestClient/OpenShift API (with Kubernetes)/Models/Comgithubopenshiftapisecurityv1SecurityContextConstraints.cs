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
    /// SecurityContextConstraints governs the ability to make requests that
    /// affect the SecurityContext that will be applied to a container. For
    /// historical reasons SCC was exposed under the core Kubernetes API
    /// group. That exposure is deprecated and will be removed in a future
    /// release - users should instead use the security.openshift.io group to
    /// manage SecurityContextConstraints.
    /// </summary>
    public partial class Comgithubopenshiftapisecurityv1SecurityContextConstraints
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Comgithubopenshiftapisecurityv1SecurityContextConstraints class.
        /// </summary>
        public Comgithubopenshiftapisecurityv1SecurityContextConstraints() { }

        /// <summary>
        /// Initializes a new instance of the
        /// Comgithubopenshiftapisecurityv1SecurityContextConstraints class.
        /// </summary>
        public Comgithubopenshiftapisecurityv1SecurityContextConstraints(bool allowHostDirVolumePlugin, bool allowHostIPC, bool allowHostNetwork, bool allowHostPID, bool allowHostPorts, bool allowPrivilegedContainer, IList<string> allowedCapabilities, IList<Comgithubopenshiftapisecurityv1AllowedFlexVolume> allowedFlexVolumes, IList<string> defaultAddCapabilities, int priority, bool readOnlyRootFilesystem, IList<string> requiredDropCapabilities, IList<string> volumes, string apiVersion = default(string), Comgithubopenshiftapisecurityv1FSGroupStrategyOptions fsGroup = default(Comgithubopenshiftapisecurityv1FSGroupStrategyOptions), IList<string> groups = default(IList<string>), string kind = default(string), Iok8sapimachinerypkgapismetav1ObjectMeta metadata = default(Iok8sapimachinerypkgapismetav1ObjectMeta), Comgithubopenshiftapisecurityv1RunAsUserStrategyOptions runAsUser = default(Comgithubopenshiftapisecurityv1RunAsUserStrategyOptions), Comgithubopenshiftapisecurityv1SELinuxContextStrategyOptions seLinuxContext = default(Comgithubopenshiftapisecurityv1SELinuxContextStrategyOptions), IList<string> seccompProfiles = default(IList<string>), Comgithubopenshiftapisecurityv1SupplementalGroupsStrategyOptions supplementalGroups = default(Comgithubopenshiftapisecurityv1SupplementalGroupsStrategyOptions), IList<string> users = default(IList<string>))
        {
            AllowHostDirVolumePlugin = allowHostDirVolumePlugin;
            AllowHostIPC = allowHostIPC;
            AllowHostNetwork = allowHostNetwork;
            AllowHostPID = allowHostPID;
            AllowHostPorts = allowHostPorts;
            AllowPrivilegedContainer = allowPrivilegedContainer;
            AllowedCapabilities = allowedCapabilities;
            AllowedFlexVolumes = allowedFlexVolumes;
            ApiVersion = apiVersion;
            DefaultAddCapabilities = defaultAddCapabilities;
            FsGroup = fsGroup;
            Groups = groups;
            Kind = kind;
            Metadata = metadata;
            Priority = priority;
            ReadOnlyRootFilesystem = readOnlyRootFilesystem;
            RequiredDropCapabilities = requiredDropCapabilities;
            RunAsUser = runAsUser;
            SeLinuxContext = seLinuxContext;
            SeccompProfiles = seccompProfiles;
            SupplementalGroups = supplementalGroups;
            Users = users;
            Volumes = volumes;
        }

        /// <summary>
        /// AllowHostDirVolumePlugin determines if the policy allow containers
        /// to use the HostDir volume plugin
        /// </summary>
        [JsonProperty(PropertyName = "allowHostDirVolumePlugin")]
        public bool AllowHostDirVolumePlugin { get; set; }

        /// <summary>
        /// AllowHostIPC determines if the policy allows host ipc in the
        /// containers.
        /// </summary>
        [JsonProperty(PropertyName = "allowHostIPC")]
        public bool AllowHostIPC { get; set; }

        /// <summary>
        /// AllowHostNetwork determines if the policy allows the use of
        /// HostNetwork in the pod spec.
        /// </summary>
        [JsonProperty(PropertyName = "allowHostNetwork")]
        public bool AllowHostNetwork { get; set; }

        /// <summary>
        /// AllowHostPID determines if the policy allows host pid in the
        /// containers.
        /// </summary>
        [JsonProperty(PropertyName = "allowHostPID")]
        public bool AllowHostPID { get; set; }

        /// <summary>
        /// AllowHostPorts determines if the policy allows host ports in the
        /// containers.
        /// </summary>
        [JsonProperty(PropertyName = "allowHostPorts")]
        public bool AllowHostPorts { get; set; }

        /// <summary>
        /// AllowPrivilegedContainer determines if a container can request to
        /// be run as privileged.
        /// </summary>
        [JsonProperty(PropertyName = "allowPrivilegedContainer")]
        public bool AllowPrivilegedContainer { get; set; }

        /// <summary>
        /// AllowedCapabilities is a list of capabilities that can be
        /// requested to add to the container. Capabilities in this field
        /// maybe added at the pod author's discretion. You must not list a
        /// capability in both AllowedCapabilities and
        /// RequiredDropCapabilities. To allow all capabilities you may use
        /// '*'.
        /// </summary>
        [JsonProperty(PropertyName = "allowedCapabilities")]
        public IList<string> AllowedCapabilities { get; set; }

        /// <summary>
        /// AllowedFlexVolumes is a whitelist of allowed Flexvolumes.  Empty
        /// or nil indicates that all Flexvolumes may be used.  This
        /// parameter is effective only when the usage of the Flexvolumes is
        /// allowed in the "Volumes" field.
        /// </summary>
        [JsonProperty(PropertyName = "allowedFlexVolumes")]
        public IList<Comgithubopenshiftapisecurityv1AllowedFlexVolume> AllowedFlexVolumes { get; set; }

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
        /// DefaultAddCapabilities is the default set of capabilities that
        /// will be added to the container unless the pod spec specifically
        /// drops the capability.  You may not list a capabiility in both
        /// DefaultAddCapabilities and RequiredDropCapabilities.
        /// </summary>
        [JsonProperty(PropertyName = "defaultAddCapabilities")]
        public IList<string> DefaultAddCapabilities { get; set; }

        /// <summary>
        /// FSGroup is the strategy that will dictate what fs group is used by
        /// the SecurityContext.
        /// </summary>
        [JsonProperty(PropertyName = "fsGroup")]
        public Comgithubopenshiftapisecurityv1FSGroupStrategyOptions FsGroup { get; set; }

        /// <summary>
        /// The groups that have permission to use this security context
        /// constraints
        /// </summary>
        [JsonProperty(PropertyName = "groups")]
        public IList<string> Groups { get; set; }

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
        /// http://releases.k8s.io/HEAD/docs/devel/api-conventions.md#metadata
        /// </summary>
        [JsonProperty(PropertyName = "metadata")]
        public Iok8sapimachinerypkgapismetav1ObjectMeta Metadata { get; set; }

        /// <summary>
        /// Priority influences the sort order of SCCs when evaluating which
        /// SCCs to try first for a given pod request based on access in the
        /// Users and Groups fields.  The higher the int, the higher
        /// priority. An unset value is considered a 0 priority. If scores
        /// for multiple SCCs are equal they will be sorted from most
        /// restrictive to least restrictive. If both priorities and
        /// restrictions are equal the SCCs will be sorted by name.
        /// </summary>
        [JsonProperty(PropertyName = "priority")]
        public int Priority { get; set; }

        /// <summary>
        /// ReadOnlyRootFilesystem when set to true will force containers to
        /// run with a read only root file system.  If the container
        /// specifically requests to run with a non-read only root file
        /// system the SCC should deny the pod. If set to false the container
        /// may run with a read only root file system if it wishes but it
        /// will not be forced to.
        /// </summary>
        [JsonProperty(PropertyName = "readOnlyRootFilesystem")]
        public bool ReadOnlyRootFilesystem { get; set; }

        /// <summary>
        /// RequiredDropCapabilities are the capabilities that will be dropped
        /// from the container.  These are required to be dropped and cannot
        /// be added.
        /// </summary>
        [JsonProperty(PropertyName = "requiredDropCapabilities")]
        public IList<string> RequiredDropCapabilities { get; set; }

        /// <summary>
        /// RunAsUser is the strategy that will dictate what RunAsUser is used
        /// in the SecurityContext.
        /// </summary>
        [JsonProperty(PropertyName = "runAsUser")]
        public Comgithubopenshiftapisecurityv1RunAsUserStrategyOptions RunAsUser { get; set; }

        /// <summary>
        /// SELinuxContext is the strategy that will dictate what labels will
        /// be set in the SecurityContext.
        /// </summary>
        [JsonProperty(PropertyName = "seLinuxContext")]
        public Comgithubopenshiftapisecurityv1SELinuxContextStrategyOptions SeLinuxContext { get; set; }

        /// <summary>
        /// SeccompProfiles lists the allowed profiles that may be set for the
        /// pod or container's seccomp annotations.  An unset (nil) or empty
        /// value means that no profiles may be specifid by the pod or
        /// container.	The wildcard '*' may be used to allow all profiles.
        /// When used to generate a value for a pod the first non-wildcard
        /// profile will be used as the default.
        /// </summary>
        [JsonProperty(PropertyName = "seccompProfiles")]
        public IList<string> SeccompProfiles { get; set; }

        /// <summary>
        /// SupplementalGroups is the strategy that will dictate what
        /// supplemental groups are used by the SecurityContext.
        /// </summary>
        [JsonProperty(PropertyName = "supplementalGroups")]
        public Comgithubopenshiftapisecurityv1SupplementalGroupsStrategyOptions SupplementalGroups { get; set; }

        /// <summary>
        /// The users who have permissions to use this security context
        /// constraints
        /// </summary>
        [JsonProperty(PropertyName = "users")]
        public IList<string> Users { get; set; }

        /// <summary>
        /// Volumes is a white list of allowed volume plugins.  FSType
        /// corresponds directly with the field names of a VolumeSource
        /// (azureFile, configMap, emptyDir).  To allow all volumes you may
        /// use "*". To allow no volumes, set to ["none"].
        /// </summary>
        [JsonProperty(PropertyName = "volumes")]
        public IList<string> Volumes { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (AllowedCapabilities == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AllowedCapabilities");
            }
            if (AllowedFlexVolumes == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AllowedFlexVolumes");
            }
            if (DefaultAddCapabilities == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DefaultAddCapabilities");
            }
            if (RequiredDropCapabilities == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "RequiredDropCapabilities");
            }
            if (Volumes == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Volumes");
            }
            if (this.Metadata != null)
            {
                this.Metadata.Validate();
            }
        }
    }
}

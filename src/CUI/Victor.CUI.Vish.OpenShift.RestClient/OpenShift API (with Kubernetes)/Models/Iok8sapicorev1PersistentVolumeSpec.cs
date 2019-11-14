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
    /// PersistentVolumeSpec is the specification of a persistent volume.
    /// </summary>
    public partial class Iok8sapicorev1PersistentVolumeSpec
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Iok8sapicorev1PersistentVolumeSpec class.
        /// </summary>
        public Iok8sapicorev1PersistentVolumeSpec() { }

        /// <summary>
        /// Initializes a new instance of the
        /// Iok8sapicorev1PersistentVolumeSpec class.
        /// </summary>
        public Iok8sapicorev1PersistentVolumeSpec(IList<string> accessModes = default(IList<string>), Iok8sapicorev1AWSElasticBlockStoreVolumeSource awsElasticBlockStore = default(Iok8sapicorev1AWSElasticBlockStoreVolumeSource), Iok8sapicorev1AzureDiskVolumeSource azureDisk = default(Iok8sapicorev1AzureDiskVolumeSource), Iok8sapicorev1AzureFilePersistentVolumeSource azureFile = default(Iok8sapicorev1AzureFilePersistentVolumeSource), IDictionary<string, string> capacity = default(IDictionary<string, string>), Iok8sapicorev1CephFSPersistentVolumeSource cephfs = default(Iok8sapicorev1CephFSPersistentVolumeSource), Iok8sapicorev1CinderVolumeSource cinder = default(Iok8sapicorev1CinderVolumeSource), Iok8sapicorev1ObjectReference claimRef = default(Iok8sapicorev1ObjectReference), Iok8sapicorev1CSIPersistentVolumeSource csi = default(Iok8sapicorev1CSIPersistentVolumeSource), Iok8sapicorev1FCVolumeSource fc = default(Iok8sapicorev1FCVolumeSource), Iok8sapicorev1FlexVolumeSource flexVolume = default(Iok8sapicorev1FlexVolumeSource), Iok8sapicorev1FlockerVolumeSource flocker = default(Iok8sapicorev1FlockerVolumeSource), Iok8sapicorev1GCEPersistentDiskVolumeSource gcePersistentDisk = default(Iok8sapicorev1GCEPersistentDiskVolumeSource), Iok8sapicorev1GlusterfsVolumeSource glusterfs = default(Iok8sapicorev1GlusterfsVolumeSource), Iok8sapicorev1HostPathVolumeSource hostPath = default(Iok8sapicorev1HostPathVolumeSource), Iok8sapicorev1ISCSIPersistentVolumeSource iscsi = default(Iok8sapicorev1ISCSIPersistentVolumeSource), Iok8sapicorev1LocalVolumeSource local = default(Iok8sapicorev1LocalVolumeSource), IList<string> mountOptions = default(IList<string>), Iok8sapicorev1NFSVolumeSource nfs = default(Iok8sapicorev1NFSVolumeSource), string persistentVolumeReclaimPolicy = default(string), Iok8sapicorev1PhotonPersistentDiskVolumeSource photonPersistentDisk = default(Iok8sapicorev1PhotonPersistentDiskVolumeSource), Iok8sapicorev1PortworxVolumeSource portworxVolume = default(Iok8sapicorev1PortworxVolumeSource), Iok8sapicorev1QuobyteVolumeSource quobyte = default(Iok8sapicorev1QuobyteVolumeSource), Iok8sapicorev1RBDPersistentVolumeSource rbd = default(Iok8sapicorev1RBDPersistentVolumeSource), Iok8sapicorev1ScaleIOPersistentVolumeSource scaleIO = default(Iok8sapicorev1ScaleIOPersistentVolumeSource), string storageClassName = default(string), Iok8sapicorev1StorageOSPersistentVolumeSource storageos = default(Iok8sapicorev1StorageOSPersistentVolumeSource), string volumeMode = default(string), Iok8sapicorev1VsphereVirtualDiskVolumeSource vsphereVolume = default(Iok8sapicorev1VsphereVirtualDiskVolumeSource))
        {
            AccessModes = accessModes;
            AwsElasticBlockStore = awsElasticBlockStore;
            AzureDisk = azureDisk;
            AzureFile = azureFile;
            Capacity = capacity;
            Cephfs = cephfs;
            Cinder = cinder;
            ClaimRef = claimRef;
            Csi = csi;
            Fc = fc;
            FlexVolume = flexVolume;
            Flocker = flocker;
            GcePersistentDisk = gcePersistentDisk;
            Glusterfs = glusterfs;
            HostPath = hostPath;
            Iscsi = iscsi;
            Local = local;
            MountOptions = mountOptions;
            Nfs = nfs;
            PersistentVolumeReclaimPolicy = persistentVolumeReclaimPolicy;
            PhotonPersistentDisk = photonPersistentDisk;
            PortworxVolume = portworxVolume;
            Quobyte = quobyte;
            Rbd = rbd;
            ScaleIO = scaleIO;
            StorageClassName = storageClassName;
            Storageos = storageos;
            VolumeMode = volumeMode;
            VsphereVolume = vsphereVolume;
        }

        /// <summary>
        /// AccessModes contains all ways the volume can be mounted. More
        /// info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#access-modes
        /// </summary>
        [JsonProperty(PropertyName = "accessModes")]
        public IList<string> AccessModes { get; set; }

        /// <summary>
        /// AWSElasticBlockStore represents an AWS Disk resource that is
        /// attached to a kubelet's host machine and then exposed to the pod.
        /// More info:
        /// https://kubernetes.io/docs/concepts/storage/volumes#awselasticblockstore
        /// </summary>
        [JsonProperty(PropertyName = "awsElasticBlockStore")]
        public Iok8sapicorev1AWSElasticBlockStoreVolumeSource AwsElasticBlockStore { get; set; }

        /// <summary>
        /// AzureDisk represents an Azure Data Disk mount on the host and bind
        /// mount to the pod.
        /// </summary>
        [JsonProperty(PropertyName = "azureDisk")]
        public Iok8sapicorev1AzureDiskVolumeSource AzureDisk { get; set; }

        /// <summary>
        /// AzureFile represents an Azure File Service mount on the host and
        /// bind mount to the pod.
        /// </summary>
        [JsonProperty(PropertyName = "azureFile")]
        public Iok8sapicorev1AzureFilePersistentVolumeSource AzureFile { get; set; }

        /// <summary>
        /// A description of the persistent volume's resources and capacity.
        /// More info:
        /// https://kubernetes.io/docs/concepts/storage/persistent-volumes#capacity
        /// </summary>
        [JsonProperty(PropertyName = "capacity")]
        public IDictionary<string, string> Capacity { get; set; }

        /// <summary>
        /// CephFS represents a Ceph FS mount on the host that shares a pod's
        /// lifetime
        /// </summary>
        [JsonProperty(PropertyName = "cephfs")]
        public Iok8sapicorev1CephFSPersistentVolumeSource Cephfs { get; set; }

        /// <summary>
        /// Cinder represents a cinder volume attached and mounted on kubelets
        /// host machine More info:
        /// https://releases.k8s.io/HEAD/examples/mysql-cinder-pd/README.md
        /// </summary>
        [JsonProperty(PropertyName = "cinder")]
        public Iok8sapicorev1CinderVolumeSource Cinder { get; set; }

        /// <summary>
        /// ClaimRef is part of a bi-directional binding between
        /// PersistentVolume and PersistentVolumeClaim. Expected to be
        /// non-nil when bound. claim.VolumeName is the authoritative bind
        /// between PV and PVC. More info:
        /// https://kubernetes.io/docs/concepts/storage/persistent-volumes#binding
        /// </summary>
        [JsonProperty(PropertyName = "claimRef")]
        public Iok8sapicorev1ObjectReference ClaimRef { get; set; }

        /// <summary>
        /// CSI represents storage that handled by an external CSI driver
        /// </summary>
        [JsonProperty(PropertyName = "csi")]
        public Iok8sapicorev1CSIPersistentVolumeSource Csi { get; set; }

        /// <summary>
        /// FC represents a Fibre Channel resource that is attached to a
        /// kubelet's host machine and then exposed to the pod.
        /// </summary>
        [JsonProperty(PropertyName = "fc")]
        public Iok8sapicorev1FCVolumeSource Fc { get; set; }

        /// <summary>
        /// FlexVolume represents a generic volume resource that is
        /// provisioned/attached using an exec based plugin.
        /// </summary>
        [JsonProperty(PropertyName = "flexVolume")]
        public Iok8sapicorev1FlexVolumeSource FlexVolume { get; set; }

        /// <summary>
        /// Flocker represents a Flocker volume attached to a kubelet's host
        /// machine and exposed to the pod for its usage. This depends on the
        /// Flocker control service being running
        /// </summary>
        [JsonProperty(PropertyName = "flocker")]
        public Iok8sapicorev1FlockerVolumeSource Flocker { get; set; }

        /// <summary>
        /// GCEPersistentDisk represents a GCE Disk resource that is attached
        /// to a kubelet's host machine and then exposed to the pod.
        /// Provisioned by an admin. More info:
        /// https://kubernetes.io/docs/concepts/storage/volumes#gcepersistentdisk
        /// </summary>
        [JsonProperty(PropertyName = "gcePersistentDisk")]
        public Iok8sapicorev1GCEPersistentDiskVolumeSource GcePersistentDisk { get; set; }

        /// <summary>
        /// Glusterfs represents a Glusterfs volume that is attached to a host
        /// and exposed to the pod. Provisioned by an admin. More info:
        /// https://releases.k8s.io/HEAD/examples/volumes/glusterfs/README.md
        /// </summary>
        [JsonProperty(PropertyName = "glusterfs")]
        public Iok8sapicorev1GlusterfsVolumeSource Glusterfs { get; set; }

        /// <summary>
        /// HostPath represents a directory on the host. Provisioned by a
        /// developer or tester. This is useful for single-node development
        /// and testing only! On-host storage is not supported in any way and
        /// WILL NOT WORK in a multi-node cluster. More info:
        /// https://kubernetes.io/docs/concepts/storage/volumes#hostpath
        /// </summary>
        [JsonProperty(PropertyName = "hostPath")]
        public Iok8sapicorev1HostPathVolumeSource HostPath { get; set; }

        /// <summary>
        /// ISCSI represents an ISCSI Disk resource that is attached to a
        /// kubelet's host machine and then exposed to the pod. Provisioned
        /// by an admin.
        /// </summary>
        [JsonProperty(PropertyName = "iscsi")]
        public Iok8sapicorev1ISCSIPersistentVolumeSource Iscsi { get; set; }

        /// <summary>
        /// Local represents directly-attached storage with node affinity
        /// </summary>
        [JsonProperty(PropertyName = "local")]
        public Iok8sapicorev1LocalVolumeSource Local { get; set; }

        /// <summary>
        /// A list of mount options, e.g. ["ro", "soft"]. Not validated -
        /// mount will simply fail if one is invalid. More info:
        /// https://kubernetes.io/docs/concepts/storage/persistent-volumes/#mount-options
        /// </summary>
        [JsonProperty(PropertyName = "mountOptions")]
        public IList<string> MountOptions { get; set; }

        /// <summary>
        /// NFS represents an NFS mount on the host. Provisioned by an admin.
        /// More info: https://kubernetes.io/docs/concepts/storage/volumes#nfs
        /// </summary>
        [JsonProperty(PropertyName = "nfs")]
        public Iok8sapicorev1NFSVolumeSource Nfs { get; set; }

        /// <summary>
        /// What happens to a persistent volume when released from its claim.
        /// Valid options are Retain (default) and Recycle. Recycling must be
        /// supported by the volume plugin underlying this persistent volume.
        /// More info:
        /// https://kubernetes.io/docs/concepts/storage/persistent-volumes#reclaiming
        /// </summary>
        [JsonProperty(PropertyName = "persistentVolumeReclaimPolicy")]
        public string PersistentVolumeReclaimPolicy { get; set; }

        /// <summary>
        /// PhotonPersistentDisk represents a PhotonController persistent disk
        /// attached and mounted on kubelets host machine
        /// </summary>
        [JsonProperty(PropertyName = "photonPersistentDisk")]
        public Iok8sapicorev1PhotonPersistentDiskVolumeSource PhotonPersistentDisk { get; set; }

        /// <summary>
        /// PortworxVolume represents a portworx volume attached and mounted
        /// on kubelets host machine
        /// </summary>
        [JsonProperty(PropertyName = "portworxVolume")]
        public Iok8sapicorev1PortworxVolumeSource PortworxVolume { get; set; }

        /// <summary>
        /// Quobyte represents a Quobyte mount on the host that shares a pod's
        /// lifetime
        /// </summary>
        [JsonProperty(PropertyName = "quobyte")]
        public Iok8sapicorev1QuobyteVolumeSource Quobyte { get; set; }

        /// <summary>
        /// RBD represents a Rados Block Device mount on the host that shares
        /// a pod's lifetime. More info:
        /// https://releases.k8s.io/HEAD/examples/volumes/rbd/README.md
        /// </summary>
        [JsonProperty(PropertyName = "rbd")]
        public Iok8sapicorev1RBDPersistentVolumeSource Rbd { get; set; }

        /// <summary>
        /// ScaleIO represents a ScaleIO persistent volume attached and
        /// mounted on Kubernetes nodes.
        /// </summary>
        [JsonProperty(PropertyName = "scaleIO")]
        public Iok8sapicorev1ScaleIOPersistentVolumeSource ScaleIO { get; set; }

        /// <summary>
        /// Name of StorageClass to which this persistent volume belongs.
        /// Empty value means that this volume does not belong to any
        /// StorageClass.
        /// </summary>
        [JsonProperty(PropertyName = "storageClassName")]
        public string StorageClassName { get; set; }

        /// <summary>
        /// StorageOS represents a StorageOS volume that is attached to the
        /// kubelet's host machine and mounted into the pod More info:
        /// https://releases.k8s.io/HEAD/examples/volumes/storageos/README.md
        /// </summary>
        [JsonProperty(PropertyName = "storageos")]
        public Iok8sapicorev1StorageOSPersistentVolumeSource Storageos { get; set; }

        /// <summary>
        /// volumeMode defines if a volume is intended to be used with a
        /// formatted filesystem or to remain in raw block state. Value of
        /// Filesystem is implied when not included in spec. This is an alpha
        /// feature and may change in the future.
        /// </summary>
        [JsonProperty(PropertyName = "volumeMode")]
        public string VolumeMode { get; set; }

        /// <summary>
        /// VsphereVolume represents a vSphere volume attached and mounted on
        /// kubelets host machine
        /// </summary>
        [JsonProperty(PropertyName = "vsphereVolume")]
        public Iok8sapicorev1VsphereVirtualDiskVolumeSource VsphereVolume { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (this.AwsElasticBlockStore != null)
            {
                this.AwsElasticBlockStore.Validate();
            }
            if (this.AzureDisk != null)
            {
                this.AzureDisk.Validate();
            }
            if (this.AzureFile != null)
            {
                this.AzureFile.Validate();
            }
            if (this.Cephfs != null)
            {
                this.Cephfs.Validate();
            }
            if (this.Cinder != null)
            {
                this.Cinder.Validate();
            }
            if (this.Csi != null)
            {
                this.Csi.Validate();
            }
            if (this.FlexVolume != null)
            {
                this.FlexVolume.Validate();
            }
            if (this.GcePersistentDisk != null)
            {
                this.GcePersistentDisk.Validate();
            }
            if (this.Glusterfs != null)
            {
                this.Glusterfs.Validate();
            }
            if (this.HostPath != null)
            {
                this.HostPath.Validate();
            }
            if (this.Iscsi != null)
            {
                this.Iscsi.Validate();
            }
            if (this.Local != null)
            {
                this.Local.Validate();
            }
            if (this.Nfs != null)
            {
                this.Nfs.Validate();
            }
            if (this.PhotonPersistentDisk != null)
            {
                this.PhotonPersistentDisk.Validate();
            }
            if (this.PortworxVolume != null)
            {
                this.PortworxVolume.Validate();
            }
            if (this.Quobyte != null)
            {
                this.Quobyte.Validate();
            }
            if (this.Rbd != null)
            {
                this.Rbd.Validate();
            }
            if (this.ScaleIO != null)
            {
                this.ScaleIO.Validate();
            }
            if (this.VsphereVolume != null)
            {
                this.VsphereVolume.Validate();
            }
        }
    }
}
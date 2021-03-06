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
    /// ImageStreamImportSpec defines what images should be imported.
    /// </summary>
    public partial class Comgithubopenshiftapiimagev1ImageStreamImportSpec
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Comgithubopenshiftapiimagev1ImageStreamImportSpec class.
        /// </summary>
        public Comgithubopenshiftapiimagev1ImageStreamImportSpec() { }

        /// <summary>
        /// Initializes a new instance of the
        /// Comgithubopenshiftapiimagev1ImageStreamImportSpec class.
        /// </summary>
        public Comgithubopenshiftapiimagev1ImageStreamImportSpec(bool import, IList<Comgithubopenshiftapiimagev1ImageImportSpec> images = default(IList<Comgithubopenshiftapiimagev1ImageImportSpec>), Comgithubopenshiftapiimagev1RepositoryImportSpec repository = default(Comgithubopenshiftapiimagev1RepositoryImportSpec))
        {
            Images = images;
            Import = import;
            Repository = repository;
        }

        /// <summary>
        /// Images are a list of individual images to import.
        /// </summary>
        [JsonProperty(PropertyName = "images")]
        public IList<Comgithubopenshiftapiimagev1ImageImportSpec> Images { get; set; }

        /// <summary>
        /// Import indicates whether to perform an import - if so, the
        /// specified tags are set on the spec and status of the image stream
        /// defined by the type meta.
        /// </summary>
        [JsonProperty(PropertyName = "import")]
        public bool Import { get; set; }

        /// <summary>
        /// Repository is an optional import of an entire Docker image
        /// repository. A maximum limit on the number of tags imported this
        /// way is imposed by the server.
        /// </summary>
        [JsonProperty(PropertyName = "repository")]
        public Comgithubopenshiftapiimagev1RepositoryImportSpec Repository { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (this.Images != null)
            {
                foreach (var element in this.Images)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (this.Repository != null)
            {
                this.Repository.Validate();
            }
        }
    }
}

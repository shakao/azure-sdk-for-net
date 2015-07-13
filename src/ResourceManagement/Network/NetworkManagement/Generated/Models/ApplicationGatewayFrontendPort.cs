namespace Microsoft.Azure.Management.Network.Models
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Azure;

    /// <summary>
    /// </summary>
    public partial class ApplicationGatewayFrontendPort : SubResource
    {
        /// <summary>
        /// Gets name of the resource that is unique within a resource group.
        /// This name can be used to access the resource
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// A unique read-only string that changes whenever the resource is
        /// updated
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; set; }

        /// <summary>
        /// Gets or sets the frontend port
        /// </summary>
        [JsonProperty(PropertyName = "properties.port")]
        public int? Port { get; set; }

        /// <summary>
        /// Gets or sets Provisioning state of the frontend port resource
        /// Updating/Deleting/Failed
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; set; }

    }
}

namespace Microsoft.Azure.Management.Resources.Models
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Azure;

    /// <summary>
    /// </summary>
    public partial class ProviderListResult
    {
        /// <summary>
        /// Gets or sets the list of resource providers.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<Provider> Value { get; set; }

        /// <summary>
        /// Gets or sets the URL to get the next set of results.
        /// </summary>
        [JsonProperty(PropertyName = "nextLink")]
        public string NextLink { get; set; }

    }
}

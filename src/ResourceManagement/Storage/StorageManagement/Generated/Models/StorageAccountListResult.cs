namespace Microsoft.Azure.Management.Storage.Models
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Azure;

    /// <summary>
    /// </summary>
    public partial class StorageAccountListResult
    {
        /// <summary>
        /// Gets the list of storage accounts and their properties.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<StorageAccount> Value { get; set; }

        /// <summary>
        /// Gets the link to the next set of results. Currently this will
        /// always be empty as the API does not support pagination.
        /// </summary>
        [JsonProperty(PropertyName = "nextLink")]
        public string NextLink { get; set; }

    }
}

// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RedisEnterprise.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A partial update to the RedisEnterprise database
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class DatabaseUpdate
    {
        /// <summary>
        /// Initializes a new instance of the DatabaseUpdate class.
        /// </summary>
        public DatabaseUpdate()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DatabaseUpdate class.
        /// </summary>
        /// <param name="clientProtocol">Specifies whether redis clients can
        /// connect using TLS-encrypted or plaintext redis protocols. Default
        /// is TLS-encrypted. Possible values include: 'Encrypted',
        /// 'Plaintext'</param>
        /// <param name="port">TCP port of the database endpoint. Specified at
        /// create time. Defaults to an available port.</param>
        /// <param name="provisioningState">Current provisioning status of the
        /// database. Possible values include: 'Succeeded', 'Failed',
        /// 'Canceled', 'Creating', 'Updating', 'Deleting'</param>
        /// <param name="resourceState">Current resource status of the
        /// database. Possible values include: 'Running', 'Creating',
        /// 'CreateFailed', 'Updating', 'UpdateFailed', 'Deleting',
        /// 'DeleteFailed', 'Enabling', 'EnableFailed', 'Disabling',
        /// 'DisableFailed', 'Disabled'</param>
        /// <param name="clusteringPolicy">Clustering policy - default is
        /// OSSCluster. Specified at create time. Possible values include:
        /// 'EnterpriseCluster', 'OSSCluster'</param>
        /// <param name="evictionPolicy">Redis eviction policy - default is
        /// VolatileLRU. Possible values include: 'AllKeysLFU', 'AllKeysLRU',
        /// 'AllKeysRandom', 'VolatileLRU', 'VolatileLFU', 'VolatileTTL',
        /// 'VolatileRandom', 'NoEviction'</param>
        /// <param name="modules">Optional set of redis modules to enable in
        /// this database - modules can only be added at creation time.</param>
        public DatabaseUpdate(string clientProtocol = default(string), int? port = default(int?), string provisioningState = default(string), string resourceState = default(string), string clusteringPolicy = default(string), string evictionPolicy = default(string), IList<Module> modules = default(IList<Module>))
        {
            ClientProtocol = clientProtocol;
            Port = port;
            ProvisioningState = provisioningState;
            ResourceState = resourceState;
            ClusteringPolicy = clusteringPolicy;
            EvictionPolicy = evictionPolicy;
            Modules = modules;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets specifies whether redis clients can connect using
        /// TLS-encrypted or plaintext redis protocols. Default is
        /// TLS-encrypted. Possible values include: 'Encrypted', 'Plaintext'
        /// </summary>
        [JsonProperty(PropertyName = "properties.clientProtocol")]
        public string ClientProtocol { get; set; }

        /// <summary>
        /// Gets or sets TCP port of the database endpoint. Specified at create
        /// time. Defaults to an available port.
        /// </summary>
        [JsonProperty(PropertyName = "properties.port")]
        public int? Port { get; set; }

        /// <summary>
        /// Gets current provisioning status of the database. Possible values
        /// include: 'Succeeded', 'Failed', 'Canceled', 'Creating', 'Updating',
        /// 'Deleting'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets current resource status of the database. Possible values
        /// include: 'Running', 'Creating', 'CreateFailed', 'Updating',
        /// 'UpdateFailed', 'Deleting', 'DeleteFailed', 'Enabling',
        /// 'EnableFailed', 'Disabling', 'DisableFailed', 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.resourceState")]
        public string ResourceState { get; private set; }

        /// <summary>
        /// Gets or sets clustering policy - default is OSSCluster. Specified
        /// at create time. Possible values include: 'EnterpriseCluster',
        /// 'OSSCluster'
        /// </summary>
        [JsonProperty(PropertyName = "properties.clusteringPolicy")]
        public string ClusteringPolicy { get; set; }

        /// <summary>
        /// Gets or sets redis eviction policy - default is VolatileLRU.
        /// Possible values include: 'AllKeysLFU', 'AllKeysLRU',
        /// 'AllKeysRandom', 'VolatileLRU', 'VolatileLFU', 'VolatileTTL',
        /// 'VolatileRandom', 'NoEviction'
        /// </summary>
        [JsonProperty(PropertyName = "properties.evictionPolicy")]
        public string EvictionPolicy { get; set; }

        /// <summary>
        /// Gets or sets optional set of redis modules to enable in this
        /// database - modules can only be added at creation time.
        /// </summary>
        [JsonProperty(PropertyName = "properties.modules")]
        public IList<Module> Modules { get; set; }

    }
}

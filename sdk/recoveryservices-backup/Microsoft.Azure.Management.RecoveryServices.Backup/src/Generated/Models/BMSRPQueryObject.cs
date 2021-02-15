// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Filters to list backup copies.
    /// </summary>
    public partial class BMSRPQueryObject
    {
        /// <summary>
        /// Initializes a new instance of the BMSRPQueryObject class.
        /// </summary>
        public BMSRPQueryObject()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BMSRPQueryObject class.
        /// </summary>
        /// <param name="startDate">Backup copies created after this
        /// time.</param>
        /// <param name="endDate">Backup copies created before this
        /// time.</param>
        /// <param name="restorePointQueryType">RestorePoint type. Possible
        /// values include: 'Invalid', 'Full', 'Log', 'Differential',
        /// 'FullAndDifferential', 'All', 'Incremental'</param>
        /// <param name="extendedInfo">In Get Recovery Point, it tells whether
        /// extended information about recovery point is asked.</param>
        /// <param name="moveReadyRPOnly">Whether the RP can be moved to
        /// another tier</param>
        public BMSRPQueryObject(System.DateTime? startDate = default(System.DateTime?), System.DateTime? endDate = default(System.DateTime?), string restorePointQueryType = default(string), bool? extendedInfo = default(bool?), bool? moveReadyRPOnly = default(bool?))
        {
            StartDate = startDate;
            EndDate = endDate;
            RestorePointQueryType = restorePointQueryType;
            ExtendedInfo = extendedInfo;
            MoveReadyRPOnly = moveReadyRPOnly;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets backup copies created after this time.
        /// </summary>
        [JsonProperty(PropertyName = "startDate")]
        public System.DateTime? StartDate { get; set; }

        /// <summary>
        /// Gets or sets backup copies created before this time.
        /// </summary>
        [JsonProperty(PropertyName = "endDate")]
        public System.DateTime? EndDate { get; set; }

        /// <summary>
        /// Gets or sets restorePoint type. Possible values include: 'Invalid',
        /// 'Full', 'Log', 'Differential', 'FullAndDifferential', 'All',
        /// 'Incremental'
        /// </summary>
        [JsonProperty(PropertyName = "restorePointQueryType")]
        public string RestorePointQueryType { get; set; }

        /// <summary>
        /// Gets or sets in Get Recovery Point, it tells whether extended
        /// information about recovery point is asked.
        /// </summary>
        [JsonProperty(PropertyName = "extendedInfo")]
        public bool? ExtendedInfo { get; set; }

        /// <summary>
        /// Gets or sets whether the RP can be moved to another tier
        /// </summary>
        [JsonProperty(PropertyName = "moveReadyRPOnly")]
        public bool? MoveReadyRPOnly { get; set; }

    }
}

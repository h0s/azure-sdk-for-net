﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> The format definition of a storage. </summary>
    public partial class DatasetStorageFormat : IReadOnlyDictionary<string, object>
    {
        /// <summary> Initializes a new instance of DatasetStorageFormat. </summary>
        public DatasetStorageFormat()
        {
            AdditionalProperties = new ChangeTrackingDictionary<string, object>();
            Type = "DatasetStorageFormat";
        }
    }
}

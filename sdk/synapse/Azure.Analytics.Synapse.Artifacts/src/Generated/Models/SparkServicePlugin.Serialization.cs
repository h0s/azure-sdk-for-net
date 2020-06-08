// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    public partial class SparkServicePlugin
    {
        internal static SparkServicePlugin DeserializeSparkServicePlugin(JsonElement element)
        {
            DateTimeOffset? preparationStartedAt = default;
            DateTimeOffset? resourceAcquisitionStartedAt = default;
            DateTimeOffset? submissionStartedAt = default;
            DateTimeOffset? monitoringStartedAt = default;
            DateTimeOffset? cleanupStartedAt = default;
            PluginCurrentState? currentState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("preparationStartedAt"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    preparationStartedAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("resourceAcquisitionStartedAt"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resourceAcquisitionStartedAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("submissionStartedAt"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    submissionStartedAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("monitoringStartedAt"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    monitoringStartedAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("cleanupStartedAt"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cleanupStartedAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("currentState"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    currentState = new PluginCurrentState(property.Value.GetString());
                    continue;
                }
            }
            return new SparkServicePlugin(preparationStartedAt, resourceAcquisitionStartedAt, submissionStartedAt, monitoringStartedAt, cleanupStartedAt, currentState);
        }
    }
}
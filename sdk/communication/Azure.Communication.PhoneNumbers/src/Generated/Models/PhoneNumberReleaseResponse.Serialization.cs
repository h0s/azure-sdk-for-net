// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.PhoneNumbers.Models
{
    internal partial class PhoneNumberReleaseResponse
    {
        internal static PhoneNumberReleaseResponse DeserializePhoneNumberReleaseResponse(JsonElement element)
        {
            string releaseId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("releaseId"))
                {
                    releaseId = property.Value.GetString();
                    continue;
                }
            }
            return new PhoneNumberReleaseResponse(releaseId);
        }
    }
}

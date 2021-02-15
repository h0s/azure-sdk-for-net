// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.PhoneNumbers.Models
{
    internal partial class CreateReservationResponse
    {
        internal static CreateReservationResponse DeserializeCreateReservationResponse(JsonElement element)
        {
            string searchId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("searchId"))
                {
                    searchId = property.Value.GetString();
                    continue;
                }
            }
            return new CreateReservationResponse(searchId);
        }
    }
}

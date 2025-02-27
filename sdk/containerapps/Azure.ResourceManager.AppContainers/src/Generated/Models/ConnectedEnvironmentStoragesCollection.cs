// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.AppContainers;

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> Collection of Storage for Environments. </summary>
    internal partial class ConnectedEnvironmentStoragesCollection
    {
        /// <summary> Initializes a new instance of <see cref="ConnectedEnvironmentStoragesCollection"/>. </summary>
        /// <param name="value"> Collection of storage resources. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal ConnectedEnvironmentStoragesCollection(IEnumerable<ContainerAppConnectedEnvironmentStorageData> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="ConnectedEnvironmentStoragesCollection"/>. </summary>
        /// <param name="value"> Collection of storage resources. </param>
        internal ConnectedEnvironmentStoragesCollection(IReadOnlyList<ContainerAppConnectedEnvironmentStorageData> value)
        {
            Value = value;
        }

        /// <summary> Collection of storage resources. </summary>
        public IReadOnlyList<ContainerAppConnectedEnvironmentStorageData> Value { get; }
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Input to create vault setting. </summary>
    public partial class SiteRecoveryVaultSettingCreateOrUpdateContent
    {
        /// <summary> Initializes a new instance of <see cref="SiteRecoveryVaultSettingCreateOrUpdateContent"/>. </summary>
        /// <param name="properties"> Vault setting creation input properties. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public SiteRecoveryVaultSettingCreateOrUpdateContent(VaultSettingCreationProperties properties)
        {
            Argument.AssertNotNull(properties, nameof(properties));

            Properties = properties;
        }

        /// <summary> Vault setting creation input properties. </summary>
        public VaultSettingCreationProperties Properties { get; }
    }
}

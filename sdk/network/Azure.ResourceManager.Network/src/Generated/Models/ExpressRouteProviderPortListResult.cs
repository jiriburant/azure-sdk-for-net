// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Network;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Response for ListExpressRouteProviderPort API service call. </summary>
    internal partial class ExpressRouteProviderPortListResult
    {
        /// <summary> Initializes a new instance of <see cref="ExpressRouteProviderPortListResult"/>. </summary>
        internal ExpressRouteProviderPortListResult()
        {
            Value = new ChangeTrackingList<ExpressRouteProviderPortData>();
        }

        /// <summary> Initializes a new instance of <see cref="ExpressRouteProviderPortListResult"/>. </summary>
        /// <param name="value"> A list of ExpressRouteProviderPort resources. </param>
        /// <param name="nextLink"> The URL to get the next set of results. </param>
        internal ExpressRouteProviderPortListResult(IReadOnlyList<ExpressRouteProviderPortData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> A list of ExpressRouteProviderPort resources. </summary>
        public IReadOnlyList<ExpressRouteProviderPortData> Value { get; }
        /// <summary> The URL to get the next set of results. </summary>
        public string NextLink { get; }
    }
}

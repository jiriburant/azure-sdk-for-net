// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Chaos.Models
{
    /// <summary> Model that represents the a list of actions and action statuses. </summary>
    public partial class BranchStatus
    {
        /// <summary> Initializes a new instance of <see cref="BranchStatus"/>. </summary>
        internal BranchStatus()
        {
            Actions = new ChangeTrackingList<ActionStatus>();
        }

        /// <summary> Initializes a new instance of <see cref="BranchStatus"/>. </summary>
        /// <param name="branchName"> The name of the branch status. </param>
        /// <param name="branchId"> The id of the branch status. </param>
        /// <param name="status"> The status of the branch. </param>
        /// <param name="actions"> The array of actions. </param>
        internal BranchStatus(string branchName, string branchId, string status, IReadOnlyList<ActionStatus> actions)
        {
            BranchName = branchName;
            BranchId = branchId;
            Status = status;
            Actions = actions;
        }

        /// <summary> The name of the branch status. </summary>
        public string BranchName { get; }
        /// <summary> The id of the branch status. </summary>
        public string BranchId { get; }
        /// <summary> The status of the branch. </summary>
        public string Status { get; }
        /// <summary> The array of actions. </summary>
        public IReadOnlyList<ActionStatus> Actions { get; }
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> Properties of a query execution statistics. </summary>
    public partial class QueryStatisticsProperties
    {
        /// <summary> Initializes a new instance of <see cref="QueryStatisticsProperties"/>. </summary>
        internal QueryStatisticsProperties()
        {
            Intervals = new ChangeTrackingList<QueryMetricInterval>();
        }

        /// <summary> Initializes a new instance of <see cref="QueryStatisticsProperties"/>. </summary>
        /// <param name="databaseName"> Database name of the database in which this query was executed. </param>
        /// <param name="queryId"> Unique query id (unique within one database). </param>
        /// <param name="startTime"> The start time for the metric (ISO-8601 format). </param>
        /// <param name="endTime"> The end time for the metric (ISO-8601 format). </param>
        /// <param name="intervals"> List of intervals with appropriate metric data. </param>
        internal QueryStatisticsProperties(string databaseName, string queryId, string startTime, string endTime, IReadOnlyList<QueryMetricInterval> intervals)
        {
            DatabaseName = databaseName;
            QueryId = queryId;
            StartTime = startTime;
            EndTime = endTime;
            Intervals = intervals;
        }

        /// <summary> Database name of the database in which this query was executed. </summary>
        public string DatabaseName { get; }
        /// <summary> Unique query id (unique within one database). </summary>
        public string QueryId { get; }
        /// <summary> The start time for the metric (ISO-8601 format). </summary>
        public string StartTime { get; }
        /// <summary> The end time for the metric (ISO-8601 format). </summary>
        public string EndTime { get; }
        /// <summary> List of intervals with appropriate metric data. </summary>
        public IReadOnlyList<QueryMetricInterval> Intervals { get; }
    }
}

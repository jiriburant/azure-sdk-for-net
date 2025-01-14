// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.OperationalInsights.Models
{
    /// <summary> Table column. </summary>
    public partial class OperationalInsightsColumn
    {
        /// <summary> Initializes a new instance of <see cref="OperationalInsightsColumn"/>. </summary>
        public OperationalInsightsColumn()
        {
        }

        /// <summary> Initializes a new instance of <see cref="OperationalInsightsColumn"/>. </summary>
        /// <param name="name"> Column name. </param>
        /// <param name="columnType"> Column data type. </param>
        /// <param name="dataTypeHint"> Column data type logical hint. </param>
        /// <param name="displayName"> Column display name. </param>
        /// <param name="description"> Column description. </param>
        /// <param name="isDefaultDisplay"> Is displayed by default. </param>
        /// <param name="isHidden"> Is column hidden. </param>
        internal OperationalInsightsColumn(string name, OperationalInsightsColumnType? columnType, OperationalInsightsColumnDataTypeHint? dataTypeHint, string displayName, string description, bool? isDefaultDisplay, bool? isHidden)
        {
            Name = name;
            ColumnType = columnType;
            DataTypeHint = dataTypeHint;
            DisplayName = displayName;
            Description = description;
            IsDefaultDisplay = isDefaultDisplay;
            IsHidden = isHidden;
        }

        /// <summary> Column name. </summary>
        public string Name { get; set; }
        /// <summary> Column data type. </summary>
        public OperationalInsightsColumnType? ColumnType { get; set; }
        /// <summary> Column data type logical hint. </summary>
        public OperationalInsightsColumnDataTypeHint? DataTypeHint { get; set; }
        /// <summary> Column display name. </summary>
        public string DisplayName { get; set; }
        /// <summary> Column description. </summary>
        public string Description { get; set; }
        /// <summary> Is displayed by default. </summary>
        public bool? IsDefaultDisplay { get; }
        /// <summary> Is column hidden. </summary>
        public bool? IsHidden { get; }
    }
}

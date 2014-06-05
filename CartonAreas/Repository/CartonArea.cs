﻿
using System;
namespace DcmsMobile.CartonAreas.Repository
{
    /// <summary>
    /// Count* properties are populated by the query only when a single area is retrieved
    /// </summary>
    internal class CartonArea : Area
    {
        public int TotalLocations { get; set; }

        public bool LocationNumberingFlag { get; set; }

        public bool IsPalletRequired { get; set; }

        public bool UnusableInventory { get; set; }

        public LocationCountMatrix LocationCounts { get; set; }

        [Obsolete]
        public int? CountAssignedLocations { get; set; }

        [Obsolete]
        public int? CountUnassignedLocations { get; set; }

        [Obsolete]
        public int? CountNonemptyUnassignedLocations { get; set; }

        [Obsolete]
        public int? CountEmptyUnassignedLocations { get; set; }

        [Obsolete]
        public int? CountNonemptyAssignedLocations { get; set; }

        [Obsolete]
        public int? CountEmptyAssignedLocations { get; set; }

        [Obsolete]
        public int? CountEmptyLocations { get; set; }

        [Obsolete]
        public int? CountNonemptyLocations { get; set; }
    }
}
//$Id$
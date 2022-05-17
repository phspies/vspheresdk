using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;
using vspheresdk.Appliance.Models.Enums;

namespace vspheresdk.Appliance.Models
{
    public class ApplianceVcenterSettingsV1ConfigComponentsInventoryResourcepoolResourceAllocationInfoType 
    {
        /// <summary>
        /// Amount of resource that is guaranteed available to a resource pool. Reserved resources are not wasted if they are not
        /// used. If the utilization is less than the reservation, the resources can be utilized by other running virtual machines.
        /// Units are MB fo memory, and MHz for CPU.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "reservation", Required = Required.AllowNull)]
        public long Reservation { get; set; }
        /// <summary>
        /// In a resource pool with an expandable reservation, the reservation can grow beyond the specified value, if the parent
        /// resource pool has unreserved resources. A non-expandable reservation is called a fixed reservation.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "expandable_reservation", Required = Required.AllowNull)]
        public bool ExpandableReservation { get; set; }
        /// <summary>
        /// The utilization of a resource pool will not exceed this limit, even if there are available resources. This is typically
        /// used to ensure a consistent performance of resource pools independent of available resources. If set to -1, then there
        /// is no fixed limit on resource usage (only bounded by available resources and shares). Units are MB for memory, and MHz
        /// for CPU.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "limit", Required = Required.AllowNull)]
        public long Limit { get; set; }
        /// <summary>
        /// Shares are used in case of resource contention.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "shares", Required = Required.AllowNull)]
        public ApplianceVcenterSettingsV1ConfigComponentsInventoryResourcepoolSharesType Shares { get; set; }
    }
}

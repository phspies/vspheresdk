using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;
using vspheresdk.Vcenter.Models.Enums;

namespace vspheresdk.Vcenter.Models
{
    public class VcenterGuestDomainTypeA 
    {
        /// <summary>
        /// The type of network to join after the customization.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.AllowNull)]
        public VcenterGuestDomainTypeEnumA Type { get; set; }
        /// <summary>
        /// The workgroup that the virtual machine should join.
        /// This field is optional and it is only relevant when the value of Domain.type is WORKGROUP.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "workgroup")]
        public string? Workgroup { get; set; }
        /// <summary>
        /// The domain to which the virtual machine should be joined.
        /// This field is optional and it is only relevant when the value of Domain.type is DOMAIN.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "domain")]
        public string? Domain { get; set; }
        /// <summary>
        /// The domain user that has permission to join the domain after virtual machine is joined.
        /// This field is optional and it is only relevant when the value of Domain.type is DOMAIN.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "domain_username")]
        public string? DomainUsername { get; set; }
        /// <summary>
        /// The domain user password that has permission to join the Domain.domain-username after customization.
        /// This field is optional and it is only relevant when the value of Domain.type is DOMAIN.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "domain_password")]
        public string? DomainPassword { get; set; }
    }
}

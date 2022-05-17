using System.Runtime.Serialization;

namespace vspheresdk.Stats.Models.Enums
{
    /// <summary>
    /// Declares which predicates are supported by the ResourceAddressSchemas.ResourceIdDefinition. Warning: This enumeration is available as Technology Preview. These are early access APIs provided to test, automate and provide feedback on the feature. Since this can change based on feedback, VMware does not guarantee backwards compatibility and recommends against using them in production environments. Some Technology Preview APIs might only be applicable to specific environments.
    /// </summary>
    public enum VstatsResourceAddressSchemasQueryCapabilitiesEnumType
    {
        [EnumMember(Value = "EQUAL")]
        EQUAL = 1,
        [EnumMember(Value = "EQUAL_ALL")]
        EQUALALL = 2,
    }
}

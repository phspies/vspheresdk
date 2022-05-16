using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// The ApplianceState enumerated type defines the various states the vCenter Appliance can be in.
    /// </summary>
    public enum VcenterDeploymentApplianceStateTypeA
    {
        [EnumMember(Value = "NOT_INITIALIZED")]
        NOTINITIALIZED = 1,
        [EnumMember(Value = "INITIALIZED")]
        INITIALIZED = 2,
        [EnumMember(Value = "CONFIG_IN_PROGRESS")]
        CONFIGINPROGRESS = 3,
        [EnumMember(Value = "QUESTION_RAISED")]
        QUESTIONRAISED = 4,
        [EnumMember(Value = "FAILED")]
        FAILED = 5,
        [EnumMember(Value = "CONFIGURED")]
        CONFIGURED = 6,
    }
}

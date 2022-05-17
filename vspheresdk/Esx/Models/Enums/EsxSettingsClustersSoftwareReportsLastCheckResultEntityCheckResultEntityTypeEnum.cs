using System.Runtime.Serialization;

namespace vspheresdk.Esx.Models.Enums
{
    /// <summary>
    /// The {@name EntityType} {@term enumerated type} contains the entitites on which checks can be performed.
    /// </summary>
    public enum EsxSettingsClustersSoftwareReportsLastCheckResultEntityCheckResultEntityTypeEnum
    {
        [EnumMember(Value = "CLUSTER")]
        CLUSTER = 1,
        [EnumMember(Value = "HOST")]
        HOST = 2,
    }
}

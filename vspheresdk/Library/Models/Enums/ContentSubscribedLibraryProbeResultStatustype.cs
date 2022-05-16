using System.Runtime.Serialization;

namespace vspheresdk.Library.Models.Enums
{
    /// <summary>
    /// The {@name Status} {@term enumerated type} defines the error status constants for the probe result.
    /// </summary>
    public enum ContentSubscribedLibraryProbeResultStatusType
    {
        [EnumMember(Value = "SUCCESS")]
        SUCCESS = 1,
        [EnumMember(Value = "INVALID_URL")]
        INVALIDURL = 2,
        [EnumMember(Value = "TIMED_OUT")]
        TIMEDOUT = 3,
        [EnumMember(Value = "HOST_NOT_FOUND")]
        HOSTNOTFOUND = 4,
        [EnumMember(Value = "RESOURCE_NOT_FOUND")]
        RESOURCENOTFOUND = 5,
        [EnumMember(Value = "INVALID_CREDENTIALS")]
        INVALIDCREDENTIALS = 6,
        [EnumMember(Value = "CERTIFICATE_ERROR")]
        CERTIFICATEERROR = 7,
        [EnumMember(Value = "UNKNOWN_ERROR")]
        UNKNOWNERROR = 8,
    }
}

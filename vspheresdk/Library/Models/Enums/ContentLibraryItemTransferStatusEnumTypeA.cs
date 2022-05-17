using System.Runtime.Serialization;

namespace vspheresdk.Library.Models.Enums
{
    /// <summary>
    /// The {@name TransferStatus} {@term enumerated type} defines the transfer state of a file.
    /// </summary>
    public enum ContentLibraryItemTransferStatusEnumTypeA
    {
        [EnumMember(Value = "WAITING_FOR_TRANSFER")]
        WAITINGFORTRANSFER = 1,
        [EnumMember(Value = "TRANSFERRING")]
        TRANSFERRING = 2,
        [EnumMember(Value = "READY")]
        READY = 3,
        [EnumMember(Value = "VALIDATING")]
        VALIDATING = 4,
        [EnumMember(Value = "ERROR")]
        ERROR = 5,
    }
}

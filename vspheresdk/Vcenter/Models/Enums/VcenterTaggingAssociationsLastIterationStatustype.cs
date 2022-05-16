using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// The last status for the iterator. A field of this type is returned as part of the result and indicates to the caller of the API whether it can continue to make requests for more data.  The last status only reports on the state of the iteration at the time data was last returned. As a result, it not does guarantee if the next call will succeed in getting more data or not.  Failures to retrieve results will be returned as Error responses. These last statuses are only returned when the iterator is operating as expected.
    /// </summary>
    public enum VcenterTaggingAssociationsLastIterationStatusType
    {
        [EnumMember(Value = "READY")]
        READY = 1,
        [EnumMember(Value = "END_OF_DATA")]
        ENDOFDATA = 2,
    }
}

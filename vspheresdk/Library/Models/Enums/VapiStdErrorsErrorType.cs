using System.Runtime.Serialization;

namespace vspheresdk.Library.Models.Enums
{
    /// <summary>
    /// Enumeration of all standard errors. Used as discriminator in protocols that have no standard means for transporting the error type, e.g. REST.
    /// </summary>
    public enum VapiStdErrorsErrorType
    {
        [EnumMember(Value = "ERROR")]
        ERROR = 1,
        [EnumMember(Value = "ALREADY_EXISTS")]
        ALREADYEXISTS = 2,
        [EnumMember(Value = "ALREADY_IN_DESIRED_STATE")]
        ALREADYINDESIREDSTATE = 3,
        [EnumMember(Value = "CANCELED")]
        CANCELED = 4,
        [EnumMember(Value = "CONCURRENT_CHANGE")]
        CONCURRENTCHANGE = 5,
        [EnumMember(Value = "FEATURE_IN_USE")]
        FEATUREINUSE = 6,
        [EnumMember(Value = "INTERNAL_SERVER_ERROR")]
        INTERNALSERVERERROR = 7,
        [EnumMember(Value = "INVALID_ARGUMENT")]
        INVALIDARGUMENT = 8,
        [EnumMember(Value = "INVALID_ELEMENT_CONFIGURATION")]
        INVALIDELEMENTCONFIGURATION = 9,
        [EnumMember(Value = "INVALID_ELEMENT_TYPE")]
        INVALIDELEMENTTYPE = 10,
        [EnumMember(Value = "INVALID_REQUEST")]
        INVALIDREQUEST = 11,
        [EnumMember(Value = "NOT_ALLOWED_IN_CURRENT_STATE")]
        NOTALLOWEDINCURRENTSTATE = 12,
        [EnumMember(Value = "NOT_FOUND")]
        NOTFOUND = 13,
        [EnumMember(Value = "OPERATION_NOT_FOUND")]
        OPERATIONNOTFOUND = 14,
        [EnumMember(Value = "RESOURCE_BUSY")]
        RESOURCEBUSY = 15,
        [EnumMember(Value = "RESOURCE_IN_USE")]
        RESOURCEINUSE = 16,
        [EnumMember(Value = "RESOURCE_INACCESSIBLE")]
        RESOURCEINACCESSIBLE = 17,
        [EnumMember(Value = "SERVICE_UNAVAILABLE")]
        SERVICEUNAVAILABLE = 18,
        [EnumMember(Value = "TIMED_OUT")]
        TIMEDOUT = 19,
        [EnumMember(Value = "UNABLE_TO_ALLOCATE_RESOURCE")]
        UNABLETOALLOCATERESOURCE = 20,
        [EnumMember(Value = "UNAUTHENTICATED")]
        UNAUTHENTICATED = 21,
        [EnumMember(Value = "UNAUTHORIZED")]
        UNAUTHORIZED = 22,
        [EnumMember(Value = "UNEXPECTED_INPUT")]
        UNEXPECTEDINPUT = 23,
        [EnumMember(Value = "UNSUPPORTED")]
        UNSUPPORTED = 24,
        [EnumMember(Value = "UNVERIFIED_PEER")]
        UNVERIFIEDPEER = 25,
    }
}

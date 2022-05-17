using System.Runtime.Serialization;

namespace vspheresdk.Vapi.Models.Enums
{
    /// <summary>
    /// The HttpMethod enumerated type defines the valid http methods that can be used with a URL to make a REST call.
    /// </summary>
    public enum VapiRestNavigationHttpMethodEnumType
    {
        [EnumMember(Value = "GET")]
        GET = 1,
        [EnumMember(Value = "POST")]
        POST = 2,
        [EnumMember(Value = "PUT")]
        PUT = 3,
        [EnumMember(Value = "DELETE")]
        DELETE = 4,
        [EnumMember(Value = "OPTIONS")]
        OPTIONS = 5,
        [EnumMember(Value = "PATCH")]
        PATCH = 6,
        [EnumMember(Value = "TRACE")]
        TRACE = 7,
        [EnumMember(Value = "CONNECT")]
        CONNECT = 8,
        [EnumMember(Value = "HEAD")]
        HEAD = 9,
    }
}

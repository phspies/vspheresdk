using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;
using vspheresdk.Library.Models.Enums;

namespace vspheresdk.Library.Models
{
    public class ContentLibraryItemUpdatesessionPreviewInfoType 
    {
        /// <summary>
        /// Indicates the state of the preview of the update session.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "state", Required = Required.AllowNull)]
        public ContentLibraryItemUpdatesessionPreviewInfoStateEnumType State { get; set; }
        /// <summary>
        /// The certificate information of the signed update session content.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "certificate_info")]
        public ContentLibraryItemUpdatesessionCertificateInfoType CertificateInfo { get; set; }
        /// <summary>
        /// The list of warnings raised for this update session. Any warning which is not ignored by the client will, by default,
        /// fail the update session during session complete operation.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "warnings")]
        public Dictionary<string,ContentLibraryItemUpdatesessionPreviewWarningInfoType> Warnings { get; set; }
        /// <summary>
        /// Certificate chain in base64 format.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "cert_chain")]
        public IList<string> CertChain { get; set; }
    }
}

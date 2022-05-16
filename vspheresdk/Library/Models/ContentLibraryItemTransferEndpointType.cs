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
    public class ContentLibraryItemTransferEndpointType 
    {
        /// <summary>
        /// Transfer endpoint URI. The supported URI schemes are: {@code http}, {@code https}, and {@code ds}. <p> An endpoint URI
        /// with the {@code ds} scheme specifies the location of the file on the datastore. The format of the datastore URI is: <ul>
        /// <li>ds:///vmfs/volumes/uuid/path</li> </ul> <p> When the transfer endpoint is a datastore location, the server can
        /// import the file directly from the storage backing without the overhead of streaming over HTTP.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "uri", Required = Required.AllowNull)]
        public string Uri { get; set; }
        /// <summary>
        /// Thumbprint of the expected SSL certificate for this endpoint. Only used for HTTPS connections. The thumbprint is the
        /// SHA-1 hash of the DER encoding of the remote endpoint's SSL certificate. If set, the remote endpoint's SSL certificate
        /// is only accepted if it matches this thumbprint, and no other certificate validation is performed.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssl_certificate_thumbprint")]
        public string? SslCertificateThumbprint { get; set; }
    }
}

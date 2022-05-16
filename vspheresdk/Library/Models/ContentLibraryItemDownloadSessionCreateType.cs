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
    public class ContentLibraryItemDownloadSessionCreateType 
    {
        /// <summary>
        /// The identifier of this download session.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string? Id { get; set; }
        /// <summary>
        /// The identifier of the library item whose content is being downloaded.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "library_item_id")]
        public string? LibraryItemId { get; set; }
        /// <summary>
        /// The content version of the library item whose content is being downloaded. This value is the {@link
        /// ItemModel#contentVersion} at the time when the session is created for the library item.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "library_item_content_version")]
        public string? LibraryItemContentVersion { get; set; }
        /// <summary>
        /// If the session is in the {@link State#ERROR} status this property will have more details about the error.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "error_message")]
        public VapiStdLocalizableMessageType ErrorMessage { get; set; }
        /// <summary>
        /// The progress that has been made with the download. This property is to be updated by the client during the download
        /// process to indicate the progress of its work in completing the download. The initial progress is 0 until updated by the
        /// client. The maximum value is 100, which indicates that the download is complete.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "client_progress")]
        public long? ClientProgress { get; set; }
        /// <summary>
        /// The current state ({@enum.values State}) of the download session.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public ContentLibraryItemDownloadSessionModelStateType State { get; set; }
        /// <summary>
        /// Indicates the time after which the session will expire. The session is guaranteed not to expire before this time.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "expiration_time")]
        public DateTime? ExpirationTime { get; set; }
    }
}

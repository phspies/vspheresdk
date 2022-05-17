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
    public class ContentLibraryItemUpdateSessionCreateType 
    {
        /// <summary>
        /// The identifier of this update session.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string? Id { get; set; }
        /// <summary>
        /// The identifier of the library item to which content will be uploaded or removed.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "library_item_id")]
        public string? LibraryItemId { get; set; }
        /// <summary>
        /// The content version of the library item whose content is being modified. This value is the {@link
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
        /// The progress that has been made with the upload. This property is to be updated by the client during the upload process
        /// to indicate the progress of its work in completing the upload. The initial progress is 0 until updated by the client.
        /// The maximum value is 100, which indicates that the update is complete.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "client_progress")]
        public long? ClientProgress { get; set; }
        /// <summary>
        /// The current state ({@enum.values State}) of the update session.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public ContentLibraryItemUpdateSessionModelStateEnumType State { get; set; }
        /// <summary>
        /// Indicates the time after which the session will expire. The session is guaranteed not to expire earlier than this time.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "expiration_time")]
        public DateTime? ExpirationTime { get; set; }
        /// <summary>
        /// A preview of the files currently being uploaded in the session. This property will be set only when the session is in
        /// the {@link State#ACTIVE}.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "preview_info")]
        public ContentLibraryItemUpdatesessionPreviewInfoType PreviewInfo { get; set; }
        /// <summary>
        /// Indicates the update session behavior if warnings are raised in the session preview. Any warning which is raised by
        /// session preview but not ignored by the client will, by default, fail the update session.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "warning_behavior")]
        public Dictionary<string,ContentLibraryItemUpdatesessionWarningBehaviorType> WarningBehavior { get; set; }
    }
}

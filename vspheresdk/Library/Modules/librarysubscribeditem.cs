using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Newtonsoft.Json;
using System.Net;
using vspheresdk;
using vspheresdk.Library.Models;
using vspheresdk.Library.Models.Enums;

namespace vspheresdk.Library.Modules
{
    public class LibrarySubscribedItemModule
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public LibrarySubscribedItemModule(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
        {
            restClient = Client;
            retry = _retry;
            timeout = _timeout;
            cancellationToken = _cancellationToken;
        }
        public async Task EvictAsync(string LibraryItemId)
        {
            ArgumentNullException.ThrowIfNull(LibraryItemId, "LibraryItemId cannot be null");
            StringBuilder EvictServiceURL = new StringBuilder("/api/content/library/subscribed-item/{library_item_id}?action=evict");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            EvictServiceURL.Replace("{library_item_id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LibraryItemId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = EvictServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (200 <= (int)response.StatusCode && (int)response.StatusCode <= 300) { }
            else if ((int)response.StatusCode == 404) { throw new vSphereException("if the library item specified by param.name libraryItemId does not exist.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 400) { throw new vSphereException("if the content of the library item specified by param.name libraryItemId has been deleted from the storage backings see link LibraryModelstorageBackings associated with it. p For instance this term error is reported on evicting a library item in an ondemand subscribed library that was restored from backup and the library item was deleted after backup thus resulting in its content being deleted from the associated storage backings. In this scenario the metadata of the library item is present on a restore while its content has been deleted.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
            
        }
        public async Task SyncAsync(string LibraryItemId, ContentLibrarySubscribedItemSyncType RequestBody)
        {
            ArgumentNullException.ThrowIfNull(LibraryItemId, "LibraryItemId cannot be null");
            ArgumentNullException.ThrowIfNull(RequestBody, "RequestBody cannot be null");
            StringBuilder SyncServiceURL = new StringBuilder("/api/content/library/subscribed-item/{library_item_id}?action=sync");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            SyncServiceURL.Replace("{library_item_id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LibraryItemId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(RequestBody);
            request.Resource = SyncServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (200 <= (int)response.StatusCode && (int)response.StatusCode <= 300) { }
            else if ((int)response.StatusCode == 404) { throw new vSphereException("if the library item specified by param.name libraryItemId could not be found.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 400) { throw new vSphereException("if the content of the library item specified by param.name libraryItemId has been deleted from the storage backings see link LibraryModelstorageBackings associated with it. p For instance this term error is reported on synchronizing a library item in a subscribed library that was restored from backup and the library item was deleted after backup thus resulting in its content being deleted from the associated storage backings. In this scenario the metadata of the library item is present on a restore while its content has been deleted.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
            
        }
    }
}

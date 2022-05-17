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

namespace vspheresdk.Library.Modules
{
    public class LibraryItemUpdateSessionModule
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public LibraryItemUpdateSessionModule(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
        {
            restClient = Client;
            retry = _retry;
            timeout = _timeout;
            cancellationToken = _cancellationToken;
        }
        public async Task<string> CreateAsync(ContentLibraryItemUpdateSessionCreateType RequestBody = null, string? ClientToken = null)
        {
            StringBuilder CreateServiceURL = new StringBuilder("/api/content/library/item/update-session");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(RequestBody);
            if (ClientToken != null) { request.AddQueryParameter("client_token", ClientToken.ToString()); }
            request.Resource = CreateServiceURL.ToString();
            RestResponse<string> response = await restClient.ExecuteTaskAsyncWithPolicy<string>(request, cancellationToken, timeout, retry);
            if ((int)response.StatusCode == 201) { ArgumentNullException.ThrowIfNull(response.Data) ; return response.Data; }
            else if ((int)response.StatusCode == 400) { throw new vSphereException("if the update session is being created on a subscribed library item.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 404) { throw new vSphereException("if the item targeted for update does not exist.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 500) { throw new vSphereException("if there is another update session on the same library item.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
        }
        public async Task<List<string>> ListAsync(string? LibraryItemId = null)
        {
            StringBuilder ListServiceURL = new StringBuilder("/api/content/library/item/update-session");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (LibraryItemId != null) { request.AddQueryParameter("library_item_id", LibraryItemId.ToString()); }
            request.Resource = ListServiceURL.ToString();
            RestResponse<List<string>> response = await restClient.ExecuteTaskAsyncWithPolicy<List<string>>(request, cancellationToken, timeout, retry);
            if ((int)response.StatusCode == 200) { ArgumentNullException.ThrowIfNull(response.Data) ; return response.Data; }
            else if ((int)response.StatusCode == 404) { throw new vSphereException("if a library item identifier is given for an item which does not exist.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
        }
        public async Task<ContentLibraryItemUpdateSessionCreateType> GetAsync(string UpdateSessionId)
        {
            ArgumentNullException.ThrowIfNull(UpdateSessionId, "UpdateSessionId cannot be null");
            StringBuilder GetServiceURL = new StringBuilder("/api/content/library/item/update-session/{update_session_id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetServiceURL.Replace("{update_session_id}", System.Uri.EscapeDataString(Helpers.ConvertToString(UpdateSessionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetServiceURL.ToString();
            RestResponse<ContentLibraryItemUpdateSessionCreateType> response = await restClient.ExecuteTaskAsyncWithPolicy<ContentLibraryItemUpdateSessionCreateType>(request, cancellationToken, timeout, retry);
            if ((int)response.StatusCode == 200) { ArgumentNullException.ThrowIfNull(response.Data) ; return response.Data; }
            else if ((int)response.StatusCode == 404) { throw new vSphereException("if no update session with the given identifier exists.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
        }
        public async Task UpdateAsync(string UpdateSessionId, ContentLibraryItemUpdateSessionCreateType RequestBody = null)
        {
            ArgumentNullException.ThrowIfNull(UpdateSessionId, "UpdateSessionId cannot be null");
            StringBuilder UpdateServiceURL = new StringBuilder("/api/content/library/item/update-session/{update_session_id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            UpdateServiceURL.Replace("{update_session_id}", System.Uri.EscapeDataString(Helpers.ConvertToString(UpdateSessionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(RequestBody);
            request.Resource = UpdateServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if ((int)response.StatusCode == 204) {}
            else if ((int)response.StatusCode == 404) { throw new vSphereException("if the update session does not exist.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 400) { throw new vSphereException("if the update session specification is not valid.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
        }
        public async Task DeleteAsync(string UpdateSessionId)
        {
            ArgumentNullException.ThrowIfNull(UpdateSessionId, "UpdateSessionId cannot be null");
            StringBuilder DeleteServiceURL = new StringBuilder("/api/content/library/item/update-session/{update_session_id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteServiceURL.Replace("{update_session_id}", System.Uri.EscapeDataString(Helpers.ConvertToString(UpdateSessionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if ((int)response.StatusCode == 204) {}
            else if ((int)response.StatusCode == 404) { throw new vSphereException("if the update session does not exist.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 400) { throw new vSphereException("if the update session is in the link UpdateSessionModel.StateACTIVE state.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
        }
        public async Task CancelAsync(string UpdateSessionId)
        {
            ArgumentNullException.ThrowIfNull(UpdateSessionId, "UpdateSessionId cannot be null");
            StringBuilder CancelServiceURL = new StringBuilder("/api/content/library/item/update-session/{update_session_id}?action=cancel");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            CancelServiceURL.Replace("{update_session_id}", System.Uri.EscapeDataString(Helpers.ConvertToString(UpdateSessionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = CancelServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if ((int)response.StatusCode == 204) {}
            else if ((int)response.StatusCode == 404) { throw new vSphereException("if no update session with the given identifier exists.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 400) { throw new vSphereException("if the update session is not in the link UpdateSessionModel.StateACTIVE state.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
        }
        public async Task CompleteAsync(string UpdateSessionId)
        {
            ArgumentNullException.ThrowIfNull(UpdateSessionId, "UpdateSessionId cannot be null");
            StringBuilder CompleteServiceURL = new StringBuilder("/api/content/library/item/update-session/{update_session_id}?action=complete");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            CompleteServiceURL.Replace("{update_session_id}", System.Uri.EscapeDataString(Helpers.ConvertToString(UpdateSessionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = CompleteServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if ((int)response.StatusCode == 204) {}
            else if ((int)response.StatusCode == 404) { throw new vSphereException("if no update session with the given identifier exists.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 400) { throw new vSphereException("if the update session is not in the link UpdateSessionModel.StateACTIVE state or if some of the files that will be uploaded by the client arent received correctly.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
        }
        public async Task FailAsync(string UpdateSessionId, ContentLibraryItemUpdateSessionFailType RequestBody)
        {
            ArgumentNullException.ThrowIfNull(UpdateSessionId, "UpdateSessionId cannot be null");
            ArgumentNullException.ThrowIfNull(RequestBody, "RequestBody cannot be null");
            StringBuilder FailServiceURL = new StringBuilder("/api/content/library/item/update-session/{update_session_id}?action=fail");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            FailServiceURL.Replace("{update_session_id}", System.Uri.EscapeDataString(Helpers.ConvertToString(UpdateSessionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(RequestBody);
            request.Resource = FailServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if ((int)response.StatusCode == 204) {}
            else if ((int)response.StatusCode == 404) { throw new vSphereException("if the update session does not exist.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 400) { throw new vSphereException("if the update session is not in the link UpdateSessionModel.StateACTIVE state.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
        }
        public async Task KeepAliveAsync(string UpdateSessionId, ContentLibraryItemUpdateSessionKeepAliveType RequestBody = null)
        {
            ArgumentNullException.ThrowIfNull(UpdateSessionId, "UpdateSessionId cannot be null");
            StringBuilder KeepAliveServiceURL = new StringBuilder("/api/content/library/item/update-session/{update_session_id}?action=keep-alive");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            KeepAliveServiceURL.Replace("{update_session_id}", System.Uri.EscapeDataString(Helpers.ConvertToString(UpdateSessionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(RequestBody);
            request.Resource = KeepAliveServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if ((int)response.StatusCode == 204) {}
            else if ((int)response.StatusCode == 404) { throw new vSphereException("if no update session with the given identifier exists.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 400) { throw new vSphereException("if the update session is not in the link UpdateSessionModel.StateACTIVE state.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
        }
    }
}

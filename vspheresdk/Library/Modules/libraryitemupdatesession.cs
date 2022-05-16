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
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreateServiceURL.ToString() + " did not complete successfull";
                throw new vSphereException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
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
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListServiceURL.ToString() + " did not complete successfull";
                throw new vSphereException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
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
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetServiceURL.ToString() + " did not complete successfull";
                throw new vSphereException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
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
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + UpdateServiceURL.ToString() + " did not complete successfull";
                throw new vSphereException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
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
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteServiceURL.ToString() + " did not complete successfull";
                throw new vSphereException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
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
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CancelServiceURL.ToString() + " did not complete successfull";
                throw new vSphereException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
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
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CompleteServiceURL.ToString() + " did not complete successfull";
                throw new vSphereException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
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
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + FailServiceURL.ToString() + " did not complete successfull";
                throw new vSphereException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
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
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + KeepAliveServiceURL.ToString() + " did not complete successfull";
                throw new vSphereException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
    }
}

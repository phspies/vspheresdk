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
    public class LibraryItemDownloadSessionModule
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public LibraryItemDownloadSessionModule(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
        {
            restClient = Client;
            retry = _retry;
            timeout = _timeout;
            cancellationToken = _cancellationToken;
        }
        public async Task<string> CreateAsync(ContentLibraryItemDownloadSessionCreateType RequestBody = null, string? ClientToken = null)
        {
            StringBuilder CreateServiceURL = new StringBuilder("/api/content/library/item/download-session");
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
            StringBuilder ListServiceURL = new StringBuilder("/api/content/library/item/download-session");
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
        public async Task<ContentLibraryItemDownloadSessionCreateType> GetAsync(string DownloadSessionId)
        {
            ArgumentNullException.ThrowIfNull(DownloadSessionId, "DownloadSessionId cannot be null");
            StringBuilder GetServiceURL = new StringBuilder("/api/content/library/item/download-session/{download_session_id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetServiceURL.Replace("{download_session_id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DownloadSessionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetServiceURL.ToString();
            RestResponse<ContentLibraryItemDownloadSessionCreateType> response = await restClient.ExecuteTaskAsyncWithPolicy<ContentLibraryItemDownloadSessionCreateType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetServiceURL.ToString() + " did not complete successfull";
                throw new vSphereException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        public async Task DeleteAsync(string DownloadSessionId)
        {
            ArgumentNullException.ThrowIfNull(DownloadSessionId, "DownloadSessionId cannot be null");
            StringBuilder DeleteServiceURL = new StringBuilder("/api/content/library/item/download-session/{download_session_id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteServiceURL.Replace("{download_session_id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DownloadSessionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteServiceURL.ToString() + " did not complete successfull";
                throw new vSphereException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        public async Task CancelAsync(string DownloadSessionId)
        {
            ArgumentNullException.ThrowIfNull(DownloadSessionId, "DownloadSessionId cannot be null");
            StringBuilder CancelServiceURL = new StringBuilder("/api/content/library/item/download-session/{download_session_id}?action=cancel");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            CancelServiceURL.Replace("{download_session_id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DownloadSessionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = CancelServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CancelServiceURL.ToString() + " did not complete successfull";
                throw new vSphereException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        public async Task FailAsync(string DownloadSessionId, ContentLibraryItemDownloadSessionFailType RequestBody)
        {
            ArgumentNullException.ThrowIfNull(DownloadSessionId, "DownloadSessionId cannot be null");
            ArgumentNullException.ThrowIfNull(RequestBody, "RequestBody cannot be null");
            StringBuilder FailServiceURL = new StringBuilder("/api/content/library/item/download-session/{download_session_id}?action=fail");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            FailServiceURL.Replace("{download_session_id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DownloadSessionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(RequestBody);
            request.Resource = FailServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + FailServiceURL.ToString() + " did not complete successfull";
                throw new vSphereException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        public async Task KeepAliveAsync(string DownloadSessionId, ContentLibraryItemDownloadSessionKeepAliveType RequestBody = null)
        {
            ArgumentNullException.ThrowIfNull(DownloadSessionId, "DownloadSessionId cannot be null");
            StringBuilder KeepAliveServiceURL = new StringBuilder("/api/content/library/item/download-session/{download_session_id}?action=keep-alive");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            KeepAliveServiceURL.Replace("{download_session_id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DownloadSessionId, System.Globalization.CultureInfo.InvariantCulture)));
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

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
    public class SubscribedLibraryModule
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public SubscribedLibraryModule(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
        {
            restClient = Client;
            retry = _retry;
            timeout = _timeout;
            cancellationToken = _cancellationToken;
        }
        public async Task<string> CreateAsync(ContentLibraryModelType RequestBody = null, string? ClientToken = null)
        {
            StringBuilder CreateServiceURL = new StringBuilder("/api/content/subscribed-library");
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
        public async Task<List<string>> ListAsync()
        {
            StringBuilder ListServiceURL = new StringBuilder("/api/content/subscribed-library");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = ListServiceURL.ToString();
            RestResponse<List<string>> response = await restClient.ExecuteTaskAsyncWithPolicy<List<string>>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListServiceURL.ToString() + " did not complete successfull";
                throw new vSphereException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        public async Task<ContentLibraryModelType> GetAsync(string LibraryId)
        {
            ArgumentNullException.ThrowIfNull(LibraryId, "LibraryId cannot be null");
            StringBuilder GetServiceURL = new StringBuilder("/api/content/subscribed-library/{library_id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetServiceURL.Replace("{library_id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LibraryId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetServiceURL.ToString();
            RestResponse<ContentLibraryModelType> response = await restClient.ExecuteTaskAsyncWithPolicy<ContentLibraryModelType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetServiceURL.ToString() + " did not complete successfull";
                throw new vSphereException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        public async Task UpdateAsync(string LibraryId, ContentLibraryModelType RequestBody = null)
        {
            ArgumentNullException.ThrowIfNull(LibraryId, "LibraryId cannot be null");
            StringBuilder UpdateServiceURL = new StringBuilder("/api/content/subscribed-library/{library_id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            UpdateServiceURL.Replace("{library_id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LibraryId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(RequestBody);
            request.Resource = UpdateServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + UpdateServiceURL.ToString() + " did not complete successfull";
                throw new vSphereException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        public async Task DeleteAsync(string LibraryId)
        {
            ArgumentNullException.ThrowIfNull(LibraryId, "LibraryId cannot be null");
            StringBuilder DeleteServiceURL = new StringBuilder("/api/content/subscribed-library/{library_id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteServiceURL.Replace("{library_id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LibraryId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteServiceURL.ToString() + " did not complete successfull";
                throw new vSphereException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        public async Task EvictAsync(string LibraryId)
        {
            ArgumentNullException.ThrowIfNull(LibraryId, "LibraryId cannot be null");
            StringBuilder EvictServiceURL = new StringBuilder("/api/content/subscribed-library/{library_id}?action=evict");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            EvictServiceURL.Replace("{library_id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LibraryId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = EvictServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + EvictServiceURL.ToString() + " did not complete successfull";
                throw new vSphereException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        public async Task SyncAsync(string LibraryId)
        {
            ArgumentNullException.ThrowIfNull(LibraryId, "LibraryId cannot be null");
            StringBuilder SyncServiceURL = new StringBuilder("/api/content/subscribed-library/{library_id}?action=sync");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            SyncServiceURL.Replace("{library_id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LibraryId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = SyncServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + SyncServiceURL.ToString() + " did not complete successfull";
                throw new vSphereException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        public async Task<ContentSubscribedLibraryProbeResultType> ProbeAsync(ContentSubscribedLibraryProbeType RequestBody)
        {
            ArgumentNullException.ThrowIfNull(RequestBody, "RequestBody cannot be null");
            StringBuilder ProbeServiceURL = new StringBuilder("/api/content/subscribed-library?action=probe");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(RequestBody);
            request.Resource = ProbeServiceURL.ToString();
            RestResponse<ContentSubscribedLibraryProbeResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<ContentSubscribedLibraryProbeResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + ProbeServiceURL.ToString() + " did not complete successfull";
                throw new vSphereException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}

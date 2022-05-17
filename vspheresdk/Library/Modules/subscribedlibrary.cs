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
            if (200 <= (int)response.StatusCode && (int)response.StatusCode <= 300) { return response.Data; }
            else if ((int)response.StatusCode == 400) { throw new vSphereException("if using multiple storage backings.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 500) { throw new vSphereException("if subscribing to a published library which cannot be accessed.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
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
            if (200 <= (int)response.StatusCode && (int)response.StatusCode <= 300) { return response.Data; }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
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
            if (200 <= (int)response.StatusCode && (int)response.StatusCode <= 300) { return response.Data; }
            else if ((int)response.StatusCode == 404) { throw new vSphereException("if the library associated with param.name libraryId does not exist.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 400) { throw new vSphereException("if the library associated with param.name libraryId is not a subscribed library.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
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
            if (200 <= (int)response.StatusCode && (int)response.StatusCode <= 300) { }
            else if ((int)response.StatusCode == 404) { throw new vSphereException("if the library specified by param.name libraryId does not exist.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 400) { throw new vSphereException("if the param.name updateSpec is not valid.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 500) { throw new vSphereException("if the link LibraryModelversion of param.name updateSpec is term unset and the library is being concurrently updated by another user.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 409) { throw new vSphereException("if the link LibraryModelversion of param.name updateSpec is not equal to the current version of the library.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
            
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
            if (200 <= (int)response.StatusCode && (int)response.StatusCode <= 300) { }
            else if ((int)response.StatusCode == 400) { throw new vSphereException("if the library referenced by param.name libraryId is not a subscribed library.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 404) { throw new vSphereException("if the library referenced by param.name libraryId does not exist.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
            
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
            if (200 <= (int)response.StatusCode && (int)response.StatusCode <= 300) { }
            else if ((int)response.StatusCode == 404) { throw new vSphereException("if the library specified by param.name libraryId does not exist.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 400) { throw new vSphereException("if the library specified by param.name libraryId does not synchronize ondemand or if the content of the library specified by param.name libraryId has been deleted from the storage backings see link LibraryModelstorageBackings associated with it. p For instance this term error is reported on evicting an ondemand subscribed library that was restored from backup and the library was deleted after the backup was taken thus resulting in its content being deleted from the associated storage backings. In this scenario the metadata of the library is present on a restore while its content has been deleted.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
            
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
            if (200 <= (int)response.StatusCode && (int)response.StatusCode <= 300) { }
            else if ((int)response.StatusCode == 404) { throw new vSphereException("if the library specified by param.name libraryId does not exist.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 400) { throw new vSphereException("if some parameter in the subscribed library subscription info is invalid.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 500) { throw new vSphereException("if the published library cannot be contacted or found.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
            
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
            if (200 <= (int)response.StatusCode && (int)response.StatusCode <= 300) { return response.Data; }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
            return response.Data;
        }
    }
}

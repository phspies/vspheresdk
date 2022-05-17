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
    public class LibraryItemModule
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public LibraryItemModule(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
        {
            restClient = Client;
            retry = _retry;
            timeout = _timeout;
            cancellationToken = _cancellationToken;
        }
        public async Task<string> CreateAsync(ContentLibraryItemCopyType RequestBody = null, string? ClientToken = null)
        {
            StringBuilder CreateServiceURL = new StringBuilder("/api/content/library/item");
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
            else if ((int)response.StatusCode == 404) { throw new vSphereException("if the link ItemModellibraryId property of param.name createSpec refers to a library that does not exist.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 400) { throw new vSphereException("if there is already a library item with same name in the library.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
        }
        public async Task<ContentLibraryItemCopyType> GetAsync(string LibraryItemId)
        {
            ArgumentNullException.ThrowIfNull(LibraryItemId, "LibraryItemId cannot be null");
            StringBuilder GetServiceURL = new StringBuilder("/api/content/library/item/{library_item_id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetServiceURL.Replace("{library_item_id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LibraryItemId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetServiceURL.ToString();
            RestResponse<ContentLibraryItemCopyType> response = await restClient.ExecuteTaskAsyncWithPolicy<ContentLibraryItemCopyType>(request, cancellationToken, timeout, retry);
            if ((int)response.StatusCode == 200) { ArgumentNullException.ThrowIfNull(response.Data) ; return response.Data; }
            else if ((int)response.StatusCode == 404) { throw new vSphereException("if no item with the given param.name libraryItemId exists.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
        }
        public async Task UpdateAsync(string LibraryItemId, ContentLibraryItemCopyType RequestBody = null)
        {
            ArgumentNullException.ThrowIfNull(LibraryItemId, "LibraryItemId cannot be null");
            StringBuilder UpdateServiceURL = new StringBuilder("/api/content/library/item/{library_item_id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            UpdateServiceURL.Replace("{library_item_id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LibraryItemId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(RequestBody);
            request.Resource = UpdateServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if ((int)response.StatusCode == 204) {}
            else if ((int)response.StatusCode == 404) { throw new vSphereException("if the library item specified by param.name libraryItemId does not exist.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 400) { throw new vSphereException("if there is already a library item with same name in the library.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
        }
        public async Task DeleteAsync(string LibraryItemId)
        {
            ArgumentNullException.ThrowIfNull(LibraryItemId, "LibraryItemId cannot be null");
            StringBuilder DeleteServiceURL = new StringBuilder("/api/content/library/item/{library_item_id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteServiceURL.Replace("{library_item_id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LibraryItemId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if ((int)response.StatusCode == 204) {}
            else if ((int)response.StatusCode == 400) { throw new vSphereException("if the library item contains a virtual machine template and a virtual machine is checked out of the library item.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 404) { throw new vSphereException("if the library item with the specified param.name libraryItemId does not exist.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
        }
        public async Task PublishAsync(string LibraryItemId, ContentLibraryItemPublishType RequestBody)
        {
            ArgumentNullException.ThrowIfNull(LibraryItemId, "LibraryItemId cannot be null");
            ArgumentNullException.ThrowIfNull(RequestBody, "RequestBody cannot be null");
            StringBuilder PublishServiceURL = new StringBuilder("/api/content/library/item/{library_item_id}?action=publish");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            PublishServiceURL.Replace("{library_item_id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LibraryItemId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(RequestBody);
            request.Resource = PublishServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if ((int)response.StatusCode == 204) {}
            else if ((int)response.StatusCode == 500) { throw new vSphereException("If the system reports an error while responding to the request.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 404) { throw new vSphereException("If the library item specified by param.name libraryItemId does not exist.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 400) { throw new vSphereException("If the library item specified by param.name libraryItemId does not belong to a published library.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 401) { throw new vSphereException("If the user that requested the term operation cannot be authenticated.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 403) { throw new vSphereException("If the user that requested the term operation is not authorized to perform the term operation.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
        }
        public async Task<string> CopyAsync(string SourceLibraryItemId, ContentLibraryItemCopyType RequestBody = null, string? ClientToken = null)
        {
            ArgumentNullException.ThrowIfNull(SourceLibraryItemId, "SourceLibraryItemId cannot be null");
            StringBuilder CopyServiceURL = new StringBuilder("/api/content/library/item/{source_library_item_id}?action=copy");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            CopyServiceURL.Replace("{source_library_item_id}", System.Uri.EscapeDataString(Helpers.ConvertToString(SourceLibraryItemId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(RequestBody);
            if (ClientToken != null) { request.AddQueryParameter("client_token", ClientToken.ToString()); }
            request.Resource = CopyServiceURL.ToString();
            RestResponse<string> response = await restClient.ExecuteTaskAsyncWithPolicy<string>(request, cancellationToken, timeout, retry);
            if ((int)response.StatusCode == 200) { ArgumentNullException.ThrowIfNull(response.Data) ; return response.Data; }
            else if ((int)response.StatusCode == 404) { throw new vSphereException("if the library item with param.name sourceLibraryItemId does not exist or if the library referenced by the link ItemModellibraryId property of param.name destinationCreateSpec does not exist.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 400) { throw new vSphereException("if the content of the source library item specified by param.name sourceLibraryItemId or the content of the target library specified by the library ID see link ItemModellibraryId property of param.name destinationCreateSpec has been deleted from the storage backings see link LibraryModelstorageBackings associated with it.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 500) { throw new vSphereException("if the copy operation failed because the source or destination library item is not accessible.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
        }
        public async Task<List<string>> FindAsync(ContentLibraryItemFindType RequestBody = null)
        {
            StringBuilder FindServiceURL = new StringBuilder("/api/content/library/item?action=find");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(RequestBody);
            request.Resource = FindServiceURL.ToString();
            RestResponse<List<string>> response = await restClient.ExecuteTaskAsyncWithPolicy<List<string>>(request, cancellationToken, timeout, retry);
            if ((int)response.StatusCode == 200) { ArgumentNullException.ThrowIfNull(response.Data) ; return response.Data; }
            else if ((int)response.StatusCode == 400) { throw new vSphereException("if no properties are specified in the param.name spec.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
        }
        public async Task<List<string>> ListAsync(string LibraryId)
        {
            ArgumentNullException.ThrowIfNull(LibraryId, "LibraryId cannot be null");
            StringBuilder ListServiceURL = new StringBuilder("/api/content/library/item");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (LibraryId != null) { request.AddQueryParameter("library_id", LibraryId.ToString()); }
            request.Resource = ListServiceURL.ToString();
            RestResponse<List<string>> response = await restClient.ExecuteTaskAsyncWithPolicy<List<string>>(request, cancellationToken, timeout, retry);
            if ((int)response.StatusCode == 200) { ArgumentNullException.ThrowIfNull(response.Data) ; return response.Data; }
            else if ((int)response.StatusCode == 404) { throw new vSphereException("if the library associated with param.name libraryId does not exist.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
        }
    }
}

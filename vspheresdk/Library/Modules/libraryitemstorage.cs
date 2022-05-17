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
    public class LibraryItemStorageModule
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public LibraryItemStorageModule(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
        {
            restClient = Client;
            retry = _retry;
            timeout = _timeout;
            cancellationToken = _cancellationToken;
        }
        public async Task<List<ContentLibraryItemStorageInfoType>> ListAsync(string LibraryItemId)
        {
            ArgumentNullException.ThrowIfNull(LibraryItemId, "LibraryItemId cannot be null");
            StringBuilder ListServiceURL = new StringBuilder("/api/content/library/item/{library_item_id}/storage");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListServiceURL.Replace("{library_item_id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LibraryItemId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ListServiceURL.ToString();
            RestResponse<List<ContentLibraryItemStorageInfoType>> response = await restClient.ExecuteTaskAsyncWithPolicy<List<ContentLibraryItemStorageInfoType>>(request, cancellationToken, timeout, retry);
            if ((int)response.StatusCode == 200) { ArgumentNullException.ThrowIfNull(response.Data) ; return response.Data; }
            else if ((int)response.StatusCode == 404) { throw new vSphereException("if the specified library item does not exist.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
        }
        public async Task<List<ContentLibraryItemStorageInfoType>> GetAsync(string LibraryItemId, string FileName)
        {
            ArgumentNullException.ThrowIfNull(LibraryItemId, "LibraryItemId cannot be null");
            ArgumentNullException.ThrowIfNull(FileName, "FileName cannot be null");
            StringBuilder GetServiceURL = new StringBuilder("/api/content/library/item/{library_item_id}/storage?file_name");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetServiceURL.Replace("{library_item_id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LibraryItemId, System.Globalization.CultureInfo.InvariantCulture)));
            if (FileName != null) { request.AddQueryParameter("file_name", FileName.ToString()); }
            request.Resource = GetServiceURL.ToString();
            RestResponse<List<ContentLibraryItemStorageInfoType>> response = await restClient.ExecuteTaskAsyncWithPolicy<List<ContentLibraryItemStorageInfoType>>(request, cancellationToken, timeout, retry);
            if ((int)response.StatusCode == 200) { ArgumentNullException.ThrowIfNull(response.Data) ; return response.Data; }
            else if ((int)response.StatusCode == 404) { throw new vSphereException("if the specified library item does not exist.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
        }
    }
}

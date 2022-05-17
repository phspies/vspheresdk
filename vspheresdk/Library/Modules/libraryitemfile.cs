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
    public class LibraryItemFileModule
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public LibraryItemFileModule(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
        {
            restClient = Client;
            retry = _retry;
            timeout = _timeout;
            cancellationToken = _cancellationToken;
        }
        public async Task<List<ContentLibraryItemFileInfoType>> ListAsync(string LibraryItemId)
        {
            ArgumentNullException.ThrowIfNull(LibraryItemId, "LibraryItemId cannot be null");
            StringBuilder ListServiceURL = new StringBuilder("/api/content/library/item/{library_item_id}/file");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListServiceURL.Replace("{library_item_id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LibraryItemId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ListServiceURL.ToString();
            RestResponse<List<ContentLibraryItemFileInfoType>> response = await restClient.ExecuteTaskAsyncWithPolicy<List<ContentLibraryItemFileInfoType>>(request, cancellationToken, timeout, retry);
            if ((int)response.StatusCode == 200) { ArgumentNullException.ThrowIfNull(response.Data) ; return response.Data; }
            else if ((int)response.StatusCode == 404) { throw new vSphereException("if param.name libraryItemId refers to a library item that does not exist.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
        }
        public async Task<ContentLibraryItemFileInfoType> GetAsync(string LibraryItemId, string Name)
        {
            ArgumentNullException.ThrowIfNull(LibraryItemId, "LibraryItemId cannot be null");
            ArgumentNullException.ThrowIfNull(Name, "Name cannot be null");
            StringBuilder GetServiceURL = new StringBuilder("/api/content/library/item/{library_item_id}/file?name");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetServiceURL.Replace("{library_item_id}", System.Uri.EscapeDataString(Helpers.ConvertToString(LibraryItemId, System.Globalization.CultureInfo.InvariantCulture)));
            if (Name != null) { request.AddQueryParameter("name", Name.ToString()); }
            request.Resource = GetServiceURL.ToString();
            RestResponse<ContentLibraryItemFileInfoType> response = await restClient.ExecuteTaskAsyncWithPolicy<ContentLibraryItemFileInfoType>(request, cancellationToken, timeout, retry);
            if ((int)response.StatusCode == 200) { ArgumentNullException.ThrowIfNull(response.Data) ; return response.Data; }
            else if ((int)response.StatusCode == 404) { throw new vSphereException("if param.name libraryItemId refers to a library item that does not exist.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
        }
    }
}

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
    public class LibraryItemChangesModule
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public LibraryItemChangesModule(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
        {
            restClient = Client;
            retry = _retry;
            timeout = _timeout;
            cancellationToken = _cancellationToken;
        }
        public async Task<List<ContentLibraryItemChangesSummaryType>> ListAsync(string LibraryItem)
        {
            ArgumentNullException.ThrowIfNull(LibraryItem, "LibraryItem cannot be null");
            StringBuilder ListServiceURL = new StringBuilder("/api/content/library/item/{library_item}/changes");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListServiceURL.Replace("{library_item}", System.Uri.EscapeDataString(Helpers.ConvertToString(LibraryItem, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ListServiceURL.ToString();
            RestResponse<List<ContentLibraryItemChangesSummaryType>> response = await restClient.ExecuteTaskAsyncWithPolicy<List<ContentLibraryItemChangesSummaryType>>(request, cancellationToken, timeout, retry);
            if (200 <= (int)response.StatusCode && (int)response.StatusCode <= 300) { return response.Data; }
            else if ((int)response.StatusCode == 404) { throw new vSphereException("if the library item is not found.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 401) { throw new vSphereException("if the user that requested the term operation cannot be authenticated.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 403) { throw new vSphereException("if the user that requested the term operation is not authorized to perform the term operation.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 500) { throw new vSphereException("if the system reports an error while responding to the request.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
            return response.Data;
        }
        public async Task<ContentLibraryItemChangesInfoType> GetAsync(string LibraryItem, string Version)
        {
            ArgumentNullException.ThrowIfNull(LibraryItem, "LibraryItem cannot be null");
            ArgumentNullException.ThrowIfNull(Version, "Version cannot be null");
            StringBuilder GetServiceURL = new StringBuilder("/api/content/library/item/{library_item}/changes/{version}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetServiceURL.Replace("{library_item}", System.Uri.EscapeDataString(Helpers.ConvertToString(LibraryItem, System.Globalization.CultureInfo.InvariantCulture)));
            GetServiceURL.Replace("{version}", System.Uri.EscapeDataString(Helpers.ConvertToString(Version, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetServiceURL.ToString();
            RestResponse<ContentLibraryItemChangesInfoType> response = await restClient.ExecuteTaskAsyncWithPolicy<ContentLibraryItemChangesInfoType>(request, cancellationToken, timeout, retry);
            if (200 <= (int)response.StatusCode && (int)response.StatusCode <= 300) { return response.Data; }
            else if ((int)response.StatusCode == 404) { throw new vSphereException("if the library item or version is not found.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 401) { throw new vSphereException("if the user that requested the term operation cannot be authenticated.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 403) { throw new vSphereException("if the user that requested the term operation is not authorized to perform the term operation.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 500) { throw new vSphereException("if the system reports an error while responding to the request.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
            return response.Data;
        }
    }
}

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
    public class LibrarySubscriptionsModule
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public LibrarySubscriptionsModule(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
        {
            restClient = Client;
            retry = _retry;
            timeout = _timeout;
            cancellationToken = _cancellationToken;
        }
        public async Task<string> CreateAsync(string Library, ContentLibrarySubscriptionsCreateType RequestBody = null, string? ClientToken = null)
        {
            ArgumentNullException.ThrowIfNull(Library, "Library cannot be null");
            StringBuilder CreateServiceURL = new StringBuilder("/api/content/library/{library}/subscriptions");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            CreateServiceURL.Replace("{library}", System.Uri.EscapeDataString(Helpers.ConvertToString(Library, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(RequestBody);
            if (ClientToken != null) { request.AddQueryParameter("client_token", ClientToken.ToString()); }
            request.Resource = CreateServiceURL.ToString();
            RestResponse<string> response = await restClient.ExecuteTaskAsyncWithPolicy<string>(request, cancellationToken, timeout, retry);
            if (200 <= (int)response.StatusCode && (int)response.StatusCode <= 300) { return response.Data; }
            else if ((int)response.StatusCode == 400) { throw new vSphereException("If the library specified by param.name library is not a published library.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 500) { throw new vSphereException("If the vCenter instance specified by param.name subscribedLibraryvcenter cannot be contacted or found.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 404) { throw new vSphereException("If the library specified by param.name library does not exist.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 401) { throw new vSphereException("If the user that requested the term operation cannot be authenticated.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 403) { throw new vSphereException("If the user that requested the term operation is not authorized to perform the term operation.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
            return response.Data;
        }
        public async Task<List<ContentLibrarySubscriptionsSummaryType>> ListAsync(string Library)
        {
            ArgumentNullException.ThrowIfNull(Library, "Library cannot be null");
            StringBuilder ListServiceURL = new StringBuilder("/api/content/library/{library}/subscriptions");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListServiceURL.Replace("{library}", System.Uri.EscapeDataString(Helpers.ConvertToString(Library, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ListServiceURL.ToString();
            RestResponse<List<ContentLibrarySubscriptionsSummaryType>> response = await restClient.ExecuteTaskAsyncWithPolicy<List<ContentLibrarySubscriptionsSummaryType>>(request, cancellationToken, timeout, retry);
            if (200 <= (int)response.StatusCode && (int)response.StatusCode <= 300) { return response.Data; }
            else if ((int)response.StatusCode == 500) { throw new vSphereException("If the system reports an error while responding to the request.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 400) { throw new vSphereException("If the library specified by param.name library is not a published library.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 404) { throw new vSphereException("If the library specified by param.name library does not exist.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 401) { throw new vSphereException("If the user that requested the term operation cannot be authenticated.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 403) { throw new vSphereException("If the user that requested the term operation is not authorized to perform the term operation.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
            return response.Data;
        }
        public async Task<ContentLibrarySubscriptionsInfoType> GetAsync(string Library, string Subscription)
        {
            ArgumentNullException.ThrowIfNull(Library, "Library cannot be null");
            ArgumentNullException.ThrowIfNull(Subscription, "Subscription cannot be null");
            StringBuilder GetServiceURL = new StringBuilder("/api/content/library/{library}/subscriptions/{subscription}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetServiceURL.Replace("{library}", System.Uri.EscapeDataString(Helpers.ConvertToString(Library, System.Globalization.CultureInfo.InvariantCulture)));
            GetServiceURL.Replace("{subscription}", System.Uri.EscapeDataString(Helpers.ConvertToString(Subscription, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetServiceURL.ToString();
            RestResponse<ContentLibrarySubscriptionsInfoType> response = await restClient.ExecuteTaskAsyncWithPolicy<ContentLibrarySubscriptionsInfoType>(request, cancellationToken, timeout, retry);
            if (200 <= (int)response.StatusCode && (int)response.StatusCode <= 300) { return response.Data; }
            else if ((int)response.StatusCode == 500) { throw new vSphereException("If the system reports an error while responding to the request.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 404) { throw new vSphereException("If the library specified by param.name library does not exist.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 400) { throw new vSphereException("If the library specified by param.name library is not a published library.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 401) { throw new vSphereException("If the user that requested the term operation cannot be authenticated.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 403) { throw new vSphereException("If the user that requested the term operation is not authorized to perform the term operation.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
            return response.Data;
        }
        public async Task UpdateAsync(string Library, string Subscription, ContentLibrarySubscriptionsUpdateType RequestBody = null)
        {
            ArgumentNullException.ThrowIfNull(Library, "Library cannot be null");
            ArgumentNullException.ThrowIfNull(Subscription, "Subscription cannot be null");
            StringBuilder UpdateServiceURL = new StringBuilder("/api/content/library/{library}/subscriptions/{subscription}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            UpdateServiceURL.Replace("{library}", System.Uri.EscapeDataString(Helpers.ConvertToString(Library, System.Globalization.CultureInfo.InvariantCulture)));
            UpdateServiceURL.Replace("{subscription}", System.Uri.EscapeDataString(Helpers.ConvertToString(Subscription, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(RequestBody);
            request.Resource = UpdateServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (200 <= (int)response.StatusCode && (int)response.StatusCode <= 300) { }
            else if ((int)response.StatusCode == 500) { throw new vSphereException("If the subscribed library cannot be contacted or found.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 404) { throw new vSphereException("If the library specified by param.name library does not exist.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 400) { throw new vSphereException("If the library specified by param.name library is not a published library.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 401) { throw new vSphereException("If the user that requested the term operation cannot be authenticated.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 403) { throw new vSphereException("If the user that requested the term operation is not authorized to perform the term operation.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
            
        }
        public async Task DeleteAsync(string Library, string Subscription)
        {
            ArgumentNullException.ThrowIfNull(Library, "Library cannot be null");
            ArgumentNullException.ThrowIfNull(Subscription, "Subscription cannot be null");
            StringBuilder DeleteServiceURL = new StringBuilder("/api/content/library/{library}/subscriptions/{subscription}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteServiceURL.Replace("{library}", System.Uri.EscapeDataString(Helpers.ConvertToString(Library, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteServiceURL.Replace("{subscription}", System.Uri.EscapeDataString(Helpers.ConvertToString(Subscription, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (200 <= (int)response.StatusCode && (int)response.StatusCode <= 300) { }
            else if ((int)response.StatusCode == 500) { throw new vSphereException("If the system reports an error while responding to the request.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 400) { throw new vSphereException("If the library specified by param.name library is not a published library.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 404) { throw new vSphereException("If the library specified by param.name library does not exist.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 401) { throw new vSphereException("If the user that requested the term operation cannot be authenticated.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 403) { throw new vSphereException("If the user that requested the term operation is not authorized to perform the term operation.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
            
        }
    }
}

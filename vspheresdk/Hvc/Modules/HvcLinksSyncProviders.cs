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
using vspheresdk.Hvc.Models;
using vspheresdk.Hvc.Models.Enums;

namespace vspheresdk.Hvc.Modules
{
    public class HvcLinksSyncProvidersModule
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public HvcLinksSyncProvidersModule(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
        {
            restClient = Client;
            retry = _retry;
            timeout = _timeout;
            cancellationToken = _cancellationToken;
        }
        public async Task<List<VcenterHvcLinksSyncProvidersSummaryType>> ListAsync(string Link)
        {
            ArgumentNullException.ThrowIfNull(Link, "Link cannot be null");
            StringBuilder ListServiceURL = new StringBuilder("/api/hvc/links/{link}/sync/providers");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListServiceURL.Replace("{link}", System.Uri.EscapeDataString(Helpers.ConvertToString(Link, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ListServiceURL.ToString();
            RestResponse<List<VcenterHvcLinksSyncProvidersSummaryType>> response = await restClient.ExecuteTaskAsyncWithPolicy<List<VcenterHvcLinksSyncProvidersSummaryType>>(request, cancellationToken, timeout, retry);
            if (200 <= (int)response.StatusCode && (int)response.StatusCode <= 300) { return response.Data; }
            else if ((int)response.StatusCode == 500) { throw new vSphereException("If list fails.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 403) { throw new vSphereException("If the user is not authorized to perform this operation.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
            return response.Data;
        }
        public async Task<VcenterHvcLinksSyncProvidersInfoType> GetAsync(string Link, string Provider)
        {
            ArgumentNullException.ThrowIfNull(Link, "Link cannot be null");
            ArgumentNullException.ThrowIfNull(Provider, "Provider cannot be null");
            StringBuilder GetServiceURL = new StringBuilder("/api/hvc/links/{link}/sync/providers/{provider}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetServiceURL.Replace("{link}", System.Uri.EscapeDataString(Helpers.ConvertToString(Link, System.Globalization.CultureInfo.InvariantCulture)));
            GetServiceURL.Replace("{provider}", System.Uri.EscapeDataString(Helpers.ConvertToString(Provider, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetServiceURL.ToString();
            RestResponse<VcenterHvcLinksSyncProvidersInfoType> response = await restClient.ExecuteTaskAsyncWithPolicy<VcenterHvcLinksSyncProvidersInfoType>(request, cancellationToken, timeout, retry);
            if (200 <= (int)response.StatusCode && (int)response.StatusCode <= 300) { return response.Data; }
            else if ((int)response.StatusCode == 500) { throw new vSphereException("if the system reports an error while responding to the request.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 404) { throw new vSphereException("if the sync provider associated with param.name provider does not exist.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 403) { throw new vSphereException("if the user is not authorized to perform this operation.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
            return response.Data;
        }
        public async Task StartAsync(string Link, string Provider)
        {
            ArgumentNullException.ThrowIfNull(Link, "Link cannot be null");
            ArgumentNullException.ThrowIfNull(Provider, "Provider cannot be null");
            StringBuilder StartServiceURL = new StringBuilder("/api/hvc/links/{link}/sync/providers/{provider}?action=start");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            StartServiceURL.Replace("{link}", System.Uri.EscapeDataString(Helpers.ConvertToString(Link, System.Globalization.CultureInfo.InvariantCulture)));
            StartServiceURL.Replace("{provider}", System.Uri.EscapeDataString(Helpers.ConvertToString(Provider, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = StartServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (200 <= (int)response.StatusCode && (int)response.StatusCode <= 300) { }
            else if ((int)response.StatusCode == 500) { throw new vSphereException("if a sync is already running.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 404) { throw new vSphereException("if the link associated with param.name link does not exist if the provider associated with param.name provider is not registered for sync", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 403) { throw new vSphereException("if the user is not authorized to perform this operation.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
            
        }
    }
}

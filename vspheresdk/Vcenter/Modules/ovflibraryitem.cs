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
using vspheresdk.Vcenter.Models;

namespace vspheresdk.Vcenter.Modules
{
    public class OvfLibraryItemModule
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public OvfLibraryItemModule(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
        {
            restClient = Client;
            retry = _retry;
            timeout = _timeout;
            cancellationToken = _cancellationToken;
        }
        public async Task<VcenterOvfLibraryItemCreateResultType> CreateAsync(VcenterOvfLibraryItemCreateType RequestBody, string? ClientToken = null)
        {
            ArgumentNullException.ThrowIfNull(RequestBody, "RequestBody cannot be null");
            StringBuilder CreateServiceURL = new StringBuilder("/api/vcenter/ovf/library-item");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(RequestBody);
            if (ClientToken != null) { request.AddQueryParameter("client_token", ClientToken.ToString()); }
            request.Resource = CreateServiceURL.ToString();
            RestResponse<VcenterOvfLibraryItemCreateResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<VcenterOvfLibraryItemCreateResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreateServiceURL.ToString() + " did not complete successfull";
                throw new vSphereException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        public async Task<VcenterOvfLibraryItemDeploymentResultType> DeployAsync(string OvfLibraryItemId, VcenterOvfLibraryItemDeployType RequestBody, string? ClientToken = null)
        {
            ArgumentNullException.ThrowIfNull(OvfLibraryItemId, "OvfLibraryItemId cannot be null");
            ArgumentNullException.ThrowIfNull(RequestBody, "RequestBody cannot be null");
            StringBuilder DeployServiceURL = new StringBuilder("/api/vcenter/ovf/library-item/{ovf_library_item_id}?action=deploy");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            DeployServiceURL.Replace("{ovf_library_item_id}", System.Uri.EscapeDataString(Helpers.ConvertToString(OvfLibraryItemId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(RequestBody);
            if (ClientToken != null) { request.AddQueryParameter("client_token", ClientToken.ToString()); }
            request.Resource = DeployServiceURL.ToString();
            RestResponse<VcenterOvfLibraryItemDeploymentResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<VcenterOvfLibraryItemDeploymentResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + DeployServiceURL.ToString() + " did not complete successfull";
                throw new vSphereException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        public async Task<VcenterOvfLibraryItemOvfSummaryType> FilterAsync(string OvfLibraryItemId, VcenterOvfLibraryItemFilterType RequestBody)
        {
            ArgumentNullException.ThrowIfNull(OvfLibraryItemId, "OvfLibraryItemId cannot be null");
            ArgumentNullException.ThrowIfNull(RequestBody, "RequestBody cannot be null");
            StringBuilder FilterServiceURL = new StringBuilder("/api/vcenter/ovf/library-item/{ovf_library_item_id}?action=filter");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            FilterServiceURL.Replace("{ovf_library_item_id}", System.Uri.EscapeDataString(Helpers.ConvertToString(OvfLibraryItemId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(RequestBody);
            request.Resource = FilterServiceURL.ToString();
            RestResponse<VcenterOvfLibraryItemOvfSummaryType> response = await restClient.ExecuteTaskAsyncWithPolicy<VcenterOvfLibraryItemOvfSummaryType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + FilterServiceURL.ToString() + " did not complete successfull";
                throw new vSphereException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}

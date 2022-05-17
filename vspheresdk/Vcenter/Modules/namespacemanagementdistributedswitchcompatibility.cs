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
using vspheresdk.Vcenter.Models.Enums;

namespace vspheresdk.Vcenter.Modules
{
    public class NamespaceManagementDistributedSwitchCompatibilityModule
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public NamespaceManagementDistributedSwitchCompatibilityModule(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
        {
            restClient = Client;
            retry = _retry;
            timeout = _timeout;
            cancellationToken = _cancellationToken;
        }
        public async Task<List<VcenterNamespaceManagementDistributedSwitchCompatibilitySummaryType>> ListAsync(string Cluster, bool? Compatible = null, string? NetworkProvider = null)
        {
            ArgumentNullException.ThrowIfNull(Cluster, "Cluster cannot be null");
            StringBuilder ListServiceURL = new StringBuilder("/api/vcenter/namespace-management/distributed-switch-compatibility");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Cluster != null) { request.AddQueryParameter("cluster", Cluster.ToString()); }
            if (Compatible != null) { request.AddQueryParameter("compatible", Compatible.ToString()); }
            if (NetworkProvider != null) { request.AddQueryParameter("network_provider", NetworkProvider.ToString()); }
            request.Resource = ListServiceURL.ToString();
            RestResponse<List<VcenterNamespaceManagementDistributedSwitchCompatibilitySummaryType>> response = await restClient.ExecuteTaskAsyncWithPolicy<List<VcenterNamespaceManagementDistributedSwitchCompatibilitySummaryType>>(request, cancellationToken, timeout, retry);
            if (200 <= (int)response.StatusCode && (int)response.StatusCode <= 300) { return response.Data; }
            else if ((int)response.StatusCode == 500) { throw new vSphereException("if the server reports an unknown internal error.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 404) { throw new vSphereException("if no cluster with the given cluster ID can be found", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 401) { throw new vSphereException("if the user can not be authenticated.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 403) { throw new vSphereException("if the user does not have System.Read privilege.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
            return response.Data;
        }
    }
}

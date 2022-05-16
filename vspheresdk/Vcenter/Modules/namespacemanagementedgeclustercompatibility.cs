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
    public class NamespaceManagementEdgeClusterCompatibilityModule
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public NamespaceManagementEdgeClusterCompatibilityModule(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
        {
            restClient = Client;
            retry = _retry;
            timeout = _timeout;
            cancellationToken = _cancellationToken;
        }
        public async Task<List<VcenterNamespaceManagementEdgeClusterCompatibilitySummaryType>> ListAsync(string Cluster, string DistributedSwitch, bool? Compatible = null)
        {
            ArgumentNullException.ThrowIfNull(Cluster, "Cluster cannot be null");
            ArgumentNullException.ThrowIfNull(DistributedSwitch, "DistributedSwitch cannot be null");
            StringBuilder ListServiceURL = new StringBuilder("/api/vcenter/namespace-management/edge-cluster-compatibility");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Cluster != null) { request.AddQueryParameter("cluster", Cluster.ToString()); }
            if (DistributedSwitch != null) { request.AddQueryParameter("distributed_switch", DistributedSwitch.ToString()); }
            if (Compatible != null) { request.AddQueryParameter("compatible", Compatible.ToString()); }
            request.Resource = ListServiceURL.ToString();
            RestResponse<List<VcenterNamespaceManagementEdgeClusterCompatibilitySummaryType>> response = await restClient.ExecuteTaskAsyncWithPolicy<List<VcenterNamespaceManagementEdgeClusterCompatibilitySummaryType>>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListServiceURL.ToString() + " did not complete successfull";
                throw new vSphereException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}

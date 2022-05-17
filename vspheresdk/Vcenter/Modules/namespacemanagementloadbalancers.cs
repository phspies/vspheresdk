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
    public class NamespaceManagementLoadBalancersModule
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public NamespaceManagementLoadBalancersModule(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
        {
            restClient = Client;
            retry = _retry;
            timeout = _timeout;
            cancellationToken = _cancellationToken;
        }
        public async Task<List<VcenterNamespaceManagementLoadBalancersSummaryType>> ListAsync(string Cluster)
        {
            ArgumentNullException.ThrowIfNull(Cluster, "Cluster cannot be null");
            StringBuilder ListServiceURL = new StringBuilder("/api/vcenter/namespace-management/clusters/{cluster}/load-balancers");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListServiceURL.Replace("{cluster}", System.Uri.EscapeDataString(Helpers.ConvertToString(Cluster, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ListServiceURL.ToString();
            RestResponse<List<VcenterNamespaceManagementLoadBalancersSummaryType>> response = await restClient.ExecuteTaskAsyncWithPolicy<List<VcenterNamespaceManagementLoadBalancersSummaryType>>(request, cancellationToken, timeout, retry);
            if (200 <= (int)response.StatusCode && (int)response.StatusCode <= 300) { return response.Data; }
            else if ((int)response.StatusCode == 500) { throw new vSphereException("if the system reports an error while responding to the request.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 404) { throw new vSphereException("if cluster cannot be located.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 401) { throw new vSphereException("if the user cannot be authenticated.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 403) { throw new vSphereException("if the user does not have System.Read privilege.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 400) { throw new vSphereException("if the specified cluster does not have vSphere Namespaces enabled.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
            return response.Data;
        }
        public async Task SetAsync(string Cluster, string Id, VcenterNamespaceManagementLoadBalancersSetType RequestBody = null)
        {
            ArgumentNullException.ThrowIfNull(Cluster, "Cluster cannot be null");
            ArgumentNullException.ThrowIfNull(Id, "Id cannot be null");
            StringBuilder SetServiceURL = new StringBuilder("/api/vcenter/namespace-management/clusters/{cluster}/load-balancers/{id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            SetServiceURL.Replace("{cluster}", System.Uri.EscapeDataString(Helpers.ConvertToString(Cluster, System.Globalization.CultureInfo.InvariantCulture)));
            SetServiceURL.Replace("{id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Id, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(RequestBody);
            request.Resource = SetServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (200 <= (int)response.StatusCode && (int)response.StatusCode <= 300) { }
            else if ((int)response.StatusCode == 500) { throw new vSphereException("if the system reports an error while responding to the request.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 400) { throw new vSphereException("if the specified cluster does not have vSphere Namespaces enabled.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 404) { throw new vSphereException("if cluster or id cannot be located.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 401) { throw new vSphereException("if the user cannot be authenticated.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 403) { throw new vSphereException("if the user does not have Namespaces.Manage privilege.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
            
        }
        public async Task<VcenterNamespaceManagementLoadBalancersInfoType> GetAsync(string Cluster, string Id)
        {
            ArgumentNullException.ThrowIfNull(Cluster, "Cluster cannot be null");
            ArgumentNullException.ThrowIfNull(Id, "Id cannot be null");
            StringBuilder GetServiceURL = new StringBuilder("/api/vcenter/namespace-management/clusters/{cluster}/load-balancers/{id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetServiceURL.Replace("{cluster}", System.Uri.EscapeDataString(Helpers.ConvertToString(Cluster, System.Globalization.CultureInfo.InvariantCulture)));
            GetServiceURL.Replace("{id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Id, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetServiceURL.ToString();
            RestResponse<VcenterNamespaceManagementLoadBalancersInfoType> response = await restClient.ExecuteTaskAsyncWithPolicy<VcenterNamespaceManagementLoadBalancersInfoType>(request, cancellationToken, timeout, retry);
            if (200 <= (int)response.StatusCode && (int)response.StatusCode <= 300) { return response.Data; }
            else if ((int)response.StatusCode == 500) { throw new vSphereException("if the system reports an error while responding to the request.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 404) { throw new vSphereException("if cluster or id cannot be located.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 401) { throw new vSphereException("if the user cannot be authenticated.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 403) { throw new vSphereException("if the user does not have System.Read privilege.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 400) { throw new vSphereException("if the specified cluster does not have vSphere Namespaces enabled.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
            return response.Data;
        }
        public async Task UpdateAsync(string Cluster, string Id, VcenterNamespaceManagementLoadBalancersUpdateType RequestBody = null)
        {
            ArgumentNullException.ThrowIfNull(Cluster, "Cluster cannot be null");
            ArgumentNullException.ThrowIfNull(Id, "Id cannot be null");
            StringBuilder UpdateServiceURL = new StringBuilder("/api/vcenter/namespace-management/clusters/{cluster}/load-balancers/{id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            UpdateServiceURL.Replace("{cluster}", System.Uri.EscapeDataString(Helpers.ConvertToString(Cluster, System.Globalization.CultureInfo.InvariantCulture)));
            UpdateServiceURL.Replace("{id}", System.Uri.EscapeDataString(Helpers.ConvertToString(Id, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(RequestBody);
            request.Resource = UpdateServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (200 <= (int)response.StatusCode && (int)response.StatusCode <= 300) { }
            else if ((int)response.StatusCode == 500) { throw new vSphereException("if the system reports an error while responding to the request.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 400) { throw new vSphereException("if the specified cluster does not have vSphere Namespaces enabled.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 404) { throw new vSphereException("if cluster or id cannot be located.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 401) { throw new vSphereException("if the user cannot be authenticated.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 403) { throw new vSphereException("if the user does not have Namespaces.Manage privilege.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
            
        }
    }
}

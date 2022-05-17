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
    public class TrustedInfrastructureTrustAuthorityClustersModule
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public TrustedInfrastructureTrustAuthorityClustersModule(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
        {
            restClient = Client;
            retry = _retry;
            timeout = _timeout;
            cancellationToken = _cancellationToken;
        }
        public async Task<List<VcenterTrustedInfrastructureTrustAuthorityClustersSummaryType>> ListAsync(string Cluster = null, string State = null)
        {
            StringBuilder ListServiceURL = new StringBuilder("/api/vcenter/trusted-infrastructure/trust-authority-clusters");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Cluster != null) { request.AddQueryParameter("cluster", Cluster.ToString()); }
            if (State != null) { request.AddQueryParameter("state", State.ToString()); }
            request.Resource = ListServiceURL.ToString();
            RestResponse<List<VcenterTrustedInfrastructureTrustAuthorityClustersSummaryType>> response = await restClient.ExecuteTaskAsyncWithPolicy<List<VcenterTrustedInfrastructureTrustAuthorityClustersSummaryType>>(request, cancellationToken, timeout, retry);
            if (200 <= (int)response.StatusCode && (int)response.StatusCode <= 300) { return response.Data; }
            else if ((int)response.StatusCode == 500) { throw new vSphereException("if there is a generic error.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 401) { throw new vSphereException("if the user can not be authenticated.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
            return response.Data;
        }
        public async Task<VcenterTrustedInfrastructureTrustAuthorityClustersInfoType> GetAsync(string Cluster)
        {
            ArgumentNullException.ThrowIfNull(Cluster, "Cluster cannot be null");
            StringBuilder GetServiceURL = new StringBuilder("/api/vcenter/trusted-infrastructure/trust-authority-clusters/{cluster}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetServiceURL.Replace("{cluster}", System.Uri.EscapeDataString(Helpers.ConvertToString(Cluster, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetServiceURL.ToString();
            RestResponse<VcenterTrustedInfrastructureTrustAuthorityClustersInfoType> response = await restClient.ExecuteTaskAsyncWithPolicy<VcenterTrustedInfrastructureTrustAuthorityClustersInfoType>(request, cancellationToken, timeout, retry);
            if (200 <= (int)response.StatusCode && (int)response.StatusCode <= 300) { return response.Data; }
            else if ((int)response.StatusCode == 500) { throw new vSphereException("if there is a generic error.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 404) { throw new vSphereException("if cluster doesnt match to any ClusterComputeResource.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 401) { throw new vSphereException("if the user can not be authenticated.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
            return response.Data;
        }
        public async Task<string> UpdateTaskAsync(string Cluster, VcenterTrustedInfrastructureTrustAuthorityClustersUpdateSpecType RequestBody = null)
        {
            ArgumentNullException.ThrowIfNull(Cluster, "Cluster cannot be null");
            StringBuilder UpdateTaskServiceURL = new StringBuilder("/api/vcenter/trusted-infrastructure/trust-authority-clusters/{cluster}?vmw-task=true");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            UpdateTaskServiceURL.Replace("{cluster}", System.Uri.EscapeDataString(Helpers.ConvertToString(Cluster, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(RequestBody);
            request.Resource = UpdateTaskServiceURL.ToString();
            RestResponse<string> response = await restClient.ExecuteTaskAsyncWithPolicy<string>(request, cancellationToken, timeout, retry);
            if (200 <= (int)response.StatusCode && (int)response.StatusCode <= 300) { return response.Data; }
            else if ((int)response.StatusCode == 500) { throw new vSphereException("if there is a generic error.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 404) { throw new vSphereException("if spec doesnt match to any cluster compute resource.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 401) { throw new vSphereException("if the user can not be authenticated.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
            return response.Data;
        }
    }
}

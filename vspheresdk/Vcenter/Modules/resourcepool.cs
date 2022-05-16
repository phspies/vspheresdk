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
    public class ResourcePoolModule
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public ResourcePoolModule(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
        {
            restClient = Client;
            retry = _retry;
            timeout = _timeout;
            cancellationToken = _cancellationToken;
        }
        public async Task<string> CreateAsync(VcenterResourcePoolCreateType RequestBody = null)
        {
            StringBuilder CreateServiceURL = new StringBuilder("/api/vcenter/resource-pool");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(RequestBody);
            request.Resource = CreateServiceURL.ToString();
            RestResponse<string> response = await restClient.ExecuteTaskAsyncWithPolicy<string>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreateServiceURL.ToString() + " did not complete successfull";
                throw new vSphereException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        public async Task<List<VcenterResourcePoolSummaryType>> ListAsync(string ResourcePools = null, string Names = null, string ParentResourcePools = null, string Datacenters = null, string Hosts = null, string Clusters = null)
        {
            StringBuilder ListServiceURL = new StringBuilder("/api/vcenter/resource-pool");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (ResourcePools != null) { request.AddQueryParameter("resource_pools", ResourcePools.ToString()); }
            if (Names != null) { request.AddQueryParameter("names", Names.ToString()); }
            if (ParentResourcePools != null) { request.AddQueryParameter("parent_resource_pools", ParentResourcePools.ToString()); }
            if (Datacenters != null) { request.AddQueryParameter("datacenters", Datacenters.ToString()); }
            if (Hosts != null) { request.AddQueryParameter("hosts", Hosts.ToString()); }
            if (Clusters != null) { request.AddQueryParameter("clusters", Clusters.ToString()); }
            request.Resource = ListServiceURL.ToString();
            RestResponse<List<VcenterResourcePoolSummaryType>> response = await restClient.ExecuteTaskAsyncWithPolicy<List<VcenterResourcePoolSummaryType>>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListServiceURL.ToString() + " did not complete successfull";
                throw new vSphereException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        public async Task<VcenterResourcePoolInfoType> GetAsync(string ResourcePool)
        {
            ArgumentNullException.ThrowIfNull(ResourcePool, "ResourcePool cannot be null");
            StringBuilder GetServiceURL = new StringBuilder("/api/vcenter/resource-pool/{resource_pool}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetServiceURL.Replace("{resource_pool}", System.Uri.EscapeDataString(Helpers.ConvertToString(ResourcePool, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetServiceURL.ToString();
            RestResponse<VcenterResourcePoolInfoType> response = await restClient.ExecuteTaskAsyncWithPolicy<VcenterResourcePoolInfoType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetServiceURL.ToString() + " did not complete successfull";
                throw new vSphereException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        public async Task UpdateAsync(string ResourcePool, VcenterResourcePoolUpdateType RequestBody = null)
        {
            ArgumentNullException.ThrowIfNull(ResourcePool, "ResourcePool cannot be null");
            StringBuilder UpdateServiceURL = new StringBuilder("/api/vcenter/resource-pool/{resource_pool}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            UpdateServiceURL.Replace("{resource_pool}", System.Uri.EscapeDataString(Helpers.ConvertToString(ResourcePool, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(RequestBody);
            request.Resource = UpdateServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + UpdateServiceURL.ToString() + " did not complete successfull";
                throw new vSphereException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        public async Task DeleteAsync(string ResourcePool)
        {
            ArgumentNullException.ThrowIfNull(ResourcePool, "ResourcePool cannot be null");
            StringBuilder DeleteServiceURL = new StringBuilder("/api/vcenter/resource-pool/{resource_pool}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteServiceURL.Replace("{resource_pool}", System.Uri.EscapeDataString(Helpers.ConvertToString(ResourcePool, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteServiceURL.ToString() + " did not complete successfull";
                throw new vSphereException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
    }
}

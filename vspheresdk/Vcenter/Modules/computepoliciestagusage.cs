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
    public class ComputePoliciesTagUsageModule
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public ComputePoliciesTagUsageModule(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
        {
            restClient = Client;
            retry = _retry;
            timeout = _timeout;
            cancellationToken = _cancellationToken;
        }
        public async Task<List<VcenterComputePoliciesTagUsageSummaryType>> ListAsync(string Policies = null, string Tags = null, string TagTypes = null)
        {
            StringBuilder ListServiceURL = new StringBuilder("/api/vcenter/compute/policies/tag-usage");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Policies != null) { request.AddQueryParameter("policies", Policies.ToString()); }
            if (Tags != null) { request.AddQueryParameter("tags", Tags.ToString()); }
            if (TagTypes != null) { request.AddQueryParameter("tag_types", TagTypes.ToString()); }
            request.Resource = ListServiceURL.ToString();
            RestResponse<List<VcenterComputePoliciesTagUsageSummaryType>> response = await restClient.ExecuteTaskAsyncWithPolicy<List<VcenterComputePoliciesTagUsageSummaryType>>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListServiceURL.ToString() + " did not complete successfull";
                throw new vSphereException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}

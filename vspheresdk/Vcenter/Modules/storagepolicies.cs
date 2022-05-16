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
    public class StoragePoliciesModule
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public StoragePoliciesModule(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
        {
            restClient = Client;
            retry = _retry;
            timeout = _timeout;
            cancellationToken = _cancellationToken;
        }
        public async Task<List<VcenterStoragePoliciesSummaryType>> ListAsync(string Policies = null)
        {
            StringBuilder ListServiceURL = new StringBuilder("/api/vcenter/storage/policies");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Policies != null) { request.AddQueryParameter("policies", Policies.ToString()); }
            request.Resource = ListServiceURL.ToString();
            RestResponse<List<VcenterStoragePoliciesSummaryType>> response = await restClient.ExecuteTaskAsyncWithPolicy<List<VcenterStoragePoliciesSummaryType>>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListServiceURL.ToString() + " did not complete successfull";
                throw new vSphereException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        public async Task<VcenterStoragePoliciesCompatibilityInfoType> CheckCompatibilityAsync(string Policy, VcenterStoragePoliciesCheckCompatibilityType RequestBody)
        {
            ArgumentNullException.ThrowIfNull(Policy, "Policy cannot be null");
            ArgumentNullException.ThrowIfNull(RequestBody, "RequestBody cannot be null");
            StringBuilder CheckCompatibilityServiceURL = new StringBuilder("/api/vcenter/storage/policies/{policy}?action=check-compatibility");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            CheckCompatibilityServiceURL.Replace("{policy}", System.Uri.EscapeDataString(Helpers.ConvertToString(Policy, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(RequestBody);
            request.Resource = CheckCompatibilityServiceURL.ToString();
            RestResponse<VcenterStoragePoliciesCompatibilityInfoType> response = await restClient.ExecuteTaskAsyncWithPolicy<VcenterStoragePoliciesCompatibilityInfoType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CheckCompatibilityServiceURL.ToString() + " did not complete successfull";
                throw new vSphereException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
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
    public class StoragePoliciesComplianceModule
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public StoragePoliciesComplianceModule(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
        {
            restClient = Client;
            retry = _retry;
            timeout = _timeout;
            cancellationToken = _cancellationToken;
        }
        public async Task<List<VcenterStoragePoliciesComplianceSummaryType>> ListAsync(string Status = null)
        {
            StringBuilder ListServiceURL = new StringBuilder("/api/vcenter/storage/policies/entities/compliance");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Status != null) { request.AddQueryParameter("status", Status.ToString()); }
            request.Resource = ListServiceURL.ToString();
            RestResponse<List<VcenterStoragePoliciesComplianceSummaryType>> response = await restClient.ExecuteTaskAsyncWithPolicy<List<VcenterStoragePoliciesComplianceSummaryType>>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListServiceURL.ToString() + " did not complete successfull";
                throw new vSphereException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}

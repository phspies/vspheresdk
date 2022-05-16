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
    public class TrustedInfrastructureTrustAuthorityHostsKmsModule
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public TrustedInfrastructureTrustAuthorityHostsKmsModule(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
        {
            restClient = Client;
            retry = _retry;
            timeout = _timeout;
            cancellationToken = _cancellationToken;
        }
        public async Task<List<VcenterTrustedInfrastructureTrustAuthorityHostsKmsSummaryType>> ListAsync(VcenterTrustedInfrastructureTrustAuthorityHostsKmsFilterSpecType RequestBody = null, string? Projection = null)
        {
            StringBuilder ListServiceURL = new StringBuilder("/api/vcenter/trusted-infrastructure/trust-authority-hosts/kms?action=query");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(RequestBody);
            if (Projection != null) { request.AddQueryParameter("projection", Projection.ToString()); }
            request.Resource = ListServiceURL.ToString();
            RestResponse<List<VcenterTrustedInfrastructureTrustAuthorityHostsKmsSummaryType>> response = await restClient.ExecuteTaskAsyncWithPolicy<List<VcenterTrustedInfrastructureTrustAuthorityHostsKmsSummaryType>>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + ListServiceURL.ToString() + " did not complete successfull";
                throw new vSphereException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        public async Task<VcenterTrustedInfrastructureTrustAuthorityHostsKmsInfoType> GetAsync(string Host)
        {
            ArgumentNullException.ThrowIfNull(Host, "Host cannot be null");
            StringBuilder GetServiceURL = new StringBuilder("/api/vcenter/trusted-infrastructure/trust-authority-hosts/{host}/kms/");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetServiceURL.Replace("{host}", System.Uri.EscapeDataString(Helpers.ConvertToString(Host, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetServiceURL.ToString();
            RestResponse<VcenterTrustedInfrastructureTrustAuthorityHostsKmsInfoType> response = await restClient.ExecuteTaskAsyncWithPolicy<VcenterTrustedInfrastructureTrustAuthorityHostsKmsInfoType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetServiceURL.ToString() + " did not complete successfull";
                throw new vSphereException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}
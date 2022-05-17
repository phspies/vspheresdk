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
using vspheresdk.Esx.Models;
using vspheresdk.Esx.Models.Enums;

namespace vspheresdk.Esx.Modules
{
    public class HostsSoftwareModule
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public HostsSoftwareModule(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
        {
            restClient = Client;
            retry = _retry;
            timeout = _timeout;
            cancellationToken = _cancellationToken;
        }
        public async Task<EsxHostsSoftwareInfoType> GetAsync(string AuthType, string? HostCredential = null, string? Host = null)
        {
            ArgumentNullException.ThrowIfNull(AuthType, "AuthType cannot be null");
            StringBuilder GetServiceURL = new StringBuilder("/api/esx/software");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (AuthType != null) { request.AddQueryParameter("auth_type", AuthType.ToString()); }
            if (HostCredential != null) { request.AddQueryParameter("host_credential", HostCredential.ToString()); }
            if (Host != null) { request.AddQueryParameter("host", Host.ToString()); }
            request.Resource = GetServiceURL.ToString();
            RestResponse<EsxHostsSoftwareInfoType> response = await restClient.ExecuteTaskAsyncWithPolicy<EsxHostsSoftwareInfoType>(request, cancellationToken, timeout, retry);
            if (200 <= (int)response.StatusCode && (int)response.StatusCode <= 300) { return response.Data; }
            else if ((int)response.StatusCode == 400) { throw new vSphereException("If the SSL certificate of the target node cannot be validated by comparing with the thumbprint provided in link ConnectionSpec.HostCredentialssslThumbPrint.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 500) { throw new vSphereException("If there is some unknown internal error. The accompanying error message will give more details about the failure.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 404) { throw new vSphereException("If there is no basename ConnectionSpec.HostCredentialshostName term field associated with host id in the system.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 503) { throw new vSphereException("If the service is not available.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 401) { throw new vSphereException("if the caller is not authenticated.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
            return response.Data;
        }
    }
}

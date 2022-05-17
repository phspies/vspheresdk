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
    public class CertificateManagementVcenterSigningCertificateModule
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public CertificateManagementVcenterSigningCertificateModule(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
        {
            restClient = Client;
            retry = _retry;
            timeout = _timeout;
            cancellationToken = _cancellationToken;
        }
        public async Task SetAsync(VcenterCertificateManagementVcenterSigningCertificateSetType RequestBody = null)
        {
            StringBuilder SetServiceURL = new StringBuilder("/api/vcenter/certificate-management/vcenter/signing-certificate");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            request.AddJsonBody(RequestBody);
            request.Resource = SetServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if ((int)response.StatusCode == 204) {}
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
        }
        public async Task<VcenterCertificateManagementVcenterSigningCertificateInfoType> GetAsync()
        {
            StringBuilder GetServiceURL = new StringBuilder("/api/vcenter/certificate-management/vcenter/signing-certificate");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = GetServiceURL.ToString();
            RestResponse<VcenterCertificateManagementVcenterSigningCertificateInfoType> response = await restClient.ExecuteTaskAsyncWithPolicy<VcenterCertificateManagementVcenterSigningCertificateInfoType>(request, cancellationToken, timeout, retry);
            if ((int)response.StatusCode == 200) { ArgumentNullException.ThrowIfNull(response.Data) ; return response.Data; }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
        }
        public async Task<VcenterCertificateManagementX509CertChainType> RefreshAsync(VcenterCertificateManagementVcenterSigningCertificateRefreshType RequestBody = null)
        {
            StringBuilder RefreshServiceURL = new StringBuilder("/api/vcenter/certificate-management/vcenter/signing-certificate?action=refresh");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(RequestBody);
            request.Resource = RefreshServiceURL.ToString();
            RestResponse<VcenterCertificateManagementX509CertChainType> response = await restClient.ExecuteTaskAsyncWithPolicy<VcenterCertificateManagementX509CertChainType>(request, cancellationToken, timeout, retry);
            if ((int)response.StatusCode == 200) { ArgumentNullException.ThrowIfNull(response.Data) ; return response.Data; }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
        }
    }
}

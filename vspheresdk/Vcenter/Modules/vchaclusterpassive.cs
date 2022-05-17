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
    public class VchaClusterPassiveModule
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public VchaClusterPassiveModule(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
        {
            restClient = Client;
            retry = _retry;
            timeout = _timeout;
            cancellationToken = _cancellationToken;
        }
        public async Task<VcenterVchaClusterPassiveCheckResultType> CheckAsync(VcenterVchaClusterPassiveCheckType RequestBody = null)
        {
            StringBuilder CheckServiceURL = new StringBuilder("/api/vcenter/vcha/cluster/passive?action=check");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(RequestBody);
            request.Resource = CheckServiceURL.ToString();
            RestResponse<VcenterVchaClusterPassiveCheckResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<VcenterVchaClusterPassiveCheckResultType>(request, cancellationToken, timeout, retry);
            if ((int)response.StatusCode == 200) { ArgumentNullException.ThrowIfNull(response.Data) ; return response.Data; }
            else if ((int)response.StatusCode == 400) { throw new vSphereException("If the clone operation is not allowed in the current state of the system.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 404) { throw new vSphereException("If the active virtual machine is not managed by the specified vCenter server for the active node.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 403) { throw new vSphereException("If the user has insufficient privilege to perform the operation. Operation execution requires the Global.VCServer privilege.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 500) { throw new vSphereException("If any other error occurs.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
        }
        public async Task<string> RedeployTaskAsync(VcenterVchaClusterPassiveRedeploySpecType RequestBody = null)
        {
            StringBuilder RedeployTaskServiceURL = new StringBuilder("/api/vcenter/vcha/cluster/passive?action=redeploy&vmw-task=true");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(RequestBody);
            request.Resource = RedeployTaskServiceURL.ToString();
            RestResponse<string> response = await restClient.ExecuteTaskAsyncWithPolicy<string>(request, cancellationToken, timeout, retry);
            if ((int)response.StatusCode == 202) { ArgumentNullException.ThrowIfNull(response.Data) ; return response.Data; }
            else if ((int)response.StatusCode == 400) { throw new vSphereException("If the SSL certificate of the management vCenter server cannot be validated. The value of the data field of Error will be a structure that contains all the fields defined in CertificateInfo.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 403) { throw new vSphereException("If the user has insufficient privilege to perform the operation. Operation execution requires the Global.VCServer privilege.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 500) { throw new vSphereException("If any other error occurs.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
        }
    }
}

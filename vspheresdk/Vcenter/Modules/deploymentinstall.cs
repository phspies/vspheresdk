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
    public class DeploymentInstallModule
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public DeploymentInstallModule(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
        {
            restClient = Client;
            retry = _retry;
            timeout = _timeout;
            cancellationToken = _cancellationToken;
        }
        public async Task<VcenterDeploymentInstallCheckType> GetAsync()
        {
            StringBuilder GetServiceURL = new StringBuilder("/api/vcenter/deployment/install");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = GetServiceURL.ToString();
            RestResponse<VcenterDeploymentInstallCheckType> response = await restClient.ExecuteTaskAsyncWithPolicy<VcenterDeploymentInstallCheckType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetServiceURL.ToString() + " did not complete successfull";
                throw new vSphereException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        public async Task CancelAsync()
        {
            StringBuilder CancelServiceURL = new StringBuilder("/api/vcenter/deployment/install?action=cancel");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.Resource = CancelServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CancelServiceURL.ToString() + " did not complete successfull";
                throw new vSphereException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        public async Task<VcenterDeploymentCheckInfoType> CheckAsync(VcenterDeploymentInstallCheckType RequestBody = null)
        {
            StringBuilder CheckServiceURL = new StringBuilder("/api/vcenter/deployment/install?action=check");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(RequestBody);
            request.Resource = CheckServiceURL.ToString();
            RestResponse<VcenterDeploymentCheckInfoType> response = await restClient.ExecuteTaskAsyncWithPolicy<VcenterDeploymentCheckInfoType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CheckServiceURL.ToString() + " did not complete successfull";
                throw new vSphereException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        public async Task StartAsync(VcenterDeploymentInstallCheckType RequestBody = null)
        {
            StringBuilder StartServiceURL = new StringBuilder("/api/vcenter/deployment/install?action=start");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(RequestBody);
            request.Resource = StartServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + StartServiceURL.ToString() + " did not complete successfull";
                throw new vSphereException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
    }
}
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
    public class DeploymentQuestionModule
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public DeploymentQuestionModule(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
        {
            restClient = Client;
            retry = _retry;
            timeout = _timeout;
            cancellationToken = _cancellationToken;
        }
        public async Task<VcenterDeploymentQuestionInfoType> GetAsync()
        {
            StringBuilder GetServiceURL = new StringBuilder("/api/vcenter/deployment/question");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = GetServiceURL.ToString();
            RestResponse<VcenterDeploymentQuestionInfoType> response = await restClient.ExecuteTaskAsyncWithPolicy<VcenterDeploymentQuestionInfoType>(request, cancellationToken, timeout, retry);
            if (200 <= (int)response.StatusCode && (int)response.StatusCode <= 300) { return response.Data; }
            else if ((int)response.StatusCode == 401) { throw new vSphereException("if the caller is not authenticated.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 400) { throw new vSphereException("if the appliance is not in QUESTION_RAISED state.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 500) { throw new vSphereException("if questions could not be retrieved although the appliance is in QUESTION_RAISED state.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
            return response.Data;
        }
        public async Task AnswerAsync(VcenterDeploymentQuestionAnswerType RequestBody = null)
        {
            StringBuilder AnswerServiceURL = new StringBuilder("/api/vcenter/deployment/question?action=answer");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(RequestBody);
            request.Resource = AnswerServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (200 <= (int)response.StatusCode && (int)response.StatusCode <= 300) { }
            else if ((int)response.StatusCode == 401) { throw new vSphereException("if the caller is not authenticated.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 400) { throw new vSphereException("if the appliance is NOT in QUESTION_RAISED state.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 500) { throw new vSphereException("if answer file could not be created.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
            
        }
    }
}

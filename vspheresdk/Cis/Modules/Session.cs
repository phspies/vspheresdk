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
using vspheresdk.Cis.Models;
using vspheresdk.Cis.Models.Enums;

namespace vspheresdk.Cis.Modules
{
    public class SessionModule
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public SessionModule(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
        {
            restClient = Client;
            retry = _retry;
            timeout = _timeout;
            cancellationToken = _cancellationToken;
        }
        public async Task<CisSessionInfoType> GetAsync()
        {
            StringBuilder GetServiceURL = new StringBuilder("/api/session");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = GetServiceURL.ToString();
            RestResponse<CisSessionInfoType> response = await restClient.ExecuteTaskAsyncWithPolicy<CisSessionInfoType>(request, cancellationToken, timeout, retry);
            if (200 <= (int)response.StatusCode && (int)response.StatusCode <= 300) { return response.Data; }
            else if ((int)response.StatusCode == 401) { throw new vSphereException("if the session id is missing from the request or the corresponding session object cannot be found.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 503) { throw new vSphereException("if session retrieval fails due to server specific issues e.g. connection to back end component is failing. Due to the security nature of this API further details will not be disclosed in the error. Please refer to component health information administrative logs and product specific documentation for possible causes.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
            return response.Data;
        }
        public async Task<string> CreateAsync()
        {
            StringBuilder CreateServiceURL = new StringBuilder("/api/session");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.Resource = CreateServiceURL.ToString();
            RestResponse<string> response = await restClient.ExecuteTaskAsyncWithPolicy<string>(request, cancellationToken, timeout, retry);
            if (200 <= (int)response.StatusCode && (int)response.StatusCode <= 300) { return response.Data; }
            else if ((int)response.StatusCode == 401) { throw new vSphereException("if the session creation fails due to request specific issues. Due to the security nature of the API the details of the error are not disclosed. p Please check the following preconditions if using a SAML token to authenticate ul lithe supplied token is delegateable.li lithe time of client and server system are synchronized.li lithe token supplied is valid.li liif bearer tokens are used check that system configuration allows the API endpoint to accept such tokens.li ul", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 503) { throw new vSphereException("if session creation fails due to server specific issues for example connection to a back end component is failing. Due to the security nature of this API further details will not be disclosed in the term error. Please refer to component health information administrative logs and product specific documentation for possible causes.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
            return response.Data;
        }
        public async Task DeleteAsync()
        {
            StringBuilder DeleteServiceURL = new StringBuilder("/api/session");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            request.Resource = DeleteServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (200 <= (int)response.StatusCode && (int)response.StatusCode <= 300) { }
            else if ((int)response.StatusCode == 401) { throw new vSphereException("if the session id is missing from the request or the corresponding session object cannot be found.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 503) { throw new vSphereException("if session deletion fails due to server specific issues for example connection to a back end component is failing. Due to the security nature of this API further details will not be disclosed in the term error. Please refer to component health information administrative logs and product specific documentation for possible causes.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
            
        }
    }
}

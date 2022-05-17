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
using vspheresdk.Appliance.Models;
using vspheresdk.Appliance.Models.Enums;

namespace vspheresdk.Appliance.Modules
{
    public class AccessSshModule
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public AccessSshModule(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
        {
            restClient = Client;
            retry = _retry;
            timeout = _timeout;
            cancellationToken = _cancellationToken;
        }
        public async Task SetAsync(ApplianceAccessSshSetType RequestBody)
        {
            ArgumentNullException.ThrowIfNull(RequestBody, "RequestBody cannot be null");
            StringBuilder SetServiceURL = new StringBuilder("/api/appliance/access/ssh");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            request.AddJsonBody(RequestBody);
            request.Resource = SetServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (200 <= (int)response.StatusCode && (int)response.StatusCode <= 300) { }
            else if ((int)response.StatusCode == 500) { throw new vSphereException("Generic error", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
            
        }
        public async Task<boolean> GetAsync()
        {
            StringBuilder GetServiceURL = new StringBuilder("/api/appliance/access/ssh");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = GetServiceURL.ToString();
            RestResponse<boolean> response = await restClient.ExecuteTaskAsyncWithPolicy<boolean>(request, cancellationToken, timeout, retry);
            if (200 <= (int)response.StatusCode && (int)response.StatusCode <= 300) { return response.Data; }
            else if ((int)response.StatusCode == 500) { throw new vSphereException("Generic error", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
            return response.Data;
        }
    }
}

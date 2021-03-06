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

namespace vspheresdk.Appliance.Modules
{
    public class NetworkingProxyModule
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public NetworkingProxyModule(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
        {
            restClient = Client;
            retry = _retry;
            timeout = _timeout;
            cancellationToken = _cancellationToken;
        }
        public async Task<object> ListAsync()
        {
            StringBuilder ListServiceURL = new StringBuilder("/api/appliance/networking/proxy");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = ListServiceURL.ToString();
            RestResponse<object> response = await restClient.ExecuteTaskAsyncWithPolicy<object>(request, cancellationToken, timeout, retry);
            if ((int)response.StatusCode == 200) { ArgumentNullException.ThrowIfNull(response.Data) ; return response.Data; }
            else if ((int)response.StatusCode == 500) { throw new vSphereException("Generic error.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
        }
        public async Task SetAsync(string Protocol, ApplianceNetworkingProxyConfigType RequestBody = null)
        {
            ArgumentNullException.ThrowIfNull(Protocol, "Protocol cannot be null");
            StringBuilder SetServiceURL = new StringBuilder("/api/appliance/networking/proxy/{protocol}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            SetServiceURL.Replace("{protocol}", System.Uri.EscapeDataString(Helpers.ConvertToString(Protocol, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(RequestBody);
            request.Resource = SetServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if ((int)response.StatusCode == 204) {}
            else if ((int)response.StatusCode == 500) { throw new vSphereException("Generic error.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
        }
        public async Task<ApplianceNetworkingProxyConfigType> GetAsync(string Protocol)
        {
            ArgumentNullException.ThrowIfNull(Protocol, "Protocol cannot be null");
            StringBuilder GetServiceURL = new StringBuilder("/api/appliance/networking/proxy/{protocol}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetServiceURL.Replace("{protocol}", System.Uri.EscapeDataString(Helpers.ConvertToString(Protocol, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetServiceURL.ToString();
            RestResponse<ApplianceNetworkingProxyConfigType> response = await restClient.ExecuteTaskAsyncWithPolicy<ApplianceNetworkingProxyConfigType>(request, cancellationToken, timeout, retry);
            if ((int)response.StatusCode == 200) { ArgumentNullException.ThrowIfNull(response.Data) ; return response.Data; }
            else if ((int)response.StatusCode == 500) { throw new vSphereException("Generic error.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
        }
        public async Task DeleteAsync(string Protocol)
        {
            ArgumentNullException.ThrowIfNull(Protocol, "Protocol cannot be null");
            StringBuilder DeleteServiceURL = new StringBuilder("/api/appliance/networking/proxy/{protocol}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteServiceURL.Replace("{protocol}", System.Uri.EscapeDataString(Helpers.ConvertToString(Protocol, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if ((int)response.StatusCode == 204) {}
            else if ((int)response.StatusCode == 500) { throw new vSphereException("Generic error.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
        }
        public async Task<ApplianceNetworkingProxyTestResultType> TestAsync(string Protocol, ApplianceNetworkingProxyTestType RequestBody)
        {
            ArgumentNullException.ThrowIfNull(Protocol, "Protocol cannot be null");
            ArgumentNullException.ThrowIfNull(RequestBody, "RequestBody cannot be null");
            StringBuilder TestServiceURL = new StringBuilder("/api/appliance/networking/proxy/{protocol}?action=test");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            TestServiceURL.Replace("{protocol}", System.Uri.EscapeDataString(Helpers.ConvertToString(Protocol, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(RequestBody);
            request.Resource = TestServiceURL.ToString();
            RestResponse<ApplianceNetworkingProxyTestResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<ApplianceNetworkingProxyTestResultType>(request, cancellationToken, timeout, retry);
            if ((int)response.StatusCode == 200) { ArgumentNullException.ThrowIfNull(response.Data) ; return response.Data; }
            else if ((int)response.StatusCode == 500) { throw new vSphereException("Generic error.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
        }
    }
}

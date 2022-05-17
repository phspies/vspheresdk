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
    public class ServicesModule
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public ServicesModule(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
        {
            restClient = Client;
            retry = _retry;
            timeout = _timeout;
            cancellationToken = _cancellationToken;
        }
        public async Task<object> ListAsync()
        {
            StringBuilder ListServiceURL = new StringBuilder("/api/appliance/services");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = ListServiceURL.ToString();
            RestResponse<object> response = await restClient.ExecuteTaskAsyncWithPolicy<object>(request, cancellationToken, timeout, retry);
            if ((int)response.StatusCode == 200) { ArgumentNullException.ThrowIfNull(response.Data) ; return response.Data; }
            else if ((int)response.StatusCode == 500) { throw new vSphereException("if any error occurs during the execution of the operation.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
        }
        public async Task<ApplianceServicesInfoType> GetAsync(string Service)
        {
            ArgumentNullException.ThrowIfNull(Service, "Service cannot be null");
            StringBuilder GetServiceURL = new StringBuilder("/api/appliance/services/{service}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetServiceURL.Replace("{service}", System.Uri.EscapeDataString(Helpers.ConvertToString(Service, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetServiceURL.ToString();
            RestResponse<ApplianceServicesInfoType> response = await restClient.ExecuteTaskAsyncWithPolicy<ApplianceServicesInfoType>(request, cancellationToken, timeout, retry);
            if ((int)response.StatusCode == 200) { ArgumentNullException.ThrowIfNull(response.Data) ; return response.Data; }
            else if ((int)response.StatusCode == 404) { throw new vSphereException("if the service associated with service does not exist.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 500) { throw new vSphereException("if any other error occurs during the execution of the operation.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
        }
        public async Task RestartAsync(string Service)
        {
            ArgumentNullException.ThrowIfNull(Service, "Service cannot be null");
            StringBuilder RestartServiceURL = new StringBuilder("/api/appliance/services/{service}?action=restart");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            RestartServiceURL.Replace("{service}", System.Uri.EscapeDataString(Helpers.ConvertToString(Service, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = RestartServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if ((int)response.StatusCode == 204) {}
            else if ((int)response.StatusCode == 404) { throw new vSphereException("if the service associated with service does not exist.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 500) { throw new vSphereException("if any other error occurs during the execution of the operation.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 400) { throw new vSphereException("if the operation is denied in the current state of the service. If a stop or start operation is in progress issuing a restart operation will lead to this error.if a restart operation is issued on a service which has startup type StartupTypeDISABLED", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
        }
        public async Task StartAsync(string Service)
        {
            ArgumentNullException.ThrowIfNull(Service, "Service cannot be null");
            StringBuilder StartServiceURL = new StringBuilder("/api/appliance/services/{service}?action=start");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            StartServiceURL.Replace("{service}", System.Uri.EscapeDataString(Helpers.ConvertToString(Service, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = StartServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if ((int)response.StatusCode == 204) {}
            else if ((int)response.StatusCode == 404) { throw new vSphereException("if the service associated with service does not exist.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 400) { throw new vSphereException("if the operation is denied in the current state of the service. If a stop or restart operation is in progress the start operation will not be allowed.if start operation is issued on a service which has startup type StartupTypeDISABLED.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 500) { throw new vSphereException("if any other error occurs during the execution of the operation.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
        }
        public async Task StopAsync(string Service)
        {
            ArgumentNullException.ThrowIfNull(Service, "Service cannot be null");
            StringBuilder StopServiceURL = new StringBuilder("/api/appliance/services/{service}?action=stop");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            StopServiceURL.Replace("{service}", System.Uri.EscapeDataString(Helpers.ConvertToString(Service, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = StopServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if ((int)response.StatusCode == 204) {}
            else if ((int)response.StatusCode == 404) { throw new vSphereException("if the service associated with service does not exist.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 500) { throw new vSphereException("if any other error occurs during the execution of the operation.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 400) { throw new vSphereException("if the operation is denied in the current state of the service. If a stop operation is in progress issuing another stop operation will lead to this error.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
        }
    }
}

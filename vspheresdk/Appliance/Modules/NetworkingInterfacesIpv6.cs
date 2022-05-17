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
    public class NetworkingInterfacesIpv6Module
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public NetworkingInterfacesIpv6Module(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
        {
            restClient = Client;
            retry = _retry;
            timeout = _timeout;
            cancellationToken = _cancellationToken;
        }
        public async Task SetAsync(string InterfaceName, ApplianceNetworkingInterfacesIpv6ConfigType RequestBody = null)
        {
            ArgumentNullException.ThrowIfNull(InterfaceName, "InterfaceName cannot be null");
            StringBuilder SetServiceURL = new StringBuilder("/api/appliance/networking/interfaces/{interface_name}/ipv6");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            SetServiceURL.Replace("{interface_name}", System.Uri.EscapeDataString(Helpers.ConvertToString(InterfaceName, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(RequestBody);
            request.Resource = SetServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (200 <= (int)response.StatusCode && (int)response.StatusCode <= 300) { }
            else if ((int)response.StatusCode == 500) { throw new vSphereException("Generic error.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 404) { throw new vSphereException("The specified NIC is not found.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
            
        }
        public async Task<ApplianceNetworkingInterfacesIpv6InfoType> GetAsync(string InterfaceName)
        {
            ArgumentNullException.ThrowIfNull(InterfaceName, "InterfaceName cannot be null");
            StringBuilder GetServiceURL = new StringBuilder("/api/appliance/networking/interfaces/{interface_name}/ipv6");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetServiceURL.Replace("{interface_name}", System.Uri.EscapeDataString(Helpers.ConvertToString(InterfaceName, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetServiceURL.ToString();
            RestResponse<ApplianceNetworkingInterfacesIpv6InfoType> response = await restClient.ExecuteTaskAsyncWithPolicy<ApplianceNetworkingInterfacesIpv6InfoType>(request, cancellationToken, timeout, retry);
            if (200 <= (int)response.StatusCode && (int)response.StatusCode <= 300) { return response.Data; }
            else if ((int)response.StatusCode == 404) { throw new vSphereException("if the specified NIC is not found.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 500) { throw new vSphereException("Generic error.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
            return response.Data;
        }
    }
}

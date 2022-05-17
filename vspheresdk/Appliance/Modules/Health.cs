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
    public class HealthModule
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public HealthModule(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
        {
            restClient = Client;
            retry = _retry;
            timeout = _timeout;
            cancellationToken = _cancellationToken;
        }
        public async Task<List<ApplianceNotificationType>> MessagesAsync(string Item)
        {
            ArgumentNullException.ThrowIfNull(Item, "Item cannot be null");
            StringBuilder MessagesServiceURL = new StringBuilder("/api/appliance/health/{item}/messages");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            MessagesServiceURL.Replace("{item}", System.Uri.EscapeDataString(Helpers.ConvertToString(Item, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = MessagesServiceURL.ToString();
            RestResponse<List<ApplianceNotificationType>> response = await restClient.ExecuteTaskAsyncWithPolicy<List<ApplianceNotificationType>>(request, cancellationToken, timeout, retry);
            if (200 <= (int)response.StatusCode && (int)response.StatusCode <= 300) { return response.Data; }
            else if ((int)response.StatusCode == 404) { throw new vSphereException("Unknown health item", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 500) { throw new vSphereException("Generic error", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
            return response.Data;
        }
    }
}

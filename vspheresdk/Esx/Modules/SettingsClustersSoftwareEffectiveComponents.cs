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
using vspheresdk.Esx.Models;

namespace vspheresdk.Esx.Modules
{
    public class SettingsClustersSoftwareEffectiveComponentsModule
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public SettingsClustersSoftwareEffectiveComponentsModule(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
        {
            restClient = Client;
            retry = _retry;
            timeout = _timeout;
            cancellationToken = _cancellationToken;
        }
        public async Task<object> ListAsync(string Cluster)
        {
            ArgumentNullException.ThrowIfNull(Cluster, "Cluster cannot be null");
            StringBuilder ListServiceURL = new StringBuilder("/api/esx/settings/clusters/{cluster}/software/effective-components");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListServiceURL.Replace("{cluster}", System.Uri.EscapeDataString(Helpers.ConvertToString(Cluster, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ListServiceURL.ToString();
            RestResponse<object> response = await restClient.ExecuteTaskAsyncWithPolicy<object>(request, cancellationToken, timeout, retry);
            if ((int)response.StatusCode == 200) { ArgumentNullException.ThrowIfNull(response.Data) ; return response.Data; }
            else if ((int)response.StatusCode == 500) { throw new vSphereException("If there is unknown internal error. The accompanying error message will give more details about the failure.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 404) { throw new vSphereException("If there is no cluster associated with param.name cluster in the system.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 503) { throw new vSphereException("If the service is not available.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 401) { throw new vSphereException("If the caller is not authenticated.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
        }
    }
}

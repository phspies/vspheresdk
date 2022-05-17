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
    public class SettingsDepotContentAddOnsModule
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public SettingsDepotContentAddOnsModule(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
        {
            restClient = Client;
            retry = _retry;
            timeout = _timeout;
            cancellationToken = _cancellationToken;
        }
        public async Task<List<EsxSettingsDepotContentAddOnsSummaryType>> ListAsync(string Vendors = null, string Names = null, string Versions = null, string? MinVersion = null)
        {
            StringBuilder ListServiceURL = new StringBuilder("/api/esx/settings/depot-content/add-ons");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Vendors != null) { request.AddQueryParameter("vendors", Vendors.ToString()); }
            if (Names != null) { request.AddQueryParameter("names", Names.ToString()); }
            if (Versions != null) { request.AddQueryParameter("versions", Versions.ToString()); }
            if (MinVersion != null) { request.AddQueryParameter("min_version", MinVersion.ToString()); }
            request.Resource = ListServiceURL.ToString();
            RestResponse<List<EsxSettingsDepotContentAddOnsSummaryType>> response = await restClient.ExecuteTaskAsyncWithPolicy<List<EsxSettingsDepotContentAddOnsSummaryType>>(request, cancellationToken, timeout, retry);
            if ((int)response.StatusCode == 200) { ArgumentNullException.ThrowIfNull(response.Data) ; return response.Data; }
            else if ((int)response.StatusCode == 500) { throw new vSphereException("If there is unknown internal error. The accompanying error message will give more details about the failure.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 503) { throw new vSphereException("If the service is not available.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 401) { throw new vSphereException("if the caller is not authenticated.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
        }
    }
}

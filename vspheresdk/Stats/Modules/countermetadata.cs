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
using vspheresdk.Stats.Models;

namespace vspheresdk.Stats.Modules
{
    public class CounterMetadataModule
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public CounterMetadataModule(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
        {
            restClient = Client;
            retry = _retry;
            timeout = _timeout;
            cancellationToken = _cancellationToken;
        }
        public async Task<List<VstatsCounterMetadataInfoType>> ListAsync(string Cid, string? Status = null)
        {
            ArgumentNullException.ThrowIfNull(Cid, "Cid cannot be null");
            StringBuilder ListServiceURL = new StringBuilder("/api/stats/counters/{cid}/metadata");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListServiceURL.Replace("{cid}", System.Uri.EscapeDataString(Helpers.ConvertToString(Cid, System.Globalization.CultureInfo.InvariantCulture)));
            if (Status != null) { request.AddQueryParameter("status", Status.ToString()); }
            request.Resource = ListServiceURL.ToString();
            RestResponse<List<VstatsCounterMetadataInfoType>> response = await restClient.ExecuteTaskAsyncWithPolicy<List<VstatsCounterMetadataInfoType>>(request, cancellationToken, timeout, retry);
            if ((int)response.StatusCode == 200) { ArgumentNullException.ThrowIfNull(response.Data) ; return response.Data; }
            else if ((int)response.StatusCode == 500) { throw new vSphereException("if the system reports an error while responding to the request.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 400) { throw new vSphereException("if any of the specified parameters are invalid.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 404) { throw new vSphereException("if Counter could not be located.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 401) { throw new vSphereException("if the user can not be authenticated.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 403) { throw new vSphereException("if the user does not have sufficient privileges.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
        }
        public async Task<List<VstatsCounterMetadataInfoType>> GetDefaultAsync(string Cid)
        {
            ArgumentNullException.ThrowIfNull(Cid, "Cid cannot be null");
            StringBuilder GetDefaultServiceURL = new StringBuilder("/api/stats/counters/{cid}/metadata/default");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetDefaultServiceURL.Replace("{cid}", System.Uri.EscapeDataString(Helpers.ConvertToString(Cid, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetDefaultServiceURL.ToString();
            RestResponse<List<VstatsCounterMetadataInfoType>> response = await restClient.ExecuteTaskAsyncWithPolicy<List<VstatsCounterMetadataInfoType>>(request, cancellationToken, timeout, retry);
            if ((int)response.StatusCode == 200) { ArgumentNullException.ThrowIfNull(response.Data) ; return response.Data; }
            else if ((int)response.StatusCode == 500) { throw new vSphereException("if the system reports an error while responding to the request.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 400) { throw new vSphereException("if cid is invalid.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 404) { throw new vSphereException("if Counter could not be located.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 401) { throw new vSphereException("if the user can not be authenticated.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 403) { throw new vSphereException("if the user does not have sufficient privileges.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
        }
        public async Task<VstatsCounterMetadataInfoType> GetAsync(string Cid, string Mid)
        {
            ArgumentNullException.ThrowIfNull(Cid, "Cid cannot be null");
            ArgumentNullException.ThrowIfNull(Mid, "Mid cannot be null");
            StringBuilder GetServiceURL = new StringBuilder("/api/stats/counters/{cid}/metadata/{mid}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetServiceURL.Replace("{cid}", System.Uri.EscapeDataString(Helpers.ConvertToString(Cid, System.Globalization.CultureInfo.InvariantCulture)));
            GetServiceURL.Replace("{mid}", System.Uri.EscapeDataString(Helpers.ConvertToString(Mid, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetServiceURL.ToString();
            RestResponse<VstatsCounterMetadataInfoType> response = await restClient.ExecuteTaskAsyncWithPolicy<VstatsCounterMetadataInfoType>(request, cancellationToken, timeout, retry);
            if ((int)response.StatusCode == 200) { ArgumentNullException.ThrowIfNull(response.Data) ; return response.Data; }
            else if ((int)response.StatusCode == 500) { throw new vSphereException("if the system reports an error while responding to the request.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 400) { throw new vSphereException("if any of the specified parameters are invalid.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 404) { throw new vSphereException("if Counter or CounterMetadata could not be located.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 401) { throw new vSphereException("if the user can not be authenticated.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 403) { throw new vSphereException("if the user does not have sufficient privileges.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
        }
    }
}

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
    public class CountersModule
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public CountersModule(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
        {
            restClient = Client;
            retry = _retry;
            timeout = _timeout;
            cancellationToken = _cancellationToken;
        }
        public async Task<List<VstatsCountersInfoType>> ListAsync(string? Cid = null, string Types = null, string? Metric = null)
        {
            StringBuilder ListServiceURL = new StringBuilder("/api/stats/counters");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Cid != null) { request.AddQueryParameter("cid", Cid.ToString()); }
            if (Types != null) { request.AddQueryParameter("types", Types.ToString()); }
            if (Metric != null) { request.AddQueryParameter("metric", Metric.ToString()); }
            request.Resource = ListServiceURL.ToString();
            RestResponse<List<VstatsCountersInfoType>> response = await restClient.ExecuteTaskAsyncWithPolicy<List<VstatsCountersInfoType>>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListServiceURL.ToString() + " did not complete successfull";
                throw new vSphereException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        public async Task<VstatsCountersInfoType> GetAsync(string Cid)
        {
            ArgumentNullException.ThrowIfNull(Cid, "Cid cannot be null");
            StringBuilder GetServiceURL = new StringBuilder("/api/stats/counters/{cid}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetServiceURL.Replace("{cid}", System.Uri.EscapeDataString(Helpers.ConvertToString(Cid, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetServiceURL.ToString();
            RestResponse<VstatsCountersInfoType> response = await restClient.ExecuteTaskAsyncWithPolicy<VstatsCountersInfoType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetServiceURL.ToString() + " did not complete successfull";
                throw new vSphereException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}

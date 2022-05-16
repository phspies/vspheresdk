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
    public class DataModule
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public DataModule(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
        {
            restClient = Client;
            retry = _retry;
            timeout = _timeout;
            cancellationToken = _cancellationToken;
        }
        public async Task<VstatsDataDataPointsResultType> QueryDataPointsAsync(int? Start = null, int? End = null, string? Cid = null, string? Metric = null, string Types = null, string Resources = null, string? Order = null, string? Page = null)
        {
            StringBuilder QueryDataPointsServiceURL = new StringBuilder("/api/stats/data/dp");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Start != null) { request.AddQueryParameter("start", Start.ToString()); }
            if (End != null) { request.AddQueryParameter("end", End.ToString()); }
            if (Cid != null) { request.AddQueryParameter("cid", Cid.ToString()); }
            if (Metric != null) { request.AddQueryParameter("metric", Metric.ToString()); }
            if (Types != null) { request.AddQueryParameter("types", Types.ToString()); }
            if (Resources != null) { request.AddQueryParameter("resources", Resources.ToString()); }
            if (Order != null) { request.AddQueryParameter("order", Order.ToString()); }
            if (Page != null) { request.AddQueryParameter("page", Page.ToString()); }
            request.Resource = QueryDataPointsServiceURL.ToString();
            RestResponse<VstatsDataDataPointsResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<VstatsDataDataPointsResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + QueryDataPointsServiceURL.ToString() + " did not complete successfull";
                throw new vSphereException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}

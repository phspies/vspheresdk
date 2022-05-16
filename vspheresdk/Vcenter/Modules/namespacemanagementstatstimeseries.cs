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
using vspheresdk.Vcenter.Models;

namespace vspheresdk.Vcenter.Modules
{
    public class NamespaceManagementStatsTimeSeriesModule
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public NamespaceManagementStatsTimeSeriesModule(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
        {
            restClient = Client;
            retry = _retry;
            timeout = _timeout;
            cancellationToken = _cancellationToken;
        }
        public async Task<List<VcenterNamespaceManagementStatsTimeSeriesTimeSeriesType>> GetAsync(string ObjType, int Start, int End, string? Pod = null, string? Namespace = null, string? Cluster = null)
        {
            ArgumentNullException.ThrowIfNull(ObjType, "ObjType cannot be null");
            ArgumentNullException.ThrowIfNull(Start, "Start cannot be null");
            ArgumentNullException.ThrowIfNull(End, "End cannot be null");
            StringBuilder GetServiceURL = new StringBuilder("/api/vcenter/namespace-management/stats/time-series");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (ObjType != null) { request.AddQueryParameter("obj_type", ObjType.ToString()); }
            if (Pod != null) { request.AddQueryParameter("pod", Pod.ToString()); }
            if (Namespace != null) { request.AddQueryParameter("namespace", Namespace.ToString()); }
            if (Cluster != null) { request.AddQueryParameter("cluster", Cluster.ToString()); }
            if (Start != null) { request.AddQueryParameter("start", Start.ToString()); }
            if (End != null) { request.AddQueryParameter("end", End.ToString()); }
            request.Resource = GetServiceURL.ToString();
            RestResponse<List<VcenterNamespaceManagementStatsTimeSeriesTimeSeriesType>> response = await restClient.ExecuteTaskAsyncWithPolicy<List<VcenterNamespaceManagementStatsTimeSeriesTimeSeriesType>>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetServiceURL.ToString() + " did not complete successfull";
                throw new vSphereException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}

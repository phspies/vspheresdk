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
using vspheresdk.Vcenter.Models.Enums;

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
            if (200 <= (int)response.StatusCode && (int)response.StatusCode <= 300) { return response.Data; }
            else if ((int)response.StatusCode == 500) { throw new vSphereException("if the system reports an error while responding to the request.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 400) { throw new vSphereException("if the specified cluster in TimeSeries.Spec.cluster is not enabled for Namespaces.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 404) { throw new vSphereException("if the specified cluster in TimeSeries.Spec.cluster or the namespace in TimeSeries.Spec.namespace or TimeSeries.Spec.pod does not exist.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 401) { throw new vSphereException("if the user can not be authenticated.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 403) { throw new vSphereException("if the user does not have System.Read privilege.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
            return response.Data;
        }
    }
}

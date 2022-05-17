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
    public class MonitoringModule
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public MonitoringModule(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
        {
            restClient = Client;
            retry = _retry;
            timeout = _timeout;
            cancellationToken = _cancellationToken;
        }
        public async Task<List<ApplianceMonitoringMonitoredItemType>> ListAsync()
        {
            StringBuilder ListServiceURL = new StringBuilder("/api/appliance/monitoring");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = ListServiceURL.ToString();
            RestResponse<List<ApplianceMonitoringMonitoredItemType>> response = await restClient.ExecuteTaskAsyncWithPolicy<List<ApplianceMonitoringMonitoredItemType>>(request, cancellationToken, timeout, retry);
            if ((int)response.StatusCode == 200) { ArgumentNullException.ThrowIfNull(response.Data) ; return response.Data; }
            else if ((int)response.StatusCode == 500) { throw new vSphereException("Generic error", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
        }
        public async Task<List<ApplianceMonitoringMonitoredItemDataType>> QueryAsync(string Names, string Interval, string Function, string StartTime, string EndTime)
        {
            ArgumentNullException.ThrowIfNull(Names, "Names cannot be null");
            ArgumentNullException.ThrowIfNull(Interval, "Interval cannot be null");
            ArgumentNullException.ThrowIfNull(Function, "Function cannot be null");
            ArgumentNullException.ThrowIfNull(StartTime, "StartTime cannot be null");
            ArgumentNullException.ThrowIfNull(EndTime, "EndTime cannot be null");
            StringBuilder QueryServiceURL = new StringBuilder("/api/appliance/monitoring/query");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Names != null) { request.AddQueryParameter("names", Names.ToString()); }
            if (Interval != null) { request.AddQueryParameter("interval", Interval.ToString()); }
            if (Function != null) { request.AddQueryParameter("function", Function.ToString()); }
            if (StartTime != null) { request.AddQueryParameter("start_time", StartTime.ToString()); }
            if (EndTime != null) { request.AddQueryParameter("end_time", EndTime.ToString()); }
            request.Resource = QueryServiceURL.ToString();
            RestResponse<List<ApplianceMonitoringMonitoredItemDataType>> response = await restClient.ExecuteTaskAsyncWithPolicy<List<ApplianceMonitoringMonitoredItemDataType>>(request, cancellationToken, timeout, retry);
            if ((int)response.StatusCode == 200) { ArgumentNullException.ThrowIfNull(response.Data) ; return response.Data; }
            else if ((int)response.StatusCode == 500) { throw new vSphereException("Generic error", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
        }
        public async Task<ApplianceMonitoringMonitoredItemType> GetAsync(string StatId)
        {
            ArgumentNullException.ThrowIfNull(StatId, "StatId cannot be null");
            StringBuilder GetServiceURL = new StringBuilder("/api/appliance/monitoring/{stat_id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetServiceURL.Replace("{stat_id}", System.Uri.EscapeDataString(Helpers.ConvertToString(StatId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetServiceURL.ToString();
            RestResponse<ApplianceMonitoringMonitoredItemType> response = await restClient.ExecuteTaskAsyncWithPolicy<ApplianceMonitoringMonitoredItemType>(request, cancellationToken, timeout, retry);
            if ((int)response.StatusCode == 200) { ArgumentNullException.ThrowIfNull(response.Data) ; return response.Data; }
            else if ((int)response.StatusCode == 500) { throw new vSphereException("Generic error", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
        }
    }
}

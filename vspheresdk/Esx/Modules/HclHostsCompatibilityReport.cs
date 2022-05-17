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
using vspheresdk.Esx.Models.Enums;

namespace vspheresdk.Esx.Modules
{
    public class HclHostsCompatibilityReportModule
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public HclHostsCompatibilityReportModule(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
        {
            restClient = Client;
            retry = _retry;
            timeout = _timeout;
            cancellationToken = _cancellationToken;
        }
        public async Task<EsxHclHostsCompatibilityReportResultType> GetAsync(string Host)
        {
            ArgumentNullException.ThrowIfNull(Host, "Host cannot be null");
            StringBuilder GetServiceURL = new StringBuilder("/api/esx/hcl/hosts/{host}/compatibility-report");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetServiceURL.Replace("{host}", System.Uri.EscapeDataString(Helpers.ConvertToString(Host, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetServiceURL.ToString();
            RestResponse<EsxHclHostsCompatibilityReportResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<EsxHclHostsCompatibilityReportResultType>(request, cancellationToken, timeout, retry);
            if (200 <= (int)response.StatusCode && (int)response.StatusCode <= 300) { return response.Data; }
            else if ((int)response.StatusCode == 404) { throw new vSphereException("if there is no report generated for the given host. This operation does not check if the host id is valid or it exists.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 401) { throw new vSphereException("if the caller is not authenticated.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 500) { throw new vSphereException("If there is some unknown error. The accompanying error message will give more details about the failure.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
            return response.Data;
        }
        public async Task<string> CreateTaskAsync(string Host, EsxHclHostsCompatibilityReportCreateTaskType RequestBody = null)
        {
            ArgumentNullException.ThrowIfNull(Host, "Host cannot be null");
            StringBuilder CreateTaskServiceURL = new StringBuilder("/api/esx/hcl/hosts/{host}/compatibility-report?vmw-task=true");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            CreateTaskServiceURL.Replace("{host}", System.Uri.EscapeDataString(Helpers.ConvertToString(Host, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(RequestBody);
            request.Resource = CreateTaskServiceURL.ToString();
            RestResponse<string> response = await restClient.ExecuteTaskAsyncWithPolicy<string>(request, cancellationToken, timeout, retry);
            if (200 <= (int)response.StatusCode && (int)response.StatusCode <= 300) { return response.Data; }
            else if ((int)response.StatusCode == 404) { throw new vSphereException("if no host with the given MoID can be found.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 401) { throw new vSphereException("if the caller is not authenticated.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 400) { throw new vSphereException("if there is no compatibility data on the vCenter executing the operation.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 500) { throw new vSphereException("If there is some unknown error. The accompanying error message will give more details about the failure.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
            return response.Data;
        }
    }
}

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
    public class LcmUpdatePrecheckReportModule
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public LcmUpdatePrecheckReportModule(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
        {
            restClient = Client;
            retry = _retry;
            timeout = _timeout;
            cancellationToken = _cancellationToken;
        }
        public async Task<string> CreateTaskAsync(string Version)
        {
            ArgumentNullException.ThrowIfNull(Version, "Version cannot be null");
            StringBuilder CreateTaskServiceURL = new StringBuilder("/api/vcenter/lcm/update/pending/{version}/precheck-report?vmw-task=true");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            CreateTaskServiceURL.Replace("{version}", System.Uri.EscapeDataString(Helpers.ConvertToString(Version, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = CreateTaskServiceURL.ToString();
            RestResponse<string> response = await restClient.ExecuteTaskAsyncWithPolicy<string>(request, cancellationToken, timeout, retry);
            if ((int)response.StatusCode == 202) { ArgumentNullException.ThrowIfNull(response.Data) ; return response.Data; }
            else if ((int)response.StatusCode == 401) { throw new vSphereException("if the user can not be authenticated.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 404) { throw new vSphereException("if there is no pending update assosiated with the version in the system.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 400) { throw new vSphereException("if a precheck is already in progress.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 500) { throw new vSphereException("if there is some unknown internal error. The accompanying error message will give more details about the error.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
        }
    }
}

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
    public class SettingsDepotsOnlineModule
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public SettingsDepotsOnlineModule(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
        {
            restClient = Client;
            retry = _retry;
            timeout = _timeout;
            cancellationToken = _cancellationToken;
        }
        public async Task<string> CreateAsync(EsxSettingsDepotsOnlineCreateType RequestBody = null)
        {
            StringBuilder CreateServiceURL = new StringBuilder("/api/esx/settings/depots/online");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(RequestBody);
            request.Resource = CreateServiceURL.ToString();
            RestResponse<string> response = await restClient.ExecuteTaskAsyncWithPolicy<string>(request, cancellationToken, timeout, retry);
            if ((int)response.StatusCode == 201) { ArgumentNullException.ThrowIfNull(response.Data) ; return response.Data; }
            else if ((int)response.StatusCode == 401) { throw new vSphereException("If the caller is not authenticated.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 400) { throw new vSphereException("If depot with given location already exists.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 500) { throw new vSphereException("If there is some unknown internal error. The accompanying error message will give more details about the failure.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 503) { throw new vSphereException("If the service is not available.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
        }
        public async Task<object> ListAsync()
        {
            StringBuilder ListServiceURL = new StringBuilder("/api/esx/settings/depots/online");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = ListServiceURL.ToString();
            RestResponse<object> response = await restClient.ExecuteTaskAsyncWithPolicy<object>(request, cancellationToken, timeout, retry);
            if ((int)response.StatusCode == 200) { ArgumentNullException.ThrowIfNull(response.Data) ; return response.Data; }
            else if ((int)response.StatusCode == 401) { throw new vSphereException("if the caller is not authenticated.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 503) { throw new vSphereException("If the service is not available.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 500) { throw new vSphereException("If there is some unknown internal error. The accompanying error message will give more details about the failure.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
        }
        public async Task<EsxSettingsDepotsOnlineInfoType> GetAsync(string Depot)
        {
            ArgumentNullException.ThrowIfNull(Depot, "Depot cannot be null");
            StringBuilder GetServiceURL = new StringBuilder("/api/esx/settings/depots/online/{depot}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetServiceURL.Replace("{depot}", System.Uri.EscapeDataString(Helpers.ConvertToString(Depot, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetServiceURL.ToString();
            RestResponse<EsxSettingsDepotsOnlineInfoType> response = await restClient.ExecuteTaskAsyncWithPolicy<EsxSettingsDepotsOnlineInfoType>(request, cancellationToken, timeout, retry);
            if ((int)response.StatusCode == 200) { ArgumentNullException.ThrowIfNull(response.Data) ; return response.Data; }
            else if ((int)response.StatusCode == 401) { throw new vSphereException("If the caller is not authenticated.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 404) { throw new vSphereException("If there is no depot with given identifier param.name depot in the system.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 503) { throw new vSphereException("If the service is not available.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 500) { throw new vSphereException("If there is some unknown internal error. The accompanying error message will give more details about the failure.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
        }
        public async Task UpdateAsync(string Depot, EsxSettingsDepotsOnlineUpdateType RequestBody = null)
        {
            ArgumentNullException.ThrowIfNull(Depot, "Depot cannot be null");
            StringBuilder UpdateServiceURL = new StringBuilder("/api/esx/settings/depots/online/{depot}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            UpdateServiceURL.Replace("{depot}", System.Uri.EscapeDataString(Helpers.ConvertToString(Depot, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(RequestBody);
            request.Resource = UpdateServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if ((int)response.StatusCode == 204) {}
            else if ((int)response.StatusCode == 401) { throw new vSphereException("If the caller is not authenticated.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 400) { throw new vSphereException("If given depot is system defined.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 404) { throw new vSphereException("If there is no depot associated with parameter param.name depot in the system.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 500) { throw new vSphereException("If there is some unknown internal error. The accompanying error message will give more details about the failure.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 503) { throw new vSphereException("If the service is not available.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
        }
        public async Task DeleteAsync(string Depot)
        {
            ArgumentNullException.ThrowIfNull(Depot, "Depot cannot be null");
            StringBuilder DeleteServiceURL = new StringBuilder("/api/esx/settings/depots/online/{depot}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteServiceURL.Replace("{depot}", System.Uri.EscapeDataString(Helpers.ConvertToString(Depot, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if ((int)response.StatusCode == 204) {}
            else if ((int)response.StatusCode == 401) { throw new vSphereException("If the caller is not authenticated.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 400) { throw new vSphereException("If the content of depot to be deleted is used in some baseline or desired state. The value of the data term field of link Error will be the PrecheckResult term structure that lists the information of affected baselines and desired states. This error is applicable to the taskbased name delete term operation only.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 404) { throw new vSphereException("If there is no depot associated with parameter param.name depot in the system.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 503) { throw new vSphereException("If the service is not available.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 500) { throw new vSphereException("If there some unknown internal error. The accompanying error message will give more details about the failure. For taskbased name delete term operation once the task is started it does NOT stop if encountering an error. Instead it will continuously run to completion. In this case the value of the data term field of link Error will be the DeleteResult term structure that lists all the errors encountered.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
        }
        public async Task<string> FlushTaskAsync(string Depot)
        {
            ArgumentNullException.ThrowIfNull(Depot, "Depot cannot be null");
            StringBuilder FlushTaskServiceURL = new StringBuilder("/api/esx/settings/depots/online/{depot}?action=flush&vmw-task=true");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            FlushTaskServiceURL.Replace("{depot}", System.Uri.EscapeDataString(Helpers.ConvertToString(Depot, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = FlushTaskServiceURL.ToString();
            RestResponse<string> response = await restClient.ExecuteTaskAsyncWithPolicy<string>(request, cancellationToken, timeout, retry);
            if ((int)response.StatusCode == 202) { ArgumentNullException.ThrowIfNull(response.Data) ; return response.Data; }
            else if ((int)response.StatusCode == 401) { throw new vSphereException("If the caller is not authenticated.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 400) { throw new vSphereException("If the content of depot to be deleted is used in some baseline or desired state. The value of the data term field of link Error will be the PrecheckResult term structure that lists the information of affected baselines and desired states.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 404) { throw new vSphereException("If there is no depot associated with parameter param.name depot in the system.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 503) { throw new vSphereException("If the service is not available.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 500) { throw new vSphereException("If there some unknown internal error. The accompanying error message will give more details about the failure. name flush is a taskbased term operation. Once the task is started it does NOT stop if encountering an error. Instead it will continuously run to completion. In this case the value of the data term field of link Error will be the FlushResult term structure that lists all the errors encountered.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
        }
        public async Task<string> DeleteTaskAsync(string Depot)
        {
            ArgumentNullException.ThrowIfNull(Depot, "Depot cannot be null");
            StringBuilder DeleteTaskServiceURL = new StringBuilder("/api/esx/settings/depots/online/{depot}?vmw-task=true");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteTaskServiceURL.Replace("{depot}", System.Uri.EscapeDataString(Helpers.ConvertToString(Depot, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteTaskServiceURL.ToString();
            RestResponse<string> response = await restClient.ExecuteTaskAsyncWithPolicy<string>(request, cancellationToken, timeout, retry);
            if ((int)response.StatusCode == 202) { ArgumentNullException.ThrowIfNull(response.Data) ; return response.Data; }
            else if ((int)response.StatusCode == 401) { throw new vSphereException("If the caller is not authenticated.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 400) { throw new vSphereException("If the content of depot to be deleted is used in some baseline or desired state. The value of the data term field of link Error will be the PrecheckResult term structure that lists the information of affected baselines and desired states. This error is applicable to the taskbased name delete term operation only.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 404) { throw new vSphereException("If there is no depot associated with parameter param.name depot in the system.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 503) { throw new vSphereException("If the service is not available.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 500) { throw new vSphereException("If there some unknown internal error. The accompanying error message will give more details about the failure. For taskbased name delete term operation once the task is started it does NOT stop if encountering an error. Instead it will continuously run to completion. In this case the value of the data term field of link Error will be the DeleteResult term structure that lists all the errors encountered.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
        }
    }
}

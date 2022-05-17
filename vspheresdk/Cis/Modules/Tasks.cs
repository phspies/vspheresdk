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
using vspheresdk.Cis.Models;
using vspheresdk.Cis.Models.Enums;

namespace vspheresdk.Cis.Modules
{
    public class TasksModule
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public TasksModule(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
        {
            restClient = Client;
            retry = _retry;
            timeout = _timeout;
            cancellationToken = _cancellationToken;
        }
        public async Task<CisTaskInfoType> GetAsync(string Task, bool? ReturnAll = null, bool? ExcludeResult = null)
        {
            ArgumentNullException.ThrowIfNull(Task, "Task cannot be null");
            StringBuilder GetServiceURL = new StringBuilder("/api/cis/tasks/{task}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetServiceURL.Replace("{task}", System.Uri.EscapeDataString(Helpers.ConvertToString(Task, System.Globalization.CultureInfo.InvariantCulture)));
            if (ReturnAll != null) { request.AddQueryParameter("return_all", ReturnAll.ToString()); }
            if (ExcludeResult != null) { request.AddQueryParameter("exclude_result", ExcludeResult.ToString()); }
            request.Resource = GetServiceURL.ToString();
            RestResponse<CisTaskInfoType> response = await restClient.ExecuteTaskAsyncWithPolicy<CisTaskInfoType>(request, cancellationToken, timeout, retry);
            if (200 <= (int)response.StatusCode && (int)response.StatusCode <= 300) { return response.Data; }
            else if ((int)response.StatusCode == 500) { throw new vSphereException("if the tasks state cannot be accessed.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 404) { throw new vSphereException("if the task is not found.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 503) { throw new vSphereException("if the system is unable to communicate with a service to complete the request.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 401) { throw new vSphereException("if the user can not be authenticated.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 403) { throw new vSphereException("if the user doesnt have the required privileges.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
            return response.Data;
        }
        public async Task CancelAsync(string Task)
        {
            ArgumentNullException.ThrowIfNull(Task, "Task cannot be null");
            StringBuilder CancelServiceURL = new StringBuilder("/api/cis/tasks/{task}?action=cancel");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            CancelServiceURL.Replace("{task}", System.Uri.EscapeDataString(Helpers.ConvertToString(Task, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = CancelServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (200 <= (int)response.StatusCode && (int)response.StatusCode <= 300) { }
            else if ((int)response.StatusCode == 500) { throw new vSphereException("if the tasks state cannot be accessed.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 400) { throw new vSphereException("if the task is not cancelable.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 404) { throw new vSphereException("if the task is not found.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 503) { throw new vSphereException("if the system is unable to communicate with a service to complete the request.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 401) { throw new vSphereException("if the user can not be authenticated.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 403) { throw new vSphereException("if the user doesnt have the required privileges.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
            
        }
        public async Task<object> ListAsync(CisTasksListType RequestBody = null)
        {
            StringBuilder ListServiceURL = new StringBuilder("/api/cis/tasks?action=list");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(RequestBody);
            request.Resource = ListServiceURL.ToString();
            RestResponse<object> response = await restClient.ExecuteTaskAsyncWithPolicy<object>(request, cancellationToken, timeout, retry);
            if (200 <= (int)response.StatusCode && (int)response.StatusCode <= 300) { return response.Data; }
            else if ((int)response.StatusCode == 400) { throw new vSphereException("if any of the specified parameters are invalid.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 500) { throw new vSphereException("if a tasks state cannot be accessed or over 1000 tasks matching the Tasks.FilterSpec.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 503) { throw new vSphereException("if the system is unable to communicate with a service to complete the request.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 401) { throw new vSphereException("if the user can not be authenticated.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 403) { throw new vSphereException("if the user doesnt have the required privileges.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
            return response.Data;
        }
    }
}

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
using vspheresdk.Appliance.Models.Enums;

namespace vspheresdk.Appliance.Modules
{
    public class RecoveryBackupSchedulesModule
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public RecoveryBackupSchedulesModule(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
        {
            restClient = Client;
            retry = _retry;
            timeout = _timeout;
            cancellationToken = _cancellationToken;
        }
        public async Task CreateAsync(ApplianceRecoveryBackupSchedulesCreateType RequestBody)
        {
            ArgumentNullException.ThrowIfNull(RequestBody, "RequestBody cannot be null");
            StringBuilder CreateServiceURL = new StringBuilder("/api/appliance/recovery/backup/schedules");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(RequestBody);
            request.Resource = CreateServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (200 <= (int)response.StatusCode && (int)response.StatusCode <= 300) { }
            else if ((int)response.StatusCode == 400) { throw new vSphereException("if the schedule with the given id already exists.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 500) { throw new vSphereException("if any error occurs during the execution of the operation.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
            
        }
        public async Task<object> ListAsync()
        {
            StringBuilder ListServiceURL = new StringBuilder("/api/appliance/recovery/backup/schedules");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = ListServiceURL.ToString();
            RestResponse<object> response = await restClient.ExecuteTaskAsyncWithPolicy<object>(request, cancellationToken, timeout, retry);
            if (200 <= (int)response.StatusCode && (int)response.StatusCode <= 300) { return response.Data; }
            else if ((int)response.StatusCode == 500) { throw new vSphereException("if any error occurs during the execution of the operation.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
            return response.Data;
        }
        public async Task<ApplianceRecoveryBackupSchedulesInfoType> GetAsync(string Schedule)
        {
            ArgumentNullException.ThrowIfNull(Schedule, "Schedule cannot be null");
            StringBuilder GetServiceURL = new StringBuilder("/api/appliance/recovery/backup/schedules/{schedule}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetServiceURL.Replace("{schedule}", System.Uri.EscapeDataString(Helpers.ConvertToString(Schedule, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetServiceURL.ToString();
            RestResponse<ApplianceRecoveryBackupSchedulesInfoType> response = await restClient.ExecuteTaskAsyncWithPolicy<ApplianceRecoveryBackupSchedulesInfoType>(request, cancellationToken, timeout, retry);
            if (200 <= (int)response.StatusCode && (int)response.StatusCode <= 300) { return response.Data; }
            else if ((int)response.StatusCode == 404) { throw new vSphereException("if schedule associated with id does not exist.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 500) { throw new vSphereException("if any error occurs during the execution of the operation.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
            return response.Data;
        }
        public async Task UpdateAsync(string Schedule, ApplianceRecoveryBackupSchedulesUpdateType RequestBody = null)
        {
            ArgumentNullException.ThrowIfNull(Schedule, "Schedule cannot be null");
            StringBuilder UpdateServiceURL = new StringBuilder("/api/appliance/recovery/backup/schedules/{schedule}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            UpdateServiceURL.Replace("{schedule}", System.Uri.EscapeDataString(Helpers.ConvertToString(Schedule, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(RequestBody);
            request.Resource = UpdateServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (200 <= (int)response.StatusCode && (int)response.StatusCode <= 300) { }
            else if ((int)response.StatusCode == 400) { throw new vSphereException("if provided with invalid schedule specification.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 404) { throw new vSphereException("if schedule associated with id does not exist.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 500) { throw new vSphereException("if any error occurs during the execution of the operation.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
            
        }
        public async Task DeleteAsync(string Schedule)
        {
            ArgumentNullException.ThrowIfNull(Schedule, "Schedule cannot be null");
            StringBuilder DeleteServiceURL = new StringBuilder("/api/appliance/recovery/backup/schedules/{schedule}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteServiceURL.Replace("{schedule}", System.Uri.EscapeDataString(Helpers.ConvertToString(Schedule, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (200 <= (int)response.StatusCode && (int)response.StatusCode <= 300) { }
            else if ((int)response.StatusCode == 404) { throw new vSphereException("if schedule associated with id does not exist.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 500) { throw new vSphereException("if any error occurs during the execution of the operation.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
            
        }
        public async Task<ApplianceRecoveryBackupJobBackupJobStatusType> RunAsync(string Schedule, ApplianceRecoveryBackupSchedulesRunType RequestBody = null)
        {
            ArgumentNullException.ThrowIfNull(Schedule, "Schedule cannot be null");
            StringBuilder RunServiceURL = new StringBuilder("/api/appliance/recovery/backup/schedules/{schedule}?action=run");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            RunServiceURL.Replace("{schedule}", System.Uri.EscapeDataString(Helpers.ConvertToString(Schedule, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(RequestBody);
            request.Resource = RunServiceURL.ToString();
            RestResponse<ApplianceRecoveryBackupJobBackupJobStatusType> response = await restClient.ExecuteTaskAsyncWithPolicy<ApplianceRecoveryBackupJobBackupJobStatusType>(request, cancellationToken, timeout, retry);
            if (200 <= (int)response.StatusCode && (int)response.StatusCode <= 300) { return response.Data; }
            else if ((int)response.StatusCode == 400) { throw new vSphereException("if a backup or restore is already in progress.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 404) { throw new vSphereException("if schedule associated with id does not exist.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 500) { throw new vSphereException("if any error occurs during the execution of the operation.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
            return response.Data;
        }
    }
}

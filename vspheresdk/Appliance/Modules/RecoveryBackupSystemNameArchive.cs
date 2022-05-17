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
    public class RecoveryBackupSystemNameArchiveModule
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public RecoveryBackupSystemNameArchiveModule(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
        {
            restClient = Client;
            retry = _retry;
            timeout = _timeout;
            cancellationToken = _cancellationToken;
        }
        public async Task<ApplianceRecoveryBackupSystemNameArchiveInfoType> GetAsync(string SystemName, string Archive, ApplianceRecoveryBackupLocationSpecType RequestBody = null)
        {
            ArgumentNullException.ThrowIfNull(SystemName, "SystemName cannot be null");
            ArgumentNullException.ThrowIfNull(Archive, "Archive cannot be null");
            StringBuilder GetServiceURL = new StringBuilder("/api/appliance/recovery/backup/system-name/{system_name}/archives/{archive}?action=get");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            GetServiceURL.Replace("{system_name}", System.Uri.EscapeDataString(Helpers.ConvertToString(SystemName, System.Globalization.CultureInfo.InvariantCulture)));
            GetServiceURL.Replace("{archive}", System.Uri.EscapeDataString(Helpers.ConvertToString(Archive, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(RequestBody);
            request.Resource = GetServiceURL.ToString();
            RestResponse<ApplianceRecoveryBackupSystemNameArchiveInfoType> response = await restClient.ExecuteTaskAsyncWithPolicy<ApplianceRecoveryBackupSystemNameArchiveInfoType>(request, cancellationToken, timeout, retry);
            if ((int)response.StatusCode == 200) { ArgumentNullException.ThrowIfNull(response.Data) ; return response.Data; }
            else if ((int)response.StatusCode == 404) { throw new vSphereException("if backup does not exist.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 500) { throw new vSphereException("if any error occurs during the execution of the operation.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
        }
        public async Task<List<ApplianceRecoveryBackupSystemNameArchiveSummaryType>> ListAsync(string SystemName, ApplianceRecoveryBackupSystemNameArchiveListType RequestBody)
        {
            ArgumentNullException.ThrowIfNull(SystemName, "SystemName cannot be null");
            ArgumentNullException.ThrowIfNull(RequestBody, "RequestBody cannot be null");
            StringBuilder ListServiceURL = new StringBuilder("/api/appliance/recovery/backup/system-name/{system_name}/archives?action=list");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            ListServiceURL.Replace("{system_name}", System.Uri.EscapeDataString(Helpers.ConvertToString(SystemName, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(RequestBody);
            request.Resource = ListServiceURL.ToString();
            RestResponse<List<ApplianceRecoveryBackupSystemNameArchiveSummaryType>> response = await restClient.ExecuteTaskAsyncWithPolicy<List<ApplianceRecoveryBackupSystemNameArchiveSummaryType>>(request, cancellationToken, timeout, retry);
            if ((int)response.StatusCode == 200) { ArgumentNullException.ThrowIfNull(response.Data) ; return response.Data; }
            else if ((int)response.StatusCode == 404) { throw new vSphereException("if combination of locSpec and system name does not refer to an existing location on the backup server.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 500) { throw new vSphereException("if any error occurs during the execution of the operation.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
        }
    }
}

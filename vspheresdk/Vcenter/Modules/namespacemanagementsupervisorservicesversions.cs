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
    public class NamespaceManagementSupervisorServicesVersionsModule
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public NamespaceManagementSupervisorServicesVersionsModule(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
        {
            restClient = Client;
            retry = _retry;
            timeout = _timeout;
            cancellationToken = _cancellationToken;
        }
        public async Task CreateAsync(string SupervisorService, VcenterNamespaceManagementSupervisorServicesVersionsCreateType RequestBody = null)
        {
            ArgumentNullException.ThrowIfNull(SupervisorService, "SupervisorService cannot be null");
            StringBuilder CreateServiceURL = new StringBuilder("/api/vcenter/namespace-management/supervisor-services/{supervisor_service}/versions");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            CreateServiceURL.Replace("{supervisor_service}", System.Uri.EscapeDataString(Helpers.ConvertToString(SupervisorService, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(RequestBody);
            request.Resource = CreateServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (200 <= (int)response.StatusCode && (int)response.StatusCode <= 300) { }
            else if ((int)response.StatusCode == 400) { throw new vSphereException("if the Supervisor Service version cannot be created in the current state for example the Supervisor Service is in DEACTIVATED state.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 500) { throw new vSphereException("if the system reports an error while responding to the request.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 404) { throw new vSphereException("if Supervisor Service with the ID supervisorService could not be located.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 401) { throw new vSphereException("if the user can not be authenticated.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 403) { throw new vSphereException("if the user doesnt have the SupervisorServices.Manage privilege.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
            
        }
        public async Task<List<VcenterNamespaceManagementSupervisorServicesVersionsSummaryType>> ListAsync(string SupervisorService)
        {
            ArgumentNullException.ThrowIfNull(SupervisorService, "SupervisorService cannot be null");
            StringBuilder ListServiceURL = new StringBuilder("/api/vcenter/namespace-management/supervisor-services/{supervisor_service}/versions");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListServiceURL.Replace("{supervisor_service}", System.Uri.EscapeDataString(Helpers.ConvertToString(SupervisorService, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ListServiceURL.ToString();
            RestResponse<List<VcenterNamespaceManagementSupervisorServicesVersionsSummaryType>> response = await restClient.ExecuteTaskAsyncWithPolicy<List<VcenterNamespaceManagementSupervisorServicesVersionsSummaryType>>(request, cancellationToken, timeout, retry);
            if (200 <= (int)response.StatusCode && (int)response.StatusCode <= 300) { return response.Data; }
            else if ((int)response.StatusCode == 500) { throw new vSphereException("if the system reports an error while responding to the request.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 404) { throw new vSphereException("if service with the ID supervisorService could not be located.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 401) { throw new vSphereException("if the user can not be authenticated.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 403) { throw new vSphereException("if the user doesnt have the System.Read privilege.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
            return response.Data;
        }
        public async Task<VcenterNamespaceManagementSupervisorServicesVersionsInfoType> GetAsync(string SupervisorService, string Version)
        {
            ArgumentNullException.ThrowIfNull(SupervisorService, "SupervisorService cannot be null");
            ArgumentNullException.ThrowIfNull(Version, "Version cannot be null");
            StringBuilder GetServiceURL = new StringBuilder("/api/vcenter/namespace-management/supervisor-services/{supervisor_service}/versions/{version}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetServiceURL.Replace("{supervisor_service}", System.Uri.EscapeDataString(Helpers.ConvertToString(SupervisorService, System.Globalization.CultureInfo.InvariantCulture)));
            GetServiceURL.Replace("{version}", System.Uri.EscapeDataString(Helpers.ConvertToString(Version, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetServiceURL.ToString();
            RestResponse<VcenterNamespaceManagementSupervisorServicesVersionsInfoType> response = await restClient.ExecuteTaskAsyncWithPolicy<VcenterNamespaceManagementSupervisorServicesVersionsInfoType>(request, cancellationToken, timeout, retry);
            if (200 <= (int)response.StatusCode && (int)response.StatusCode <= 300) { return response.Data; }
            else if ((int)response.StatusCode == 500) { throw new vSphereException("if the system reports an error while responding to the request.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 404) { throw new vSphereException("if Supervisor Service with the ID supervisorService or version with the ID param.name version could not be located.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 401) { throw new vSphereException("if the user can not be authenticated.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 403) { throw new vSphereException("if the user doesnt have the System.Read privilege.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
            return response.Data;
        }
        public async Task DeleteAsync(string SupervisorService, string Version)
        {
            ArgumentNullException.ThrowIfNull(SupervisorService, "SupervisorService cannot be null");
            ArgumentNullException.ThrowIfNull(Version, "Version cannot be null");
            StringBuilder DeleteServiceURL = new StringBuilder("/api/vcenter/namespace-management/supervisor-services/{supervisor_service}/versions/{version}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteServiceURL.Replace("{supervisor_service}", System.Uri.EscapeDataString(Helpers.ConvertToString(SupervisorService, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteServiceURL.Replace("{version}", System.Uri.EscapeDataString(Helpers.ConvertToString(Version, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (200 <= (int)response.StatusCode && (int)response.StatusCode <= 300) { }
            else if ((int)response.StatusCode == 500) { throw new vSphereException("if the system reports an error while responding to the request e.g. if it is unable to reach a vSphere Supervisor that has the version enabled.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 400) { throw new vSphereException("if the Supervisor Service version cannot be deleted in the current state e.g. the version is not in DEACTIVATED state.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 404) { throw new vSphereException("if Supervisor Service with the ID supervisorService or version with the ID param.name version could not be located.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 401) { throw new vSphereException("if the user can not be authenticated.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 403) { throw new vSphereException("if the user doesnt have the SupervisorServices.Manage privilege.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
            
        }
        public async Task ActivateAsync(string SupervisorService, string Version)
        {
            ArgumentNullException.ThrowIfNull(SupervisorService, "SupervisorService cannot be null");
            ArgumentNullException.ThrowIfNull(Version, "Version cannot be null");
            StringBuilder ActivateServiceURL = new StringBuilder("/api/vcenter/namespace-management/supervisor-services/{supervisor_service}/versions/{version}?action=activate");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            ActivateServiceURL.Replace("{supervisor_service}", System.Uri.EscapeDataString(Helpers.ConvertToString(SupervisorService, System.Globalization.CultureInfo.InvariantCulture)));
            ActivateServiceURL.Replace("{version}", System.Uri.EscapeDataString(Helpers.ConvertToString(Version, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ActivateServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (200 <= (int)response.StatusCode && (int)response.StatusCode <= 300) { }
            else if ((int)response.StatusCode == 500) { throw new vSphereException("if the system reports an error while responding to the request.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 400) { throw new vSphereException("if the Supervisor Service version cannot be activated in the current state for example the Supervisor Service is in DEACTIVATED state.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 404) { throw new vSphereException("if Supervisor Service with the ID supervisorService or version with the ID param.name version could not be located.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 401) { throw new vSphereException("if the user cannot be authenticated.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 403) { throw new vSphereException("if the user does not have the SupervisorServices.Manage privilege.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
            
        }
        public async Task DeactivateAsync(string SupervisorService, string Version)
        {
            ArgumentNullException.ThrowIfNull(SupervisorService, "SupervisorService cannot be null");
            ArgumentNullException.ThrowIfNull(Version, "Version cannot be null");
            StringBuilder DeactivateServiceURL = new StringBuilder("/api/vcenter/namespace-management/supervisor-services/{supervisor_service}/versions/{version}?action=deactivate");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            DeactivateServiceURL.Replace("{supervisor_service}", System.Uri.EscapeDataString(Helpers.ConvertToString(SupervisorService, System.Globalization.CultureInfo.InvariantCulture)));
            DeactivateServiceURL.Replace("{version}", System.Uri.EscapeDataString(Helpers.ConvertToString(Version, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeactivateServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (200 <= (int)response.StatusCode && (int)response.StatusCode <= 300) { }
            else if ((int)response.StatusCode == 500) { throw new vSphereException("if the system reports an error while responding to the request.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 400) { throw new vSphereException("if the Supervisor Service version cannot be deactivated in the current state for example the Supervisor Service is in ACTIVATED state and this version is the last version of the Supervisor Service in ACTIVATED state.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 404) { throw new vSphereException("if Supervisor Service with the ID supervisorService or version with the ID version could not be located.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 401) { throw new vSphereException("if the user cannot be authenticated.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 403) { throw new vSphereException("if the user does not have the SupervisorServices.Manage privilege.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
            
        }
    }
}

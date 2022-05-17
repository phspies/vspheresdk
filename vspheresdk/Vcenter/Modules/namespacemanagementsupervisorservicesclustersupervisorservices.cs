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
    public class NamespaceManagementSupervisorServicesClusterSupervisorServicesModule
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public NamespaceManagementSupervisorServicesClusterSupervisorServicesModule(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
        {
            restClient = Client;
            retry = _retry;
            timeout = _timeout;
            cancellationToken = _cancellationToken;
        }
        public async Task CreateAsync(string Cluster, VcenterNamespaceManagementSupervisorServicesClusterSupervisorServicesCreateType RequestBody = null)
        {
            ArgumentNullException.ThrowIfNull(Cluster, "Cluster cannot be null");
            StringBuilder CreateServiceURL = new StringBuilder("/api/vcenter/namespace-management/clusters/{cluster}/supervisor-services");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            CreateServiceURL.Replace("{cluster}", System.Uri.EscapeDataString(Helpers.ConvertToString(Cluster, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(RequestBody);
            request.Resource = CreateServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (200 <= (int)response.StatusCode && (int)response.StatusCode <= 300) { }
            else if ((int)response.StatusCode == 500) { throw new vSphereException("if the system reports an error while responding to the request.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 400) { throw new vSphereException("if the Supervisor doesnt support Supervisor Services or if the Supervisor Service cannot be created in the current state e.g. the supervisor service version is in the DEACTIVATED state.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 404) { throw new vSphereException("if the specified cluster with ID cluster or Supervisor Service with the Supervisor Service ID defined in spec or version with the ID param.name version could not be located.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 401) { throw new vSphereException("if the user cannot be authenticated.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 403) { throw new vSphereException("if the user does not have the SupervisorServices.Manage privilege on the specified cluster.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
            
        }
        public async Task<List<VcenterNamespaceManagementSupervisorServicesClusterSupervisorServicesSummaryType>> ListAsync(string Cluster)
        {
            ArgumentNullException.ThrowIfNull(Cluster, "Cluster cannot be null");
            StringBuilder ListServiceURL = new StringBuilder("/api/vcenter/namespace-management/clusters/{cluster}/supervisor-services");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListServiceURL.Replace("{cluster}", System.Uri.EscapeDataString(Helpers.ConvertToString(Cluster, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ListServiceURL.ToString();
            RestResponse<List<VcenterNamespaceManagementSupervisorServicesClusterSupervisorServicesSummaryType>> response = await restClient.ExecuteTaskAsyncWithPolicy<List<VcenterNamespaceManagementSupervisorServicesClusterSupervisorServicesSummaryType>>(request, cancellationToken, timeout, retry);
            if (200 <= (int)response.StatusCode && (int)response.StatusCode <= 300) { return response.Data; }
            else if ((int)response.StatusCode == 500) { throw new vSphereException("if the system reports an error while responding to the request.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 404) { throw new vSphereException("if Supervisor with the ID cluster could not be located.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 400) { throw new vSphereException("if the Supervisor doesnt support Supervisor Services.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 401) { throw new vSphereException("if the user cannot be authenticated.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 403) { throw new vSphereException("if the user does not have the SupervisorServices.Manage privilege on the specified cluster.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
            return response.Data;
        }
        public async Task SetAsync(string Cluster, string SupervisorService, VcenterNamespaceManagementSupervisorServicesClusterSupervisorServicesSetType RequestBody = null)
        {
            ArgumentNullException.ThrowIfNull(Cluster, "Cluster cannot be null");
            ArgumentNullException.ThrowIfNull(SupervisorService, "SupervisorService cannot be null");
            StringBuilder SetServiceURL = new StringBuilder("/api/vcenter/namespace-management/clusters/{cluster}/supervisor-services/{supervisor_service}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            SetServiceURL.Replace("{cluster}", System.Uri.EscapeDataString(Helpers.ConvertToString(Cluster, System.Globalization.CultureInfo.InvariantCulture)));
            SetServiceURL.Replace("{supervisor_service}", System.Uri.EscapeDataString(Helpers.ConvertToString(SupervisorService, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(RequestBody);
            request.Resource = SetServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (200 <= (int)response.StatusCode && (int)response.StatusCode <= 300) { }
            else if ((int)response.StatusCode == 500) { throw new vSphereException("if the system reports an error while responding to the request.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 400) { throw new vSphereException("if the Supervisor doesnt support Supervisor Services or the specified version is not in the ACTIVATED state.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 404) { throw new vSphereException("if Supervisor with the ID cluster or Supervisor Service with the ID supervisorService or version with the ID param.name version could not be located or the Supervisor Service does not exist on the Supervisor.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 401) { throw new vSphereException("if the user cannot be authenticated.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 403) { throw new vSphereException("if the user does not have the SupervisorServices.Manage privilege on the specified cluster.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
            
        }
        public async Task<VcenterNamespaceManagementSupervisorServicesClusterSupervisorServicesInfoType> GetAsync(string Cluster, string SupervisorService)
        {
            ArgumentNullException.ThrowIfNull(Cluster, "Cluster cannot be null");
            ArgumentNullException.ThrowIfNull(SupervisorService, "SupervisorService cannot be null");
            StringBuilder GetServiceURL = new StringBuilder("/api/vcenter/namespace-management/clusters/{cluster}/supervisor-services/{supervisor_service}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetServiceURL.Replace("{cluster}", System.Uri.EscapeDataString(Helpers.ConvertToString(Cluster, System.Globalization.CultureInfo.InvariantCulture)));
            GetServiceURL.Replace("{supervisor_service}", System.Uri.EscapeDataString(Helpers.ConvertToString(SupervisorService, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetServiceURL.ToString();
            RestResponse<VcenterNamespaceManagementSupervisorServicesClusterSupervisorServicesInfoType> response = await restClient.ExecuteTaskAsyncWithPolicy<VcenterNamespaceManagementSupervisorServicesClusterSupervisorServicesInfoType>(request, cancellationToken, timeout, retry);
            if (200 <= (int)response.StatusCode && (int)response.StatusCode <= 300) { return response.Data; }
            else if ((int)response.StatusCode == 500) { throw new vSphereException("if the system reports an error while responding to the request.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 404) { throw new vSphereException("if Supervisor with the ID cluster or the Supervisor Service does not exist on the Supervisor.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 400) { throw new vSphereException("if the Supervisor doesnt support Supervisor Services.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 401) { throw new vSphereException("if the user cannot be authenticated.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 403) { throw new vSphereException("if the user does not have the SupervisorServices.Manage privilege on the specified cluster.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
            return response.Data;
        }
        public async Task DeleteAsync(string Cluster, string SupervisorService)
        {
            ArgumentNullException.ThrowIfNull(Cluster, "Cluster cannot be null");
            ArgumentNullException.ThrowIfNull(SupervisorService, "SupervisorService cannot be null");
            StringBuilder DeleteServiceURL = new StringBuilder("/api/vcenter/namespace-management/clusters/{cluster}/supervisor-services/{supervisor_service}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteServiceURL.Replace("{cluster}", System.Uri.EscapeDataString(Helpers.ConvertToString(Cluster, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteServiceURL.Replace("{supervisor_service}", System.Uri.EscapeDataString(Helpers.ConvertToString(SupervisorService, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (200 <= (int)response.StatusCode && (int)response.StatusCode <= 300) { }
            else if ((int)response.StatusCode == 500) { throw new vSphereException("if the system reports an error while responding to the request.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 404) { throw new vSphereException("if Supervisor with the ID cluster or the Supervisor Service does not exist on the Supervisor.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 400) { throw new vSphereException("if the Supervisor doesnt support Supervisor Services.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 401) { throw new vSphereException("if the user cannot be authenticated.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 403) { throw new vSphereException("if the user does not have the SupervisorServices.Manage privilege on the specified cluster.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
            
        }
    }
}

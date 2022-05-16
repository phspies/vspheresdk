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
    public class NamespaceManagementSupervisorServicesModule
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public NamespaceManagementSupervisorServicesModule(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
        {
            restClient = Client;
            retry = _retry;
            timeout = _timeout;
            cancellationToken = _cancellationToken;
        }
        public async Task CreateAsync(VcenterNamespaceManagementSupervisorServicesCreateType RequestBody = null)
        {
            StringBuilder CreateServiceURL = new StringBuilder("/api/vcenter/namespace-management/supervisor-services");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(RequestBody);
            request.Resource = CreateServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreateServiceURL.ToString() + " did not complete successfull";
                throw new vSphereException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        public async Task<List<VcenterNamespaceManagementSupervisorServicesSummaryType>> ListAsync()
        {
            StringBuilder ListServiceURL = new StringBuilder("/api/vcenter/namespace-management/supervisor-services");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = ListServiceURL.ToString();
            RestResponse<List<VcenterNamespaceManagementSupervisorServicesSummaryType>> response = await restClient.ExecuteTaskAsyncWithPolicy<List<VcenterNamespaceManagementSupervisorServicesSummaryType>>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListServiceURL.ToString() + " did not complete successfull";
                throw new vSphereException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        public async Task<VcenterNamespaceManagementSupervisorServicesInfoType> GetAsync(string SupervisorService)
        {
            ArgumentNullException.ThrowIfNull(SupervisorService, "SupervisorService cannot be null");
            StringBuilder GetServiceURL = new StringBuilder("/api/vcenter/namespace-management/supervisor-services/{supervisor_service}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetServiceURL.Replace("{supervisor_service}", System.Uri.EscapeDataString(Helpers.ConvertToString(SupervisorService, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetServiceURL.ToString();
            RestResponse<VcenterNamespaceManagementSupervisorServicesInfoType> response = await restClient.ExecuteTaskAsyncWithPolicy<VcenterNamespaceManagementSupervisorServicesInfoType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetServiceURL.ToString() + " did not complete successfull";
                throw new vSphereException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        public async Task UpdateAsync(string SupervisorService, VcenterNamespaceManagementSupervisorServicesUpdateType RequestBody = null)
        {
            ArgumentNullException.ThrowIfNull(SupervisorService, "SupervisorService cannot be null");
            StringBuilder UpdateServiceURL = new StringBuilder("/api/vcenter/namespace-management/supervisor-services/{supervisor_service}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            UpdateServiceURL.Replace("{supervisor_service}", System.Uri.EscapeDataString(Helpers.ConvertToString(SupervisorService, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(RequestBody);
            request.Resource = UpdateServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + UpdateServiceURL.ToString() + " did not complete successfull";
                throw new vSphereException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        public async Task DeleteAsync(string SupervisorService)
        {
            ArgumentNullException.ThrowIfNull(SupervisorService, "SupervisorService cannot be null");
            StringBuilder DeleteServiceURL = new StringBuilder("/api/vcenter/namespace-management/supervisor-services/{supervisor_service}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteServiceURL.Replace("{supervisor_service}", System.Uri.EscapeDataString(Helpers.ConvertToString(SupervisorService, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteServiceURL.ToString() + " did not complete successfull";
                throw new vSphereException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        public async Task ActivateAsync(string SupervisorService)
        {
            ArgumentNullException.ThrowIfNull(SupervisorService, "SupervisorService cannot be null");
            StringBuilder ActivateServiceURL = new StringBuilder("/api/vcenter/namespace-management/supervisor-services/{supervisor_service}?action=activate");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            ActivateServiceURL.Replace("{supervisor_service}", System.Uri.EscapeDataString(Helpers.ConvertToString(SupervisorService, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ActivateServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + ActivateServiceURL.ToString() + " did not complete successfull";
                throw new vSphereException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        public async Task DeactivateAsync(string SupervisorService)
        {
            ArgumentNullException.ThrowIfNull(SupervisorService, "SupervisorService cannot be null");
            StringBuilder DeactivateServiceURL = new StringBuilder("/api/vcenter/namespace-management/supervisor-services/{supervisor_service}?action=deactivate");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            DeactivateServiceURL.Replace("{supervisor_service}", System.Uri.EscapeDataString(Helpers.ConvertToString(SupervisorService, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeactivateServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + DeactivateServiceURL.ToString() + " did not complete successfull";
                throw new vSphereException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        public async Task<VcenterNamespaceManagementSupervisorServicesCheckResultType> CheckContentAsync(VcenterNamespaceManagementSupervisorServicesCheckContentType RequestBody)
        {
            ArgumentNullException.ThrowIfNull(RequestBody, "RequestBody cannot be null");
            StringBuilder CheckContentServiceURL = new StringBuilder("/api/vcenter/namespace-management/supervisor-services?action=checkContent");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(RequestBody);
            request.Resource = CheckContentServiceURL.ToString();
            RestResponse<VcenterNamespaceManagementSupervisorServicesCheckResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<VcenterNamespaceManagementSupervisorServicesCheckResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CheckContentServiceURL.ToString() + " did not complete successfull";
                throw new vSphereException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}

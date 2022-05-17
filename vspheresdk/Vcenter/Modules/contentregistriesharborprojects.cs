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
    public class ContentRegistriesHarborProjectsModule
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public ContentRegistriesHarborProjectsModule(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
        {
            restClient = Client;
            retry = _retry;
            timeout = _timeout;
            cancellationToken = _cancellationToken;
        }
        public async Task<string> CreateAsync(string Registry, VcenterContentRegistriesHarborProjectsCreateType RequestBody = null)
        {
            ArgumentNullException.ThrowIfNull(Registry, "Registry cannot be null");
            StringBuilder CreateServiceURL = new StringBuilder("/api/vcenter/content/registries/harbor/{registry}/projects");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            CreateServiceURL.Replace("{registry}", System.Uri.EscapeDataString(Helpers.ConvertToString(Registry, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(RequestBody);
            request.Resource = CreateServiceURL.ToString();
            RestResponse<string> response = await restClient.ExecuteTaskAsyncWithPolicy<string>(request, cancellationToken, timeout, retry);
            if ((int)response.StatusCode == 201) { ArgumentNullException.ThrowIfNull(response.Data) ; return response.Data; }
            else if ((int)response.StatusCode == 400) { throw new vSphereException("if a project with the same name already exists in the registry. In vSphere 7.0 the existing project could have been created automatically when a namespace with the same name is created.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 404) { throw new vSphereException("if a registry specified by param.name registry could not be found.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 500) { throw new vSphereException("if the system reports an error while responding to the request.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 401) { throw new vSphereException("if the user can not be authenticated.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 403) { throw new vSphereException("if the user does not have ContentLibrary.ManageRegistryProject privilege.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
        }
        public async Task<List<VcenterContentRegistriesHarborProjectsSummaryType>> ListAsync(string Registry)
        {
            ArgumentNullException.ThrowIfNull(Registry, "Registry cannot be null");
            StringBuilder ListServiceURL = new StringBuilder("/api/vcenter/content/registries/harbor/{registry}/projects");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListServiceURL.Replace("{registry}", System.Uri.EscapeDataString(Helpers.ConvertToString(Registry, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ListServiceURL.ToString();
            RestResponse<List<VcenterContentRegistriesHarborProjectsSummaryType>> response = await restClient.ExecuteTaskAsyncWithPolicy<List<VcenterContentRegistriesHarborProjectsSummaryType>>(request, cancellationToken, timeout, retry);
            if ((int)response.StatusCode == 200) { ArgumentNullException.ThrowIfNull(response.Data) ; return response.Data; }
            else if ((int)response.StatusCode == 404) { throw new vSphereException("if param.name registry cannot be found.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 500) { throw new vSphereException("if the system reports an error while responding to the request.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 401) { throw new vSphereException("if the user can not be authenticated.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 403) { throw new vSphereException("if the user does not have System.Read privilege.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
        }
        public async Task<VcenterContentRegistriesHarborProjectsInfoType> GetAsync(string Registry, string Project)
        {
            ArgumentNullException.ThrowIfNull(Registry, "Registry cannot be null");
            ArgumentNullException.ThrowIfNull(Project, "Project cannot be null");
            StringBuilder GetServiceURL = new StringBuilder("/api/vcenter/content/registries/harbor/{registry}/projects/{project}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetServiceURL.Replace("{registry}", System.Uri.EscapeDataString(Helpers.ConvertToString(Registry, System.Globalization.CultureInfo.InvariantCulture)));
            GetServiceURL.Replace("{project}", System.Uri.EscapeDataString(Helpers.ConvertToString(Project, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetServiceURL.ToString();
            RestResponse<VcenterContentRegistriesHarborProjectsInfoType> response = await restClient.ExecuteTaskAsyncWithPolicy<VcenterContentRegistriesHarborProjectsInfoType>(request, cancellationToken, timeout, retry);
            if ((int)response.StatusCode == 200) { ArgumentNullException.ThrowIfNull(response.Data) ; return response.Data; }
            else if ((int)response.StatusCode == 404) { throw new vSphereException("if param.name registry or param.name project cannot be found.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 500) { throw new vSphereException("if the system reports an error while responding to the request.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 401) { throw new vSphereException("if the user can not be authenticated.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 403) { throw new vSphereException("if the user does not have System.Read privilege.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
        }
        public async Task DeleteAsync(string Registry, string Project)
        {
            ArgumentNullException.ThrowIfNull(Registry, "Registry cannot be null");
            ArgumentNullException.ThrowIfNull(Project, "Project cannot be null");
            StringBuilder DeleteServiceURL = new StringBuilder("/api/vcenter/content/registries/harbor/{registry}/projects/{project}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteServiceURL.Replace("{registry}", System.Uri.EscapeDataString(Helpers.ConvertToString(Registry, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteServiceURL.Replace("{project}", System.Uri.EscapeDataString(Helpers.ConvertToString(Project, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if ((int)response.StatusCode == 204) {}
            else if ((int)response.StatusCode == 400) { throw new vSphereException("if Harbor registry is being deleted.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 404) { throw new vSphereException("if param.name registry or param.name project cannot be found. In vSphere 7.0 the existing project could have been deleted automatically when a namespace with the same name is deleted.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 500) { throw new vSphereException("if the system reports an error while responding to the request.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 401) { throw new vSphereException("if the user can not be authenticated.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 403) { throw new vSphereException("if the user does not have ContentLibrary.ManageRegistryProject privilege.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
        }
        public async Task PurgeAsync(string Registry, string Project)
        {
            ArgumentNullException.ThrowIfNull(Registry, "Registry cannot be null");
            ArgumentNullException.ThrowIfNull(Project, "Project cannot be null");
            StringBuilder PurgeServiceURL = new StringBuilder("/api/vcenter/content/registries/harbor/{registry}/projects/{project}?action=purge");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            PurgeServiceURL.Replace("{registry}", System.Uri.EscapeDataString(Helpers.ConvertToString(Registry, System.Globalization.CultureInfo.InvariantCulture)));
            PurgeServiceURL.Replace("{project}", System.Uri.EscapeDataString(Helpers.ConvertToString(Project, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = PurgeServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if ((int)response.StatusCode == 204) {}
            else if ((int)response.StatusCode == 404) { throw new vSphereException("if param.name registry or param.name project cannot be found.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 400) { throw new vSphereException("if Harbor registry is being deleted or the project is not in link ConfigStatusREADY status.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 500) { throw new vSphereException("if the system reports an error while responding to the request.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 401) { throw new vSphereException("if the user can not be authenticated.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 403) { throw new vSphereException("if the user does not have ContentLibrary.ManageRegistryProject privilege.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
        }
    }
}

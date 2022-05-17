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
    public class NamespacesNamespaceTemplatesModule
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public NamespacesNamespaceTemplatesModule(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
        {
            restClient = Client;
            retry = _retry;
            timeout = _timeout;
            cancellationToken = _cancellationToken;
        }
        public async Task CreateAsync(string Cluster, VcenterNamespacesNamespaceTemplatesCreateType RequestBody = null)
        {
            ArgumentNullException.ThrowIfNull(Cluster, "Cluster cannot be null");
            StringBuilder CreateServiceURL = new StringBuilder("/api/vcenter/namespaces/namespace-templates/clusters/{cluster}");
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
            else if ((int)response.StatusCode == 404) { throw new vSphereException("if cluster doesnt exist.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 400) { throw new vSphereException("if the namespace template with given name already exists.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 401) { throw new vSphereException("if the user can not be authenticated.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 403) { throw new vSphereException("if the user does not have Namespaces.SelfServiceManage privilege.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
            
        }
        public async Task<List<VcenterNamespacesNamespaceTemplatesSummaryType>> ListAsync(string Cluster)
        {
            ArgumentNullException.ThrowIfNull(Cluster, "Cluster cannot be null");
            StringBuilder ListServiceURL = new StringBuilder("/api/vcenter/namespaces/namespace-templates/clusters/{cluster}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListServiceURL.Replace("{cluster}", System.Uri.EscapeDataString(Helpers.ConvertToString(Cluster, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ListServiceURL.ToString();
            RestResponse<List<VcenterNamespacesNamespaceTemplatesSummaryType>> response = await restClient.ExecuteTaskAsyncWithPolicy<List<VcenterNamespacesNamespaceTemplatesSummaryType>>(request, cancellationToken, timeout, retry);
            if (200 <= (int)response.StatusCode && (int)response.StatusCode <= 300) { return response.Data; }
            else if ((int)response.StatusCode == 500) { throw new vSphereException("if the system reports an error while responding to the request.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 404) { throw new vSphereException("if cluster doesnt exist.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 401) { throw new vSphereException("if the user can not be authenticated.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 403) { throw new vSphereException("if the user does not have System.Read privilege.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
            return response.Data;
        }
        public async Task<VcenterNamespacesNamespaceTemplatesInfoType> GetAsync(string Cluster, string Template)
        {
            ArgumentNullException.ThrowIfNull(Cluster, "Cluster cannot be null");
            ArgumentNullException.ThrowIfNull(Template, "Template cannot be null");
            StringBuilder GetServiceURL = new StringBuilder("/api/vcenter/namespaces/namespace-templates/clusters/{cluster}/{template}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetServiceURL.Replace("{cluster}", System.Uri.EscapeDataString(Helpers.ConvertToString(Cluster, System.Globalization.CultureInfo.InvariantCulture)));
            GetServiceURL.Replace("{template}", System.Uri.EscapeDataString(Helpers.ConvertToString(Template, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetServiceURL.ToString();
            RestResponse<VcenterNamespacesNamespaceTemplatesInfoType> response = await restClient.ExecuteTaskAsyncWithPolicy<VcenterNamespacesNamespaceTemplatesInfoType>(request, cancellationToken, timeout, retry);
            if (200 <= (int)response.StatusCode && (int)response.StatusCode <= 300) { return response.Data; }
            else if ((int)response.StatusCode == 500) { throw new vSphereException("if the system reports an error while responding to the request.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 404) { throw new vSphereException("if cluster doesnt exist or if template doesnt exist.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 401) { throw new vSphereException("if the user can not be authenticated.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 403) { throw new vSphereException("if the user does not have System.Read privilege.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
            return response.Data;
        }
        public async Task UpdateAsync(string Cluster, string Template, VcenterNamespacesNamespaceTemplatesUpdateType RequestBody = null)
        {
            ArgumentNullException.ThrowIfNull(Cluster, "Cluster cannot be null");
            ArgumentNullException.ThrowIfNull(Template, "Template cannot be null");
            StringBuilder UpdateServiceURL = new StringBuilder("/api/vcenter/namespaces/namespace-templates/clusters/{cluster}/{template}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            UpdateServiceURL.Replace("{cluster}", System.Uri.EscapeDataString(Helpers.ConvertToString(Cluster, System.Globalization.CultureInfo.InvariantCulture)));
            UpdateServiceURL.Replace("{template}", System.Uri.EscapeDataString(Helpers.ConvertToString(Template, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(RequestBody);
            request.Resource = UpdateServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (200 <= (int)response.StatusCode && (int)response.StatusCode <= 300) { }
            else if ((int)response.StatusCode == 500) { throw new vSphereException("if the system reports an error while responding to the request.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 404) { throw new vSphereException("if cluster doesnt exist or if template doesnt exist.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 400) { throw new vSphereException("if spec contain any errors.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 401) { throw new vSphereException("if the user can not be authenticated.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 403) { throw new vSphereException("if the user does not have Namespaces.SelfServiceManage privilege.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
            
        }
    }
}

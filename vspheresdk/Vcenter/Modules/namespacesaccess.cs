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
    public class NamespacesAccessModule
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public NamespacesAccessModule(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
        {
            restClient = Client;
            retry = _retry;
            timeout = _timeout;
            cancellationToken = _cancellationToken;
        }
        public async Task SetAsync(string Namespace, string Domain, string Subject, string Type, VcenterNamespacesAccessSetType RequestBody = null)
        {
            ArgumentNullException.ThrowIfNull(Namespace, "Namespace cannot be null");
            ArgumentNullException.ThrowIfNull(Domain, "Domain cannot be null");
            ArgumentNullException.ThrowIfNull(Subject, "Subject cannot be null");
            ArgumentNullException.ThrowIfNull(Type, "Type cannot be null");
            StringBuilder SetServiceURL = new StringBuilder("/api/vcenter/namespaces/instances/{namespace}/access/{domain}/{subject}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            SetServiceURL.Replace("{namespace}", System.Uri.EscapeDataString(Helpers.ConvertToString(Namespace, System.Globalization.CultureInfo.InvariantCulture)));
            SetServiceURL.Replace("{domain}", System.Uri.EscapeDataString(Helpers.ConvertToString(Domain, System.Globalization.CultureInfo.InvariantCulture)));
            SetServiceURL.Replace("{subject}", System.Uri.EscapeDataString(Helpers.ConvertToString(Subject, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(RequestBody);
            if (Type != null) { request.AddQueryParameter("type", Type.ToString()); }
            request.Resource = SetServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if ((int)response.StatusCode == 204) {}
            else if ((int)response.StatusCode == 500) { throw new vSphereException("if the system reports an error while responding to the request.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 400) { throw new vSphereException("if the specified principal on given domain is not associated with the namespace.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 404) { throw new vSphereException("if namespace cannot be located.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 401) { throw new vSphereException("if the user can not be authenticated.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 403) { throw new vSphereException("if the user does not have Namespaces.Configure privilege or the namespace identifier begins with vmwaresystem prefix.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
        }
        public async Task<VcenterNamespacesAccessInfoType> GetAsync(string Namespace, string Domain, string Subject, string Type)
        {
            ArgumentNullException.ThrowIfNull(Namespace, "Namespace cannot be null");
            ArgumentNullException.ThrowIfNull(Domain, "Domain cannot be null");
            ArgumentNullException.ThrowIfNull(Subject, "Subject cannot be null");
            ArgumentNullException.ThrowIfNull(Type, "Type cannot be null");
            StringBuilder GetServiceURL = new StringBuilder("/api/vcenter/namespaces/instances/{namespace}/access/{domain}/{subject}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetServiceURL.Replace("{namespace}", System.Uri.EscapeDataString(Helpers.ConvertToString(Namespace, System.Globalization.CultureInfo.InvariantCulture)));
            GetServiceURL.Replace("{domain}", System.Uri.EscapeDataString(Helpers.ConvertToString(Domain, System.Globalization.CultureInfo.InvariantCulture)));
            GetServiceURL.Replace("{subject}", System.Uri.EscapeDataString(Helpers.ConvertToString(Subject, System.Globalization.CultureInfo.InvariantCulture)));
            if (Type != null) { request.AddQueryParameter("type", Type.ToString()); }
            request.Resource = GetServiceURL.ToString();
            RestResponse<VcenterNamespacesAccessInfoType> response = await restClient.ExecuteTaskAsyncWithPolicy<VcenterNamespacesAccessInfoType>(request, cancellationToken, timeout, retry);
            if ((int)response.StatusCode == 200) { ArgumentNullException.ThrowIfNull(response.Data) ; return response.Data; }
            else if ((int)response.StatusCode == 500) { throw new vSphereException("if the system reports an error while responding to the request.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 404) { throw new vSphereException("if namespace cannot be located.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 400) { throw new vSphereException("if the specified principal on given domain is not associated with the namespace.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 401) { throw new vSphereException("if the user can not be authenticated.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 403) { throw new vSphereException("if the user does not have System.Read privilege.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
        }
        public async Task CreateAsync(string Namespace, string Domain, string Subject, string Type, VcenterNamespacesAccessCreateType RequestBody = null)
        {
            ArgumentNullException.ThrowIfNull(Namespace, "Namespace cannot be null");
            ArgumentNullException.ThrowIfNull(Domain, "Domain cannot be null");
            ArgumentNullException.ThrowIfNull(Subject, "Subject cannot be null");
            ArgumentNullException.ThrowIfNull(Type, "Type cannot be null");
            StringBuilder CreateServiceURL = new StringBuilder("/api/vcenter/namespaces/instances/{namespace}/access/{domain}/{subject}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            CreateServiceURL.Replace("{namespace}", System.Uri.EscapeDataString(Helpers.ConvertToString(Namespace, System.Globalization.CultureInfo.InvariantCulture)));
            CreateServiceURL.Replace("{domain}", System.Uri.EscapeDataString(Helpers.ConvertToString(Domain, System.Globalization.CultureInfo.InvariantCulture)));
            CreateServiceURL.Replace("{subject}", System.Uri.EscapeDataString(Helpers.ConvertToString(Subject, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(RequestBody);
            if (Type != null) { request.AddQueryParameter("type", Type.ToString()); }
            request.Resource = CreateServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if ((int)response.StatusCode == 204) {}
            else if ((int)response.StatusCode == 400) { throw new vSphereException("if the namespace is marked for deletion or the associated cluster is being disabled.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 500) { throw new vSphereException("if the system reports an error while responding to the request.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 404) { throw new vSphereException("if namespace cannot be located.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 401) { throw new vSphereException("if the user can not be authenticated.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 403) { throw new vSphereException("if the user does not have Namespaces.Configure privilege or the namespace identifier begins with vmwaresystem prefix.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
        }
        public async Task DeleteAsync(string Namespace, string Domain, string Subject, string Type)
        {
            ArgumentNullException.ThrowIfNull(Namespace, "Namespace cannot be null");
            ArgumentNullException.ThrowIfNull(Domain, "Domain cannot be null");
            ArgumentNullException.ThrowIfNull(Subject, "Subject cannot be null");
            ArgumentNullException.ThrowIfNull(Type, "Type cannot be null");
            StringBuilder DeleteServiceURL = new StringBuilder("/api/vcenter/namespaces/instances/{namespace}/access/{domain}/{subject}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteServiceURL.Replace("{namespace}", System.Uri.EscapeDataString(Helpers.ConvertToString(Namespace, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteServiceURL.Replace("{domain}", System.Uri.EscapeDataString(Helpers.ConvertToString(Domain, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteServiceURL.Replace("{subject}", System.Uri.EscapeDataString(Helpers.ConvertToString(Subject, System.Globalization.CultureInfo.InvariantCulture)));
            if (Type != null) { request.AddQueryParameter("type", Type.ToString()); }
            request.Resource = DeleteServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if ((int)response.StatusCode == 204) {}
            else if ((int)response.StatusCode == 500) { throw new vSphereException("if the system reports an error while responding to the request.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 400) { throw new vSphereException("if the specified principal on given domain is not associated with the namespace.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 404) { throw new vSphereException("if namespace cannot be located.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 401) { throw new vSphereException("if the user can not be authenticated.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 403) { throw new vSphereException("if the user does not have Namespaces.Configure privilege or the namespace identifier begins with vmwaresystem prefix.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
        }
    }
}

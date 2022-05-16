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
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Put operation to " + SetServiceURL.ToString() + " did not complete successfull";
                throw new vSphereException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
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
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetServiceURL.ToString() + " did not complete successfull";
                throw new vSphereException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
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
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreateServiceURL.ToString() + " did not complete successfull";
                throw new vSphereException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
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
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteServiceURL.ToString() + " did not complete successfull";
                throw new vSphereException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
    }
}

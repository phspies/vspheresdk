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
using vspheresdk.Vapi.Models;
using vspheresdk.Vapi.Models.Enums;

namespace vspheresdk.Vapi.Modules
{
    public class MetadataCliNamespaceModule
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public MetadataCliNamespaceModule(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
        {
            restClient = Client;
            retry = _retry;
            timeout = _timeout;
            cancellationToken = _cancellationToken;
        }
        public async Task<List<VapiMetadataCliNamespaceIdentityType>> ListAsync()
        {
            StringBuilder ListServiceURL = new StringBuilder("/api/vapi/metadata/cli/namespace");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = ListServiceURL.ToString();
            RestResponse<List<VapiMetadataCliNamespaceIdentityType>> response = await restClient.ExecuteTaskAsyncWithPolicy<List<VapiMetadataCliNamespaceIdentityType>>(request, cancellationToken, timeout, retry);
            if (200 <= (int)response.StatusCode && (int)response.StatusCode <= 300) { return response.Data; }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
            return response.Data;
        }
        public async Task<string> FingerprintAsync()
        {
            StringBuilder FingerprintServiceURL = new StringBuilder("/api/vapi/metadata/cli/namespace/fingerprint");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = FingerprintServiceURL.ToString();
            RestResponse<string> response = await restClient.ExecuteTaskAsyncWithPolicy<string>(request, cancellationToken, timeout, retry);
            if (200 <= (int)response.StatusCode && (int)response.StatusCode <= 300) { return response.Data; }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
            return response.Data;
        }
        public async Task<VapiMetadataCliNamespaceInfoType> GetAsync(VapiMetadataCliNamespaceGetType RequestBody)
        {
            ArgumentNullException.ThrowIfNull(RequestBody, "RequestBody cannot be null");
            StringBuilder GetServiceURL = new StringBuilder("/api/vapi/metadata/cli/namespace?action=get");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(RequestBody);
            request.Resource = GetServiceURL.ToString();
            RestResponse<VapiMetadataCliNamespaceInfoType> response = await restClient.ExecuteTaskAsyncWithPolicy<VapiMetadataCliNamespaceInfoType>(request, cancellationToken, timeout, retry);
            if (200 <= (int)response.StatusCode && (int)response.StatusCode <= 300) { return response.Data; }
            else if ((int)response.StatusCode == 404) { throw new vSphereException("if a namespace corresponding to param.name identity doesnt exist.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
            return response.Data;
        }
    }
}
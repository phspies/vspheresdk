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

namespace vspheresdk.Vapi.Modules
{
    public class MetadataMetamodelComponentModule
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public MetadataMetamodelComponentModule(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
        {
            restClient = Client;
            retry = _retry;
            timeout = _timeout;
            cancellationToken = _cancellationToken;
        }
        public async Task<List<string>> ListAsync()
        {
            StringBuilder ListServiceURL = new StringBuilder("/api/vapi/metadata/metamodel/component");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = ListServiceURL.ToString();
            RestResponse<List<string>> response = await restClient.ExecuteTaskAsyncWithPolicy<List<string>>(request, cancellationToken, timeout, retry);
            if ((int)response.StatusCode == 200) { ArgumentNullException.ThrowIfNull(response.Data) ; return response.Data; }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
        }
        public async Task<VapiMetadataMetamodelComponentDataType> GetAsync(string ComponentId)
        {
            ArgumentNullException.ThrowIfNull(ComponentId, "ComponentId cannot be null");
            StringBuilder GetServiceURL = new StringBuilder("/api/vapi/metadata/metamodel/component/{component_id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetServiceURL.Replace("{component_id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ComponentId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetServiceURL.ToString();
            RestResponse<VapiMetadataMetamodelComponentDataType> response = await restClient.ExecuteTaskAsyncWithPolicy<VapiMetadataMetamodelComponentDataType>(request, cancellationToken, timeout, retry);
            if ((int)response.StatusCode == 200) { ArgumentNullException.ThrowIfNull(response.Data) ; return response.Data; }
            else if ((int)response.StatusCode == 404) { throw new vSphereException("if the component element associated with param.name componentId is not registered with the infrastructure.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
        }
        public async Task<string> FingerprintAsync(string ComponentId)
        {
            ArgumentNullException.ThrowIfNull(ComponentId, "ComponentId cannot be null");
            StringBuilder FingerprintServiceURL = new StringBuilder("/api/vapi/metadata/metamodel/component/{component_id}/fingerprint");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            FingerprintServiceURL.Replace("{component_id}", System.Uri.EscapeDataString(Helpers.ConvertToString(ComponentId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = FingerprintServiceURL.ToString();
            RestResponse<string> response = await restClient.ExecuteTaskAsyncWithPolicy<string>(request, cancellationToken, timeout, retry);
            if ((int)response.StatusCode == 200) { ArgumentNullException.ThrowIfNull(response.Data) ; return response.Data; }
            else if ((int)response.StatusCode == 404) { throw new vSphereException("if the component element associated with param.name componentId is not registered with the infrastructure.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
        }
    }
}

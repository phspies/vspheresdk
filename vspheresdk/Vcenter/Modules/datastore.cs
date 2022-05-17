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
    public class DatastoreModule
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public DatastoreModule(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
        {
            restClient = Client;
            retry = _retry;
            timeout = _timeout;
            cancellationToken = _cancellationToken;
        }
        public async Task<List<VcenterDatastoreSummaryType>> ListAsync(string Datastores = null, string Names = null, string Types = null, string Folders = null, string Datacenters = null)
        {
            StringBuilder ListServiceURL = new StringBuilder("/api/vcenter/datastore");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Datastores != null) { request.AddQueryParameter("datastores", Datastores.ToString()); }
            if (Names != null) { request.AddQueryParameter("names", Names.ToString()); }
            if (Types != null) { request.AddQueryParameter("types", Types.ToString()); }
            if (Folders != null) { request.AddQueryParameter("folders", Folders.ToString()); }
            if (Datacenters != null) { request.AddQueryParameter("datacenters", Datacenters.ToString()); }
            request.Resource = ListServiceURL.ToString();
            RestResponse<List<VcenterDatastoreSummaryType>> response = await restClient.ExecuteTaskAsyncWithPolicy<List<VcenterDatastoreSummaryType>>(request, cancellationToken, timeout, retry);
            if ((int)response.StatusCode == 200) { ArgumentNullException.ThrowIfNull(response.Data) ; return response.Data; }
            else if ((int)response.StatusCode == 400) { throw new vSphereException("if the Datastore.FilterSpec.types field contains a value that is not supported by the server.if the Datastore.FilterSpec.types field contains a value that is not supported by the server.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 500) { throw new vSphereException("if more than 2500 datastores match the Datastore.FilterSpec.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 503) { throw new vSphereException("if the system is unable to communicate with a service to complete the request.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 401) { throw new vSphereException("if the user can not be authenticated.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 403) { throw new vSphereException("if the user doesnt have the required privileges.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
        }
        public async Task<VcenterDatastoreInfoType> GetAsync(string Datastore)
        {
            ArgumentNullException.ThrowIfNull(Datastore, "Datastore cannot be null");
            StringBuilder GetServiceURL = new StringBuilder("/api/vcenter/datastore/{datastore}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetServiceURL.Replace("{datastore}", System.Uri.EscapeDataString(Helpers.ConvertToString(Datastore, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetServiceURL.ToString();
            RestResponse<VcenterDatastoreInfoType> response = await restClient.ExecuteTaskAsyncWithPolicy<VcenterDatastoreInfoType>(request, cancellationToken, timeout, retry);
            if ((int)response.StatusCode == 200) { ArgumentNullException.ThrowIfNull(response.Data) ; return response.Data; }
            else if ((int)response.StatusCode == 404) { throw new vSphereException("if the datastore indicated by datastore does not exist.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 503) { throw new vSphereException("if the system is unable to communicate with a service to complete the request.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 401) { throw new vSphereException("if the user can not be authenticated.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 403) { throw new vSphereException("if the user doesnt have the required privileges.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
        }
    }
}

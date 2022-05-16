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
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListServiceURL.ToString() + " did not complete successfull";
                throw new vSphereException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
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
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetServiceURL.ToString() + " did not complete successfull";
                throw new vSphereException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}

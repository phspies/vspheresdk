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
    public class NetworkModule
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public NetworkModule(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
        {
            restClient = Client;
            retry = _retry;
            timeout = _timeout;
            cancellationToken = _cancellationToken;
        }
        public async Task<List<VcenterNetworkSummaryType>> ListAsync(string Networks = null, string Names = null, string Types = null, string Folders = null, string Datacenters = null)
        {
            StringBuilder ListServiceURL = new StringBuilder("/api/vcenter/network");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Networks != null) { request.AddQueryParameter("networks", Networks.ToString()); }
            if (Names != null) { request.AddQueryParameter("names", Names.ToString()); }
            if (Types != null) { request.AddQueryParameter("types", Types.ToString()); }
            if (Folders != null) { request.AddQueryParameter("folders", Folders.ToString()); }
            if (Datacenters != null) { request.AddQueryParameter("datacenters", Datacenters.ToString()); }
            request.Resource = ListServiceURL.ToString();
            RestResponse<List<VcenterNetworkSummaryType>> response = await restClient.ExecuteTaskAsyncWithPolicy<List<VcenterNetworkSummaryType>>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListServiceURL.ToString() + " did not complete successfull";
                throw new vSphereException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}

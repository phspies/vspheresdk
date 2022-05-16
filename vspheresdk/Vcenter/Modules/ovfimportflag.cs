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
    public class OvfImportFlagModule
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public OvfImportFlagModule(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
        {
            restClient = Client;
            retry = _retry;
            timeout = _timeout;
            cancellationToken = _cancellationToken;
        }
        public async Task<List<VcenterOvfImportFlagInfoType>> ListAsync(string Rp)
        {
            ArgumentNullException.ThrowIfNull(Rp, "Rp cannot be null");
            StringBuilder ListServiceURL = new StringBuilder("/api/vcenter/ovf/import-flag");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Rp != null) { request.AddQueryParameter("rp", Rp.ToString()); }
            request.Resource = ListServiceURL.ToString();
            RestResponse<List<VcenterOvfImportFlagInfoType>> response = await restClient.ExecuteTaskAsyncWithPolicy<List<VcenterOvfImportFlagInfoType>>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListServiceURL.ToString() + " did not complete successfull";
                throw new vSphereException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}

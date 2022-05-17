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
            if ((int)response.StatusCode == 200) { ArgumentNullException.ThrowIfNull(response.Data) ; return response.Data; }
            else if ((int)response.StatusCode == 404) { throw new vSphereException("If the resource pool associated with param.name rp does not exist.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
        }
    }
}

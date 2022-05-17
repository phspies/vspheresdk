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
    public class TaggingAssociationsModule
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public TaggingAssociationsModule(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
        {
            restClient = Client;
            retry = _retry;
            timeout = _timeout;
            cancellationToken = _cancellationToken;
        }
        public async Task<VcenterTaggingAssociationsListResultType> ListAsync(string? Marker = null)
        {
            StringBuilder ListServiceURL = new StringBuilder("/api/vcenter/tagging/associations");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Marker != null) { request.AddQueryParameter("marker", Marker.ToString()); }
            request.Resource = ListServiceURL.ToString();
            RestResponse<VcenterTaggingAssociationsListResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<VcenterTaggingAssociationsListResultType>(request, cancellationToken, timeout, retry);
            if (200 <= (int)response.StatusCode && (int)response.StatusCode <= 300) { return response.Data; }
            else if ((int)response.StatusCode == 400) { throw new vSphereException("if Associations.IterationSpec.marker is not a marker returned from an earlier invocation of this term operation.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 403) { throw new vSphereException("if the user doesnt have the required privileges.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
            return response.Data;
        }
    }
}

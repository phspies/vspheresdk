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
    public class FolderModule
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public FolderModule(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
        {
            restClient = Client;
            retry = _retry;
            timeout = _timeout;
            cancellationToken = _cancellationToken;
        }
        public async Task<List<VcenterFolderSummaryType>> ListAsync(string Folders = null, string Names = null, string? Type = null, string ParentFolders = null, string Datacenters = null)
        {
            StringBuilder ListServiceURL = new StringBuilder("/api/vcenter/folder");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Folders != null) { request.AddQueryParameter("folders", Folders.ToString()); }
            if (Names != null) { request.AddQueryParameter("names", Names.ToString()); }
            if (Type != null) { request.AddQueryParameter("type", Type.ToString()); }
            if (ParentFolders != null) { request.AddQueryParameter("parent_folders", ParentFolders.ToString()); }
            if (Datacenters != null) { request.AddQueryParameter("datacenters", Datacenters.ToString()); }
            request.Resource = ListServiceURL.ToString();
            RestResponse<List<VcenterFolderSummaryType>> response = await restClient.ExecuteTaskAsyncWithPolicy<List<VcenterFolderSummaryType>>(request, cancellationToken, timeout, retry);
            if (200 <= (int)response.StatusCode && (int)response.StatusCode <= 300) { return response.Data; }
            else if ((int)response.StatusCode == 400) { throw new vSphereException("if the Folder.FilterSpec.type field contains a value that is not supported by the server.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 500) { throw new vSphereException("if more than 1000 folders match the Folder.FilterSpec.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 503) { throw new vSphereException("if the system is unable to communicate with a service to complete the request.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 401) { throw new vSphereException("if the user can not be authenticated.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 403) { throw new vSphereException("if the user doesnt have the required privileges.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
            return response.Data;
        }
    }
}

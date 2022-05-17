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
    public class OvfLibraryItemModule
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public OvfLibraryItemModule(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
        {
            restClient = Client;
            retry = _retry;
            timeout = _timeout;
            cancellationToken = _cancellationToken;
        }
        public async Task<VcenterOvfLibraryItemCreateResultType> CreateAsync(VcenterOvfLibraryItemCreateType RequestBody, string? ClientToken = null)
        {
            ArgumentNullException.ThrowIfNull(RequestBody, "RequestBody cannot be null");
            StringBuilder CreateServiceURL = new StringBuilder("/api/vcenter/ovf/library-item");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(RequestBody);
            if (ClientToken != null) { request.AddQueryParameter("client_token", ClientToken.ToString()); }
            request.Resource = CreateServiceURL.ToString();
            RestResponse<VcenterOvfLibraryItemCreateResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<VcenterOvfLibraryItemCreateResultType>(request, cancellationToken, timeout, retry);
            if ((int)response.StatusCode == 201) { ArgumentNullException.ThrowIfNull(response.Data) ; return response.Data; }
            else if ((int)response.StatusCode == 400) { throw new vSphereException("if the operation cannot be performed because of the specified virtual machine or virtual appliances current state. For example if the virtual machine configuration information is not available or if the virtual appliance is running.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 404) { throw new vSphereException("if the virtual machine or virtual appliance specified by param.name source does not exist.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 500) { throw new vSphereException("if the specified virtual machine or virtual appliance is busy.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
        }
        public async Task<VcenterOvfLibraryItemDeploymentResultType> DeployAsync(string OvfLibraryItemId, VcenterOvfLibraryItemDeployType RequestBody, string? ClientToken = null)
        {
            ArgumentNullException.ThrowIfNull(OvfLibraryItemId, "OvfLibraryItemId cannot be null");
            ArgumentNullException.ThrowIfNull(RequestBody, "RequestBody cannot be null");
            StringBuilder DeployServiceURL = new StringBuilder("/api/vcenter/ovf/library-item/{ovf_library_item_id}?action=deploy");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            DeployServiceURL.Replace("{ovf_library_item_id}", System.Uri.EscapeDataString(Helpers.ConvertToString(OvfLibraryItemId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(RequestBody);
            if (ClientToken != null) { request.AddQueryParameter("client_token", ClientToken.ToString()); }
            request.Resource = DeployServiceURL.ToString();
            RestResponse<VcenterOvfLibraryItemDeploymentResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<VcenterOvfLibraryItemDeploymentResultType>(request, cancellationToken, timeout, retry);
            if ((int)response.StatusCode == 200) { ArgumentNullException.ThrowIfNull(response.Data) ; return response.Data; }
            else if ((int)response.StatusCode == 400) { throw new vSphereException("if param.name target contains invalid arguments.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 404) { throw new vSphereException("if the library item specified by param.name ovfLibraryItemId does not exist.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 500) { throw new vSphereException("if there was an error accessing the OVF package stored in the library item specified by param.name ovfLibraryItemId.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 403) { throw new vSphereException("if you do not have all of the privileges described as follows  ul literm Operation execution requires VirtualMachine.Config.AddNewDisk if the OVF descriptor has a disk drive type 17 section. li literm Operation execution requires VirtualMachine.Config.AdvancedConfig if the OVF descriptor has an ExtraConfig section. li literm Operation execution requires Extension.Register for specified resource group if the OVF descriptor has a vServiceDependency section. li literm Operation execution requires Network.Assign for target network if specified. li literm Operation execution requires Datastore.AllocateSpace for target datastore if specified. li ul", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
        }
        public async Task<VcenterOvfLibraryItemOvfSummaryType> FilterAsync(string OvfLibraryItemId, VcenterOvfLibraryItemFilterType RequestBody)
        {
            ArgumentNullException.ThrowIfNull(OvfLibraryItemId, "OvfLibraryItemId cannot be null");
            ArgumentNullException.ThrowIfNull(RequestBody, "RequestBody cannot be null");
            StringBuilder FilterServiceURL = new StringBuilder("/api/vcenter/ovf/library-item/{ovf_library_item_id}?action=filter");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            FilterServiceURL.Replace("{ovf_library_item_id}", System.Uri.EscapeDataString(Helpers.ConvertToString(OvfLibraryItemId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(RequestBody);
            request.Resource = FilterServiceURL.ToString();
            RestResponse<VcenterOvfLibraryItemOvfSummaryType> response = await restClient.ExecuteTaskAsyncWithPolicy<VcenterOvfLibraryItemOvfSummaryType>(request, cancellationToken, timeout, retry);
            if ((int)response.StatusCode == 200) { ArgumentNullException.ThrowIfNull(response.Data) ; return response.Data; }
            else if ((int)response.StatusCode == 400) { throw new vSphereException("if param.name target contains invalid arguments.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 404) { throw new vSphereException("if the library item specified by param.name ovfLibraryItemId does not exist.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 500) { throw new vSphereException("if there was an error accessing the OVF package at the specified param.name ovfLibraryItemId.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
        }
    }
}

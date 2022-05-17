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
    public class VmGuestCustomizationModule
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public VmGuestCustomizationModule(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
        {
            restClient = Client;
            retry = _retry;
            timeout = _timeout;
            cancellationToken = _cancellationToken;
        }
        public async Task SetAsync(string Vm, VcenterVmGuestCustomizationSetType RequestBody = null)
        {
            ArgumentNullException.ThrowIfNull(Vm, "Vm cannot be null");
            StringBuilder SetServiceURL = new StringBuilder("/api/vcenter/vm/{vm}/guest/customization");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Put
            };
            SetServiceURL.Replace("{vm}", System.Uri.EscapeDataString(Helpers.ConvertToString(Vm, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(RequestBody);
            request.Resource = SetServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (200 <= (int)response.StatusCode && (int)response.StatusCode <= 300) { }
            else if ((int)response.StatusCode == 400) { throw new vSphereException("if the virtual machine vm is not in a powered off state.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 404) { throw new vSphereException("if a customization specification is not found with the unique name in spec.If the virtual machine vm is not found.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 503) { throw new vSphereException("if the system is unable to communicate with a service to complete the request.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 401) { throw new vSphereException("if the user can not be authenticated.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 403) { throw new vSphereException("if the user doesnt have the required privileges.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
            
        }
        public async Task<VcenterVmGuestCustomizationInfoType> GetAsync(string Vm)
        {
            ArgumentNullException.ThrowIfNull(Vm, "Vm cannot be null");
            StringBuilder GetServiceURL = new StringBuilder("/api/vcenter/vm/{vm}/guest/customization");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetServiceURL.Replace("{vm}", System.Uri.EscapeDataString(Helpers.ConvertToString(Vm, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetServiceURL.ToString();
            RestResponse<VcenterVmGuestCustomizationInfoType> response = await restClient.ExecuteTaskAsyncWithPolicy<VcenterVmGuestCustomizationInfoType>(request, cancellationToken, timeout, retry);
            if (200 <= (int)response.StatusCode && (int)response.StatusCode <= 300) { return response.Data; }
            else if ((int)response.StatusCode == 404) { throw new vSphereException("If the virtual machine vm is not found.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 503) { throw new vSphereException("if the system is unable to communicate with a service to complete the request.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 401) { throw new vSphereException("if the user can not be authenticated.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 403) { throw new vSphereException("if the user doesnt have the required privileges.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
            return response.Data;
        }
    }
}

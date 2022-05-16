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
    public class VmTemplateLibraryItemsCheckOutsModule
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public VmTemplateLibraryItemsCheckOutsModule(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
        {
            restClient = Client;
            retry = _retry;
            timeout = _timeout;
            cancellationToken = _cancellationToken;
        }
        public async Task<List<VcenterVmTemplateLibraryItemsCheckOutsSummaryType>> ListAsync(string TemplateLibraryItem)
        {
            ArgumentNullException.ThrowIfNull(TemplateLibraryItem, "TemplateLibraryItem cannot be null");
            StringBuilder ListServiceURL = new StringBuilder("/api/vcenter/vm-template/library-items/{template_library_item}/check-outs");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListServiceURL.Replace("{template_library_item}", System.Uri.EscapeDataString(Helpers.ConvertToString(TemplateLibraryItem, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ListServiceURL.ToString();
            RestResponse<List<VcenterVmTemplateLibraryItemsCheckOutsSummaryType>> response = await restClient.ExecuteTaskAsyncWithPolicy<List<VcenterVmTemplateLibraryItemsCheckOutsSummaryType>>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListServiceURL.ToString() + " did not complete successfull";
                throw new vSphereException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        public async Task<VcenterVmTemplateLibraryItemsCheckOutsInfoType> GetAsync(string TemplateLibraryItem, string Vm)
        {
            ArgumentNullException.ThrowIfNull(TemplateLibraryItem, "TemplateLibraryItem cannot be null");
            ArgumentNullException.ThrowIfNull(Vm, "Vm cannot be null");
            StringBuilder GetServiceURL = new StringBuilder("/api/vcenter/vm-template/library-items/{template_library_item}/check-outs/{vm}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetServiceURL.Replace("{template_library_item}", System.Uri.EscapeDataString(Helpers.ConvertToString(TemplateLibraryItem, System.Globalization.CultureInfo.InvariantCulture)));
            GetServiceURL.Replace("{vm}", System.Uri.EscapeDataString(Helpers.ConvertToString(Vm, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetServiceURL.ToString();
            RestResponse<VcenterVmTemplateLibraryItemsCheckOutsInfoType> response = await restClient.ExecuteTaskAsyncWithPolicy<VcenterVmTemplateLibraryItemsCheckOutsInfoType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetServiceURL.ToString() + " did not complete successfull";
                throw new vSphereException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        public async Task DeleteAsync(string TemplateLibraryItem, string Vm)
        {
            ArgumentNullException.ThrowIfNull(TemplateLibraryItem, "TemplateLibraryItem cannot be null");
            ArgumentNullException.ThrowIfNull(Vm, "Vm cannot be null");
            StringBuilder DeleteServiceURL = new StringBuilder("/api/vcenter/vm-template/library-items/{template_library_item}/check-outs/{vm}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteServiceURL.Replace("{template_library_item}", System.Uri.EscapeDataString(Helpers.ConvertToString(TemplateLibraryItem, System.Globalization.CultureInfo.InvariantCulture)));
            DeleteServiceURL.Replace("{vm}", System.Uri.EscapeDataString(Helpers.ConvertToString(Vm, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteServiceURL.ToString() + " did not complete successfull";
                throw new vSphereException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        public async Task<string> CheckInAsync(string TemplateLibraryItem, string Vm, VcenterVmTemplateLibraryItemsCheckOutsCheckInType RequestBody = null)
        {
            ArgumentNullException.ThrowIfNull(TemplateLibraryItem, "TemplateLibraryItem cannot be null");
            ArgumentNullException.ThrowIfNull(Vm, "Vm cannot be null");
            StringBuilder CheckInServiceURL = new StringBuilder("/api/vcenter/vm-template/library-items/{template_library_item}/check-outs/{vm}?action=check-in");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            CheckInServiceURL.Replace("{template_library_item}", System.Uri.EscapeDataString(Helpers.ConvertToString(TemplateLibraryItem, System.Globalization.CultureInfo.InvariantCulture)));
            CheckInServiceURL.Replace("{vm}", System.Uri.EscapeDataString(Helpers.ConvertToString(Vm, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(RequestBody);
            request.Resource = CheckInServiceURL.ToString();
            RestResponse<string> response = await restClient.ExecuteTaskAsyncWithPolicy<string>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CheckInServiceURL.ToString() + " did not complete successfull";
                throw new vSphereException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        public async Task<string> CheckOutAsync(string TemplateLibraryItem, VcenterVmTemplateLibraryItemsCheckOutsCheckOutType RequestBody = null)
        {
            ArgumentNullException.ThrowIfNull(TemplateLibraryItem, "TemplateLibraryItem cannot be null");
            StringBuilder CheckOutServiceURL = new StringBuilder("/api/vcenter/vm-template/library-items/{template_library_item}/check-outs?action=check-out");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            CheckOutServiceURL.Replace("{template_library_item}", System.Uri.EscapeDataString(Helpers.ConvertToString(TemplateLibraryItem, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(RequestBody);
            request.Resource = CheckOutServiceURL.ToString();
            RestResponse<string> response = await restClient.ExecuteTaskAsyncWithPolicy<string>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CheckOutServiceURL.ToString() + " did not complete successfull";
                throw new vSphereException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}

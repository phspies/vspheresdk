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
using vspheresdk.Library.Models;

namespace vspheresdk.Library.Modules
{
    public class LibraryItemUpdatesessionFileModule
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public LibraryItemUpdatesessionFileModule(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
        {
            restClient = Client;
            retry = _retry;
            timeout = _timeout;
            cancellationToken = _cancellationToken;
        }
        public async Task<ContentLibraryItemUpdatesessionFileInfoType> AddAsync(string UpdateSessionId, ContentLibraryItemUpdatesessionFileAddType RequestBody = null)
        {
            ArgumentNullException.ThrowIfNull(UpdateSessionId, "UpdateSessionId cannot be null");
            StringBuilder AddServiceURL = new StringBuilder("/api/content/library/item/update-session/{update_session_id}/file");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            AddServiceURL.Replace("{update_session_id}", System.Uri.EscapeDataString(Helpers.ConvertToString(UpdateSessionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(RequestBody);
            request.Resource = AddServiceURL.ToString();
            RestResponse<ContentLibraryItemUpdatesessionFileInfoType> response = await restClient.ExecuteTaskAsyncWithPolicy<ContentLibraryItemUpdatesessionFileInfoType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + AddServiceURL.ToString() + " did not complete successfull";
                throw new vSphereException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        public async Task<List<ContentLibraryItemUpdatesessionFileInfoType>> ListAsync(string UpdateSessionId)
        {
            ArgumentNullException.ThrowIfNull(UpdateSessionId, "UpdateSessionId cannot be null");
            StringBuilder ListServiceURL = new StringBuilder("/api/content/library/item/update-session/{update_session_id}/file");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListServiceURL.Replace("{update_session_id}", System.Uri.EscapeDataString(Helpers.ConvertToString(UpdateSessionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ListServiceURL.ToString();
            RestResponse<List<ContentLibraryItemUpdatesessionFileInfoType>> response = await restClient.ExecuteTaskAsyncWithPolicy<List<ContentLibraryItemUpdatesessionFileInfoType>>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListServiceURL.ToString() + " did not complete successfull";
                throw new vSphereException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        public async Task<ContentLibraryItemUpdatesessionFileInfoType> GetAsync(string UpdateSessionId, string FileName)
        {
            ArgumentNullException.ThrowIfNull(UpdateSessionId, "UpdateSessionId cannot be null");
            ArgumentNullException.ThrowIfNull(FileName, "FileName cannot be null");
            StringBuilder GetServiceURL = new StringBuilder("/api/content/library/item/update-session/{update_session_id}/file/{file_name}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetServiceURL.Replace("{update_session_id}", System.Uri.EscapeDataString(Helpers.ConvertToString(UpdateSessionId, System.Globalization.CultureInfo.InvariantCulture)));
            GetServiceURL.Replace("{file_name}", System.Uri.EscapeDataString(Helpers.ConvertToString(FileName, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetServiceURL.ToString();
            RestResponse<ContentLibraryItemUpdatesessionFileInfoType> response = await restClient.ExecuteTaskAsyncWithPolicy<ContentLibraryItemUpdatesessionFileInfoType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetServiceURL.ToString() + " did not complete successfull";
                throw new vSphereException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        public async Task RemoveAsync(string UpdateSessionId, string FileName)
        {
            ArgumentNullException.ThrowIfNull(UpdateSessionId, "UpdateSessionId cannot be null");
            ArgumentNullException.ThrowIfNull(FileName, "FileName cannot be null");
            StringBuilder RemoveServiceURL = new StringBuilder("/api/content/library/item/update-session/{update_session_id}/file/{file_name}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            RemoveServiceURL.Replace("{update_session_id}", System.Uri.EscapeDataString(Helpers.ConvertToString(UpdateSessionId, System.Globalization.CultureInfo.InvariantCulture)));
            RemoveServiceURL.Replace("{file_name}", System.Uri.EscapeDataString(Helpers.ConvertToString(FileName, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = RemoveServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + RemoveServiceURL.ToString() + " did not complete successfull";
                throw new vSphereException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        public async Task<ContentLibraryItemUpdatesessionFileValidationResultType> ValidateAsync(string UpdateSessionId)
        {
            ArgumentNullException.ThrowIfNull(UpdateSessionId, "UpdateSessionId cannot be null");
            StringBuilder ValidateServiceURL = new StringBuilder("/api/content/library/item/update-session/{update_session_id}/file?action=validate");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            ValidateServiceURL.Replace("{update_session_id}", System.Uri.EscapeDataString(Helpers.ConvertToString(UpdateSessionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ValidateServiceURL.ToString();
            RestResponse<ContentLibraryItemUpdatesessionFileValidationResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<ContentLibraryItemUpdatesessionFileValidationResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + ValidateServiceURL.ToString() + " did not complete successfull";
                throw new vSphereException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}

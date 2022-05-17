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
using vspheresdk.Cis.Models;
using vspheresdk.Cis.Models.Enums;

namespace vspheresdk.Cis.Modules
{
    public class TaggingTagModule
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public TaggingTagModule(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
        {
            restClient = Client;
            retry = _retry;
            timeout = _timeout;
            cancellationToken = _cancellationToken;
        }
        public async Task<string> CreateAsync(CisTaggingTagCreateType RequestBody = null)
        {
            StringBuilder CreateServiceURL = new StringBuilder("/api/cis/tagging/tag");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(RequestBody);
            request.Resource = CreateServiceURL.ToString();
            RestResponse<string> response = await restClient.ExecuteTaskAsyncWithPolicy<string>(request, cancellationToken, timeout, retry);
            if (200 <= (int)response.StatusCode && (int)response.StatusCode <= 300) { return response.Data; }
            else if ((int)response.StatusCode == 400) { throw new vSphereException("if any of the input information in the createSpec is invalid.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 404) { throw new vSphereException("if the category for in the given createSpec does not exist in the system.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 403) { throw new vSphereException("if you do not have the privilege to create tag.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
            return response.Data;
        }
        public async Task<List<string>> ListAsync()
        {
            StringBuilder ListServiceURL = new StringBuilder("/api/cis/tagging/tag");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            request.Resource = ListServiceURL.ToString();
            RestResponse<List<string>> response = await restClient.ExecuteTaskAsyncWithPolicy<List<string>>(request, cancellationToken, timeout, retry);
            if (200 <= (int)response.StatusCode && (int)response.StatusCode <= 300) { return response.Data; }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
            return response.Data;
        }
        public async Task<CisTaggingTagModelType> GetAsync(string TagId)
        {
            ArgumentNullException.ThrowIfNull(TagId, "TagId cannot be null");
            StringBuilder GetServiceURL = new StringBuilder("/api/cis/tagging/tag/{tag_id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetServiceURL.Replace("{tag_id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TagId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetServiceURL.ToString();
            RestResponse<CisTaggingTagModelType> response = await restClient.ExecuteTaskAsyncWithPolicy<CisTaggingTagModelType>(request, cancellationToken, timeout, retry);
            if (200 <= (int)response.StatusCode && (int)response.StatusCode <= 300) { return response.Data; }
            else if ((int)response.StatusCode == 404) { throw new vSphereException("if the tag for the given tagId does not exist in the system.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 403) { throw new vSphereException("if the user does not have the privilege to read the tag.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
            return response.Data;
        }
        public async Task UpdateAsync(string TagId, CisTaggingTagUpdateType RequestBody = null)
        {
            ArgumentNullException.ThrowIfNull(TagId, "TagId cannot be null");
            StringBuilder UpdateServiceURL = new StringBuilder("/api/cis/tagging/tag/{tag_id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            UpdateServiceURL.Replace("{tag_id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TagId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(RequestBody);
            request.Resource = UpdateServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (200 <= (int)response.StatusCode && (int)response.StatusCode <= 300) { }
            else if ((int)response.StatusCode == 400) { throw new vSphereException("if any of the input information in the updateSpec is invalid.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 404) { throw new vSphereException("if the tag for the given tagId does not exist in the system.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 403) { throw new vSphereException("if you do not have the privilege to update the tag.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
            
        }
        public async Task DeleteAsync(string TagId)
        {
            ArgumentNullException.ThrowIfNull(TagId, "TagId cannot be null");
            StringBuilder DeleteServiceURL = new StringBuilder("/api/cis/tagging/tag/{tag_id}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteServiceURL.Replace("{tag_id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TagId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (200 <= (int)response.StatusCode && (int)response.StatusCode <= 300) { }
            else if ((int)response.StatusCode == 404) { throw new vSphereException("if the tag for the given tagId does not exist in the system.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 403) { throw new vSphereException("if you do not have the privilege to delete the tag.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 401) { throw new vSphereException("if the user can not be authenticated.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
            
        }
        public async Task AddToUsedByAsync(string TagId, CisTaggingTagAddToUsedByType RequestBody)
        {
            ArgumentNullException.ThrowIfNull(TagId, "TagId cannot be null");
            ArgumentNullException.ThrowIfNull(RequestBody, "RequestBody cannot be null");
            StringBuilder AddToUsedByServiceURL = new StringBuilder("/api/cis/tagging/tag/{tag_id}?action=add-to-used-by");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            AddToUsedByServiceURL.Replace("{tag_id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TagId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(RequestBody);
            request.Resource = AddToUsedByServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (200 <= (int)response.StatusCode && (int)response.StatusCode <= 300) { }
            else if ((int)response.StatusCode == 404) { throw new vSphereException("if the tag for the given tagId does not exist in the system.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 403) { throw new vSphereException("if you do not have the privilege to add an entity to the TagModel.usedby field.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
            
        }
        public async Task RemoveFromUsedByAsync(string TagId, CisTaggingTagRemoveFromUsedByType RequestBody)
        {
            ArgumentNullException.ThrowIfNull(TagId, "TagId cannot be null");
            ArgumentNullException.ThrowIfNull(RequestBody, "RequestBody cannot be null");
            StringBuilder RemoveFromUsedByServiceURL = new StringBuilder("/api/cis/tagging/tag/{tag_id}?action=remove-from-used-by");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            RemoveFromUsedByServiceURL.Replace("{tag_id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TagId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(RequestBody);
            request.Resource = RemoveFromUsedByServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (200 <= (int)response.StatusCode && (int)response.StatusCode <= 300) { }
            else if ((int)response.StatusCode == 404) { throw new vSphereException("if the tag for the given tagId does not exist in the system.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 403) { throw new vSphereException("if you do not have the privilege to remove an entity from the TagModel.usedby field.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
            
        }
        public async Task RevokePropagatingPermissionsAsync(string TagId)
        {
            ArgumentNullException.ThrowIfNull(TagId, "TagId cannot be null");
            StringBuilder RevokePropagatingPermissionsServiceURL = new StringBuilder("/api/cis/tagging/tag/{tag_id}?action=revoke-propagating-permissions");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            RevokePropagatingPermissionsServiceURL.Replace("{tag_id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TagId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = RevokePropagatingPermissionsServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (200 <= (int)response.StatusCode && (int)response.StatusCode <= 300) { }
            else if ((int)response.StatusCode == 404) { throw new vSphereException("if the tag for the given tagId does not exist in the system.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 403) { throw new vSphereException("if you do not have the privilege to revoke propagating permissions on the tag.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
            
        }
        public async Task<List<string>> ListTagsForCategoryAsync(CisTaggingTagListTagsForCategoryType RequestBody)
        {
            ArgumentNullException.ThrowIfNull(RequestBody, "RequestBody cannot be null");
            StringBuilder ListTagsForCategoryServiceURL = new StringBuilder("/api/cis/tagging/tag?action=list-tags-for-category");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(RequestBody);
            request.Resource = ListTagsForCategoryServiceURL.ToString();
            RestResponse<List<string>> response = await restClient.ExecuteTaskAsyncWithPolicy<List<string>>(request, cancellationToken, timeout, retry);
            if (200 <= (int)response.StatusCode && (int)response.StatusCode <= 300) { return response.Data; }
            else if ((int)response.StatusCode == 404) { throw new vSphereException("if the category for the given categoryId does not exist in the system.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 403) { throw new vSphereException("if you do not have the privilege to read the category.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
            return response.Data;
        }
        public async Task<List<string>> ListUsedTagsAsync(CisTaggingTagListUsedTagsType RequestBody)
        {
            ArgumentNullException.ThrowIfNull(RequestBody, "RequestBody cannot be null");
            StringBuilder ListUsedTagsServiceURL = new StringBuilder("/api/cis/tagging/tag?action=list-used-tags");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(RequestBody);
            request.Resource = ListUsedTagsServiceURL.ToString();
            RestResponse<List<string>> response = await restClient.ExecuteTaskAsyncWithPolicy<List<string>>(request, cancellationToken, timeout, retry);
            if (200 <= (int)response.StatusCode && (int)response.StatusCode <= 300) { return response.Data; }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
            return response.Data;
        }
    }
}

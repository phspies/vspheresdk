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

namespace vspheresdk.Cis.Modules
{
    public class TaggingTagAssociationModule
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public TaggingTagAssociationModule(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
        {
            restClient = Client;
            retry = _retry;
            timeout = _timeout;
            cancellationToken = _cancellationToken;
        }
        public async Task AttachAsync(string TagId, CisTaggingTagAssociationAttachType RequestBody)
        {
            ArgumentNullException.ThrowIfNull(TagId, "TagId cannot be null");
            ArgumentNullException.ThrowIfNull(RequestBody, "RequestBody cannot be null");
            StringBuilder AttachServiceURL = new StringBuilder("/api/cis/tagging/tag-association/{tag_id}?action=attach");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            AttachServiceURL.Replace("{tag_id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TagId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(RequestBody);
            request.Resource = AttachServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if ((int)response.StatusCode == 204) {}
            else if ((int)response.StatusCode == 404) { throw new vSphereException("if the tag for the given tagId does not exist in the system.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 400) { throw new vSphereException("if the input tag is not eligible to be attached to this object or if the objectId is not valid.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 403) { throw new vSphereException("if you do not have the privilege to attach the tag or do not have the privilege to read the object.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 401) { throw new vSphereException("if the user can not be authenticated.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
        }
        public async Task<CisTaggingTagAssociationBatchResultType> AttachTagToMultipleObjectsAsync(string TagId, CisTaggingTagAssociationAttachTagToMultipleObjectsType RequestBody)
        {
            ArgumentNullException.ThrowIfNull(TagId, "TagId cannot be null");
            ArgumentNullException.ThrowIfNull(RequestBody, "RequestBody cannot be null");
            StringBuilder AttachTagToMultipleObjectsServiceURL = new StringBuilder("/api/cis/tagging/tag-association/{tag_id}?action=attach-tag-to-multiple-objects");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            AttachTagToMultipleObjectsServiceURL.Replace("{tag_id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TagId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(RequestBody);
            request.Resource = AttachTagToMultipleObjectsServiceURL.ToString();
            RestResponse<CisTaggingTagAssociationBatchResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<CisTaggingTagAssociationBatchResultType>(request, cancellationToken, timeout, retry);
            if ((int)response.StatusCode == 200) { ArgumentNullException.ThrowIfNull(response.Data) ; return response.Data; }
            else if ((int)response.StatusCode == 404) { throw new vSphereException("if the tag for the given tagId does not exist in the system.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 403) { throw new vSphereException("if you do not have the attach tag privilege on the tag.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 401) { throw new vSphereException("if the user can not be authenticated.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
        }
        public async Task DetachAsync(string TagId, CisTaggingTagAssociationDetachType RequestBody)
        {
            ArgumentNullException.ThrowIfNull(TagId, "TagId cannot be null");
            ArgumentNullException.ThrowIfNull(RequestBody, "RequestBody cannot be null");
            StringBuilder DetachServiceURL = new StringBuilder("/api/cis/tagging/tag-association/{tag_id}?action=detach");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            DetachServiceURL.Replace("{tag_id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TagId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(RequestBody);
            request.Resource = DetachServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if ((int)response.StatusCode == 204) {}
            else if ((int)response.StatusCode == 404) { throw new vSphereException("if the tag for the given tagId does not exist in the system.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 403) { throw new vSphereException("if you do not have the privilege to detach the tag or do not have the privilege to read the given object.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 401) { throw new vSphereException("if the user can not be authenticated.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
        }
        public async Task<CisTaggingTagAssociationBatchResultType> DetachTagFromMultipleObjectsAsync(string TagId, CisTaggingTagAssociationDetachTagFromMultipleObjectsType RequestBody)
        {
            ArgumentNullException.ThrowIfNull(TagId, "TagId cannot be null");
            ArgumentNullException.ThrowIfNull(RequestBody, "RequestBody cannot be null");
            StringBuilder DetachTagFromMultipleObjectsServiceURL = new StringBuilder("/api/cis/tagging/tag-association/{tag_id}?action=detach-tag-from-multiple-objects");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            DetachTagFromMultipleObjectsServiceURL.Replace("{tag_id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TagId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(RequestBody);
            request.Resource = DetachTagFromMultipleObjectsServiceURL.ToString();
            RestResponse<CisTaggingTagAssociationBatchResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<CisTaggingTagAssociationBatchResultType>(request, cancellationToken, timeout, retry);
            if ((int)response.StatusCode == 200) { ArgumentNullException.ThrowIfNull(response.Data) ; return response.Data; }
            else if ((int)response.StatusCode == 404) { throw new vSphereException("if the tag for the given tag does not exist in the system.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 403) { throw new vSphereException("if you do not have the attach tag privilege on the tag.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 401) { throw new vSphereException("if the user can not be authenticated.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
        }
        public async Task<List<VapiStdDynamicIdtype>> ListAttachedObjectsAsync(string TagId)
        {
            ArgumentNullException.ThrowIfNull(TagId, "TagId cannot be null");
            StringBuilder ListAttachedObjectsServiceURL = new StringBuilder("/api/cis/tagging/tag-association/{tag_id}?action=list-attached-objects");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            ListAttachedObjectsServiceURL.Replace("{tag_id}", System.Uri.EscapeDataString(Helpers.ConvertToString(TagId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ListAttachedObjectsServiceURL.ToString();
            RestResponse<List<VapiStdDynamicIdtype>> response = await restClient.ExecuteTaskAsyncWithPolicy<List<VapiStdDynamicIdtype>>(request, cancellationToken, timeout, retry);
            if ((int)response.StatusCode == 200) { ArgumentNullException.ThrowIfNull(response.Data) ; return response.Data; }
            else if ((int)response.StatusCode == 404) { throw new vSphereException("if the tag for the given tagId does not exist in the system.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 403) { throw new vSphereException("if you do not have the privilege to read the tag.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 401) { throw new vSphereException("if the user can not be authenticated.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
        }
        public async Task<CisTaggingTagAssociationBatchResultType> AttachMultipleTagsToObjectAsync(CisTaggingTagAssociationAttachMultipleTagsToObjectType RequestBody)
        {
            ArgumentNullException.ThrowIfNull(RequestBody, "RequestBody cannot be null");
            StringBuilder AttachMultipleTagsToObjectServiceURL = new StringBuilder("/api/cis/tagging/tag-association?action=attach-multiple-tags-to-object");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(RequestBody);
            request.Resource = AttachMultipleTagsToObjectServiceURL.ToString();
            RestResponse<CisTaggingTagAssociationBatchResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<CisTaggingTagAssociationBatchResultType>(request, cancellationToken, timeout, retry);
            if ((int)response.StatusCode == 200) { ArgumentNullException.ThrowIfNull(response.Data) ; return response.Data; }
            else if ((int)response.StatusCode == 403) { throw new vSphereException("if you do not have the privilege to read the object.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 401) { throw new vSphereException("if the user can not be authenticated.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
        }
        public async Task<CisTaggingTagAssociationBatchResultType> DetachMultipleTagsFromObjectAsync(CisTaggingTagAssociationDetachMultipleTagsFromObjectType RequestBody)
        {
            ArgumentNullException.ThrowIfNull(RequestBody, "RequestBody cannot be null");
            StringBuilder DetachMultipleTagsFromObjectServiceURL = new StringBuilder("/api/cis/tagging/tag-association?action=detach-multiple-tags-from-object");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(RequestBody);
            request.Resource = DetachMultipleTagsFromObjectServiceURL.ToString();
            RestResponse<CisTaggingTagAssociationBatchResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<CisTaggingTagAssociationBatchResultType>(request, cancellationToken, timeout, retry);
            if ((int)response.StatusCode == 200) { ArgumentNullException.ThrowIfNull(response.Data) ; return response.Data; }
            else if ((int)response.StatusCode == 403) { throw new vSphereException("if you do not have the privilege to read the object.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 401) { throw new vSphereException("if the user can not be authenticated.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
        }
        public async Task<List<string>> ListAttachableTagsAsync(CisTaggingTagAssociationListAttachableTagsType RequestBody)
        {
            ArgumentNullException.ThrowIfNull(RequestBody, "RequestBody cannot be null");
            StringBuilder ListAttachableTagsServiceURL = new StringBuilder("/api/cis/tagging/tag-association?action=list-attachable-tags");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(RequestBody);
            request.Resource = ListAttachableTagsServiceURL.ToString();
            RestResponse<List<string>> response = await restClient.ExecuteTaskAsyncWithPolicy<List<string>>(request, cancellationToken, timeout, retry);
            if ((int)response.StatusCode == 200) { ArgumentNullException.ThrowIfNull(response.Data) ; return response.Data; }
            else if ((int)response.StatusCode == 403) { throw new vSphereException("if you do not have the privilege to read the object.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 401) { throw new vSphereException("if the user can not be authenticated.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
        }
        public async Task<List<CisTaggingTagAssociationTagToObjectsType>> ListAttachedObjectsOnTagsAsync(CisTaggingTagAssociationListAttachedObjectsOnTagsType RequestBody)
        {
            ArgumentNullException.ThrowIfNull(RequestBody, "RequestBody cannot be null");
            StringBuilder ListAttachedObjectsOnTagsServiceURL = new StringBuilder("/api/cis/tagging/tag-association?action=list-attached-objects-on-tags");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(RequestBody);
            request.Resource = ListAttachedObjectsOnTagsServiceURL.ToString();
            RestResponse<List<CisTaggingTagAssociationTagToObjectsType>> response = await restClient.ExecuteTaskAsyncWithPolicy<List<CisTaggingTagAssociationTagToObjectsType>>(request, cancellationToken, timeout, retry);
            if ((int)response.StatusCode == 200) { ArgumentNullException.ThrowIfNull(response.Data) ; return response.Data; }
            else if ((int)response.StatusCode == 401) { throw new vSphereException("if the user can not be authenticated.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
        }
        public async Task<List<string>> ListAttachedTagsAsync(CisTaggingTagAssociationListAttachedTagsType RequestBody)
        {
            ArgumentNullException.ThrowIfNull(RequestBody, "RequestBody cannot be null");
            StringBuilder ListAttachedTagsServiceURL = new StringBuilder("/api/cis/tagging/tag-association?action=list-attached-tags");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(RequestBody);
            request.Resource = ListAttachedTagsServiceURL.ToString();
            RestResponse<List<string>> response = await restClient.ExecuteTaskAsyncWithPolicy<List<string>>(request, cancellationToken, timeout, retry);
            if ((int)response.StatusCode == 200) { ArgumentNullException.ThrowIfNull(response.Data) ; return response.Data; }
            else if ((int)response.StatusCode == 403) { throw new vSphereException("if you do not have the privilege to read the object.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 401) { throw new vSphereException("if the user can not be authenticated.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
        }
        public async Task<List<CisTaggingTagAssociationObjectToTagsType>> ListAttachedTagsOnObjectsAsync(CisTaggingTagAssociationListAttachedTagsOnObjectsType RequestBody)
        {
            ArgumentNullException.ThrowIfNull(RequestBody, "RequestBody cannot be null");
            StringBuilder ListAttachedTagsOnObjectsServiceURL = new StringBuilder("/api/cis/tagging/tag-association?action=list-attached-tags-on-objects");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(RequestBody);
            request.Resource = ListAttachedTagsOnObjectsServiceURL.ToString();
            RestResponse<List<CisTaggingTagAssociationObjectToTagsType>> response = await restClient.ExecuteTaskAsyncWithPolicy<List<CisTaggingTagAssociationObjectToTagsType>>(request, cancellationToken, timeout, retry);
            if ((int)response.StatusCode == 200) { ArgumentNullException.ThrowIfNull(response.Data) ; return response.Data; }
            else if ((int)response.StatusCode == 401) { throw new vSphereException("if the user can not be authenticated.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
        }
    }
}

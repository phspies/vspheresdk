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
using vspheresdk.Library.Models.Enums;

namespace vspheresdk.Library.Modules
{
    public class LibraryItemDownloadsessionFileModule
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public LibraryItemDownloadsessionFileModule(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
        {
            restClient = Client;
            retry = _retry;
            timeout = _timeout;
            cancellationToken = _cancellationToken;
        }
        public async Task<List<ContentLibraryItemDownloadsessionFileInfoType>> ListAsync(string DownloadSessionId)
        {
            ArgumentNullException.ThrowIfNull(DownloadSessionId, "DownloadSessionId cannot be null");
            StringBuilder ListServiceURL = new StringBuilder("/api/content/library/item/download-session/{download_session_id}/file");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListServiceURL.Replace("{download_session_id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DownloadSessionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = ListServiceURL.ToString();
            RestResponse<List<ContentLibraryItemDownloadsessionFileInfoType>> response = await restClient.ExecuteTaskAsyncWithPolicy<List<ContentLibraryItemDownloadsessionFileInfoType>>(request, cancellationToken, timeout, retry);
            if (200 <= (int)response.StatusCode && (int)response.StatusCode <= 300) { return response.Data; }
            else if ((int)response.StatusCode == 404) { throw new vSphereException("if the download session associated with param.name downloadSessionId doesnt exist.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
            return response.Data;
        }
        public async Task<ContentLibraryItemDownloadsessionFileInfoType> PrepareAsync(string DownloadSessionId, ContentLibraryItemDownloadsessionFilePrepareType RequestBody)
        {
            ArgumentNullException.ThrowIfNull(DownloadSessionId, "DownloadSessionId cannot be null");
            ArgumentNullException.ThrowIfNull(RequestBody, "RequestBody cannot be null");
            StringBuilder PrepareServiceURL = new StringBuilder("/api/content/library/item/download-session/{download_session_id}/file?action=prepare");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            PrepareServiceURL.Replace("{download_session_id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DownloadSessionId, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(RequestBody);
            request.Resource = PrepareServiceURL.ToString();
            RestResponse<ContentLibraryItemDownloadsessionFileInfoType> response = await restClient.ExecuteTaskAsyncWithPolicy<ContentLibraryItemDownloadsessionFileInfoType>(request, cancellationToken, timeout, retry);
            if (200 <= (int)response.StatusCode && (int)response.StatusCode <= 300) { return response.Data; }
            else if ((int)response.StatusCode == 404) { throw new vSphereException("if the download session does not exist.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 400) { throw new vSphereException("if there is no file with the specified param.name fileName.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 403) { throw new vSphereException("if the the download session wasnt created with the ContentLibrary.ReadStorage privilege and the caller requested a link EndpointTypeDIRECT endpoint type.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
            return response.Data;
        }
        public async Task<ContentLibraryItemDownloadsessionFileInfoType> GetAsync(string DownloadSessionId, string FileName)
        {
            ArgumentNullException.ThrowIfNull(DownloadSessionId, "DownloadSessionId cannot be null");
            ArgumentNullException.ThrowIfNull(FileName, "FileName cannot be null");
            StringBuilder GetServiceURL = new StringBuilder("/api/content/library/item/download-session/{download_session_id}/file?file_name");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetServiceURL.Replace("{download_session_id}", System.Uri.EscapeDataString(Helpers.ConvertToString(DownloadSessionId, System.Globalization.CultureInfo.InvariantCulture)));
            if (FileName != null) { request.AddQueryParameter("file_name", FileName.ToString()); }
            request.Resource = GetServiceURL.ToString();
            RestResponse<ContentLibraryItemDownloadsessionFileInfoType> response = await restClient.ExecuteTaskAsyncWithPolicy<ContentLibraryItemDownloadsessionFileInfoType>(request, cancellationToken, timeout, retry);
            if (200 <= (int)response.StatusCode && (int)response.StatusCode <= 300) { return response.Data; }
            else if ((int)response.StatusCode == 404) { throw new vSphereException("if the download session associated with param.name downloadSessionId does not exist.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 400) { throw new vSphereException("if there is no file with the specified param.name fileName.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
            return response.Data;
        }
    }
}

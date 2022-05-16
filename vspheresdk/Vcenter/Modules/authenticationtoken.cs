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
    public class AuthenticationTokenModule
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public AuthenticationTokenModule(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
        {
            restClient = Client;
            retry = _retry;
            timeout = _timeout;
            cancellationToken = _cancellationToken;
        }
        public async Task<Oauth2TokenInfoType> IssueAsync(string GrantType, string? Resource = null, string? Audience = null, string? Scope = null, string? RequestedTokenType = null, string? SubjectToken = null, string? SubjectTokenType = null, string? ActorToken = null, string? ActorTokenType = null)
        {
            ArgumentNullException.ThrowIfNull(GrantType, "GrantType cannot be null");
            StringBuilder IssueServiceURL = new StringBuilder("/api/vcenter/authentication/token");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            
            
            
            
            
            
            
            
            
            request.Resource = IssueServiceURL.ToString();
            RestResponse<Oauth2TokenInfoType> response = await restClient.ExecuteTaskAsyncWithPolicy<Oauth2TokenInfoType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + IssueServiceURL.ToString() + " did not complete successfull";
                throw new vSphereException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}

using Newtonsoft.Json;
using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace vspheresdk.Authentication
{
    public class AuthenticationHelper
    {
        public static async Task<RestResponse<LoginResponseType>> LoginAsync(RestClient sessionRestClient, CancellationToken _cancellationToken, int _timeout, int _retry)
        {
            StringBuilder GetLoginURL = new StringBuilder("/rest/com/vmware/cis/session");
            var request = new RestRequest
            {
                Method = Method.Post,
                
            };
            request.Resource = GetLoginURL.ToString();

            RestResponse<LoginResponseType> response = await sessionRestClient.ExecuteTaskAsyncWithPolicy<LoginResponseType>(request, _cancellationToken, _timeout, _retry);
            if (response.StatusCode != HttpStatusCode.OK)
            {
                var message = "Login operation to " + GetLoginURL.ToString() + " did not complete successfully";
                throw new vSphereException(message, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException);
            }
            return response;
        }
        public static async Task<string> RetrieveAsync(RestClient sessionRestClient, CancellationToken _cancellationToken, int _timeout, int _retry)
        {
            StringBuilder GetLoginURL = new StringBuilder("/com/vmware/cis/session?action=get");
            var request = new RestRequest
            {
                Method = Method.Post,
                RequestFormat = DataFormat.Json,
            };
            request.Resource = GetLoginURL.ToString();

            RestResponse<string> response = await sessionRestClient.ExecuteTaskAsyncWithPolicy<string>(request, _cancellationToken, _timeout, _retry);
            if (response.StatusCode != HttpStatusCode.OK)
            {
                var message = "Login operation to " + GetLoginURL.ToString() + " did not complete successfully";
                throw new vSphereException(message, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException);
            }
            return response.Data;
        }
        public static async Task LogoutAsync(RestClient sessionRestClient, CancellationToken _cancellationToken, int _timeout, int _retry)
        {
            StringBuilder GetLogoutURL = new StringBuilder("/rest/com/vmware/cis/session");
            var request = new RestRequest
            {
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            request.Resource = GetLogoutURL.ToString();
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");

            RestResponse response = await sessionRestClient.ExecuteTaskAsyncWithPolicy(request, _cancellationToken, _timeout, _retry);
            if (response.StatusCode != HttpStatusCode.OK)
            {
                var message = "Login operation to " + GetLogoutURL.ToString() + " did not complete successfully";
                throw new vSphereException(message, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException);
            }
        }
    }
}

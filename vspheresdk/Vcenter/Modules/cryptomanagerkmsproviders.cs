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
    public class CryptoManagerKmsProvidersModule
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public CryptoManagerKmsProvidersModule(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
        {
            restClient = Client;
            retry = _retry;
            timeout = _timeout;
            cancellationToken = _cancellationToken;
        }
        public async Task CreateAsync(VcenterCryptoManagerKmsProvidersCreateType RequestBody = null)
        {
            StringBuilder CreateServiceURL = new StringBuilder("/api/vcenter/crypto-manager/kms/providers");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(RequestBody);
            request.Resource = CreateServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + CreateServiceURL.ToString() + " did not complete successfull";
                throw new vSphereException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        public async Task<List<VcenterCryptoManagerKmsProvidersSummaryType>> ListAsync(string Providers = null, string Health = null)
        {
            StringBuilder ListServiceURL = new StringBuilder("/api/vcenter/crypto-manager/kms/providers");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            if (Providers != null) { request.AddQueryParameter("providers", Providers.ToString()); }
            if (Health != null) { request.AddQueryParameter("health", Health.ToString()); }
            request.Resource = ListServiceURL.ToString();
            RestResponse<List<VcenterCryptoManagerKmsProvidersSummaryType>> response = await restClient.ExecuteTaskAsyncWithPolicy<List<VcenterCryptoManagerKmsProvidersSummaryType>>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + ListServiceURL.ToString() + " did not complete successfull";
                throw new vSphereException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        public async Task<VcenterCryptoManagerKmsProvidersInfoType> GetAsync(string Provider)
        {
            ArgumentNullException.ThrowIfNull(Provider, "Provider cannot be null");
            StringBuilder GetServiceURL = new StringBuilder("/api/vcenter/crypto-manager/kms/providers/{provider}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetServiceURL.Replace("{provider}", System.Uri.EscapeDataString(Helpers.ConvertToString(Provider, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetServiceURL.ToString();
            RestResponse<VcenterCryptoManagerKmsProvidersInfoType> response = await restClient.ExecuteTaskAsyncWithPolicy<VcenterCryptoManagerKmsProvidersInfoType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Get operation to " + GetServiceURL.ToString() + " did not complete successfull";
                throw new vSphereException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        public async Task UpdateAsync(string Provider, VcenterCryptoManagerKmsProvidersUpdateType RequestBody = null)
        {
            ArgumentNullException.ThrowIfNull(Provider, "Provider cannot be null");
            StringBuilder UpdateServiceURL = new StringBuilder("/api/vcenter/crypto-manager/kms/providers/{provider}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Patch
            };
            UpdateServiceURL.Replace("{provider}", System.Uri.EscapeDataString(Helpers.ConvertToString(Provider, System.Globalization.CultureInfo.InvariantCulture)));
            request.AddJsonBody(RequestBody);
            request.Resource = UpdateServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Patch operation to " + UpdateServiceURL.ToString() + " did not complete successfull";
                throw new vSphereException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        public async Task DeleteAsync(string Provider)
        {
            ArgumentNullException.ThrowIfNull(Provider, "Provider cannot be null");
            StringBuilder DeleteServiceURL = new StringBuilder("/api/vcenter/crypto-manager/kms/providers/{provider}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Delete
            };
            DeleteServiceURL.Replace("{provider}", System.Uri.EscapeDataString(Helpers.ConvertToString(Provider, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = DeleteServiceURL.ToString();
            RestResponse response = await restClient.ExecuteTaskAsyncWithPolicy(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Delete operation to " + DeleteServiceURL.ToString() + " did not complete successfull";
                throw new vSphereException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            
        }
        public async Task<VcenterCryptoManagerKmsProvidersExportResultType> ExportAsync(VcenterCryptoManagerKmsProvidersExportType RequestBody = null)
        {
            StringBuilder ExportServiceURL = new StringBuilder("/api/vcenter/crypto-manager/kms/providers?action=export");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(RequestBody);
            request.Resource = ExportServiceURL.ToString();
            RestResponse<VcenterCryptoManagerKmsProvidersExportResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<VcenterCryptoManagerKmsProvidersExportResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + ExportServiceURL.ToString() + " did not complete successfull";
                throw new vSphereException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
        public async Task<VcenterCryptoManagerKmsProvidersImportResultType> ImportProviderAsync(VcenterCryptoManagerKmsProvidersImportProviderType RequestBody = null)
        {
            StringBuilder ImportProviderServiceURL = new StringBuilder("/api/vcenter/crypto-manager/kms/providers?action=import");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Post
            };
            request.AddJsonBody(RequestBody);
            request.Resource = ImportProviderServiceURL.ToString();
            RestResponse<VcenterCryptoManagerKmsProvidersImportResultType> response = await restClient.ExecuteTaskAsyncWithPolicy<VcenterCryptoManagerKmsProvidersImportResultType>(request, cancellationToken, timeout, retry);
            if (response.StatusCode != HttpStatusCode.OK)
			{
                var message = "HTTP Post operation to " + ImportProviderServiceURL.ToString() + " did not complete successfull";
                throw new vSphereException(message, (int)response.StatusCode, response.Content,  response.Headers, response.ErrorException);
			}
            return response.Data;
        }
    }
}

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
using vspheresdk.Esx.Models;
using vspheresdk.Esx.Models.Enums;

namespace vspheresdk.Esx.Modules
{
    public class SettingsHardwareSupportManagersPackagesVersionsModule
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public SettingsHardwareSupportManagersPackagesVersionsModule(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
        {
            restClient = Client;
            retry = _retry;
            timeout = _timeout;
            cancellationToken = _cancellationToken;
        }
        public async Task<EsxSettingsHardwareSupportManagersPackagesVersionsPackageInfoType> GetAsync(string Manager, string Pkg, string Version, string? BaseImageVersion = null)
        {
            ArgumentNullException.ThrowIfNull(Manager, "Manager cannot be null");
            ArgumentNullException.ThrowIfNull(Pkg, "Pkg cannot be null");
            ArgumentNullException.ThrowIfNull(Version, "Version cannot be null");
            StringBuilder GetServiceURL = new StringBuilder("/api/esx/settings/hardware-support/managers/{manager}/packages/{pkg}/versions/{version}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetServiceURL.Replace("{manager}", System.Uri.EscapeDataString(Helpers.ConvertToString(Manager, System.Globalization.CultureInfo.InvariantCulture)));
            GetServiceURL.Replace("{pkg}", System.Uri.EscapeDataString(Helpers.ConvertToString(Pkg, System.Globalization.CultureInfo.InvariantCulture)));
            GetServiceURL.Replace("{version}", System.Uri.EscapeDataString(Helpers.ConvertToString(Version, System.Globalization.CultureInfo.InvariantCulture)));
            if (BaseImageVersion != null) { request.AddQueryParameter("base_image_version", BaseImageVersion.ToString()); }
            request.Resource = GetServiceURL.ToString();
            RestResponse<EsxSettingsHardwareSupportManagersPackagesVersionsPackageInfoType> response = await restClient.ExecuteTaskAsyncWithPolicy<EsxSettingsHardwareSupportManagersPackagesVersionsPackageInfoType>(request, cancellationToken, timeout, retry);
            if (200 <= (int)response.StatusCode && (int)response.StatusCode <= 300) { return response.Data; }
            else if ((int)response.StatusCode == 500) { throw new vSphereException("If there is some unknown internal error. The accompanying error message will give more details about the failure.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 400) { throw new vSphereException("If any of the specified parameters are Invalid e.g. if the release version specified in the query parameter is not in fact among those supported by the Hardware Support Package HSP.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 404) { throw new vSphereException("If there is no Hardware Support Manager HSM with the specified name or no Hardware Support Package HSP with the specified name and version.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 503) { throw new vSphereException("If the service is not available.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 401) { throw new vSphereException("if the caller is not authenticated. named param.name manager in the system.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 403) { throw new vSphereException("if the user does not have the required privilege to perform the operation.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
            return response.Data;
        }
    }
}

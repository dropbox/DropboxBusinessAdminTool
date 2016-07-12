using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Newtonsoft.Json;

namespace DfBAdminToolkit.Services
{
    public class GitHubService
    {

        private readonly RestClient _client;

        public GitHubService()
        {
            
            _client = new RestClient(@"https://api.github.com/");
        }

        public string LatestVersion()
        {
            string releasesPath = @"repos/dropbox/DropboxBusinessAdminTool/releases";
            RestRequest request = new RestRequest(releasesPath, Method.GET);
            IRestResponse response = _client.Execute(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                dynamic jsonData = JsonConvert.DeserializeObject<dynamic>(response.Content);
                return jsonData[0]["tag_name"];
            } else
            {
                return @"";
            }
        }
    }
}

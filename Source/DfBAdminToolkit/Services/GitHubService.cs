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

        public GitHubRelease LatestRelease()
        {
            GitHubRelease release = new GitHubRelease();
            string releasesPath = @"repos/dropbox/DropboxBusinessAdminTool/releases";
            RestRequest request = new RestRequest(releasesPath, Method.GET);
            IRestResponse response = _client.Execute(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                dynamic jsonData = JsonConvert.DeserializeObject<dynamic>(response.Content);
                release.version = new Version(jsonData[0]["tag_name"].ToString());
                release.name = jsonData[0]["name"];
                release.description = jsonData[0]["body"];
                release.releaseUri = new Uri(jsonData[0]["html_url"].ToString());
                release.releaseDate = Convert.ToDateTime(jsonData[0]["published_at"].ToString());
                // Look for a zip attachment that contains just the pre-built exe.
                foreach (var asset in jsonData[0]["assets"])
                {
                    if (asset["content_type"] == "application/x-zip-compressed")
                    {
                        release.downloadUri = asset["browser_download_url"];
                    }
                }
            }
            else
            {
                release.version = new Version(0, 0, 0, 0);
            }
            return release;
        }
    }

    public class GitHubRelease
    {
        public string name;
        public string description;
        public Version version;
        public DateTime releaseDate;
        public Uri releaseUri;
        public Uri downloadUri;
    }
}

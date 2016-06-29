using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace GithubAPI.API
{
    public static class GithubApi
    {
        public static IEnumerable<GithubRepo> GetRepos(string username)
        {
            using (var client = new WebClient())
            {
                client.Headers.Add("User-Agent", "Github is terrible!!!");
                string json = client.DownloadString("https://api.github.com/users/" + username + "/repos");
                return JsonConvert.DeserializeObject<IEnumerable<GithubRepo>>(json);
            }
        }
    }
}

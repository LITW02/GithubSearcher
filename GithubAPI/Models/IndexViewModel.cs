using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GithubAPI.API;

namespace GithubAPI.Models
{
    public class IndexViewModel
    {
        public string Username { get; set; }
        public IEnumerable<GithubRepo> Repos { get; set; } 
    }
}
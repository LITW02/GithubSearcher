using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GithubAPI.API;
using GithubAPI.Models;

namespace GithubAPI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string username)
        {
            IndexViewModel viewModel = new IndexViewModel();
            if (!String.IsNullOrEmpty(username))
            {
                viewModel.Username = username;
                viewModel.Repos = GithubApi.GetRepos(username);
            }
            return View(viewModel);
        }

    }
}

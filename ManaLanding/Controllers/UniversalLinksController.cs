using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ManaLanding.Controllers
{
    [Route(".well-known/{action}")]
    [ApiController]
    public class UniversalLinksController : ControllerBase
    {
        [ActionName("apple-app-site-association")]
        public string AASA()
        {
            return JsonSerializer.Serialize(new AASAFile());
        }
        private class AASAFile
        {
            public AppLinks applinks { get => new AppLinks(); }

        }
        private class AppLinks
        {
            public IEnumerable<object> apps { get => new List<object>(); }
            public IEnumerable<Detail> details { get => new List<Detail> { new Detail() }; }
        }
        private class Detail
        {
            public string appID { get => "KP6AXAXNQD.thes.mana.rising.client"; }
            public IEnumerable<string> paths { get => new List<string> { "*" }; }
        }
    }
}
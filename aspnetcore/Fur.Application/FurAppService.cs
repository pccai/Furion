﻿using Fur.FeatureApiController;
using Microsoft.AspNetCore.Mvc;

namespace Fur.Application
{
    [Route("/api/[controller]dd/")]
    [Route("/api/[controller]dd/22")]
    [FeatureApiSettings(Module = "mobile", ApiVersion = "2.0")]
    public class FurAppService : IFeatureApiController
    {
        [FeatureApiSettings(ApiVersion = "2.0")]
        //[AcceptVerbs("GET", "POST")]
        //[Route("/[action]")]
        //[HttpGet("[action]")]
        //[HttpGet("222")]
        public string GetVersion()
        {
            return "v1.0.0";
        }

        //[HttpGet("[action]")]
        //[Route("/[action]")]
        [FeatureApiSettings(SplitName = true, ApiVersion = "1.0")]
        public string GetFrameworkName(string name)
        {
            return nameof(Fur) + name;
        }
    }
}
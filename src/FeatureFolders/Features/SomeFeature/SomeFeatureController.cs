﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

namespace FeatureFolders.Features.SomeFeature
{
    public class SomeFeatureController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        
    }
}

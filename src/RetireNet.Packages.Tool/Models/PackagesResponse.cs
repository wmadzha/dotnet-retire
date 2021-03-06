﻿using System;
using System.Collections.Generic;

namespace RetireNet.Packages.Tool.Models
{
    public class PackagesResponse
    {
        public PackagesResponse()
        {
            Packages = new List<Package>();
        }

        public Uri Link { get; set; }
        public string Description { get; set; }
        public IEnumerable<Package> Packages { get; set; }
    }
}
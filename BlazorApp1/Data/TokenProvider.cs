﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class TokenProvider
    {
        public string AccessToken { get; set; }
    }

    public class InitialApplicationState
    {
        public string AccessToken { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspWebMvc.Areas.Admin.Code
{
    [Serializable]
    public class UserSession
    {
        public string UserName { get; set; }
    }
}
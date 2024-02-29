﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspWebMvc.Areas.Admin.Code
{
    public class SessionHelper
    {
        public static void SetSession(UserSession session) {
            HttpContext.Current.Session["loginSession"] = session;
        }

        public static UserSession GetSession()
        {
            var userSession = HttpContext.Current.Session["loginSession"];

            if (userSession == null)
            {
                return null;
            }
            else
            {
                return userSession as UserSession;
            }
        }
    }
}
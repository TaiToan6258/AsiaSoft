using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Web;

namespace NortwindTradersManagerment.Common
{
    public class SesstionHelper
    {
        public static void SetSession(UserSession sesstion) 
        {
            HttpContext.Current.Session["loginSession"] = sesstion;
        }
        public static UserSession GetSession() { 
            var session = HttpContext.Current.Session["loginSession"];
            if (session == null)
            {
                return null;

            }
            else {
                return session as UserSession;
            }  
        }
    }
}
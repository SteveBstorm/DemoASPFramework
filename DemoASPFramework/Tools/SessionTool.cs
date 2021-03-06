using DemoASPFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoASPFramework.Tools
{
    public static class SessionTool
    {
        public static User user
        {
            get { return (User)HttpContext.Current.Session["user"]; }
            set { HttpContext.Current.Session["user"] = value; }
        }

        public static void Disconnect()
        {
            HttpContext.Current.Session.Clear();
        }
    }
}
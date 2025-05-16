using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Daily_Dine
{
    class sessionManager
    {
        public static class SessionManager
        {
            public static string LoggedInUsername { get; set; }
            public static int CurrentUserId { get; set; } // Store logged-in user ID
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning_lks.Helper
{
 
    public static class Session
    {
        public static int UserId { get; set; }
        public static String Username { get; set; }
        public static String FullName { get; set; }
        public static String Role { get; set; }
        public static String Position { get; set; }

        public static bool IsPetugas => Role == "PetugasSPPG";
        public static bool IsSupervisor => Role == "SuperVisorSPPG";

        public static void Set(int userId, string username, string fullName, string role, string position)
        {
            UserId = userId;
            Username = username;
            FullName = fullName;
            Role = role;
            Position = position;
        }

        public static void Clear()
        {
            UserId = 0;
            Username = FullName = Role = Position = null;
        }
    }
}

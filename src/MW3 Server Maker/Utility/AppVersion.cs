using System;
using System.Reflection;

namespace MW3_Server_Maker
{
    public static class AppVersion
    {
        private static Lazy<string> _version = new Lazy<string>(new Func<string>(CreateVersion));

        private static string CreateVersion()
        {
            return (Assembly.GetExecutingAssembly().GetName().Version ?? new Version()).ToString(3);
        }

        public static string Get()
        {
            return _version.Value;
        }
    }
}

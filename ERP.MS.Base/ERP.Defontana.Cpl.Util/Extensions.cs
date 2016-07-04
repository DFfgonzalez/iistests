using System;

namespace ERP.Defontana.Cpl.Util
{
    public static class Extensions
    {
        public static string F(this string str, params object[] args)
        {
            return string.Format(str, args);
        }

        public static string GetExceptionMessages(this Exception e)
        {
            var msgs = e.Message;
            if (e.InnerException != null)
                msgs += "\r\n" + GetExceptionMessages(e.InnerException);
            return msgs;
        }

        public static bool ContainsInsensitive(this string str, string value)
        {
            return str.ToLowerInvariant().Contains(value.ToLowerInvariant());
        }
    }
}

﻿namespace ThirdDrawer.Extensions.StringExtensionMethods
{
    using System;
    using System.Text;

    public static class Base64StringExtensions
    {
        public static string ToBase64(this string s, Encoding encoding)
        {
            var bytes = encoding.GetBytes(s);

            return Convert.ToBase64String(bytes);
        }

        public static string FromBase64(this string s, Encoding encoding)
        {
            var bytes = Convert.FromBase64String(s);

            return encoding.GetString(bytes);
        }
    }
}
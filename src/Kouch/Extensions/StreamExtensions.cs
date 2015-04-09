﻿using System.IO;

namespace MyCouch.Extensions
{
    public static class StreamExtensions
    {
        public static string ReadAsString(this Stream content)
        {
            var reader = new StreamReader(content, MyCouchRuntime.DefaultEncoding);
            return reader.ReadToEnd().TrimEnd();
        }
    }
}
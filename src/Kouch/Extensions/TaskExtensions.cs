﻿#if net45 || PCL
using System.Runtime.CompilerServices;
#elif net40
using Microsoft.Runtime.CompilerServices;
#endif
using System.Threading.Tasks;

namespace MyCouch.Extensions
{
    public static class TaskExtensions
    {
        public static ConfiguredTaskAwaitable ForAwait(this Task t)
        {
            return t.ConfigureAwait(false);
        }

        public static ConfiguredTaskAwaitable<T> ForAwait<T>(this Task<T> t)
        {
            return t.ConfigureAwait(false);
        }
    }
}
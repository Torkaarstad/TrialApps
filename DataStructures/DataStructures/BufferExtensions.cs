using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public static class BufferExtensions
    {
        public static void Dump<T>(this IBuffer<T> buffer, Action<T> print)
        {
            foreach (var item in buffer)
            {
                print(item);
            }
        }

        public static IEnumerable<TOutput> Map<T, TOutput>(
            this IBuffer<T> buffer, Converter<T, TOutput> converter) //Note the use of .NET built in Converter<> delegate
        {
            return buffer.Select(i => converter(i));
        }
    }
}

using System.Collections.Generic;
using System.Linq;

namespace ThreeCee;

public static class Extensions
{
    
    public static IEnumerable<TSource> SkipLast<TSource>(this IEnumerable<TSource> source, int count)
    {
        var result = new List<TSource>();
        var counter = 0;
        var enumerable = source.ToList();
        foreach (var item in enumerable)
        {
            if(counter < enumerable.Count()-1)
                result.Add(item);
            counter++;
        }

        return result;
    }

    public static string JoinToString(this IEnumerable<string> list, string separator) => 
        string.Join(separator, list);
    
}
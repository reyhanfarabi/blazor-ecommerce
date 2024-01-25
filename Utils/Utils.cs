using System.Net;

namespace BlazorEcommerce.Utils;

public static class Utils
{
    public static string EncodeStringToUrl(this string str)
    {
        return WebUtility.UrlEncode(str);
    }

    public static string DecodeUrlToString(this string str)
    {
        return WebUtility.UrlDecode(str);
    }

    public static string ToCapitalizeWord(this string str)
    {
        return string.Join(" ", str.Split().Select(word => char.ToUpper(word[0]) + word.Substring(1).ToLower()));
    }
}

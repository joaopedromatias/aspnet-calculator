using Microsoft.Extensions.Primitives;

namespace Calculator 
{
    public class GetQueryString : IGetInput
    {
        public string Get (Dictionary<string, StringValues> queryStrings, string name)
        {
            string? input = queryStrings[name][0];
            return input ?? "";
        }
    }
}
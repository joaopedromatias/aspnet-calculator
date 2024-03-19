using Microsoft.Extensions.Primitives;

namespace Calculator
{
    public interface IGetInput
    {
        public string Get(Dictionary<string, StringValues> dict, string parameterName);
    }
}
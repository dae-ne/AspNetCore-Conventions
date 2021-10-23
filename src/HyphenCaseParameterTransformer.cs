using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Routing;

namespace Derav.Conventions
{
    internal class HyphenCaseParameterTransformer : IOutboundParameterTransformer
    {
        public string TransformOutbound(object value)
        {
            if (value is not string valueStr || string.IsNullOrWhiteSpace(valueStr))
                return string.Empty;

            return Regex.Replace(
                    valueStr, 
                    "(?<!^)([A-Z][a-z]|(?<=[a-z])[A-Z])", 
                    "-$1",
                    RegexOptions.Compiled)
                .Trim()
                .ToLower();
        }
    }
}
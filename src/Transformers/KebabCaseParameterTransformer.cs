using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Routing;

namespace DaeNe.AspNetCore.Conventions.Transformers
{
    internal sealed class KebabCaseParameterTransformer : IOutboundParameterTransformer
    {
        public string TransformOutbound(object? value)
        {
            if (!(value is string valueStr) || string.IsNullOrWhiteSpace(valueStr))
            {
                return string.Empty;
            }

            const string pattern = "(?<!^)([A-Z][a-z]|(?<=[a-z])[A-Z])";
            return Regex.Replace(valueStr, pattern, "-$1", RegexOptions.Compiled)
                .Trim()
                .ToLower();
        }
    }
}

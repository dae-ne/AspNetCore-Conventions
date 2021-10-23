using Microsoft.AspNetCore.Mvc.ApplicationModels;

namespace Derav.Conventions
{
    public class HyphenCaseRouteConvention : RouteTokenTransformerConvention
    {
        private static readonly HyphenCaseParameterTransformer Transformer = new();
        
        public HyphenCaseRouteConvention() : base(Transformer) { }
    }
}
using DaeNe.AspNetCore.Conventions.Transformers;
using Microsoft.AspNetCore.Mvc.ApplicationModels;

namespace DaeNe.AspNetCore.Conventions
{
    public class KebabCaseRouteConvention : RouteTokenTransformerConvention
    {
        public KebabCaseRouteConvention() : base(new KebabCaseParameterTransformer()) { }
    }
}

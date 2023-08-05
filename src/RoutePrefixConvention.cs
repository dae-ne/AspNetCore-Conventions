using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationModels;

namespace DaeNe.AspNetCore.Conventions
{
    public class RoutePrefixConvention : IControllerModelConvention
    {
        private readonly AttributeRouteModel _routePrefix;

        public RoutePrefixConvention(string prefix)
        {
            _routePrefix = new AttributeRouteModel(new RouteAttribute(prefix));
        }

        public void Apply(ControllerModel controller)
        {
            foreach (var selector in controller.Selectors)
            {
                selector.AttributeRouteModel = !(selector.AttributeRouteModel is null)
                    ? AttributeRouteModel.CombineAttributeRouteModel(_routePrefix, selector.AttributeRouteModel)
                    : _routePrefix;
            }
        }
    }
}

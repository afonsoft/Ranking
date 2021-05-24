using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Afonsoft.Ranking.Web.Resources
{
    public class TenantTransformer : DynamicRouteValueTransformer
    {
        private readonly TenantDatabase _tenentDatabase;

        public TenantTransformer(TenantDatabase tenentDatabase)
        {
            _tenentDatabase = tenentDatabase;
        }

        public override ValueTask<RouteValueDictionary> TransformAsync(HttpContext httpContext, RouteValueDictionary values)
        {
            if (!values.ContainsKey("tenant") || !values.ContainsKey("controller") || !values.ContainsKey("action") || values["tenant"] == "App")
                return ValueTask.FromResult(values);

            values["tenantId"] = _tenentDatabase.Resolve(values["tenant"] as string);
            values["tenant"] = "Tenant";

            return ValueTask.FromResult(values);
        }
    }
}
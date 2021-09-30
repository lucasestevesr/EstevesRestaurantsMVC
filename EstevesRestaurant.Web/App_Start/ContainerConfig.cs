using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using EstevesRestaurant.data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace EstevesRestaurant.Web
{
    public class ContainerConfig
    {
        internal static void RegisterContainer(HttpConfiguration HttpConfiguration)
        {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterApiControllers(typeof(MvcApplication).Assembly);
            builder.RegisterType<SqlRestaurantData>()
                   .As<IRestaurantData>()
                   .InstancePerRequest();
            builder.RegisterType<EstevesRestaurantsDbContext>().InstancePerRequest();


            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            HttpConfiguration.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
    }
}
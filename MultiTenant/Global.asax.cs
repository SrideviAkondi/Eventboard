using MultiTenant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace MultiTenant
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //using (var context = new MultiTenantContext())
            //{
            //    var result = new List<Tenant>() {
            //        new Tenant(){
            //            Id=1,
            //        Name="SVCC",
            //        DomainName="www.siliconvalley-codecamp.com",
            //        Default= true
            //        },
            //        new Tenant(){
            //            Id=2,
            //        Name="ANGU",
            //        DomainName="angular.com",
            //        Default= true
            //        },
            //        new Tenant(){
            //            Id=3,
            //        Name="CSSC",
            //        DomainName="codestarsummit.com",
            //        Default= true
            //        }
            //    };
            //    context.Tenants.AddRange(result);

            //    var speaker = new Speaker()
            //    {
            //        LastName = Guid.NewGuid().ToString()
            //    };
            //    var session = new Session()
            //    {
            //        Title = Guid.NewGuid().ToString()
            //    };
            //    context.Speakers.Add(speaker);
            //    context.Sessions.Add(session);
            //    context.SaveChanges();

            //}
        }
    }
}

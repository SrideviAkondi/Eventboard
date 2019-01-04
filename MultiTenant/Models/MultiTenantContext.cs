using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MultiTenant.Models
{
    [DbConfigurationType(typeof(DataConfiguration))]
    public class MultiTenantContext : DbContext
    {
        public DbSet<Tenant> Tenants { get; set; }
        public DbSet<Speaker> Speakers { get; set; }
        public DbSet<Session> Sessions { get; set; }
    }

    public class DataConfiguration: DbConfiguration
    {
        public DataConfiguration()
        {
            SetDatabaseInitializer(new MultiTenantContextInitializer());
        }
    }

    public class MultiTenantContextInitializer: CreateDatabaseIfNotExists<MultiTenantContext>
    {
        protected override void Seed(MultiTenantContext context)
        {
            var result = new List<Tenant>() {
                    new Tenant(){
                        Id=1,
                    Name="SVCC",
                    DomainName="www.siliconvalley-codecamp.com",
                    Default= true
                    },
                    new Tenant(){
                        Id=2,
                    Name="ANGU",
                    DomainName="angular.com",
                    Default= true
                    },
                    new Tenant(){
                        Id=3,
                    Name="CSSC",
                    DomainName="codestarsummit.com",
                    Default= true
                    }
                };
            result.ForEach(a => context.Tenants.Add(a)) ;
            context.SaveChanges();
        }
    }
}
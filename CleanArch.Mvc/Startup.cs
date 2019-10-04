using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CleanArch.Mvc.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ClearArch.Infra.Data.Context;
using CleanArch.Infra.IoC;
using ClearArch.Infra.Data.Repository;
using CleanArch.Application.Interfaces;
using CleanArch.Application.Services;
using ClearArch.Infra.Data.UnitOfWork;

namespace CleanArch.Mvc
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            try
            {
                services.Configure<CookiePolicyOptions>(options =>
                {
                    // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                    options.CheckConsentNeeded = context => true;
                    options.MinimumSameSitePolicy = SameSiteMode.None;
                });
                //DependencyContainer.RegisterServices(services);
                services.AddTransient<ISchoolService, SchoolService>();
                services.AddTransient<ISchoolRepository, SchoolRepository>();
                services.AddTransient<IUniteOfWork, UnitOfWork>();
                
                services.AddDbContext<ApplicationDbContext>(options =>
                    options.UseSqlServer(
                        Configuration.GetConnectionString("DefaultConnection")));
                services.AddDefaultIdentity<IdentityUser>()
                    .AddEntityFrameworkStores<ApplicationDbContext>();

                services.AddDbContext<SchoolsDBContext>(options =>

                {
                    options.UseSqlServer(Configuration.GetConnectionString("SchoolsDBConnection"));
                });

                services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

               
            }
            catch (Exception exception)
            {
                throw exception;
            }
      
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }
            FastReport.Utils.RegisteredObjects.AddConnection(typeof(MsSqlDataConnection));
            app.UseFastReport();
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }

        public class MsSqlDataConnection : FastReport.Data.DataConnectionBase
        {
            public override string QuoteIdentifier(string value, System.Data.Common.DbConnection connection)
            {

                return "\"" + value + "\"";
            }

            public override System.Type GetConnectionType()
            {
                return typeof(System.Data.SqlClient.SqlConnection);
            }

            public override System.Type GetParameterType()
            {
                return typeof(System.Data.SqlDbType);
            }

            public override System.Data.Common.DbDataAdapter GetAdapter(string selectCommand, System.Data.Common.DbConnection connection, FastReport.Data.CommandParameterCollection parameters)
            {
                System.Data.SqlClient.SqlDataAdapter adapter = new System.Data.SqlClient.SqlDataAdapter(selectCommand, connection as System.Data.SqlClient.SqlConnection);
                foreach (FastReport.Data.CommandParameter p in parameters)
                {
                    System.Data.SqlClient.SqlParameter parameter = adapter.SelectCommand.Parameters.Add(p.Name, (System.Data.SqlDbType)p.DataType, p.Size);
                    parameter.Value = p.Value;
                }
                return adapter;
            }
        }
    }
}

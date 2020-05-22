using System.Reflection;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using User.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using User.Infrastructure.Interface;
using User.Infrastructure.Repository;
using User.Domain.Query;
using User.Server.Services;
using AutoMapper;

namespace User.Server
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<UserContext>(option=> option.UseInMemoryDatabase("MyUserDb"));
            services.AddTransient<IQueryRepository, QueryRepository>();
            services.AddTransient<ICommandRepository, CommandRepository>();
            services.AddMediatR(typeof(GetUserIdentityQuery).GetTypeInfo().Assembly);
            services.AddAutoMapper(typeof(Startup));
            services.AddGrpc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                // endpoints.MapGrpcService<UserService>();
                endpoints.MapGrpcService<UserIdentityManagementService>();
                endpoints.MapGrpcService<UserProfileManagementService>();
                endpoints.MapGrpcService<UserRoleManagementService>();

                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909");
                });
            });
        }
    }
}

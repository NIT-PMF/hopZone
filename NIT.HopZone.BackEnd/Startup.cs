using System.Text;
using GraphiQl;
using GraphQL;
using GraphQL.Types;
using GraphQL.Validation;
using HopZone.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.SpaServices.ReactDevelopmentServer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using NIT.HopZone.BackEnd.InputTypes;
using NIT.HopZone.Web.Models;
using NIT.HopZone.Web.NIT.HopZone.BackEnd.Helper.Test.GraphQL.MyCoreAPI.Helper;
using NIT.HopZone.Web.NIT.HopZone.BackEnd.Repository;
using NIT.HopZone.Web.NIT.HopZone.BackEnd.Repository.Interface;
using NIT.HopZone.Web.Queries;
using NIT.HopZone.Web.Repository;
using NIT.HopZone.Web.Settings;
using NIT.HopZone.Web.Types;

namespace NIT.HopZone.Web
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
            services.AddMvc();

            services.Configure<MongoSettings>(options =>
            {
                options.ConnectionString
                    = Configuration.GetSection("MongoConnection:ConnectionString").Value;
                options.Database
                    = Configuration.GetSection("MongoConnection:Database").Value;
            });

            services.AddAuthentication("Bearer")
                    .AddJwtBearer("Bearer", options =>
                    {
                        options.Authority = "https://localhost:44309";
                        options.RequireHttpsMetadata = false;
                        options.SaveToken = true;
                        options.Audience = "graphQLApi";
                    });

            services.AddScoped<NTPQuery>();
            services.AddScoped<NTPMutation>();
            services.AddScoped<IDocumentExecuter, DocumentExecuter>();

            services.AddTransient<ICollectionRepository<Country>, CountriesRepository>();
            services.AddTransient<ICollectionRepository<Season>, SeasonsRepository>();

            services.AddTransient<IRouteRepository<Route>, RouteRepository>();
            services.AddTransient<ISpotRepository<Spot>, SpotRepository>();
            services.AddTransient<ICommentRepository<Comment>, CommentRepository>();
            services.AddTransient<IMapCoordinateRepository<MapCoordinate>, MapCoordinateRepository>();
            services.AddTransient<IPostRepository<Post>, PostRepository>();
            services.AddTransient<IUserRepository<User>, UserRepository>();
            services.AddTransient<IContactRepository<Contact>, ContactRepository>();

            services.AddTransient<ICollectionRepository<Admin>, AdminRepository>();
            services.AddTransient<ICollectionRepository<City>, CityRepository>();
            services.AddTransient<ICollectionRepository<Gender>, GenderRepository>();

            services.AddTransient<FixtureType>();
            services.AddTransient<CountryType>();
            services.AddTransient<AdminType>();
            services.AddTransient<CityType>();
            services.AddTransient<GenderType>();
            services.AddTransient<MapCoordinteType>();
            services.AddTransient<UserType>();
            services.AddTransient<SpotType>();
            services.AddTransient<RouteType>();
            services.AddTransient<PostType>();
            services.AddTransient<ContactType>();
            services.AddTransient<CommentType>();
            services.AddTransient<RoleType>();
            services.AddTransient<FixturesPredictionType>();
            services.AddTransient<BackEnd.InputTypes.AdminInputType>();
            services.AddTransient<BackEnd.InputTypes.UserInputType>();
            services.AddTransient<BackEnd.InputTypes.ContactInputType>();

            //Authentication
            services.AddSingleton<IValidationRule, AuthValidationRule>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddIdentityServer();

            services.AddTransient<BackEnd.Data.HopZoneData>();

            var sp = services.BuildServiceProvider();

            services.AddSingleton<ISchema>(new NTPSchema(new FuncDependencyResolver(type => sp.GetService(type))));

            // In production, the React files will be served from this directory
            services.AddSpaStaticFiles(configuration =>
            {
                configuration.RootPath = "NIT.HopZone.FrontEnd/build";
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSpaStaticFiles();
            app.UseGraphiQl("/graphql");

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller}/{action=Index}/{id?}");
            });

            app.UseSpa(spa =>
            {
                spa.Options.SourcePath = "NIT.HopZone.FrontEnd";

                if (env.IsDevelopment())
                {
                    spa.UseReactDevelopmentServer(npmScript: "start");
                }
            });
        }
    }
}

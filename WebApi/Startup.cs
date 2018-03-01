using DataAccess;
using Dto.DtoClasses;
using EntityModel.TypedListClasses;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Repository;
using Swashbuckle.AspNetCore.Swagger;

namespace LLBLGenTest
{
    public class Startup
    {
        private readonly string connectionString = "data source=localhost;initial catalog=Natmus;integrated security=True;MultipleActiveResultSets=True;";

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            // Register the Swagger generator, defining one or more Swagger documents
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "Test Api", Version = "v1" });
            });

            services.AddScoped<ITypedListRepository<SpecificItemTypedListRow>>(s => new SpecificItemTypedListRepository(connectionString));
            services.AddScoped<IRepository<SpecificItemDto>>(s => new SpecificItemRepository(connectionString));
            services.AddScoped<IRepository<CoreCollectionDto>>(s => new CollectionRepository(connectionString));
            services.AddScoped<IRepository<ActorPersonDto>>(s => new ActorPersonRepository(connectionString));
            services.AddScoped<IRepository<CoreIncidentDto>>(s => new IncidentRepository(connectionString));
            services.AddScoped<IRepository<CoreActorIncidentDto>>(s => new ActorIncidentRepository(connectionString));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.), specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Test Api v1");
            });

            app.UseMvc();
        }
    }
}

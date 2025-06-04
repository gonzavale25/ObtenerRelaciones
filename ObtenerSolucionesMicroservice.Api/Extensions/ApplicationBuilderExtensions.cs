using ObtenerSolucionesMicroservice.Api.Middleware;

namespace ObtenerSolucionesMicroservice.Api.Extensions
{
    public static class ApplicationBuilderExtensions
    {
        private static void ConfigureSwagger(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                var endpointUrl = env.IsDevelopment() ? "/swagger/v1/swagger.json" : "/ObtenerSoluciones/v1/swagger.json";
                c.SwaggerEndpoint(endpointUrl, "UCV.ObtenerSoluciones API V1");
            });
        }
        public static void UseCustomConfiguration(this IApplicationBuilder app, IWebHostEnvironment env)
        {

            app.UseHttpsRedirection();
            ConfigureSwagger(app, env);

            app.UseMiddleware<RequestBodyMiddleware>();

            app.UseCors("MyPolicy");
            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync($"Microservice ObtenerSoluciones is running .... ");
            });


        }
    }
}
